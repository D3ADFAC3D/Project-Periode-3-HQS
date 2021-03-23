namespace Dobbelen
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
            this.pbDice1 = new System.Windows.Forms.PictureBox();
            this.pbDice2 = new System.Windows.Forms.PictureBox();
            this.pbDice3 = new System.Windows.Forms.PictureBox();
            this.pbDice4 = new System.Windows.Forms.PictureBox();
            this.pbDice5 = new System.Windows.Forms.PictureBox();
            this.pbDice6 = new System.Windows.Forms.PictureBox();
            this.tbSom = new System.Windows.Forms.TextBox();
            this.lblSom = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.lblDeviatie = new System.Windows.Forms.Label();
            this.tbDeviatie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice6)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDice1
            // 
            this.pbDice1.Location = new System.Drawing.Point(30, 30);
            this.pbDice1.Name = "pbDice1";
            this.pbDice1.Size = new System.Drawing.Size(100, 100);
            this.pbDice1.TabIndex = 0;
            this.pbDice1.TabStop = false;
            this.pbDice1.Click += new System.EventHandler(this.pbDice1_Click);
            // 
            // pbDice2
            // 
            this.pbDice2.Location = new System.Drawing.Point(156, 30);
            this.pbDice2.Name = "pbDice2";
            this.pbDice2.Size = new System.Drawing.Size(100, 100);
            this.pbDice2.TabIndex = 1;
            this.pbDice2.TabStop = false;
            this.pbDice2.Click += new System.EventHandler(this.pbDice1_Click);
            // 
            // pbDice3
            // 
            this.pbDice3.Location = new System.Drawing.Point(285, 30);
            this.pbDice3.Name = "pbDice3";
            this.pbDice3.Size = new System.Drawing.Size(100, 100);
            this.pbDice3.TabIndex = 2;
            this.pbDice3.TabStop = false;
            this.pbDice3.Click += new System.EventHandler(this.pbDice1_Click);
            // 
            // pbDice4
            // 
            this.pbDice4.Location = new System.Drawing.Point(415, 30);
            this.pbDice4.Name = "pbDice4";
            this.pbDice4.Size = new System.Drawing.Size(100, 100);
            this.pbDice4.TabIndex = 3;
            this.pbDice4.TabStop = false;
            this.pbDice4.Click += new System.EventHandler(this.pbDice1_Click);
            // 
            // pbDice5
            // 
            this.pbDice5.Location = new System.Drawing.Point(548, 30);
            this.pbDice5.Name = "pbDice5";
            this.pbDice5.Size = new System.Drawing.Size(100, 100);
            this.pbDice5.TabIndex = 4;
            this.pbDice5.TabStop = false;
            this.pbDice5.Click += new System.EventHandler(this.pbDice1_Click);
            // 
            // pbDice6
            // 
            this.pbDice6.Location = new System.Drawing.Point(674, 30);
            this.pbDice6.Name = "pbDice6";
            this.pbDice6.Size = new System.Drawing.Size(100, 100);
            this.pbDice6.TabIndex = 5;
            this.pbDice6.TabStop = false;
            this.pbDice6.Click += new System.EventHandler(this.pbDice1_Click);
            // 
            // tbSom
            // 
            this.tbSom.Location = new System.Drawing.Point(315, 190);
            this.tbSom.Name = "tbSom";
            this.tbSom.Size = new System.Drawing.Size(100, 20);
            this.tbSom.TabIndex = 6;
            // 
            // lblSom
            // 
            this.lblSom.Location = new System.Drawing.Point(209, 190);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(100, 20);
            this.lblSom.TabIndex = 7;
            this.lblSom.Text = "Som";
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(209, 221);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(100, 20);
            this.lblAverage.TabIndex = 8;
            this.lblAverage.Text = "Average";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(315, 221);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(100, 20);
            this.tbAverage.TabIndex = 9;
            // 
            // lblRange
            // 
            this.lblRange.Location = new System.Drawing.Point(209, 255);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(100, 20);
            this.lblRange.TabIndex = 10;
            this.lblRange.Text = "Range";
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(315, 255);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(100, 20);
            this.tbRange.TabIndex = 11;
            // 
            // lblDeviatie
            // 
            this.lblDeviatie.Location = new System.Drawing.Point(209, 287);
            this.lblDeviatie.Name = "lblDeviatie";
            this.lblDeviatie.Size = new System.Drawing.Size(100, 20);
            this.lblDeviatie.TabIndex = 12;
            this.lblDeviatie.Text = "Deviatie";
            // 
            // tbDeviatie
            // 
            this.tbDeviatie.Location = new System.Drawing.Point(315, 287);
            this.tbDeviatie.Name = "tbDeviatie";
            this.tbDeviatie.Size = new System.Drawing.Size(100, 20);
            this.tbDeviatie.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDeviatie);
            this.Controls.Add(this.lblDeviatie);
            this.Controls.Add(this.tbRange);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.tbSom);
            this.Controls.Add(this.pbDice6);
            this.Controls.Add(this.pbDice5);
            this.Controls.Add(this.pbDice4);
            this.Controls.Add(this.pbDice3);
            this.Controls.Add(this.pbDice2);
            this.Controls.Add(this.pbDice1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pbDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDice6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblDeviatie;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.TextBox tbDeviatie;

        private System.Windows.Forms.TextBox tbAverage;

        private System.Windows.Forms.Label lblAverage;

        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.TextBox tbSom;

        private System.Windows.Forms.PictureBox pbDice2;
        private System.Windows.Forms.PictureBox pbDice3;
        private System.Windows.Forms.PictureBox pbDice4;
        private System.Windows.Forms.PictureBox pbDice5;
        private System.Windows.Forms.PictureBox pbDice6;

        private System.Windows.Forms.PictureBox pbDice1;

        #endregion
    }
}