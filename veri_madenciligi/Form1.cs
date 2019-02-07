using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_madenciligi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double [] veri;
        public static double[] eski_kume;
        public static double[] yeni_kume;


        public static int[] yeni_ort;
        public static liste[] l ;

        public static int e_ort;
        public static int y_ort;

        public static int kume_Sayisi;



        private void btn_hesap_Click(object sender, EventArgs e)
        {
            Random rast = new Random();

            kume_Sayisi = Convert.ToInt32(txt_veri_sayisi.Text);
            double[] veriatama = new double[kume_Sayisi];

            veri = veriatama;

            for (int i = 0; i < Convert.ToInt32(txt_veri_sayisi.Text); i++)
            {
                veri[i] =  rast.Next(1, 50) ;
                lb_veri_kumesi.Items.Add(veri[i].ToString());
            }

            kume_Sayisi=Convert.ToInt32(tb_kume_sayisi.Text);

            /*farklı dizi de uretip atama yapılacak*/

            double[] kumeatama = new double[kume_Sayisi];

            eski_kume = kumeatama;

            double[] kumeatama2 = new double[kume_Sayisi];

            yeni_kume = kumeatama2;

            for (int i = 0; i < kume_Sayisi; i++)
            {
                eski_kume[i] = rast.Next(1, 50);
                lb_kumeler.Items.Add(eski_kume[i].ToString());

                
                ListBox listbox = new ListBox();
                listbox.Name = "lb_"+i.ToString();
                Point lblyer = new Point((300+(i*3*50)), 15);
                listbox.Location = lblyer;
                Size size = new Size(120, 95);
                listbox.Size = size;
                this.Controls.Add(listbox);

                yeni_kume[i] = eski_kume[i];
            }

                 k_means(eski_kume);
        }

        public void k_means(double[] eski_kume)
        {
            for (int i = 0; i < eski_kume.Length; i++)
            {
                ((ListBox)this.Controls["lb_" + i.ToString()]).Items.Clear();

            }
            MessageBox.Show("");

            for (int i = 0; i < veri.Length; i++)
            {
                double min = 50;
                int index = 0;


                for (int j = 0; j < eski_kume.Length; j++)
                {
                    if (Math.Abs(veri[i] - eski_kume[j]) <= min)
                    {
                        min = Math.Abs(eski_kume[j] - veri[i]);
                        index = j;
                    }
                }

                ((ListBox)this.Controls["lb_" + index.ToString()]).Items.Add(veri[i].ToString());
            }
            //MessageBox.Show("");
            lb_kumeler.Items.Clear();
            for (int i = 0; i < eski_kume.Length; i++)
            {
                double ort = 0;

                if (((ListBox)this.Controls["lb_" + i.ToString()]).Items.Count == 0)
                {
                    lb_kumeler.Items.Add(0);
                }
                else
                {
                    for (int j = 0; j < ((ListBox)this.Controls["lb_" + i.ToString()]).Items.Count; j++)
                    {
                        ((ListBox)this.Controls["lb_" + i.ToString()]).SelectedIndex = j;
                        ort = ort + Convert.ToDouble(((ListBox)this.Controls["lb_" + i.ToString()]).SelectedItem.ToString());
                    }
                    lb_kumeler.Items.Add(Math.Round((ort / ((ListBox)this.Controls["lb_" + i.ToString()]).Items.Count), 1));
                }        
                
            }
            //MessageBox.Show("");

            for (int i = 0; i < eski_kume.Length; i++)
            {
                yeni_kume[i] = eski_kume[i];
            }
            double[] deneme = new double[eski_kume.Length];
            eski_kume = deneme;

            for (int i = 0; i < lb_kumeler.Items.Count; i++)
            {
                lb_kumeler.SelectedIndex = i;
                eski_kume[i] = Convert.ToDouble(lb_kumeler.SelectedItem);
            }


           if (esitmi(eski_kume,yeni_kume))
           {
               cıkıs();
           }
           else
           {
               k_means(eski_kume);
           }
 }

        public bool esitmi(double[] eski_kume, double[] yeni_kume)
        {
            int x = 1;
            for (int i = 0; i < eski_kume.Length; i++)
            {
                if (eski_kume[i] != yeni_kume[i])
                {
                    x = 0;
                }

            }
            if (x == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cıkıs()
        {
            MessageBox.Show("bitti");
        }
    }
}
