
namespace Click_or_die
{
    partial class ChooseLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevel));
            this.label1 = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.button_easy = new System.Windows.Forms.Button();
            this.button_medium = new System.Windows.Forms.Button();
            this.button_hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(269, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz poziom trudności:";
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_return.Location = new System.Drawing.Point(344, 541);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(299, 102);
            this.button_return.TabIndex = 3;
            this.button_return.Text = "Powrót do Menu";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_easy
            // 
            this.button_easy.BackColor = System.Drawing.Color.White;
            this.button_easy.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_easy.Location = new System.Drawing.Point(370, 142);
            this.button_easy.Name = "button_easy";
            this.button_easy.Size = new System.Drawing.Size(243, 91);
            this.button_easy.TabIndex = 4;
            this.button_easy.Text = "Łatwy";
            this.button_easy.UseVisualStyleBackColor = false;
            this.button_easy.Click += new System.EventHandler(this.button_easy_Click);
            // 
            // button_medium
            // 
            this.button_medium.BackColor = System.Drawing.Color.White;
            this.button_medium.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_medium.Location = new System.Drawing.Point(370, 254);
            this.button_medium.Name = "button_medium";
            this.button_medium.Size = new System.Drawing.Size(243, 91);
            this.button_medium.TabIndex = 5;
            this.button_medium.Text = "Średni";
            this.button_medium.UseVisualStyleBackColor = false;
            this.button_medium.Click += new System.EventHandler(this.button_medium_Click);
            // 
            // button_hard
            // 
            this.button_hard.BackColor = System.Drawing.Color.White;
            this.button_hard.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hard.Location = new System.Drawing.Point(370, 375);
            this.button_hard.Name = "button_hard";
            this.button_hard.Size = new System.Drawing.Size(243, 91);
            this.button_hard.TabIndex = 6;
            this.button_hard.Text = "Trudny";
            this.button_hard.UseVisualStyleBackColor = false;
            this.button_hard.Click += new System.EventHandler(this.button_hard_Click);
            // 
            // ChooseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button_hard);
            this.Controls.Add(this.button_medium);
            this.Controls.Add(this.button_easy);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.label1);
            this.Name = "ChooseLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseLevel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_easy;
        private System.Windows.Forms.Button button_medium;
        private System.Windows.Forms.Button button_hard;
    }
}