using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simpele_rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //tellen hoevaak een reeks zich getoont heeft.
        int tellerEven = 0;
        int tellerFibonacci = 0;
        int tellerPriem = 0;

        // Methodes voor het verwerken van opdrachten d.m.v. de Enter toets.
        private void EnterBereken(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                btnBereken_Click(sender, e);
            }
        }
        private void ToonReeksen(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                btnReeksen_Click(sender, e);
            }
        }
        private void EnterBerekenWis(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                btnClearBerekenen_Click(sender, e);
            }
        }
        private void EnterReeksenWis(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                btnClearReeksen_Click(sender, e);
            }
        }
        private void btnBereken_Click(object sender, EventArgs e)
        {
            // doubles aanmaken
            double getal1;
            double getal2;
            // zorgen dat ook "." tekens (punten) als komma's worden gelezen bij het invoeren.
            string stringGetal1 = tbGetal1.Text.Replace(".", ",");
            string stringGetal2 = tbGetal2.Text.Replace(".", ",");
            // als een getal met een "." begint, laat dan "0," zien.
            if (tbGetal1.Text.StartsWith("."))
            {
                stringGetal1 = tbGetal1.Text.Replace(".", "0,");
            }
            if (tbGetal2.Text.StartsWith("."))
            {
                stringGetal2 = tbGetal2.Text.Replace(".", "0,");
            }
            //als er een geen getal(len) in de box(en) staat, laat een foutmelding zien.
            if (string.IsNullOrWhiteSpace(tbGetal1.Text) && string.IsNullOrWhiteSpace(tbGetal2.Text))
            {
                tbUitkomst.Clear();
                tbSom.Clear();
                MessageBox.Show("Voer Getal 1 en/of Getal 2 in", "Foutmelding");
            }
            else if (string.IsNullOrWhiteSpace(tbGetal1.Text) && rbOptellen.Checked || string.IsNullOrWhiteSpace(tbGetal1.Text) && rbAftrekken.Checked)
            {
                tbUitkomst.Clear();
                tbSom.Clear();
                MessageBox.Show("Getal 1: vul een cijfer in", "Foutmelding");
            }
            else if (string.IsNullOrWhiteSpace(tbGetal2.Text) && rbOptellen.Checked || string.IsNullOrWhiteSpace(tbGetal2.Text) && rbAftrekken.Checked)
            {
                tbUitkomst.Clear();
                tbSom.Clear();
                MessageBox.Show("Getal 2: vul een cijfer in", "Foutmelding");
            }

            // Waneer beide boxen zijn ingevuld voor een volgende opdracht uit afhankelijk van de gekozen actie.
            if (double.TryParse(stringGetal1, out getal1) && (double.TryParse(stringGetal2, out getal2)))
            {
                //Foutmelding wanneer er geen actie is gekozen, maar wel cijfer zijn ingevuld.
                if (rbOptellen.Checked == false && rbAftrekken.Checked == false && rbVermenigvuldigen.Checked == false && rbDelen.Checked == false && rbKwadraat.Checked == false && rbWortel.Checked == false)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Kies een actie");
                }
                //Optellen
                if (rbOptellen.Checked)
                {
                    double getalUitkomst = Math.Round(Convert.ToDouble(stringGetal1) + Convert.ToDouble(stringGetal2),3);
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = stringGetal1 + " + " + stringGetal2 + " = " + getalUitkomst.ToString();
                }
                //Aftrekken 
                if (rbAftrekken.Checked)
                {
                    double getalUitkomst = Math.Round(Convert.ToDouble(stringGetal1) - Convert.ToDouble(stringGetal2),3);
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = stringGetal1 + " - " + stringGetal2 + " = " + getalUitkomst.ToString();
                }
                //Vermenigvuldigen
                if (rbVermenigvuldigen.Checked)
                {
                    double getalUitkomst = Math.Round(Convert.ToDouble(stringGetal1) * Convert.ToDouble(stringGetal2),3);
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = stringGetal1 + " x " + stringGetal2 + " = " + getalUitkomst.ToString();
                }
                //Delen
                if (rbDelen.Checked)
                {
                    double getalUitkomst = Math.Round(Convert.ToDouble(stringGetal1) / Convert.ToDouble(stringGetal2),3);
                    //waneer getal 1 of getal 2 de waarde 0 heeft, clear de textboxen en laat foutmelding zien.
                    if (getal1 == 0 || getal2 == 0)
                    {
                        tbUitkomst.Clear();
                        tbSom.Clear();
                        MessageBox.Show("Delen door 0 is niet mogelijk, probeer opnieuw", "Foutmelding");
                    }
                    else
                    {
                        tbUitkomst.Text = getalUitkomst.ToString();
                        tbSom.Text = stringGetal1 + " / " + stringGetal2 + " = " + getalUitkomst.ToString();
                    }
                }
                //Kwadraat
                if (rbKwadraat.Checked)
                {
                    double getalUitkomst = Math.Round((Convert.ToDouble(stringGetal1) * Convert.ToDouble(stringGetal1)) + (Convert.ToDouble(stringGetal2) * Convert.ToDouble(stringGetal2)),3);
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = stringGetal1 + "² + " + stringGetal2 + "² = " + getalUitkomst.ToString();
                }
                //Wortel
                if (rbWortel.Checked)
                {
                    if(getal1 < 0 || getal2 < 0)
                    {
                        tbUitkomst.Clear();
                        tbSom.Clear();
                        MessageBox.Show("Ongeschikte waarde voor Worteldeling, probeer opnieuw", "Foutmelding");
                    }
                    else
                    {
                        double getalUitkomst = Math.Round(Math.Sqrt(Convert.ToDouble(stringGetal1)) - Math.Sqrt(Convert.ToDouble(stringGetal2)),3);
                        tbUitkomst.Text = getalUitkomst.ToString();
                        tbSom.Text = "√" + stringGetal1 + " - √" + stringGetal2 + " = " + getalUitkomst.ToString();
                    }
                    
                }
            }
            else if (double.TryParse(stringGetal1, out getal1))
            {   
                //Foutmelding wanneer er geen actie is gekozen, maar wel een cijfer is ingevuld.
                if(rbOptellen.Checked == false && rbAftrekken.Checked == false && rbVermenigvuldigen.Checked == false && rbDelen.Checked == false && rbKwadraat.Checked == false && rbWortel.Checked == false)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Kies een actie");
                }
                //Vermenigvuldigen
                if (rbVermenigvuldigen.Checked)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Getal 2: vul een cijfer in", "Foutmelding");
                }
                //Delen
                if (rbDelen.Checked && getal1 == 0)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Delen door 0 is niet mogelijk, probeer opnieuw", "Foutmelding");
                }
                else if (rbDelen.Checked && getal1 != 0)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Getal 2: vul een cijfer in", "Foutmelding");
                }
                //Kwadraat
                if (rbKwadraat.Checked)
                {
                    double getalUitkomst = Math.Round(Convert.ToDouble(stringGetal1) * Convert.ToDouble(stringGetal1),3);
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = stringGetal1 + "²";
                }
                //Wortel
                if (rbWortel.Checked)
                {
                    if (getal1 < 0)
                    {
                        tbUitkomst.Clear();
                        tbSom.Clear();
                        MessageBox.Show("Ongeschikte waarde voor Worteldeling, probeer opnieuw", "Foutmelding");
                    }
                    else
                    {
                        double getalUitkomst = Math.Round(Math.Sqrt(Convert.ToDouble(stringGetal1)),3);
                        tbUitkomst.Text = getalUitkomst.ToString();
                        tbSom.Text = "√" + stringGetal1;
                    }
                }
            }
            else if (double.TryParse(stringGetal2, out getal2))
            {
                //Foutmelding wanneer er geen actie is gekozen, maar wel een cijfer is ingevuld.
                if (rbOptellen.Checked == false && rbAftrekken.Checked == false && rbVermenigvuldigen.Checked == false && rbDelen.Checked == false && rbKwadraat.Checked == false && rbWortel.Checked == false)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Kies een actie");
                }
                //Vermenigvuldigen
                if (rbVermenigvuldigen.Checked)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Getal 1: vul een cijfer in", "Foutmelding");
                }
                //Delen
                if (rbDelen.Checked && getal2 == 0)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Delen door 0 is niet mogelijk, probeer opnieuw", "Foutmelding");
                }
                else if (rbDelen.Checked && getal2 != 0)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Getal 1: vul een cijfer in", "Foutmelding");
                }
                //Kwadraat
                if (rbKwadraat.Checked)
                {
                    double getalUitkomst = Math.Round((Convert.ToDouble(stringGetal2)),3) * Math.Round((Convert.ToDouble(stringGetal2)),3);
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = stringGetal2 + "²";
                }
                //Wortel
                if (rbWortel.Checked)
                {
                    if (getal2 < 0)
                    {
                        tbUitkomst.Clear();
                        tbSom.Clear();
                        MessageBox.Show("Ongeschikte waarde voor Worteldeling, probeer opnieuw", "Foutmelding");
                    }
                    else
                    {
                        double getalUitkomst = Math.Round(Math.Sqrt(Convert.ToDouble(stringGetal2)),3);
                        tbUitkomst.Text = getalUitkomst.ToString();
                        tbSom.Text = "√" + stringGetal2;
                    }
                }
            }
            else
            { }
        }

        private void btnReeksen_Click(object sender, EventArgs e)
        {
            int reeksenHoeveelheid;
            if(int.TryParse(tbReeksenHoeveelheid.Text, out reeksenHoeveelheid))
            {
                int reeks = Convert.ToInt32(tbReeksenHoeveelheid.Text);
                int terwijl = 0;
                int priemnummer = 0;
                //Foutmelding wanneer er geen actie is gekozen, maar wel op Toon is geklikt.
                if (rbFibonaccieReeks.Checked == false && rbEvenGetallen.Checked == false && rbPriemGetallen.Checked == false)
                {
                    tbUitkomst.Clear();
                    tbSom.Clear();
                    MessageBox.Show("Kies een reeks");
                }
                //Fibonacci
                if (rbFibonaccieReeks.Checked)
                {
                    int eerste = 1, tweede = 1, som = eerste + tweede;
                    reeks = Convert.ToInt32(tbReeksenHoeveelheid.Text) - 1;
                    string fibonacci = "1 1";
                    //als reeks gelijk is aan -1 of 0 dan komt er een foutmelding
                    if (reeks == -1)
                    {
                        tbReeks.Clear();
                        MessageBox.Show("er moet een minimale waarde van 2 worden weergegeven, foutmelding");
                    }
                    else if (reeks == 0)
                    {
                        tbReeks.Clear();
                        MessageBox.Show("er moet een minimale waarde van 2 worden weergegeven, foutmelding");
                    }
                    else
                    {
                        for (int i = 1; i < reeks; i++)
                        {
                            //constant de som + het vorige getal
                            fibonacci += " " + som;
                            eerste = tweede;
                            tweede = som;
                            som = eerste + tweede;
                        }

                        //Check of textbox Reeks leeg is
                        if (string.IsNullOrWhiteSpace(tbReeks.Text))
                        {
                            tbReeks.Text = "Fibonacci: " + fibonacci;
                            tellerFibonacci++;
                        }
                        //Foutmelding als je een reeks meer dan 1 keer in de textbox wil zetten
                        else if (tellerFibonacci >= 1)
                        {
                            MessageBox.Show("Fibonacci getallenreeks is al weergegeven, kies een andere reeks", "Foutmelding");
                        }
                        else
                        {
                            tbReeks.Text = tbReeks.Text + "\r\n" + "\r\n" + "Fibonacci: " + fibonacci;
                            tellerFibonacci++;
                        }
                    }
                }
                //Even getallen
                if (rbEvenGetallen.Checked)
                {
                    int evenGetallen = 0;
                    string even = "";
                    reeks = Convert.ToInt32(tbReeksenHoeveelheid.Text);
                    //als reeks gelijk is aan 0 of 1 dan komt er een foutmelding 
                    if (reeks == 0)
                    {
                        tbReeks.Clear();
                        MessageBox.Show("er moet een minimale waarde van 2 worden weergegeven, foutmelding");
                    }
                    else if (reeks == 1)
                    {
                        tbReeks.Clear();
                        MessageBox.Show("er moet een minimale waarde van 2 worden weergegeven, foutmelding");
                    }
                    else
                    {
                        //de for lus telt verder tot de reeks bereikt is 
                        for (int o = 0; o < reeks; o++)
                        {
                            evenGetallen++;
                            evenGetallen++;

                            even += " " + evenGetallen;
                        }
                        //Check of textbox Reeks leeg is
                        if (string.IsNullOrWhiteSpace(tbReeks.Text))
                        {
                            tbReeks.Text = "Even: " + even;
                            tellerEven++;
                        }
                        //Foutmelding als je een reeks meer dan 1 keer in de textbox wil zetten
                        else if (tellerEven >= 1)
                        {
                            MessageBox.Show("Even getallenreeks is al weergegeven, kies een andere reeks", "Foutmelding");
                        }
                        //Als er al andere reeksen in de textbox staan, zet deze eronder
                        else
                        {
                            tbReeks.Text = tbReeks.Text + "\r\n" + "\r\n" + "Even: " + even;
                            tellerEven++;
                        }
                    }
                }
                //Priem getallen
                if (rbPriemGetallen.Checked)
                {
                    string priem = "";
                    //als reeks gelijk is aan 0 of 1 dan komt er een foutmelding
                    if (reeks == 0)
                    {
                        tbReeks.Clear();
                        MessageBox.Show("er moet een minimale waarde van 2 worden weergegeven, foutmelding");
                    }
                    else if (reeks == 1)
                    {
                        tbReeks.Clear();
                        MessageBox.Show("er moet een minimale waarde van 2 worden weergegeven, foutmelding");
                    }
                    else
                    {
                        //als terwijl niet gelijk is aan reeks moet hij de if else uitvoeren
                        while (terwijl != reeks)
                        {
                            //wanneer priemnummer waar s gaat er 1 bij terwijl is het niet wwar controleert hij het volgende nummer
                            if (CheckNumberPrimeNumber(priemnummer) == true)
                            {
                                priem += " " + priemnummer;
                                priemnummer++;
                                terwijl++;
                            }
                            else
                            {
                                priemnummer++;
                            }
                        }

                        //Check of textbox Reeks leeg is
                        if (string.IsNullOrWhiteSpace(tbReeks.Text))
                        {
                            tbReeks.Text = "Priem: " + priem;
                            tellerPriem++;
                        }
                        //Foutmelding als je een reeks meer dan 1 keer in de textbox wil zetten
                        else if (tellerPriem >= 1)
                        {
                            MessageBox.Show("Priem getallenreeks is al weergegeven, kies een andere reeks", "Foutmelding");
                        }
                        //Als er al andere reeksen in de textbox staan, zet deze eronder
                        else
                        {
                            tbReeks.Text = tbReeks.Text + "\r\n" + "\r\n" + "Priem: " + priem;
                            tellerPriem++;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vul eerst een getal in bij reeksen", "Foutmelding");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit knop
            this.Close();
        }
        public static bool CheckNumberPrimeNumber(int num)
        {
        //bij priem wordt hier een opdracht naar gestuurd en weer terug
            bool CheckPrimeNumber = true;
            int factor = num / 2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                //Constante check of het getal deelbaar is door 2 
                if ((num % i) == 0) CheckPrimeNumber = false;
            }
            return CheckPrimeNumber;
        }

        private void btnClearBerekenen_Click(object sender, EventArgs e)
        {
            //Wisknoppen Acties
            tbGetal1.Clear();
            tbGetal2.Clear();
            tbSom.Clear();
            tbUitkomst.Clear();
        }

        private void btnClearReeksen_Click(object sender, EventArgs e)
        {
            //Wisknoppen Reeksen
            tbReeks.Clear();
            tellerEven = 0;
            tellerFibonacci = 0;
            tellerPriem = 0;

        }
    }
}