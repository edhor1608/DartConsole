using System;
using System.Linq;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Collections.Generic;

namespace DartConsole
{
    public partial class SpielView : Form
    {
        SpeechRecognitionEngine SRE, SREStart, SREMulti;
        RecognitionResult Result;
        string ResultString;
        GrammarBuilder GB;
        Grammar CommandGrammarStart, CommandGrammarMulti, CommandGrammar;
        Dictionary<string, int> umwandlungMulti = new Dictionary<string, int>();
        Dictionary<string, int> umwandlungWert = new Dictionary<string, int>();

        Wurf wurf1;
        int multi1;
        Wurf wurf2;
        int multi2;
        Wurf wurf3;
        int multi3;

        int multiAktuell;
        int wertAktuell;

        int info = 0;

        public SpielView()
        {
            InitializeComponent();
            FillFormsInArrays();
            InitSpeech();
        }

        private void CreateDics()
        {
            umwandlungMulti.Add("einfach", 0);
            umwandlungMulti.Add("zweifach", 1);
            umwandlungMulti.Add("doppel", 1);
            umwandlungMulti.Add("dreifach", 2);
            umwandlungMulti.Add("triple", 2);
            umwandlungMulti.Add("tripple", 2);
            umwandlungMulti.Add("bull", 3);
            umwandlungMulti.Add("0", 5);

            umwandlungWert.Add("1", 0);
            umwandlungWert.Add("2", 1);
            umwandlungWert.Add("3", 2);
            umwandlungWert.Add("4", 3);
            umwandlungWert.Add("5", 4);
            umwandlungWert.Add("6", 5);
            umwandlungWert.Add("7", 6);
            umwandlungWert.Add("8", 7);
            umwandlungWert.Add("9", 8);
            umwandlungWert.Add("10", 9);
            umwandlungWert.Add("11", 10);
            umwandlungWert.Add("12", 11);
            umwandlungWert.Add("13", 12);
            umwandlungWert.Add("14", 13);
            umwandlungWert.Add("15", 14);
            umwandlungWert.Add("16", 15);
            umwandlungWert.Add("17", 16);
            umwandlungWert.Add("18", 17);
            umwandlungWert.Add("19", 18);
            umwandlungWert.Add("20", 19);
            umwandlungWert.Add("bull", 25);
        }

        private void CreateGramma()
        {
            Choices CommandsStart = new Choices();
            CommandsStart.Add("start");
            CommandsStart.Add("starten");
            CommandsStart.Add("starting");
            CommandsStart.Add("anfangen");
            CommandsStart.Add("beginnen");

            Choices CommandsMulti = new Choices();
            CommandsMulti.Add("einfach");
            CommandsMulti.Add("zweifach");
            CommandsMulti.Add("doppel");
            CommandsMulti.Add("dreifach");
            CommandsMulti.Add("triple");
            CommandsMulti.Add("tripple");
            CommandsMulti.Add("bull");
            CommandsMulti.Add("0");

            Choices Commands = new Choices();
            Commands.Add("20");
            Commands.Add("19");
            Commands.Add("18");
            Commands.Add("17");
            Commands.Add("16");
            Commands.Add("15");
            Commands.Add("14");
            Commands.Add("13");
            Commands.Add("12");
            Commands.Add("11");
            Commands.Add("10");
            Commands.Add("9");
            Commands.Add("8");
            Commands.Add("7");
            Commands.Add("6");
            Commands.Add("5");
            Commands.Add("4");
            Commands.Add("3");
            Commands.Add("2");
            Commands.Add("1");
            Commands.Add("bull");

            GB = new GrammarBuilder(CommandsMulti);
            CommandGrammarMulti = new Grammar(GB);

            GB = new GrammarBuilder(Commands);
            CommandGrammar = new Grammar(GB);

            GB = new GrammarBuilder(CommandsStart);
            CommandGrammarStart = new Grammar(GB);
        }

