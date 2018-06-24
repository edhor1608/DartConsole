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
        public static MainMenu frmMainMenu;
        public static MainView frmMainView;
        public static StartingScreen frmStartingScreen;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMainMenu = new MainMenu();
            frmMainView = new MainView();
            frmStartingScreen = new StartingScreen();
            //frmMainView.Show();
            frmStartingScreen.Show();
            Application.Run(); 
        }

    }
}
