using C__Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public static class Program
    {
        public static List<Player> playerlist = new List<Player>();
        public static Player player;
        public static int index = 0;
        
        public static List<Games> Gameslist = new List<Games>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeToGame());
        }
    }
}