        private void InitSpeech()
        {
            CreateGramma();

            SRE = new SpeechRecognitionEngine();
            SRE.LoadGrammar(CommandGrammar);
            SRE.SetInputToDefaultAudioDevice();

            SREMulti = new SpeechRecognitionEngine();
            SREMulti.LoadGrammar(CommandGrammarMulti);
            SREMulti.SetInputToDefaultAudioDevice();

            SREStart = new SpeechRecognitionEngine();
            SREStart.LoadGrammar(CommandGrammarStart);
            SREStart.SetInputToDefaultAudioDevice();

            CreateDics();
        }

        public void ClickButton(Button b)
        {
            b.Visible = true;
            b.PerformClick();
            b.Visible = false;
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
                if (Dart.checkout.ContainsKey(Program.spielAktuell.GetSetAktuell(i).GetAktuellLeg().GetRest()))
                {
                    lblArrayCheck[i].Visible = true;
                    lblArrayCheck[i].Text = "" + Dart.checkout[Program.spielAktuell.GetSetAktuell(i).GetAktuellLeg().GetRest()];
                }
                else
                {
                    lblArrayCheck[i].Visible = false;
                }
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
            SetVisibleWurf1(true, Program.speech);
            SetVisibleWurf2(false, Program.speech);
            SetVisibleWurf3(false, Program.speech);
            btn_loeschen.Visible = false;
            btn_uebernehmen.Visible = false;
            Program.spielAktuell.AddLeg();
            //Program.spielAktuell.AddDurchgangSpielerAktuell();
            RefreshStand();
        }

        private void AddWurf(int w, int multi, int wert)
        {
            multiAktuell = multi;
            wertAktuell = wert;
            info = Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().RedRest(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().AddWurf(new Wurf(multi, wert), w - 1));

            switch (w)
            {
                case 1:
                    SetVisibleWurf1Multi(false);
                    SetVisibleWurf1Wert(false);
                    if (info != 0)
                    {
                        btn_uebernehmen.Visible = true;
                    }
                    else
                    {
                        SetVisibleWurf2(true, Program.speech);
                    }
                    wurf1 = new Wurf(multi, wert);
                    Program.frmWurfView.SetVisibleWurf1(true);
                    Program.frmWurfView.SetGeworfenWurf1(multi, wert);
                    break;
                case 2:
                    SetVisibleWurf2Multi(false);
                    SetVisibleWurf2Wert(false);
                    if (info != 0)
                    {
                        btn_uebernehmen.Visible = true;
                    }
                    else
                    {
                        SetVisibleWurf3(true, Program.speech);
                    }
                    wurf2 = new Wurf(multi, wert);
                    Program.frmWurfView.SetVisibleWurf2(true);
                    Program.frmWurfView.tB_wurf2.Text = multi + "x" + wert;
                    Program.frmWurfView.SetGeworfenWurf2(multi, wert);
                    break;
                case 3:
                    SetVisibleWurf3Multi(false);
                    SetVisibleWurf3Wert(false);
                    btn_uebernehmen.Visible = true;
                    wurf3 = new Wurf(multi, wert);
                    Program.frmWurfView.SetVisibleWurf3(true);
                    Program.frmWurfView.tB_wurf3.Text = multi + "x" + wert;
                    Program.frmWurfView.SetGeworfenWurf3(multi, wert);
                    if (Program.speech) btn_loeschen.Visible = true;
                    break;
            }
            RefreshStand();
            if (!Program.speech) btn_loeschen.Visible = true;
        }

        private void SpielBeenden()
        {
            btn_loeschen.Visible = false;
            btn_uebernehmen.Visible = false;
            btn_beenden.Visible = false;
            Dart.AddSpiel(Program.spielAktuell);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Visible = false;
            btn_weiter.Visible = true;
        }

