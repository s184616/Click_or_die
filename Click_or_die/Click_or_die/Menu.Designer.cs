
namespace Click_or_die
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.button_newgame = new System.Windows.Forms.Button();
            this.button_level = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_howtoplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(266, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click or die";
            // 
            // button_newgame
            // 
            this.button_newgame.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_newgame.Location = new System.Drawing.Point(318, 227);
            this.button_newgame.Name = "button_newgame";
            this.button_newgame.Size = new System.Drawing.Size(199, 75);
            this.button_newgame.TabIndex = 1;
            this.button_newgame.Text = "NOWA GRA";
            this.button_newgame.UseVisualStyleBackColor = true;
            this.button_newgame.Click += new System.EventHandler(this.button_newgame_Click);
            // 
            // button_level
            // 
            this.button_level.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_level.Location = new System.Drawing.Point(318, 334);
            this.button_level.Name = "button_level";
            this.button_level.Size = new System.Drawing.Size(199, 75);
            this.button_level.TabIndex = 2;
            this.button_level.Text = "POZIOM TRUDNOŚCI";
            this.button_level.UseVisualStyleBackColor = true;
            this.button_level.Click += new System.EventHandler(this.button_level_Click);
            // 
            // button_exit
            // 
            this.button_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_exit.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.Location = new System.Drawing.Point(318, 552);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(199, 75);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "WYJŚCIE";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_howtoplay
            // 
            this.button_howtoplay.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_howtoplay.Location = new System.Drawing.Point(318, 444);
            this.button_howtoplay.Name = "button_howtoplay";
            this.button_howtoplay.Size = new System.Drawing.Size(199, 75);
            this.button_howtoplay.TabIndex = 4;
            this.button_howtoplay.Text = "JAK GRAĆ";
            this.button_howtoplay.UseVisualStyleBackColor = true;
            this.button_howtoplay.Click += new System.EventHandler(this.button_howtoplay_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.button_exit;
            this.ClientSize = new System.Drawing.Size(859, 750);
            this.Controls.Add(this.button_howtoplay);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_level);
            this.Controls.Add(this.button_newgame);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_newgame;
        private System.Windows.Forms.Button button_level;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_howtoplay;
    }
}