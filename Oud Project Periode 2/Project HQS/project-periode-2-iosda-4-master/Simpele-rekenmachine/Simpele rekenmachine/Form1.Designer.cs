
namespace Simpele_rekenmachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.tbUitkomst = new System.Windows.Forms.TextBox();
            this.tbSom = new System.Windows.Forms.TextBox();
            this.gbActie = new System.Windows.Forms.GroupBox();
            this.rbWortel = new System.Windows.Forms.RadioButton();
            this.rbKwadraat = new System.Windows.Forms.RadioButton();
            this.rbDelen = new System.Windows.Forms.RadioButton();
            this.rbVermenigvuldigen = new System.Windows.Forms.RadioButton();
            this.rbAftrekken = new System.Windows.Forms.RadioButton();
            this.rbOptellen = new System.Windows.Forms.RadioButton();
            this.btnBereken = new System.Windows.Forms.Button();
            this.gbReeksen = new System.Windows.Forms.GroupBox();
            this.rbFibonaccieReeks = new System.Windows.Forms.RadioButton();
            this.rbEvenGetallen = new System.Windows.Forms.RadioButton();
            this.tbReeks = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReeksen = new System.Windows.Forms.Button();
            this.btnClearReeksen = new System.Windows.Forms.Button();
            this.btnClearBerekenen = new System.Windows.Forms.Button();
            this.tbReeksenHoeveelheid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPriemGetallen = new System.Windows.Forms.RadioButton();
            this.gbActie.SuspendLayout();
            this.gbReeksen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(105, 54);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 0;
            this.lblGetal1.Text = "Getal 1";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(105, 80);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 1;
            this.lblGetal2.Text = "Getal 2";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(98, 106);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(48, 13);
            this.lblUitkomst.TabIndex = 2;
            this.lblUitkomst.Text = "Uitkomst";
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(115, 132);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(31, 13);
            this.lblSom.TabIndex = 3;
            this.lblSom.Text = "Som ";
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(166, 51);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 4;
            this.tbGetal1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(166, 77);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 5;
            this.tbGetal2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // tbUitkomst
            // 
            this.tbUitkomst.Location = new System.Drawing.Point(166, 103);
            this.tbUitkomst.Name = "tbUitkomst";
            this.tbUitkomst.ReadOnly = true;
            this.tbUitkomst.Size = new System.Drawing.Size(100, 20);
            this.tbUitkomst.TabIndex = 6;
            this.tbUitkomst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // tbSom
            // 
            this.tbSom.Location = new System.Drawing.Point(166, 129);
            this.tbSom.Name = "tbSom";
            this.tbSom.ReadOnly = true;
            this.tbSom.Size = new System.Drawing.Size(100, 20);
            this.tbSom.TabIndex = 7;
            this.tbSom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // gbActie
            // 
            this.gbActie.Controls.Add(this.rbWortel);
            this.gbActie.Controls.Add(this.rbKwadraat);
            this.gbActie.Controls.Add(this.rbDelen);
            this.gbActie.Controls.Add(this.rbVermenigvuldigen);
            this.gbActie.Controls.Add(this.rbAftrekken);
            this.gbActie.Controls.Add(this.rbOptellen);
            this.gbActie.Location = new System.Drawing.Point(308, 51);
            this.gbActie.Name = "gbActie";
            this.gbActie.Size = new System.Drawing.Size(142, 173);
            this.gbActie.TabIndex = 8;
            this.gbActie.TabStop = false;
            this.gbActie.Text = "Actie";
            // 
            // rbWortel
            // 
            this.rbWortel.AutoSize = true;
            this.rbWortel.Location = new System.Drawing.Point(18, 139);
            this.rbWortel.Name = "rbWortel";
            this.rbWortel.Size = new System.Drawing.Size(56, 17);
            this.rbWortel.TabIndex = 5;
            this.rbWortel.TabStop = true;
            this.rbWortel.Text = "Wortel";
            this.rbWortel.UseVisualStyleBackColor = true;
            this.rbWortel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // rbKwadraat
            // 
            this.rbKwadraat.AutoSize = true;
            this.rbKwadraat.Location = new System.Drawing.Point(18, 116);
            this.rbKwadraat.Name = "rbKwadraat";
            this.rbKwadraat.Size = new System.Drawing.Size(70, 17);
            this.rbKwadraat.TabIndex = 4;
            this.rbKwadraat.TabStop = true;
            this.rbKwadraat.Text = "Kwadraat";
            this.rbKwadraat.UseVisualStyleBackColor = true;
            this.rbKwadraat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // rbDelen
            // 
            this.rbDelen.AutoSize = true;
            this.rbDelen.Location = new System.Drawing.Point(18, 93);
            this.rbDelen.Name = "rbDelen";
            this.rbDelen.Size = new System.Drawing.Size(53, 17);
            this.rbDelen.TabIndex = 3;
            this.rbDelen.TabStop = true;
            this.rbDelen.Text = "Delen";
            this.rbDelen.UseVisualStyleBackColor = true;
            this.rbDelen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // rbVermenigvuldigen
            // 
            this.rbVermenigvuldigen.AutoSize = true;
            this.rbVermenigvuldigen.Location = new System.Drawing.Point(18, 70);
            this.rbVermenigvuldigen.Name = "rbVermenigvuldigen";
            this.rbVermenigvuldigen.Size = new System.Drawing.Size(109, 17);
            this.rbVermenigvuldigen.TabIndex = 2;
            this.rbVermenigvuldigen.TabStop = true;
            this.rbVermenigvuldigen.Text = "Vermenigvuldigen";
            this.rbVermenigvuldigen.UseVisualStyleBackColor = true;
            this.rbVermenigvuldigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // rbAftrekken
            // 
            this.rbAftrekken.AutoSize = true;
            this.rbAftrekken.Location = new System.Drawing.Point(18, 47);
            this.rbAftrekken.Name = "rbAftrekken";
            this.rbAftrekken.Size = new System.Drawing.Size(71, 17);
            this.rbAftrekken.TabIndex = 1;
            this.rbAftrekken.TabStop = true;
            this.rbAftrekken.Text = "Aftrekken";
            this.rbAftrekken.UseVisualStyleBackColor = true;
            this.rbAftrekken.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // rbOptellen
            // 
            this.rbOptellen.AutoSize = true;
            this.rbOptellen.Location = new System.Drawing.Point(18, 24);
            this.rbOptellen.Name = "rbOptellen";
            this.rbOptellen.Size = new System.Drawing.Size(64, 17);
            this.rbOptellen.TabIndex = 0;
            this.rbOptellen.TabStop = true;
            this.rbOptellen.Text = "Optellen";
            this.rbOptellen.UseVisualStyleBackColor = true;
            this.rbOptellen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // btnBereken
            // 
            this.btnBereken.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBereken.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBereken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBereken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBereken.Location = new System.Drawing.Point(166, 172);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 9;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = false;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            this.btnBereken.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBereken);
            // 
            // gbReeksen
            // 
            this.gbReeksen.Controls.Add(this.rbPriemGetallen);
            this.gbReeksen.Controls.Add(this.rbFibonaccieReeks);
            this.gbReeksen.Controls.Add(this.rbEvenGetallen);
            this.gbReeksen.Location = new System.Drawing.Point(101, 284);
            this.gbReeksen.Name = "gbReeksen";
            this.gbReeksen.Size = new System.Drawing.Size(200, 100);
            this.gbReeksen.TabIndex = 10;
            this.gbReeksen.TabStop = false;
            this.gbReeksen.Text = "Reeksen";
            // 
            // rbFibonaccieReeks
            // 
            this.rbFibonaccieReeks.AutoSize = true;
            this.rbFibonaccieReeks.Location = new System.Drawing.Point(7, 43);
            this.rbFibonaccieReeks.Name = "rbFibonaccieReeks";
            this.rbFibonaccieReeks.Size = new System.Drawing.Size(100, 17);
            this.rbFibonaccieReeks.TabIndex = 1;
            this.rbFibonaccieReeks.TabStop = true;
            this.rbFibonaccieReeks.Text = "Fibonacci reeks";
            this.rbFibonaccieReeks.UseVisualStyleBackColor = true;
            this.rbFibonaccieReeks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToonReeksen);
            // 
            // rbEvenGetallen
            // 
            this.rbEvenGetallen.AutoSize = true;
            this.rbEvenGetallen.Location = new System.Drawing.Point(7, 20);
            this.rbEvenGetallen.Name = "rbEvenGetallen";
            this.rbEvenGetallen.Size = new System.Drawing.Size(90, 17);
            this.rbEvenGetallen.TabIndex = 0;
            this.rbEvenGetallen.TabStop = true;
            this.rbEvenGetallen.Text = "Even getallen";
            this.rbEvenGetallen.UseVisualStyleBackColor = true;
            this.rbEvenGetallen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToonReeksen);
            // 
            // tbReeks
            // 
            this.tbReeks.Location = new System.Drawing.Point(308, 304);
            this.tbReeks.Multiline = true;
            this.tbReeks.Name = "tbReeks";
            this.tbReeks.ReadOnly = true;
            this.tbReeks.Size = new System.Drawing.Size(436, 109);
            this.tbReeks.TabIndex = 11;
            this.tbReeks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToonReeksen);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(669, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReeksen
            // 
            this.btnReeksen.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReeksen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReeksen.Location = new System.Drawing.Point(101, 390);
            this.btnReeksen.Name = "btnReeksen";
            this.btnReeksen.Size = new System.Drawing.Size(97, 23);
            this.btnReeksen.TabIndex = 13;
            this.btnReeksen.Text = "Toon";
            this.btnReeksen.UseVisualStyleBackColor = false;
            this.btnReeksen.Click += new System.EventHandler(this.btnReeksen_Click);
            this.btnReeksen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToonReeksen);
            // 
            // btnClearReeksen
            // 
            this.btnClearReeksen.BackColor = System.Drawing.Color.YellowGreen;
            this.btnClearReeksen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearReeksen.Location = new System.Drawing.Point(204, 390);
            this.btnClearReeksen.Name = "btnClearReeksen";
            this.btnClearReeksen.Size = new System.Drawing.Size(97, 23);
            this.btnClearReeksen.TabIndex = 14;
            this.btnClearReeksen.Text = "Wis";
            this.btnClearReeksen.UseVisualStyleBackColor = false;
            this.btnClearReeksen.Click += new System.EventHandler(this.btnClearReeksen_Click);
            this.btnClearReeksen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterReeksenWis);
            // 
            // btnClearBerekenen
            // 
            this.btnClearBerekenen.BackColor = System.Drawing.Color.YellowGreen;
            this.btnClearBerekenen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearBerekenen.Location = new System.Drawing.Point(166, 201);
            this.btnClearBerekenen.Name = "btnClearBerekenen";
            this.btnClearBerekenen.Size = new System.Drawing.Size(100, 23);
            this.btnClearBerekenen.TabIndex = 15;
            this.btnClearBerekenen.Text = "Wis";
            this.btnClearBerekenen.UseVisualStyleBackColor = false;
            this.btnClearBerekenen.Click += new System.EventHandler(this.btnClearBerekenen_Click);
            this.btnClearBerekenen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBerekenWis);
            // 
            // tbReeksenHoeveelheid
            // 
            this.tbReeksenHoeveelheid.Location = new System.Drawing.Point(308, 284);
            this.tbReeksenHoeveelheid.Name = "tbReeksenHoeveelheid";
            this.tbReeksenHoeveelheid.Size = new System.Drawing.Size(436, 20);
            this.tbReeksenHoeveelheid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hoe lang wilt u de reeksen hebben? ";
            // 
            // rbPriemGetallen
            // 
            this.rbPriemGetallen.AutoSize = true;
            this.rbPriemGetallen.Location = new System.Drawing.Point(7, 66);
            this.rbPriemGetallen.Name = "rbPriemGetallen";
            this.rbPriemGetallen.Size = new System.Drawing.Size(91, 17);
            this.rbPriemGetallen.TabIndex = 2;
            this.rbPriemGetallen.TabStop = true;
            this.rbPriemGetallen.Text = "Priem getallen";
            this.rbPriemGetallen.UseVisualStyleBackColor = true;
            this.rbPriemGetallen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToonReeksen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReeksenHoeveelheid);
            this.Controls.Add(this.btnClearBerekenen);
            this.Controls.Add(this.btnClearReeksen);
            this.Controls.Add(this.btnReeksen);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbReeks);
            this.Controls.Add(this.gbReeksen);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.gbActie);
            this.Controls.Add(this.tbSom);
            this.Controls.Add(this.tbUitkomst);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rekenmachine";
            this.gbActie.ResumeLayout(false);
            this.gbActie.PerformLayout();
            this.gbReeksen.ResumeLayout(false);
            this.gbReeksen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblUitkomst;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.TextBox tbUitkomst;
        private System.Windows.Forms.TextBox tbSom;
        private System.Windows.Forms.GroupBox gbActie;
        private System.Windows.Forms.RadioButton rbWortel;
        private System.Windows.Forms.RadioButton rbKwadraat;
        private System.Windows.Forms.RadioButton rbDelen;
        private System.Windows.Forms.RadioButton rbVermenigvuldigen;
        private System.Windows.Forms.RadioButton rbAftrekken;
        private System.Windows.Forms.RadioButton rbOptellen;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.GroupBox gbReeksen;
        private System.Windows.Forms.RadioButton rbFibonaccieReeks;
        private System.Windows.Forms.RadioButton rbEvenGetallen;
        private System.Windows.Forms.TextBox tbReeks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReeksen;
        private System.Windows.Forms.Button btnClearReeksen;
        private System.Windows.Forms.Button btnClearBerekenen;
        private System.Windows.Forms.TextBox tbReeksenHoeveelheid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPriemGetallen;
    }
}

