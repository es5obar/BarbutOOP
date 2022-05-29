using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbutOOP
{
    public partial class Form1 : Form
    {
        Zar zar = new Zar();

        string path = Application.StartupPath.Replace(@"bin\Debug", "Files");
        //C:\Users\okan.sabitogullari\source\repos\BarbutOOP\BarbutOOP\bin\Debug
        //C:\Users\okan.sabitogullari\source\repos\BarbutOOP\BarbutOOP\Files
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1.Basla
            // 2.Kullanıcı zar atmaya tıklar
            // 3. iki zar atılır
            // 4. eğer 1. zar 2. zardan büyükse
            // 5. 1.zarın kazandığı bilgisi listeye eklenir
            // 6. eğer 2.zar 1. zardan büyükse
            // 7. 2.zarın kazandığı bilgisi listeye eklenir.
            // 8. eğer 1.zar 2.zara eşitse
            // 9. 3.maddeye git
            // 10. bitir

            lZar1.Text = "";
            lZar2.Text = "";
        }

        private void bZarAt_Click(object sender, EventArgs e)
        {
            Oyna();
        }

        private void Oyna()
        {
            lZar1.Text =zar.ZarAt();
            int sayi1 = zar.Sayi;
            lZar2.Text =zar.ZarAt();
            int sayi2 = zar.Sayi;
            //lZar1.Text = sayi1.ToString();
            //lZar2.Text = sayi2.ToString();
            pbZar1.ImageLocation = path + "\\" + sayi1 + ".png";
            pbZar2.ImageLocation = path + "\\" + sayi2 + ".png";
            if (sayi1 > sayi2)
            {
                lbSonuc.Items.Add("1.zar kazandı.");
            }
            else if (sayi2 > sayi1)
            {
                lbSonuc.Items.Add("2.zar kazandı.");
            }
            else
            {
                //lbSonuc.Items.Add("Berabere");
                Oyna();
            }
        }
    }
}
