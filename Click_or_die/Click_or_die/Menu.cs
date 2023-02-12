using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_or_die
{
    public partial class Menu : Form
    {
        /// <summary>
        /// zmienna tworząca globalny punkt dostępu do obiektu klasy
        /// </summary>
        public static Menu instance;

        /// <summary>
        /// inicjalizacja okienka Menu
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            instance = this;

            // zamykanie przez X w prawym górnym rogu
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        /// <summary>
        /// funkcja zamykająca aplikacje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// rozpoczęcie nowej gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_newgame_Click(object sender, EventArgs e)
        {
            //wyświetlenie nowej gry
            GameWindow form_game = GameWindow.instance;
            form_game.Show();

            //wykonanie się restartu
            GameWindow.instance.button_restart_Click(sender, e);

            //zamykanie menu
            Menu form_menu = this;
            form_menu.Hide();
        }

        /// <summary>
        /// wybór poziomu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_level_Click(object sender, EventArgs e)
        {
            //wyświetlenie okienka wyboru poziomu
            ChooseLevel form_level = new ChooseLevel();
            form_level.Show();

            //zrestartowanie ustawień
            GameWindow.instance.button_restart_Click(sender, e);

            //chowamy menu
            Menu form_menu = this;
            form_menu.Hide();
        }

        /// <summary>
        /// wybór instrukcji gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_howtoplay_Click(object sender, EventArgs e)
        {
            //wyświetlenie okienka instrukcji gry
            HowToPlay form_howtoplay = new HowToPlay();
            form_howtoplay.Show();

            //chowamy menu
            Menu form_menu = this;
            form_menu.Hide();
        }

        /// <summary>
        /// przycisk wyjścia z gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
