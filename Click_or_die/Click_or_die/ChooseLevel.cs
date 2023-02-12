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
    public partial class ChooseLevel : Form
    {
        /// <summary>
        /// zmienna tworząca globalny punkt dostępu do obiektu klasy
        /// </summary>
        public static ChooseLevel instance;

        /// <summary>
        /// inicjalizacja okienka wyboru poziomu
        /// </summary>
        public ChooseLevel()
        {
            InitializeComponent();
            instance = this;

            //poziom łatwy, podświetlenie na jasny niebieski przycisku poziomu i przypisanie wartości
            if (GameWindow.instance.level == 1 )
            {
                button_easy.BackColor = Color.LightCyan;
                button_medium.BackColor = Color.White;
                button_hard.BackColor = Color.White;
                GameWindow.instance.playerPoints = 50 * 2;
                GameWindow.instance.pollution = 1500;
                GameWindow.instance.value_ticks = 500;
            }

            //poziom średni, podświetlenie na jasny niebieski przycisku poziomu i przypisanie wartości
            if (GameWindow.instance.level == 2)
            {
                button_easy.BackColor = Color.White;
                button_medium.BackColor = Color.LightCyan;
                button_hard.BackColor = Color.White;
                GameWindow.instance.playerPoints = 25*2;
                GameWindow.instance.pollution = 3000;
                GameWindow.instance.value_ticks = 550;
            }

            //poziom trudny, podświetlenie na jasny niebieski przycisku poziomu i przypisanie wartości
            if (GameWindow.instance.level == 3)
            {
                button_easy.BackColor = Color.White;
                button_medium.BackColor = Color.White;
                button_hard.BackColor = Color.LightCyan;
                GameWindow.instance.playerPoints = 0;
                GameWindow.instance.pollution = 5800;
                GameWindow.instance.value_ticks = 750;
            }
        }

        /// <summary>
        /// button return, wyjście z wyboru poziomu do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_return_Click(object sender, EventArgs e)
        {
            Menu form_menu = Click_or_die.Menu.instance;
            form_menu.Show();

            ChooseLevel form_chooselevel = this;
            form_chooselevel.Close();
        }

        /// <summary>
        /// podświetlenie po kliknięciu przycisku poziomu łatwego na jasny niebieski
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_easy_Click(object sender, EventArgs e)
        {
            GameWindow.instance.level = 1;
            button_easy.BackColor = Color.LightCyan;
            button_medium.BackColor = Color.White;
            button_hard.BackColor = Color.White;
        }

        /// <summary>
        /// podświetlenie po kliknięciu przycisku poziomu średniego na jasny niebieski
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_medium_Click(object sender, EventArgs e)
        {
            GameWindow.instance.level = 2;
            button_easy.BackColor = Color.White;
            button_medium.BackColor = Color.LightCyan;
            button_hard.BackColor = Color.White;
        }

        /// <summary>
        /// podświetlenie po kliknięciu przycisku poziomu trudnego na jasny niebieski
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_hard_Click(object sender, EventArgs e)
        {
            GameWindow.instance.level = 3;
            button_easy.BackColor = Color.White;
            button_medium.BackColor = Color.White;
            button_hard.BackColor = Color.LightCyan;
        }
    }
}
