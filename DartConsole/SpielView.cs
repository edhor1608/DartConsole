using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartConsole
{
    public partial class SpielView : Form
    {
        Wurf wurf1 = new Wurf(0, 0);
        int multi1;
        Wurf wurf2 = new Wurf(0, 0);
        int multi2;
        Wurf wurf3 = new Wurf(0, 0);
        int multi3;

        public SpielView()
        {
            InitializeComponent();
            FillFormsInArrays();
        }

        private void RefreshStand()
        {
            for (int i = 0; i < Program.spielAktuell.GetSpieler().Count; i++)
            {
                lblArrayPfeil[i].Visible = false;
                lblArraySets[i].Text = "" + Program.spielAktuell.GetSetsGewonnen()[i];
                lblArrayLegs[i].Text = "" + Program.spielAktuell.GetSetAktuell(i).GetLegsGewonnen();
                lblArrayRest[i].Text = "" + Program.spielAktuell.GetSetAktuell(i).GetAktuellLeg().GetRest();
                lblArrayAVG[i].Text = "" + Statistik.Average_Finish_Spiel(Program.spielAktuell, Program.spielAktuell.GetSpieler().ElementAt(i).Key);
                lblArrayDQ[i].Text = "" + Statistik.GetDoubleFinishQuoteSpielSpieler(Program.spielAktuell, Program.spielAktuell.GetSpieler().ElementAt(i).Value);
            }
            lblArrayPfeil[Program.spielAktuell.GetSpielerAktuell()].Visible = true;
        }

        private void NewSet()
        {
            Program.spielAktuell.AddSet();
            NewLeg();
        }

        private void NewLeg()
        {
            SetVisibleWurf1(true);
            SetVisibleWurf2(false);
            SetVisibleWurf3(false);
            btn_loeschen.Visible = false;
            btn_uebernehmen.Visible = false;
            Program.spielAktuell.AddLeg();
            Program.spielAktuell.AddDurchgangSpielerAktuell();
            RefreshStand();
        }

        private int AddWurf(int w, int multi, int wert)
        {
            int info = Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().RedRest(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().AddWurf(new Wurf(multi, wert), w - 1));

            switch (w)
            {
                case 1:
                    SetVisibleWurf1Multi(false);
                    SetVisibleWurf1Wert(false);
                    SetVisibleWurf2(true);
                    wurf1 = new Wurf(multi, wert);
                    break;
                case 2:
                    SetVisibleWurf2Multi(false);
                    SetVisibleWurf2Wert(false);
                    SetVisibleWurf3(true);
                    wurf2 = new Wurf(multi, wert);
                    break;
                case 3:
                    SetVisibleWurf3Multi(false);
                    SetVisibleWurf3Wert(false);
                    btn_uebernehmen.Visible = true;
                    wurf3 = new Wurf(multi, wert);
                    break;
            }
            RefreshStand();
            btn_loeschen.Visible = true;

            if (info == 1 && multi == 2 && Uebernehmen(false))
            {
                //LegGewonnen bei Spieler erhöhen
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).AddLegGewonnen();
                //Finish zuweisen
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().SetFinish(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                MessageBox.Show(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetSpieler().GetUsername() + " hat das Leg gewonnen");
                if (Program.spielAktuell.SearchSetWin())
                {
                    MessageBox.Show(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetSpieler().GetUsername() + " hat den Set gewonnen");
                    if (Program.spielAktuell.SearchSpielWin())
                    {
                        MessageBox.Show(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetSpieler().GetUsername() + " hat das Spiel gewonnen");
                        SpielBeenden();
                    }
                    else
                    {
                        NewSet();
                    }
                }
                else
                {
                    NewLeg();
                }
            }
            if (((info == 1 && multi != 2) || info == 2) && Uebernehmen(false))
            {
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().SetRest(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetRest() + Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                if (info == 1)
                {
                    MessageBox.Show("No Score --- Kein Doppel");
                }
                else
                {
                    MessageBox.Show("No Score --- Überworfen");
                }
                Program.spielAktuell.SpielerWeiter();
                Program.spielAktuell.AddDurchgangSpielerAktuell();
                ResetEingabe();
            }
            return info;
        }

        private void SpielBeenden()
        {
            btn_loeschen.Visible = false;
            btn_uebernehmen.Visible = false;
            btn_beenden.Visible = false;
        }

        private void ResetEingabe()
        {
            tBx_wurf1.Text = "";
            tBx_wurf2.Text = "";
            tBx_wurf3.Text = "";
            SetVisibleWurf1(true);
            SetVisibleWurf2(false);
            SetVisibleWurf3(false);
            RefreshStand();
            btn_loeschen.Visible = false;
            btn_uebernehmen.Visible = false;
        }

        private int GetWuerfeGesamt()
        {
            return wurf1.GetWurfGesamt() + wurf2.GetWurfGesamt() + wurf3.GetWurfGesamt();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetVisibleWurf1Wert(bool visible)
        {
            for (int i = 0; i < 20; i++)
            {
                btnArrayWurf1Wert[i].Visible = visible;
            }
        }

        private void SetVisibleWurf2Wert(bool visible)
        {
            for (int i = 0; i < 20; i++)
            {
                btnArrayWurf2Wert[i].Visible = visible;
            }
        }

        private void SetVisibleWurf3Wert(bool visible)
        {
            for (int i = 0; i < 20; i++)
            {
                btnArrayWurf3Wert[i].Visible = visible;
            }
        }

        private void SetVisibleWurf1Multi(bool visible)
        {
            for (int i = 0; i < btnArrayWurf1Multi.Length; i++)
            {
                btnArrayWurf1Multi[i].Visible = visible;
            }
        }

        private void SetVisibleWurf2Multi(bool visible)
        {
            for (int i = 0; i < btnArrayWurf2Multi.Length; i++)
            {
                btnArrayWurf2Multi[i].Visible = visible;
            }
        }

        private void SetVisibleWurf3Multi(bool visible)
        {
            for (int i = 0; i < btnArrayWurf3Multi.Length; i++)
            {
                btnArrayWurf3Multi[i].Visible = visible;
            }
        }

        private void SetVisibleWurf1(bool visible)
        {
            tBx_wurf1.Visible = visible;
            lbl_wurf1.Visible = visible;
            SetVisibleWurf1Multi(visible);
            if (visible)
            {
                tBx_wurf1.Text = "";
                visible = !visible;
            }
            SetVisibleWurf1Wert(visible);
        }

        private void SetVisibleWurf2(bool visible)
        {
            tBx_wurf2.Visible = visible;
            lbl_wurf2.Visible = visible;
            SetVisibleWurf2Multi(visible);
            if (visible)
            {
                tBx_wurf2.Text = "";
                visible = !visible;
            }
            SetVisibleWurf2Wert(visible);
        }

        private void SetVisibleWurf3(bool visible)
        {
            tBx_wurf3.Visible = visible;
            lbl_wurf3.Visible = visible;
            SetVisibleWurf3Multi(visible);
            if (visible)
            {
                tBx_wurf3.Text = "";
                visible = !visible;
            }
            SetVisibleWurf3Wert(visible);
        }

        private void SpielView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.spielAktuell.GetSpieler().Count; i++)
            {
                lblArraySpieler[i].Text = Program.spielAktuell.GetSpieler().ElementAt(i).Value.GetUsername();
                lblArraySets[i].Text = "" + Program.spielAktuell.GetSetsGewonnen()[i];
                lblArrayCheck[i].Visible = false;
                //Bisher keine Funktion deswegen False
                lblArrayAVG[i].Visible = false;
                lblArrayDQ[i].Visible = false;
            }
            for (int i = Program.spielAktuell.GetSpieler().Count; i < 8; i++)
            {
                lblArraySpieler[i].Visible = false;
                lblArraySets[i].Visible = false;
                lblArrayLegs[i].Visible = false;
                lblArrayRest[i].Visible = false;
                lblArrayPfeil[i].Visible = false;
                lblArrayCheck[i].Visible = false;
                lblArrayAVG[i].Visible = false;
                lblArrayDQ[i].Visible = false;
            }
            ResetEingabe();
        }

        private void btn_einmalWurf1_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = "1x";
            SetVisibleWurf1Multi(false);
            SetVisibleWurf1Wert(true);
            multi1 = 1;
        }

        private void btn_zweimalWurf1_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = "2x";
            SetVisibleWurf1Multi(false);
            SetVisibleWurf1Wert(true);
            multi1 = 2;
        }

        private void btn_dreimalWurf1_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = "3x";
            SetVisibleWurf1Multi(false);
            SetVisibleWurf1Wert(true);
            multi1 = 3;
        }

        private void btn_bullWurf1_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = "Bull(25)";
            AddWurf(1, 1, 25);
        }

        private void btn_doubleBullWurf1_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = "DBull(50)";
            AddWurf(1, 2, 25);
        }

        private void btn_wurf1_1_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "1";
            AddWurf(1, multi1, 1);
        }

        private void btn_wurf1_2_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "2";
            AddWurf(1, multi1, 2);
        }

        private void btn_wurf1_3_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "3";
            AddWurf(1, multi1, 3);
        }

        private void btn_wurf1_4_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "4";
            AddWurf(1, multi1, 4);
        }

        private void btn_wurf1_5_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "5";
            AddWurf(1, multi1, 5);
        }

        private void btn_wurf1_6_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "6";
            AddWurf(1, multi1, 6);
        }

        private void btn_wurf1_7_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "7";
            AddWurf(1, multi1, 7);
        }

        private void btn_wurf1_8_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "8";
            AddWurf(1, multi1, 8);
        }

        private void btn_wurf1_9_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "9";
            AddWurf(1, multi1, 9);
        }

        private void btn_wurf1_10_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "10";
            AddWurf(1, multi1, 10);
        }

        private void btn_wurf1_11_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "11";
            AddWurf(1, multi1, 11);
        }

        private void btn_wurf1_12_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "12";
            AddWurf(1, multi1, 12);
        }

        private void btn_wurf1_13_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "13";
            AddWurf(1, multi1, 13);
        }

        private void btn_wurf1_14_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "14";
            AddWurf(1, multi1, 14);
        }

        private void btn_wurf1_15_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "15";
            AddWurf(1, multi1, 15);
        }

        private void btn_wurf1_16_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "16";
            AddWurf(1, multi1, 16);
        }

        private void btn_wurf1_17_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "17";
            AddWurf(1, multi1, 17);
        }

        private void btn_wurf1_18_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "18";
            AddWurf(1, multi1, 18);
        }

        private void btn_wurf1_19_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "19";
            AddWurf(1, multi1, 19);
        }

        private void btn_wurf1_20_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = tBx_wurf1.Text + "20";
            AddWurf(1, multi1, 20);
        }

        private void btn_einmalWurf2_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = "1x";
            SetVisibleWurf2Multi(false);
            SetVisibleWurf2Wert(true);
            multi2 = 1;
        }

        private void btn_zweimalWurf2_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = "2x";
            SetVisibleWurf2Multi(false);
            SetVisibleWurf2Wert(true);
            multi2 = 2;
        }

        private void btn_dreimalWurf2_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = "3x";
            SetVisibleWurf2Multi(false);
            SetVisibleWurf2Wert(true);
            multi2 = 3;
        }

        private void btn_bullWurf2_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = "Bull(25)";
            AddWurf(2, 1, 25);
        }

        private void btn_doubleBullWurf2_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = "DBull(50)";
            AddWurf(2, 2, 25);
        }

        private void btn_einmalWurf3_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = "1x";
            SetVisibleWurf3Multi(false);
            SetVisibleWurf3Wert(true);
            multi3 = 1;
        }

        private void btn_zweimalWurf3_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = "2x";
            SetVisibleWurf3Multi(false);
            SetVisibleWurf3Wert(true);
            multi3 = 2;
        }

        private void btn_dreimalWurf3_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = "3x";
            SetVisibleWurf3Multi(false);
            SetVisibleWurf3Wert(true);
            multi3 = 3;
        }

        private void btn_bullWurf3_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = "Bull(25)";
            AddWurf(3, 1, 25);
        }

        private void btn_doubleBullWurf3_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = "DBull(50)";
            AddWurf(3, 2, 25);
        }

        private void btn_wurf2_1_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "1";
            AddWurf(2, multi2, 1);
        }

        private void btn_wurf2_2_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "2";
            AddWurf(2, multi2, 2);
        }

        private void btn_wurf2_3_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "3";
            AddWurf(2, multi2, 3);
        }

        private void btn_wurf2_4_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "4";
            AddWurf(2, multi2, 4);
        }

        private void btn_wurf2_5_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "5";
            AddWurf(2, multi2, 5);
        }

        private void btn_wurf2_6_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "6";
            AddWurf(2, multi2, 6);
        }

        private void btn_wurf2_7_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "7";
            AddWurf(2, multi2, 7);
        }

        private void btn_wurf2_8_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "8";
            AddWurf(2, multi2, 8);
        }

        private void btn_wurf2_9_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "9";
            AddWurf(2, multi2, 9);
        }

        private void btn_wurf2_10_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "10";
            AddWurf(2, multi2, 10);
        }

        private void btn_wurf2_11_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "11";
            AddWurf(2, multi2, 11);
        }

        private void btn_wurf2_12_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "12";
            AddWurf(2, multi2, 12);
        }

        private void btn_wurf2_13_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "13";
            AddWurf(2, multi2, 13);
        }

        private void btn_wurf2_14_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "14";
            AddWurf(2, multi2, 14);
        }

        private void btn_wurf2_15_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "15";
            AddWurf(2, multi2, 15);
        }

        private void btn_wurf2_16_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "16";
            AddWurf(2, multi2, 16);
        }

        private void btn_wurf2_17_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "17";
            AddWurf(2, multi2, 17);
        }

        private void btn_wurf2_18_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "18";
            AddWurf(2, multi2, 18);
        }

        private void btn_wurf2_19_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "19";
            AddWurf(2, multi2, 19);
        }

        private void btn_wurf2_20_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = tBx_wurf2.Text + "20";
            AddWurf(2, multi2, 20);
        }

        private void btn_wurf3_1_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "1";
            AddWurf(3, multi3, 1);
        }

        private void btn_wurf3_2_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "2";
            AddWurf(3, multi3, 2);
        }

        private void btn_wurf3_3_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "3";
            AddWurf(3, multi3, 3);
        }

        private void btn_wurf3_4_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "4";
            AddWurf(3, multi3, 4);
        }

        private void btn_wurf3_5_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "5";
            AddWurf(3, multi3, 5);
        }

        private void btn_wurf3_6_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "6";
            AddWurf(3, multi3, 6);
        }

        private void btn_wurf3_7_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "7";
            AddWurf(3, multi3, 7);
        }

        private void btn_wurf3_8_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "8";
            AddWurf(3, multi3, 8);
        }

        private void btn_wurf3_9_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "9";
            AddWurf(3, multi3, 9);
        }

        private void btn_wurf3_10_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "10";
            AddWurf(3, multi3, 10);
        }

        private void btn_wurf3_11_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "11";
            AddWurf(3, multi3, 11);
        }

        private void btn_wurf3_12_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "12";
            AddWurf(3, multi3, 12);
        }

        private void btn_wurf3_13_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "13";
            AddWurf(3, multi3, 13);
        }

        private void btn_wurf3_14_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "14";
            AddWurf(3, multi3, 14);
        }

        private void btn_wurf3_15_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "15";
            AddWurf(3, multi3, 15);
        }

        private void btn_wurf3_16_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "16";
            AddWurf(3, multi3, 16);
        }

        private void btn_wurf3_17_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "17";
            AddWurf(3, multi3, 17);
        }

        private void btn_wurf3_18_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "18";
            AddWurf(3, multi3, 18);
        }

        private void btn_wurf3_19_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "19";
            AddWurf(3, multi3, 19);
        }

        private void btn_wurf3_20_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = tBx_wurf3.Text + "20";
            AddWurf(3, multi3, 20);
        }

        private void btn_nullWurf1_Click(object sender, EventArgs e)
        {
            tBx_wurf1.Text = "0";
            AddWurf(1, 0, 0);
        }

        private void btn_nullWurf2_Click(object sender, EventArgs e)
        {
            tBx_wurf2.Text = "0";
            AddWurf(2, 0, 0);
        }

        private void btn_nullWurf3_Click(object sender, EventArgs e)
        {
            tBx_wurf3.Text = "0";
            AddWurf(3, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wirklich Beenden?\nSpiel wird gelöscht", "Beenden", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.frmSpielView.Hide();
                Dart.spiele.Remove(Program.spielAktuell);
                Program.spielAktuell = null;
                Program.frmMainMenu.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            Loeschen();
        }

        private void Loeschen()
        {
            //Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().SetAnzahlWürfe(0);
            Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().ResetWürfe();
            Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().SetRest(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetRest() + GetWuerfeGesamt());
            ResetEingabe();
        }

        private void btn_uebernehmen_Click(object sender, EventArgs e)
        {
            Uebernehmen(true);
        }

        private bool Uebernehmen(bool button)
        {
            DialogResult dialogResult = MessageBox.Show("Würfe richtig?", "Übernehmen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                wurf1 = new Wurf(0, 0);
                wurf2 = new Wurf(0, 0);
                wurf3 = new Wurf(0, 0);
                if (button)
                {
                    Program.spielAktuell.SpielerWeiter();
                    Program.spielAktuell.AddDurchgangSpielerAktuell();
                    ResetEingabe();
                }
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                Loeschen();
                return false;
            }
            return false;

        }
    }
}
