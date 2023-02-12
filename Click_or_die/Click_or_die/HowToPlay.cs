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
    public partial class HowToPlay : Form
    {
        /// <summary>
        /// zmienna tworząca globalny punkt dostępu do obiektu klasy
        /// </summary>
        public static HowToPlay instance;

        /// <summary>
        /// inicjalizacja okienka instrukcji gry
        /// </summary>
        public HowToPlay()
        {
            InitializeComponent();
            instance = this;
        }

        /// <summary>
        /// wyjście z instrukcji gry do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_return_Click(object sender, EventArgs e)
        {
            Menu form_menu = Click_or_die.Menu.instance;
            form_menu.Show();

            HowToPlay form_howtoplay = this;
            form_howtoplay.Close();
        }
    }
}
