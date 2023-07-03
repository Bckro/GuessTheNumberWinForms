
namespace forms1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zgadywanie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tries = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello! Let\'s play \"guess the number\"!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(124, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "What number did I think?";
            // 
            // zgadywanie
            // 
            this.zgadywanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zgadywanie.Location = new System.Drawing.Point(396, 118);
            this.zgadywanie.Name = "zgadywanie";
            this.zgadywanie.Size = new System.Drawing.Size(100, 30);
            this.zgadywanie.TabIndex = 4;
            this.zgadywanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zgadywanie.TextChanged += new System.EventHandler(this.zgadywanie_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(145, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "I chose a number between 0 and 100.";
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guess.Location = new System.Drawing.Point(148, 176);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(146, 33);
            this.guess.TabIndex = 16;
            this.guess.Text = "GUESS";
            this.guess.UseVisualStyleBackColor = true;
            this.guess.Click += new System.EventHandler(this.guess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(224, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number of tries:";
            // 
            // tries
            // 
            this.tries.AutoSize = true;
            this.tries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tries.Location = new System.Drawing.Point(373, 236);
            this.tries.Name = "tries";
            this.tries.Size = new System.Drawing.Size(23, 25);
            this.tries.TabIndex = 19;
            this.tries.Text = "0";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset.Location = new System.Drawing.Point(369, 176);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(146, 33);
            this.reset.TabIndex = 20;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 282);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.tries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zgadywanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guess the number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zgadywanie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tries;
        private System.Windows.Forms.Button reset;
    }
}

