namespace SzyfrCezara
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TekstTextBox = new System.Windows.Forms.TextBox();
            this.KluczTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ZaszyfrowanyTekst = new System.Windows.Forms.Label();
            this.OryginalnyTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst do zaszyfrowania";
            // 
            // TekstTextBox
            // 
            this.TekstTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TekstTextBox.Location = new System.Drawing.Point(28, 57);
            this.TekstTextBox.Name = "TekstTextBox";
            this.TekstTextBox.Size = new System.Drawing.Size(253, 22);
            this.TekstTextBox.TabIndex = 1;
            // 
            // KluczTextBox
            // 
            this.KluczTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KluczTextBox.Location = new System.Drawing.Point(528, 57);
            this.KluczTextBox.Name = "KluczTextBox";
            this.KluczTextBox.Size = new System.Drawing.Size(44, 22);
            this.KluczTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(522, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj klucz przesunięcia";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(270, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "Szyfruj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SzyfrujButton_Click);
            // 
            // ZaszyfrowanyTekst
            // 
            this.ZaszyfrowanyTekst.AutoSize = true;
            this.ZaszyfrowanyTekst.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZaszyfrowanyTekst.Location = new System.Drawing.Point(22, 318);
            this.ZaszyfrowanyTekst.Name = "ZaszyfrowanyTekst";
            this.ZaszyfrowanyTekst.Size = new System.Drawing.Size(236, 31);
            this.ZaszyfrowanyTekst.TabIndex = 5;
            this.ZaszyfrowanyTekst.Text = "Zaszyfrowany tekst:";
            // 
            // OryginalnyTekst
            // 
            this.OryginalnyTekst.AutoSize = true;
            this.OryginalnyTekst.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OryginalnyTekst.Location = new System.Drawing.Point(21, 372);
            this.OryginalnyTekst.Name = "OryginalnyTekst";
            this.OryginalnyTekst.Size = new System.Drawing.Size(198, 31);
            this.OryginalnyTekst.TabIndex = 6;
            this.OryginalnyTekst.Text = "Oryginalny tekst:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(869, 444);
            this.Controls.Add(this.OryginalnyTekst);
            this.Controls.Add(this.ZaszyfrowanyTekst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KluczTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TekstTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Szyfr Cezara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TekstTextBox;
        private System.Windows.Forms.TextBox KluczTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ZaszyfrowanyTekst;
        private System.Windows.Forms.Label OryginalnyTekst;
    }
}

