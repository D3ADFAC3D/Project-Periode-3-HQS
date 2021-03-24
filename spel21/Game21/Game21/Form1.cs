using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startup();

        }

        private void btnfoto1_Click(object sender, EventArgs e)
        {
            Image Foto1 = default;
            Fotop1(Foto1);            
        }
        public void Startup() // deze methode word opgeroepen wanneer het programma word op gestart en zet alle buttons op inactief
        {
            btnOpniew.Enabled = false;
            btnopslaan1.Enabled = false;
            btnopslaan2.Enabled = false;
            btnSpeel.Enabled = false;
            btnStart.Enabled = false;
        }

        public void Fotop1(Image Foto1) // Deze Methode pakt de foto van speler1 
        {
            OpenFileDialog iFoto1 = new OpenFileDialog();
            iFoto1.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (iFoto1.ShowDialog() == DialogResult.OK)
            {
                Foto1 = Image.FromFile(iFoto1.FileName);
                picSpeler.Image = Foto1;
                picSpeler.SizeMode = PictureBoxSizeMode.StretchImage;
                btnopslaan1.Enabled = true;
            }
            
        }


    }
}
