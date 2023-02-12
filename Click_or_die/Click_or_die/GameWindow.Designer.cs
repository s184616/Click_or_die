
namespace Click_or_die
{
    partial class GameWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.label_points = new System.Windows.Forms.Label();
            this.button_click = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_firm = new System.Windows.Forms.Label();
            this.button_50p = new System.Windows.Forms.Button();
            this.button_20p = new System.Windows.Forms.Button();
            this.button_5p = new System.Windows.Forms.Button();
            this.label_worker = new System.Windows.Forms.Label();
            this.label_coffee = new System.Windows.Forms.Label();
            this.label_poluttion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_money = new System.Windows.Forms.Label();
            this.label_ticks = new System.Windows.Forms.Label();
            this.COUNTING_TIMER = new System.Windows.Forms.Timer(this.components);
            this.button_restart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_goal = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_shop = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.BackColor = System.Drawing.Color.Transparent;
            this.label_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_points.Location = new System.Drawing.Point(12, 50);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(198, 31);
            this.label_points.TabIndex = 0;
            this.label_points.Text = "Ilość kliknięć: 0";
            // 
            // button_click
            // 
            this.button_click.BackColor = System.Drawing.Color.Transparent;
            this.button_click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_click.BackgroundImage")));
            this.button_click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_click.FlatAppearance.BorderSize = 0;
            this.button_click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_click.Location = new System.Drawing.Point(47, 326);
            this.button_click.Name = "button_click";
            this.button_click.Size = new System.Drawing.Size(220, 184);
            this.button_click.TabIndex = 1;
            this.button_click.UseVisualStyleBackColor = false;
            this.button_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_firm);
            this.groupBox1.Controls.Add(this.button_50p);
            this.groupBox1.Controls.Add(this.button_20p);
            this.groupBox1.Controls.Add(this.button_5p);
            this.groupBox1.Controls.Add(this.label_worker);
            this.groupBox1.Controls.Add(this.label_coffee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(453, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upgrade\'y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(184, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "(50 kliknięć)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(184, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "(20 kliknięć)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(183, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "(5 kliknięć)";
            // 
            // label_firm
            // 
            this.label_firm.AutoSize = true;
            this.label_firm.BackColor = System.Drawing.Color.Transparent;
            this.label_firm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_firm.Location = new System.Drawing.Point(182, 274);
            this.label_firm.Name = "label_firm";
            this.label_firm.Size = new System.Drawing.Size(121, 25);
            this.label_firm.TabIndex = 13;
            this.label_firm.Text = "ilość firm: 0";
            // 
            // button_50p
            // 
            this.button_50p.BackColor = System.Drawing.Color.Transparent;
            this.button_50p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_50p.BackgroundImage")));
            this.button_50p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_50p.FlatAppearance.BorderSize = 0;
            this.button_50p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_50p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_50p.Location = new System.Drawing.Point(12, 251);
            this.button_50p.Name = "button_50p";
            this.button_50p.Size = new System.Drawing.Size(135, 90);
            this.button_50p.TabIndex = 11;
            this.button_50p.UseVisualStyleBackColor = false;
            this.button_50p.Click += new System.EventHandler(this.button_50p_Click_1);
            // 
            // button_20p
            // 
            this.button_20p.BackColor = System.Drawing.Color.Transparent;
            this.button_20p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_20p.BackgroundImage")));
            this.button_20p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_20p.FlatAppearance.BorderSize = 0;
            this.button_20p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_20p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_20p.Location = new System.Drawing.Point(12, 136);
            this.button_20p.Name = "button_20p";
            this.button_20p.Size = new System.Drawing.Size(135, 90);
            this.button_20p.TabIndex = 10;
            this.button_20p.UseVisualStyleBackColor = false;
            this.button_20p.Click += new System.EventHandler(this.button_20p_Click_1);
            // 
            // button_5p
            // 
            this.button_5p.BackColor = System.Drawing.Color.Transparent;
            this.button_5p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_5p.BackgroundImage")));
            this.button_5p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_5p.FlatAppearance.BorderSize = 0;
            this.button_5p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_5p.Location = new System.Drawing.Point(50, 57);
            this.button_5p.Name = "button_5p";
            this.button_5p.Size = new System.Drawing.Size(57, 59);
            this.button_5p.TabIndex = 7;
            this.button_5p.UseVisualStyleBackColor = false;
            this.button_5p.Click += new System.EventHandler(this.button_5p_Click);
            // 
            // label_worker
            // 
            this.label_worker.AutoSize = true;
            this.label_worker.BackColor = System.Drawing.Color.Transparent;
            this.label_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_worker.Location = new System.Drawing.Point(182, 169);
            this.label_worker.Name = "label_worker";
            this.label_worker.Size = new System.Drawing.Size(210, 25);
            this.label_worker.TabIndex = 8;
            this.label_worker.Text = "ilość pracowników: 0";
            // 
            // label_coffee
            // 
            this.label_coffee.AutoSize = true;
            this.label_coffee.BackColor = System.Drawing.Color.Transparent;
            this.label_coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_coffee.Location = new System.Drawing.Point(182, 74);
            this.label_coffee.Name = "label_coffee";
            this.label_coffee.Size = new System.Drawing.Size(135, 25);
            this.label_coffee.TabIndex = 7;
            this.label_coffee.Text = "ilość kawy: 0";
            // 
            // label_poluttion
            // 
            this.label_poluttion.AutoSize = true;
            this.label_poluttion.BackColor = System.Drawing.Color.Transparent;
            this.label_poluttion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_poluttion.Location = new System.Drawing.Point(6, 56);
            this.label_poluttion.Name = "label_poluttion";
            this.label_poluttion.Size = new System.Drawing.Size(444, 31);
            this.label_poluttion.TabIndex = 3;
            this.label_poluttion.Text = "Poziom zanieczyszczenia: 1500 pkt";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.button_click);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(88, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 500);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Środowisko:";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.BackColor = System.Drawing.Color.Transparent;
            this.label_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_money.Location = new System.Drawing.Point(6, 16);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(250, 31);
            this.label_money.TabIndex = 5;
            this.label_money.Text = "Ilość pieniędzy: 0 zł";
            // 
            // label_ticks
            // 
            this.label_ticks.AutoSize = true;
            this.label_ticks.BackColor = System.Drawing.Color.Transparent;
            this.label_ticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ticks.Location = new System.Drawing.Point(12, 13);
            this.label_ticks.Name = "label_ticks";
            this.label_ticks.Size = new System.Drawing.Size(128, 31);
            this.label_ticks.TabIndex = 6;
            this.label_ticks.Text = "Czas: 0 s";
            // 
            // COUNTING_TIMER
            // 
            this.COUNTING_TIMER.Enabled = true;
            this.COUNTING_TIMER.Interval = 50;
            this.COUNTING_TIMER.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_restart
            // 
            this.button_restart.BackColor = System.Drawing.Color.LightGray;
            this.button_restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_restart.BackgroundImage")));
            this.button_restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_restart.FlatAppearance.BorderSize = 0;
            this.button_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restart.Location = new System.Drawing.Point(453, 615);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(97, 92);
            this.button_restart.TabIndex = 7;
            this.button_restart.UseVisualStyleBackColor = false;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.label_money);
            this.groupBox3.Controls.Add(this.label_poluttion);
            this.groupBox3.Location = new System.Drawing.Point(453, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 115);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.Controls.Add(this.label_ticks);
            this.groupBox4.Controls.Add(this.label_points);
            this.groupBox4.Location = new System.Drawing.Point(88, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 114);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.COUNTING_TIMER_Tick);
            // 
            // label_goal
            // 
            this.label_goal.AutoSize = true;
            this.label_goal.BackColor = System.Drawing.Color.Transparent;
            this.label_goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_goal.Location = new System.Drawing.Point(6, 16);
            this.label_goal.Name = "label_goal";
            this.label_goal.Size = new System.Drawing.Size(802, 29);
            this.label_goal.TabIndex = 7;
            this.label_goal.Text = "Poziom łatwy: Masz 400 s, aby pozbyć się 1500 pkt zanieczyszczenia";
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Controls.Add(this.label_goal);
            this.groupBox5.Location = new System.Drawing.Point(88, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(841, 52);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // button_shop
            // 
            this.button_shop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_shop.BackgroundImage")));
            this.button_shop.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shop.Location = new System.Drawing.Point(737, 615);
            this.button_shop.Name = "button_shop";
            this.button_shop.Size = new System.Drawing.Size(192, 92);
            this.button_shop.TabIndex = 11;
            this.button_shop.Text = "Eco for life - sklep";
            this.button_shop.UseVisualStyleBackColor = true;
            this.button_shop.Click += new System.EventHandler(this.button_shop_Click);
            // 
            // button_menu
            // 
            this.button_menu.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_menu.Location = new System.Drawing.Point(556, 615);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(175, 92);
            this.button_menu.TabIndex = 12;
            this.button_menu.Text = "Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_shop);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click or die";
            this.VisibleChanged += new System.EventHandler(this.refresh);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.Button button_click;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_poluttion;
        private System.Windows.Forms.Label label_worker;
        private System.Windows.Forms.Label label_coffee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label_ticks;
        private System.Windows.Forms.Timer COUNTING_TIMER;
        private System.Windows.Forms.Button button_5p;
        private System.Windows.Forms.Button button_50p;
        private System.Windows.Forms.Button button_20p;
        private System.Windows.Forms.Label label_firm;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_goal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_shop;
        private System.Windows.Forms.Button button_menu;
        public System.Windows.Forms.Timer timer1;
    }
}

