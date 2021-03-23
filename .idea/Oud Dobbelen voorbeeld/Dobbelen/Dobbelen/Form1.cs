using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelen
{
    public partial class Form1 : Form
    { 
        #region Global Variable
        double hans;
        //global variable
        private string path;

        //Array met 6 indexnummers
        private int[] getallen = new int[6];

        //Randomizer
        private Random objRandom = new Random();
        #endregion

        public Form1()
        {
            InitializeComponent();
            GetPath();
            Start();
        }

        private void pbDice1_Click(object sender, EventArgs e)
        {
            PullRandomNumbers();
            ShowDices();
            tbSom.Text = SumCalculate().ToString();
            tbAverage.Text = AvgCalculate().ToString();
            tbRange.Text = RangeCalculate().ToString();
        }
        #region Methods
        private void GetPath()
        {
            path = Application.StartupPath;
            path = path.Substring(0, path.Length - 9);
            path += "Images\\dice_";
        }

        /// <summary>
        /// hier laat de ik de afbeeldingen zien die van 1 naar 6 gaan
        /// </summary>
        private void Start()
        {
            pbDice1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice6.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pbDice1.Image = Image.FromFile(path + "1.jpg");
            pbDice2.Image = Image.FromFile(path + "2.jpg");
            pbDice3.Image = Image.FromFile(path + "3.jpg");
            pbDice4.Image = Image.FromFile(path + "4.jpg");
            pbDice5.Image = Image.FromFile(path + "5.jpg");
            pbDice6.Image = Image.FromFile(path + "6.jpg");

        }

        /// <summary>
        /// hier maak ik willekeurige getallen
        /// </summary>
        public void PullRandomNumbers()
        {
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = objRandom.Next(1, 7); //Trekt getallen van 1 tot en met 6
           
            }
          
        }

        private double AvgCalculate()
        {
            double gemiddeld = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                gemiddeld += getallen[i];
            }
            gemiddeld = gemiddeld / getallen.Length;
            return gemiddeld;
        }

        private int SumCalculate()
        {
            int som = 0;

            for (int i=0; i< getallen.Length; i++)
            {
                som += getallen[i];
            }
            return som;

        }

        private double RangeCalculate()
        {
            int min = getallen.Min();
            int max = getallen.Max();

            double gemiddeld = max - min;
            return (int) gemiddeld;
        }
        /// <summary>
        ///  laat de images zien in de velden liggende aan de array index
        /// </summary>
        private void ShowDices()
        {
            pbDice1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice6.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pbDice1.Image = Image.FromFile(path + getallen[0] + ".jpg");
            pbDice2.Image = Image.FromFile(path + getallen[1] + ".jpg");
            pbDice3.Image = Image.FromFile(path + getallen[2] + ".jpg");
            pbDice4.Image = Image.FromFile(path + getallen[3] + ".jpg");
            pbDice5.Image = Image.FromFile(path + getallen[4] + ".jpg");
            pbDice6.Image = Image.FromFile(path + getallen[5] + ".jpg");

        }

        #endregion
    }
}