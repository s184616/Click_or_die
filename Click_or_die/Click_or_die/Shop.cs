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
    public partial class Shop : Form
    {
        /// <summary>
        /// zmienna tworząca globalny punkt dostępu do obiektu klasy
        /// </summary>
        public static Shop instance;

        /// <summary>
        /// poruszanie się postaci prawo, lewo, góra, dół
        /// </summary>
        bool moveRight, moveLeft, moveUp, moveDown;
        /// <summary>
        /// akcja wykonana, zmienna do jednorazowej akcji wyświetlenia informacji
        /// </summary>
        bool taskdone = false;
        /// <summary>
        /// szybkość postaci
        /// </summary>
        int speed = 4;

        /// <summary>
        /// inicjalizacja okienka sklepu
        /// </summary>
        public Shop()
        {
            InitializeComponent();
            instance = this;
            label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
            label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
            label_ticks.Text = "Czas: " + GameWindow.instance._ticks + " s";
        }

        /// <summary>
        /// button return, powrót do gry ze sklepu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_return_Click(object sender, EventArgs e)
        {
            GameWindow form_game = GameWindow.instance;
            form_game.Show();

            //jeśli zegar wynosi 0s to timery mają być zatrzymane, gra się jeszcze nie zaczęła
            if (GameWindow.instance._ticks == 0)
            {
                GameWindow.instance.t1.Stop();
                GameWindow.instance.t2.Stop();
            }

            //jeśli zegar wynosi więcej niż 0s, timery mają ruszyć po powrocie do gry
            if (GameWindow.instance._ticks > 0)
            {
                GameWindow.instance.t1.Start();
                GameWindow.instance.t2.Start();
            }

            Shop form_shop = this;
            form_shop.Close();

            //informacja o wygranej, jeśli zanieczyszczenie wynosi 0pkt
            if (GameWindow.instance.pollution <= 0)
            {
                MessageBox.Show("Wygrałeś! Możesz teraz spróbować inny poziom!");
            }
        }

        /// <summary>
        /// akcja wykonywana po naciśnięciu przycisku, poruszanie się postaci za pomocą WSAD i kupowanie przedmiotów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyisdown(object sender, KeyEventArgs e)
        {
            //poruszanie się WSADem - prawo, lewo, góra, dół
            if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
            }

            //sprawdzanie w jakim miejscu znajduje się postać i kupowanie przedmiotów
            if (e.KeyCode == Keys.X)
            {
                //Eko torba
                //x od 194 do 338  i  y od 397 do 497
                if ((pictureBox_potato.Location.X > 194) & (pictureBox_potato.Location.X < 338) & 
                    (pictureBox_potato.Location.Y > 397) & (pictureBox_potato.Location.Y < 497))
                {
                    if (GameWindow.instance.playerPoints >= 50 * 2)
                    {
                        MessageBox.Show("Kupuje!");
                        GameWindow.instance.playerPoints -= 50*2;
                        GameWindow.instance.pollution -= 10;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints/2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Perlator
                //x od 195 do 338  i  y od 323 do 360
                if ((pictureBox_potato.Location.X > 195) & (pictureBox_potato.Location.X < 338) &
                    (pictureBox_potato.Location.Y > 323) & (pictureBox_potato.Location.Y < 360))
                {
                    if (GameWindow.instance.playerPoints >= 100 * 2)
                    {
                        MessageBox.Show("Kupuje!");
                        GameWindow.instance.playerPoints -= 100 * 2;
                        GameWindow.instance.pollution -= 20;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Rośliny
                //x od 194 do 338  i  y od 248 do 284
                if ((pictureBox_potato.Location.X > 194) & (pictureBox_potato.Location.X < 338) &
                    (pictureBox_potato.Location.Y > 248) & (pictureBox_potato.Location.Y < 284))
                {
                    if (GameWindow.instance.playerPoints >= 200 * 2)
                    {
                        MessageBox.Show("Kupuje!");
                        GameWindow.instance.playerPoints -= 200 * 2;
                        GameWindow.instance.pollution -= 40;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Listwy
                //x od 194 do 333  i  y od 146 do 221
                if ((pictureBox_potato.Location.X > 194) & (pictureBox_potato.Location.X < 333) &
                    (pictureBox_potato.Location.Y > 146) & (pictureBox_potato.Location.Y < 221))
                {
                    if (GameWindow.instance.playerPoints >= 350 * 2)
                    {
                    MessageBox.Show("Kupuje!");
                    GameWindow.instance.playerPoints -= 350 * 2;
                    GameWindow.instance.pollution -= 70;
                    label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                    label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Kosze do segregacji
                //x od 0 do 151    i  y od 420 do 541
                if ((pictureBox_potato.Location.X > 0) & (pictureBox_potato.Location.X < 151) &
                    (pictureBox_potato.Location.Y > 420) & (pictureBox_potato.Location.Y < 541))
                {
                    if (GameWindow.instance.playerPoints >= 300 * 2)
                    {
                        MessageBox.Show("Kupuje!");
                        GameWindow.instance.playerPoints -= 300 * 2;
                        GameWindow.instance.pollution -= 60;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Świetlówki LED
                //x od 0 do 150    i  y od 307 do 393
                if ((pictureBox_potato.Location.X > 0) & (pictureBox_potato.Location.X < 150) &
                    (pictureBox_potato.Location.Y > 307) & (pictureBox_potato.Location.Y < 393))
                {
                    if (GameWindow.instance.playerPoints >= 400 * 2)
                    {
                        MessageBox.Show("Kupuje!");
                        GameWindow.instance.playerPoints -= 400 * 2;
                        GameWindow.instance.pollution -= 80;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Filtr wody
                //x od 0 do 151    i  y od 206 do 284
                if ((pictureBox_potato.Location.X > 0) & (pictureBox_potato.Location.X < 151) &
                    (pictureBox_potato.Location.Y > 206) & (pictureBox_potato.Location.Y < 284))
                {
                    if (GameWindow.instance.playerPoints >= 250 * 2)
                    {
                        MessageBox.Show("Kupuje!");
                        GameWindow.instance.playerPoints -= 250 * 2;
                        GameWindow.instance.pollution -= 50;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Filtr do komina
                //x od 0 do 138    i  y od 69 do 186
                if ((pictureBox_potato.Location.X > 0) & (pictureBox_potato.Location.X < 138) &
                    (pictureBox_potato.Location.Y > 69) & (pictureBox_potato.Location.Y < 186))
                {
                    if (GameWindow.instance.playerPoints >= 500 * 2)
                    {
                        MessageBox.Show("Kupuje!");
                        GameWindow.instance.playerPoints -= 500 * 2;
                        GameWindow.instance.pollution -= 100;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Projekt 1
                //x od 615 do 758  i  y od 144 do 221
                if ((pictureBox_potato.Location.X > 615) & (pictureBox_potato.Location.X < 758) &
                    (pictureBox_potato.Location.Y > 144) & (pictureBox_potato.Location.Y < 221))
                {
                    if (GameWindow.instance.playerPoints >= 2500 * 2)
                    {
                        if (taskdone == false & GameWindow.instance.level == 1)
                        {
                            MessageBox.Show("Projekt 1: Skażenie wody\n\nKupując ten projekt oczyszczasz wodę, a przy tym ratujesz" +
                                " wymierające ryby. Dbaj o Ziemię i nie wylewaj szkodliwych substancji do wody!");
                            taskdone = true;
                        }
                        else
                        {
                            MessageBox.Show("Kupuje!");
                        }
                        GameWindow.instance.playerPoints -= 2500 * 2;
                        GameWindow.instance.pollution -= 500;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Projekt 2
                //x od 804 do 959  i  y od 101 do 206
                if ((pictureBox_potato.Location.X > 804) & (pictureBox_potato.Location.X < 959) &
                    (pictureBox_potato.Location.Y > 101) & (pictureBox_potato.Location.Y < 206))
                {
                    if (GameWindow.instance.playerPoints >= 3500 * 2)
                    {
                        if (taskdone == false & GameWindow.instance.level == 1)
                        {
                            MessageBox.Show("Projekt 2: Susze\n\nDzięki zainwestowaniu w ten projekt udało ci się pozbyć suszy!" +
                                " Jest to aktualnie duży problem na dużą skalę. Pamiętaj o oszczędzaniu wody, a zamiast kąpieli w wannie" +
                                " korzystaj z prysznica!");
                            taskdone = true;
                        }
                        else
                        {
                            MessageBox.Show("Kupuje!");
                        }
                        GameWindow.instance.playerPoints -= 3500 * 2;
                        GameWindow.instance.pollution -= 700;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Projekt 3
                //x od 626 do 758  i  y od 234 do 323
                if ((pictureBox_potato.Location.X > 626) & (pictureBox_potato.Location.X < 758) &
                    (pictureBox_potato.Location.Y > 234) & (pictureBox_potato.Location.Y < 323))
                {
                    if (GameWindow.instance.playerPoints >= 5000 * 2)
                    {
                        if (taskdone == false & GameWindow.instance.level == 1)
                        {
                            MessageBox.Show("Projekt 3: Wycinki lasów\n\nPoprzez zakup tego projektu udało ci się rozwiązać problem wycinek lasów i " +
                                "zasadzić nowe drzewa. Pamiętaj jednak nadal, aby zmniejszać zużycie papieru i korzystać z produktów z odnawialnych " +
                                "źródeł.");
                            taskdone = true;
                        }
                        else
                        {
                            MessageBox.Show("Kupuje!");
                        }
                        GameWindow.instance.playerPoints -= 5000 * 2;
                        GameWindow.instance.pollution -= 1000;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }

                //Projekt 4
                //x od 803 do 959  i  y od 221 do 323
                if ((pictureBox_potato.Location.X > 803) & (pictureBox_potato.Location.X < 959) &
                    (pictureBox_potato.Location.Y > 221) & (pictureBox_potato.Location.Y < 323))
                {
                    if (GameWindow.instance.playerPoints >= 7500 * 2)
                    {
                        if (taskdone == false & GameWindow.instance.level == 1)
                        {
                            MessageBox.Show("Projekt 4: Zanieczyszczenie powietrza\n\nKupując ten projekt udało ci się oczyścić Ziemię z " +
                                "zanieczyszczonego powietrza! Jednak problem jest bardzo aktualny i nadal wraca. Pamiętaj korzystać z transportu " +
                                "publicznego albo roweru zamiast jechać samochodem. Jeśli mieszkasz w domu korzystaj z filtra na komin!");
                            taskdone = true;
                        }
                        else
                        {
                            MessageBox.Show("Kupuje!");
                        }
                        GameWindow.instance.playerPoints -= 7500 * 2;
                        GameWindow.instance.pollution -= 1500;
                        label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                        label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało pieniędzy!");
                    }
                }
            }
        }

        /// <summary>
        /// akcja wykonywana po puszczeniu przycisku, postać przestaje się poruszać
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
        }

        /// <summary>
        /// timer odpowiadający za fizyczne poruszanie się postaci o daną wartość prędkości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft == true & pictureBox_potato.Left > 0)
            {
                pictureBox_potato.Left -= speed;
            }
            if (moveRight == true & pictureBox_potato.Right < 1000)
            {
                pictureBox_potato.Left += speed;
            }
            if (moveUp == true & pictureBox_potato.Top > 0)
            {
                pictureBox_potato.Top -= speed;
            }
            if (moveDown == true & pictureBox_potato.Top < 644)
            {
                pictureBox_potato.Top += speed;
            }

            //wygrana, jeśli zanieczyszczenie wynosi mniej lub równo 0pkt wyzeruj inne parametry
            if (GameWindow.instance.pollution <= 0)
            {
                GameWindow.instance.pollution = 0;
                GameWindow.instance.timer1.Stop();
                GameWindow.instance._ticks = 0;
                GameWindow.instance.playerPoints = 0;
                label_ticks.Text = "Gra skończona";
                label_money.Text = "Ilość pieniędzy: " + GameWindow.instance.playerPoints / 2 + " zł";
                label_poluttion.Text = "Poziom zanieczyszczenia: " + GameWindow.instance.pollution + " pkt";
            }
        }
    }
}