        private void ResetEingabe()
        {
            Program.frmWurfView.SetVisibleWurf1(false);
            Program.frmWurfView.SetVisibleWurf2(false);
            Program.frmWurfView.SetVisibleWurf3(false);
            tBx_wurf1.Text = "";
            tBx_wurf2.Text = "";
            tBx_wurf3.Text = "";
            SetVisibleWurf1(true, Program.speech);
            SetVisibleWurf2(false, Program.speech);
            SetVisibleWurf3(false, Program.speech);
            RefreshStand();
            btn_loeschen.Visible = false;
            btn_uebernehmen.Visible = false;
        }

        private void ChangeEingabe()
        {
            Program.speech = rbSpracheingabe.Checked;
            if (Program.speech)
            {
                btnEingabeStarten.Visible = true;
                btn_loeschen.Visible = false;

                tBx_wurf1.Visible = true;
                lbl_wurf1.Visible = true;
                SetVisibleWurf1Multi(false);
                SetVisibleWurf1Wert(false);

                tBx_wurf2.Visible = true;
                lbl_wurf2.Visible = true;
                SetVisibleWurf2Multi(false);
                SetVisibleWurf2Wert(false);

                tBx_wurf3.Visible = true;
                lbl_wurf3.Visible = true;
                SetVisibleWurf3Multi(false);
                SetVisibleWurf3Wert(false);

                if (wurf1 == null)
                {
                    lblSpracheMultiW1.Visible = true;
                }
                else if (wurf2 == null)
                {
                    lblSpracheMultiW2.Visible = true;
                }
                else if (wurf3 == null)
                {
                    lblSpracheMultiW3.Visible = true;
                }

            }
            else
            {
                btnEingabeStarten.Visible = false;
                if (wurf1 != null) btn_loeschen.Visible = true;

                lblSpracheMultiW1.Visible = false;
                lblSpracheMultiW2.Visible = false;
                lblSpracheMultiW3.Visible = false;
                lblSpracheWertW1.Visible = false;
                lblSpracheWertW2.Visible = false;
                lblSpracheWertW3.Visible = false;
                if (wurf1 == null)
                {
                    SetVisibleWurf1(true, false);
                    SetVisibleWurf2(false, false);
                    SetVisibleWurf3(false, false);
                }
                else if (wurf2 == null)
                {
                    SetVisibleWurf2(true, false);
                    SetVisibleWurf3(false, false);
                }
                else if (wurf3 == null)
                {
                    SetVisibleWurf3(true, false);
                }
            }
        }

