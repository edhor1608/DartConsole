using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartConsole
{
    static class Program
    {
        public static Spieler spieler;
        public static Spiel spielAktuell;
        public static MainMenu frmMainMenu;
        public static Spielerauflistung frmMainView;
        public static StartingScreen frmStartingScreen;
        public static SpielEinstellungen frmGameOptions;
        public static SpielView frmSpielView;
        public static StatistikView frmStatistikView;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMainMenu = new MainMenu();
            frmMainView = new Spielerauflistung();
            frmStartingScreen = new StartingScreen();
            frmGameOptions = new SpielEinstellungen();
            frmSpielView = new SpielView();
            frmStatistikView = new StatistikView();
            //frmMainView.Show();
            frmStartingScreen.Show();
            Application.Run(); 
        }

    }
}
