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
    public partial class GameWindow : Form
    {
        /// <summary>
        /// punkty gracza
        /// </summary>
        public int playerPoints = 100;
        /// <summary>
        /// punkty zanieczyszczenia
        /// </summary>
        public int pollution = 1500;
        /// <summary>
        /// ilość czasu
        /// </summary>
        public int _ticks = 0;
        /// <summary>
        /// limit czasu, domyślnie 500sek
        /// </summary>
        public int value_ticks = 500;
        /// <summary>
        /// timer 1
        /// </summary>
        public Timer t1;
        /// <summary>
        /// timer 2
        /// </summary>
        public Timer t2;
        /// <summary>
        /// wybór poziomu: 1, 2 lub 3
        /// </summary>
        public int level;

        /// <summary>
        /// auto clicker - ilość kaw
        /// </summary>
        int _5pAmount = 0;
        /// <summary>
        /// ilość pracowników
        /// </summary>
        int _20pAmount = 0;
        /// <summary>
        /// ilość firm
        /// </summary>
        int _50pAmount = 0;

        /// <summary>
        /// wartość czasomierza auto clickera
        /// </summary>
        int timerCount = 0;

        /// <summary>
        /// zmienna tworząca globalny punkt dostępu do obiektu klasy GameWindow
        /// </summary>
        public static GameWindow instance;

        /// <summary>
        /// konstruktor klasy przyjmujący wartości startowe
        /// </summary>
        public GameWindow()
        {
            InitializeComponent();
            instance = this;
            t1 = timer1; //autoclicker timer
            t2 = COUNTING_TIMER; //timer w trakcie gry
            level = 1; //poziom łatwy domyślny
            timer1.Stop(); //zatrzymanie timera1
        }

        /// <summary>
        /// naciśnięcie głównego czerwonego guzika, dodanie punktu do ilości kliknięć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label_points.Text = "Ilość kliknięć: " + playerPoints.ToString();
            label_money.Text = "Ilość pieniędzy: " + playerPoints/2 + " zł";
            playerPoints += 1;
            label_poluttion.Text = "Poziom zanieczyszczenia: "  + pollution.ToString() + " pkt";
        }

        /// <summary>
        /// auto clicker - kawa za 5 pkt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_5p_Click(object sender, EventArgs e)
        {
            //kupowanie autokliknięć za 5 pkt
            if(playerPoints >= 5)
            {
                timer1.Start();
                COUNTING_TIMER.Start();
                _5pAmount += 1;
                playerPoints -= 5;
                label_points.Text = "Ilość kliknięć: " + playerPoints.ToString();
                label_money.Text = "Ilość pieniędzy: " + playerPoints/2 + " zł";
                label_coffee.Text = "ilość kawy: " + _5pAmount;
            }
            else
            {
                MessageBox.Show("Masz niewystarczająco punktów!");
            }

        }

        /// <summary>
        /// auto clicker - pracownik za 20 pkt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_20p_Click_1(object sender, EventArgs e)
        {
            //kupowanie autokliknięć za 20 pkt
            if (playerPoints >= 20)
            {
                timer1.Start();
                COUNTING_TIMER.Start();
                _20pAmount += 1;
                playerPoints -= 20;
                label_points.Text = "Ilość kliknięć: " + playerPoints.ToString();
                label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
                label_worker.Text = "ilość pracowników " + _20pAmount;
            }
            else
            {
                MessageBox.Show("Masz niewystarczająco punktów!");
            }
        }

        /// <summary>
        /// auto clicker - firma za 50 pkt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_50p_Click_1(object sender, EventArgs e)
        {
            //kupowanie autokliknięć za 50 pkt
            if (playerPoints >= 50)
            {
                timer1.Start();
                COUNTING_TIMER.Start();
                _50pAmount += 1;
                playerPoints -= 50;
                label_points.Text = "Ilość kliknięć: " + playerPoints.ToString();
                label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
                label_firm.Text = "ilość firm: " + _50pAmount;
            }
            else
            {
                MessageBox.Show("Masz niewystarczająco punktów!");
            }
        }

        /// <summary>
        /// timer odpowiedzialny za zwiększanie się autokliknięć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount += 1;

            if (timerCount % 2 == 0)
            {
                playerPoints += _50pAmount;
            }

            if (timerCount % 5 == 0)
            {
                playerPoints += _20pAmount;
            }

            if (timerCount % 10 == 0)
            {
                playerPoints += _5pAmount;
            }

            label_points.Text = "Ilość kliknięć: " + playerPoints.ToString();
            label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
            label_poluttion.Text = "Poziom zanieczyszczenia: " + pollution.ToString() + " pkt";
        }

        /// <summary>
        /// reset button, resetuje ustawienia do domyślnych w zależności od poziomu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button_restart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _ticks = 0;
            if (level == 1)
            {
                playerPoints = 50*2;
                value_ticks = 500;
                pollution = 1500;
                label_points.Text = "Ilość kliknięć: " + playerPoints;
                label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
            }
            if (level == 2)
            {
                playerPoints = 25*2;
                value_ticks = 550;
                pollution = 3000;
                label_points.Text = "Ilość kliknięć: " + playerPoints;
                label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
            }
            if (level == 3)
            {
                playerPoints = 0;
                value_ticks = 750;
                pollution = 5800;
                label_points.Text = "Ilość kliknięć: " + playerPoints;
                label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
            }
            _5pAmount = 0;
            _20pAmount = 0;
            _50pAmount = 0;
            label_ticks.Text = "Czas: 0 s";
            label_coffee.Text = "ilość kawy: " + _5pAmount;
            label_worker.Text = "ilość pracowników " + _20pAmount;
            label_firm.Text = "ilość firm: " + _50pAmount;

        }

        /// <summary>
        /// czasomierz, timer odmierzający czas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void COUNTING_TIMER_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label_ticks.Text = "Czas: " + _ticks + " s";

            //gra przegrana po upłynięciu określonego czasu
            if (_ticks == value_ticks)
            {
                timer1.Stop();
                _ticks = 0;
                playerPoints = 0;
                _5pAmount = 0;
                _20pAmount = 0;
                _50pAmount = 0;
                label_ticks.Text = "Gra skończona";
                label_coffee.Text = "ilość kawy: " + _5pAmount;
                label_worker.Text = "ilość pracowników " + _20pAmount;
                label_firm.Text = "ilość firm: " + _50pAmount;
                MessageBox.Show("Czas się skończył!");

                switch(GameWindow.instance.level)
                {
                    case 1:
                        //level = 1;
                        playerPoints = 50*2;
                        label_points.Text = "Ilość kliknięć: " + playerPoints;
                        label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
                        break;
                    case 2:
                        //level = 2;
                        playerPoints = 25 * 2;
                        label_points.Text = "Ilość kliknięć: " + playerPoints;
                        label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
                        break;
                    case 3:
                        //level = 3;
                        playerPoints = 0;
                        label_points.Text = "Ilość kliknięć: " + playerPoints;
                        label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
                        break;
                }
            }
        }

        /// <summary>
        /// przejście z gry do Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_menu_Click(object sender, EventArgs e)
        {
            GameWindow form_game = this;
            form_game.Hide();

            Menu form_menu = new Menu();
            form_menu.Show();
            button_restart_Click(sender, e);
        }

        /// <summary>
        /// przejście z gry do sklepu, zatrzymanie czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_shop_Click(object sender, EventArgs e)
        {
            Shop form_shop = new Shop();
            form_shop.Show();

            timer1.Stop();
            COUNTING_TIMER.Stop();
            GameWindow form_game = this;
            form_game.Hide();
        }

        /// <summary>
        /// refresh po każdym otwarciu karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refresh(object sender, EventArgs e)
        {
            label_points.Text = "Ilość kliknięć: " + playerPoints.ToString();
            label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
            label_poluttion.Text = "Poziom zanieczyszczenia: " + pollution.ToString() + " pkt";

            if (GameWindow.instance.level == 1)
            {
                label_goal.Text = "Poziom łatwy: Masz 500 s, aby pozbyć się 1500 pkt zanieczyszczenia";
            }

            if (GameWindow.instance.level == 2)
            {
                label_goal.Text = "Poziom średni: Masz 550 s, aby pozbyć się 3000 pkt zanieczyszczenia";
            }

            if (GameWindow.instance.level == 3)
            {
                label_goal.Text = "Poziom trudny: Masz 750 s, aby pozbyć się 5800 pkt zanieczyszczenia";
            }

            //wygrana - jeśli zanieczyszczenie wynosi mniej lub równo 0pkt, zeruj zanieczyszczenie i inne parametry, koniec gry
            if (pollution <= 0)
            {
                pollution = 0;
                timer1.Stop();
                COUNTING_TIMER.Stop();
                _ticks = 0;
                playerPoints = 0;
                _5pAmount = 0;
                _20pAmount = 0;
                _50pAmount = 0;
                label_ticks.Text = "Gra skończona";
                label_points.Text = "Ilość kliknięć: " + playerPoints;
                label_money.Text = "Ilość pieniędzy: " + playerPoints / 2 + " zł";
                label_coffee.Text = "ilość kawy: " + _5pAmount;
                label_worker.Text = "ilość pracowników " + _20pAmount;
                label_firm.Text = "ilość firm: " + _50pAmount;
            }
        }
    }
}