        private int GetWuerfeGesamt()
        {
            int summe = 0;
            if (wurf1 != null)
            {
                summe += wurf1.GetWurfGesamt();
            }
            if (wurf2 != null)
            {
                summe += wurf2.GetWurfGesamt();
            }
            if (wurf3 != null)
            {
                summe += wurf3.GetWurfGesamt();
            }
            return summe;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetVisibleWurf1Wert(bool visible)
        {
            if (visible == true && !Program.speech || visible == false)
            {
                for (int i = 0; i < 20; i++)
                {
                    btnArrayWurf1Wert[i].Visible = visible;
                }
            }
            if (Program.speech)
            {
                lblSpracheWertW1.Visible = visible;
            }
        }

        private void SetVisibleWurf2Wert(bool visible)
        {
            if (visible == true && !Program.speech || visible == false)
            {
                for (int i = 0; i < 20; i++)
                {
                    btnArrayWurf2Wert[i].Visible = visible;
                }
            }
            if (Program.speech)
            {
                lblSpracheWertW2.Visible = visible;
            }
        }

        private void SetVisibleWurf3Wert(bool visible)
        {
            if (visible == true && !Program.speech || visible == false)
            {
                for (int i = 0; i < 20; i++)
                {
                    btnArrayWurf3Wert[i].Visible = visible;
                }
            }
            if (Program.speech)
            {
                lblSpracheWertW3.Visible = visible;
            }
        }

        private void SetVisibleWurf1Multi(bool visible)
        {
            for (int i = 0; i < btnArrayWurf1Multi.Length; i++)
            {
                btnArrayWurf1Multi[i].Visible = visible;
            }
            if(Program.speech) lblSpracheMultiW1.Visible = visible;
        }

        private void SetVisibleWurf2Multi(bool visible)
        {
            for (int i = 0; i < btnArrayWurf2Multi.Length; i++)
            {
                btnArrayWurf2Multi[i].Visible = visible;
            }
            if (Program.speech) lblSpracheMultiW2.Visible = visible;
        }

        private void SetVisibleWurf3Multi(bool visible)
        {
            for (int i = 0; i < btnArrayWurf3Multi.Length; i++)
            {
                btnArrayWurf3Multi[i].Visible = visible;
            }
            if (Program.speech) lblSpracheMultiW3.Visible = visible;
        }

        private void SetVisibleWurf1(bool visible, bool speech)
        {
            if (speech)
            {
                tBx_wurf1.Visible = true;
                lbl_wurf1.Visible = true;
                SetVisibleWurf1Multi(false);
                SetVisibleWurf1Wert(false);
                lblSpracheMultiW1.Visible = visible;
                if (visible)
                {
                    visible = !visible;
                }
                lblSpracheWertW1.Visible = visible;
            }
            else
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
        }

        private void SetVisibleWurf2(bool visible, bool speech)
        {
            if (speech)
            {
                tBx_wurf2.Visible = true;
                lbl_wurf2.Visible = true;
                SetVisibleWurf2Multi(false);
                SetVisibleWurf2Wert(false);
                lblSpracheMultiW2.Visible = visible;
                if (visible)
                {
                    visible = !visible;
                }
                lblSpracheWertW2.Visible = visible;
            }
            else
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
        }

        private void SetVisibleWurf3(bool visible, bool speech)
        {
            if (speech)
            {
                tBx_wurf3.Visible = true;
                lbl_wurf3.Visible = true;
                SetVisibleWurf3Multi(false);
                SetVisibleWurf3Wert(false);
                lblSpracheMultiW3.Visible = visible;
                if (visible)
                {
                    visible = !visible;
                }
                lblSpracheWertW3.Visible = visible;
            }
            else
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
        }

        private void SpielView_Load(object sender, EventArgs e)
        {
            lblSpracheMultiW1.Visible = Program.speech;
            lblSpracheMultiW2.Visible = Program.speech;
            lblSpracheMultiW3.Visible = Program.speech;

            lblSpracheWertW1.Visible = Program.speech;
            lblSpracheWertW2.Visible = Program.speech;
            lblSpracheWertW3.Visible = Program.speech;

            btnEingabeStarten.Visible = Program.speech;

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
            progressBar.Visible = false;
            btn_weiter.Visible = false;
            ResetEingabe();
            if (Program.speech) rbSpracheingabe.Checked = true;
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

        public void Loeschen()
        {
            //Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().SetAnzahlWürfe(0);
            Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().ResetWürfe();
            Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().SetRest(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetRest() + GetWuerfeGesamt());
            ResetEingabe();
            wurf1 = null;
            wurf2 = null;
            wurf3 = null;
            multi1 = 0;
            multi2 = 0;
            multi3 = 0;
            if (Program.speech) btnEingabeStarten.Visible = true;
        }

        private void btn_uebernehmen_Click(object sender, EventArgs e)
        {
            Program.frmWurfView.Show();
            this.Hide();
            Program.frmWurfView.SetLocation(Location.X + 290, Location.Y + 230);
            //Uebernehmen(true);
        }

        public void Uebernehmen()
        {
            //DialogResult dialogResult = MessageBox.Show("Würfe richtig?", "Übernehmen", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            wurf1 = null;
            wurf2 = null;
            wurf3 = null;

            //Finish
            if (info == 1 && multiAktuell == 2)
            {
                //LegGewonnen bei Spieler erhöhen
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).AddLegGewonnen();

                //Finish zuweisen
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().SetFinish(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());

                //Hinweis wer Leg gewonnen hat
                MessageBox.Show(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetSpieler().GetUsername() + " hat das Leg gewonnen");

                //Überprüfung ob Leg zu Ende, wenn ja dann gleichzeitig SetGewonnen bei Spieler erhöhen
                if (Program.spielAktuell.SearchSetWin())
                {
                    MessageBox.Show(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetSpieler().GetUsername() + " hat den Set gewonnen");
                    if (Program.spielAktuell.SearchSpielWin())
                    {
                        progressBar.Style = ProgressBarStyle.Marquee;
                        progressBar.MarqueeAnimationSpeed = 100;
                        progressBar.Visible = true;
                        MessageBox.Show(Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetSpieler().GetUsername() + " hat das Spiel gewonnen");
                        SpielBeenden();
                        return;
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
            if (((info == 1 && multiAktuell != 2) || info == 2))
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
            }


            // if (button)
            //{
            Program.spielAktuell.SpielerWeiter();
            Program.spielAktuell.AddDurchgangSpielerAktuell();
            ResetEingabe();
            if (Program.speech) btnEingabeStarten.Visible = true;
            //}
            //return true;
            // }
            // else if (dialogResult == DialogResult.No)
            //{
            //    Loeschen();
            //    return false;
            // }
            // return false;

        }

        private void btnEingabeStarten_Click(object sender, EventArgs e)
        {
            int j = 0;
            int wert = 0;
            int multi = 0;
            if (wurf3 == null) j = 2;
            if (wurf2 == null) j = 1;
            if (wurf1 == null) j = 0;
            btnEingabeStarten.Visible = false;
            for (int i = j; i < 3; i++)
            {
                bool test = true;
                while (test)
                {
                    try
                    {
                        Result = SREMulti.Recognize(); // Ton aufzeichnen und erkennen
                        ResultString = "";
                        // alle erkannten Wörter aus dem Ergebnis dem Ergebnisstring hinzufügen
                        foreach (RecognizedWordUnit w in Result.Words)
                        {
                            ResultString += w.Text;
                        }
                        multi = umwandlungMulti[ResultString];
                        ClickButton(btnArrayMulti[i][multi]);
                        test = false;
                    }
                    catch
                    {

                    }
                }

                if (multi >= 0 && multi <= 2)
                {
                    test = true;
                    while (test)
                    {
                        try
                        {
                            Result = SRE.Recognize(); // Ton aufzeichnen und erkennen
                            ResultString = "";
                            // alle erkannten Wörter aus dem Ergebnis dem Ergebnisstring hinzufügen
                            foreach (RecognizedWordUnit w in Result.Words)
                            {
                                ResultString += w.Text;
                            }
                            wert = umwandlungWert[ResultString];
                            if (wert != 25)
                            {
                                ClickButton(btnArrayWert[i][wert]);
                            }
                            else if (multi == 0)
                            {
                                ClickButton(btnArrayMulti[i][3]);
                            }
                            else if (multi == 1)
                            {
                                ClickButton(btnArrayMulti[i][4]);
                            }
                            else if (multi == 2)
                            {
                                Loeschen();
                                break;
                            }
                            test = false;
                        }
                        catch
                        {

                        }
                    }
                }
                if (info != 0 || (wert == 25 && multi == 2))
                {
                    break;
                }
            }
        }

        private void btn_weiter_Click(object sender, EventArgs e)
        {
            //Aufruf Spiel Rückblick, Statistik etc.

            Program.frmSpielView.Hide();
            Program.frmMainMenu.Show();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void rbKlickEingabe_CheckedChanged(object sender, EventArgs e)
        {
            ChangeEingabe();
        }

        private void rbSpracheingabe_CheckedChanged(object sender, EventArgs e)
        {
            ChangeEingabe();
        }
    }
}
