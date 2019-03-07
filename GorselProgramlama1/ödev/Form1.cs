using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{ //Berke Bartuğ Sevindik 2015280028 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxName.Text);
            listBox2.Items.Add(textBoxSurname.Text);    //kayıttan sonra isim soyisimi listede kaydettirdim.
           
            foreach (Control c in groupBox1.Controls)
            {
                if (c is RadioButton)                       //gruptaki radiolaru kontrol ettirip eğer checkliyse değerini listedeki textboxa yazdırdım.Cinsiyet iiçin
                    if (((RadioButton)c).Checked) listBox4.Items.Add(c.Text);
            }
         

            MessageBox.Show("Basarıyla Kayıt yapıldı!","İslem gerçeklestirildi", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
           
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();    //temizle buttonu için clear ve radiolar için temizledikten sonra temizlettim yeni kayıtta tekrar silmekle ugrasmamak için
            textBoxSurname.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
          
           
        }


        int sayi, toplam = 37,bos=0,dolu=0;

        private void Koltuk1_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;    //her check edildiğinde yolcu sayısını arttırırken toplam sayıdan bir azalttırdım
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();   //sonrada yazdırdım . Daha kısa yol bulamadığımdan her checkbox için tekrar yazdım

            textBoxBos.Text = toplam.ToString();
            Koltuk1.Enabled = false;      //check edildikten sonra temizlenmemesi yada iki defa kayıt olmasın diye check edildikten sonra seçmeyi kapattım
            Koltuk1.BackColor = Color.Orange;   //check edilince arka plana turuncu rengini verdim

        }

        private void Koltuk2_CheckStateChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk2.Enabled = false;
            Koltuk2.BackColor = Color.Orange;
        }

        private void Koltuk3_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk3.Enabled = false;
            Koltuk3.BackColor = Color.Orange;
        }

        private void Koltuk4_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk4.Enabled = false;
            Koltuk4.BackColor = Color.Orange;
        }

        private void Koltuk5_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk5.Enabled = false;
            Koltuk5.BackColor = Color.Orange;
        }

        private void Koltuk6_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk6.Enabled = false;
            Koltuk6.BackColor = Color.Orange;
        }

        private void Koltuk7_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk7.Enabled = false;
            Koltuk7.BackColor = Color.Orange;
        }

        private void Koltuk8_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk8.Enabled = false;
            Koltuk8.BackColor = Color.Orange;
        }

        private void Koltuk9_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk9.Enabled = false;
            Koltuk9.BackColor = Color.Orange;
        }

        private void Koltuk10_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk10.Enabled = false;
            Koltuk10.BackColor = Color.Orange;
        }

        private void Koltuk11_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk11.Enabled = false;
            Koltuk11.BackColor = Color.Orange;
        }

        private void Koltuk12_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk12.Enabled = false;
            Koltuk12.BackColor = Color.Orange;
        }

        private void Koltuk13_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk13.Enabled = false;
            Koltuk13.BackColor = Color.Orange;
        }

        private void Koltuk14_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk14.Enabled = false;
            Koltuk14.BackColor = Color.Orange;
            if (Koltuk14.Checked) bos += 1;         //işaretliğinde tek koltuk odugundan yanındakinin bos oldugunu belirtiyot
            YanıBos.Text = bos.ToString();
            if (Koltuk15.Checked && Koltuk14.Checked)   //yanındakiyle beraber seçildiyse boş sayısını azaltıp iki koltuk da dolu olduğundan 1 çift koltuk dolu yazıyr.
            {
                dolu += 1;                      //her koltuk için aynı işlemi yaptım. Kısa yol bulamadığımdan işi uzattım.
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }


        }

        private void Koltuk15_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk15.Enabled = false;
            Koltuk15.BackColor = Color.Orange;
            if (Koltuk15.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk15.Checked && Koltuk14.Checked)
            {
                dolu +=1;
                bos -=bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk16_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk16.Enabled = false;
            Koltuk16.BackColor = Color.Orange;
            if (Koltuk16.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk17.Checked && Koltuk16.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }

        }

        private void Koltuk17_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk17.Enabled = false;
            Koltuk17.BackColor = Color.Orange;
            if (Koltuk17.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk17.Checked && Koltuk16.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }


        private void Koltuk18_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk18.Enabled = false;
            Koltuk18.BackColor = Color.Orange;
            if (Koltuk18.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk18.Checked && Koltuk19.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk19_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk19.Enabled = false;
            Koltuk19.BackColor = Color.Orange;
            if (Koltuk19.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk19.Checked && Koltuk18.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk20_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk20.Enabled = false;
            Koltuk20.BackColor = Color.Orange;
            if (Koltuk20.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk20.Checked && Koltuk21.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk21_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk21.Enabled = false;
            Koltuk21.BackColor = Color.Orange;
            if (Koltuk21.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk21.Checked && Koltuk20.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk22_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk22.Enabled = false;
            Koltuk22.BackColor = Color.Orange;
            if (Koltuk22.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk22.Checked && Koltuk23.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk23_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk23.Enabled = false;
            Koltuk23.BackColor = Color.Orange;
            if (Koltuk23.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk23.Checked && Koltuk22.Checked)
            {
                dolu += 1;

                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk24_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk24.Enabled = false;
            Koltuk24.BackColor = Color.Orange;
            if (Koltuk24.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk24.Checked && Koltuk25.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

       

        private void Koltuk25_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk25.Enabled = false;
            Koltuk25.BackColor = Color.Orange;
            if (Koltuk25.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk25.Checked && Koltuk24.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk26_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk26.Enabled = false;
            Koltuk26.BackColor = Color.Orange;
            if (Koltuk26.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk26.Checked && Koltuk27.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk27_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk27.Enabled = false;
            Koltuk27.BackColor = Color.Orange;
            if (Koltuk27.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk27.Checked && Koltuk26.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk28_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk28.Enabled = false;
            Koltuk28.BackColor = Color.Orange;
            if (Koltuk28.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk28.Checked && Koltuk29.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk29_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk29.Enabled = false;
            Koltuk29.BackColor = Color.Orange;
            if (Koltuk29.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk29.Checked && Koltuk28.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk30_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk30.Enabled = false;
            Koltuk30.BackColor = Color.Orange;
            if (Koltuk30.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk30.Checked && Koltuk31.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk31_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk31.Enabled = false;
            Koltuk31.BackColor = Color.Orange;
            if (Koltuk31.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk31.Checked && Koltuk30.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk32_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk32.Enabled = false;
            Koltuk32.BackColor = Color.Orange;
            if (Koltuk32.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk32.Checked && Koltuk33.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk33_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk33.Enabled = false;
            Koltuk33.BackColor = Color.Orange;
            if (Koltuk33.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk33.Checked && Koltuk32.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk34_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk34.Enabled = false;
            Koltuk34.BackColor = Color.Orange;
            if (Koltuk34.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk34.Checked && Koltuk35.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk35_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk35.Enabled = false;
            Koltuk35.BackColor = Color.Orange;
            if (Koltuk35.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk35.Checked && Koltuk34.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk36_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk36.Enabled = false;
            Koltuk36.BackColor = Color.Orange;
            if (Koltuk36.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk36.Checked && Koltuk37.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }
        }

        private void Koltuk37_CheckedChanged(object sender, EventArgs e)
        {
            sayi += 1;
            toplam -= 1;

            textBoxYolcu.Text = sayi.ToString();

            textBoxBos.Text = toplam.ToString();
            Koltuk37.Enabled = false;
            Koltuk37.BackColor = Color.Orange;
            if (Koltuk37.Checked) bos += 1;
            YanıBos.Text = bos.ToString();
            if (Koltuk37.Checked && Koltuk36.Checked)
            {
                dolu += 1;
                bos -= bos;
                YanıBos.Text = bos.ToString();
                YanıDolu.Text = dolu.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxYolcu.Text = sayi.ToString(); //toplam koltuk sayısını ve her kayıtta artacak yolcu sayısını stringe dönüştürdüm.
             textBoxBos.Text = toplam.ToString();
            

        }


       
    }
}
