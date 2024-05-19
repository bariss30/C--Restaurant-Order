using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Bariss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        String[] masa1Siparis = new String[99];
        String[] masa2Siparis = new String[99];
        String[] masa3Siparis = new String[99];
        int toplam = 0;
        int masa1Toplam = 0;
        int masa2Toplam = 0;
        int masa3Toplam = 0;
        int krediKartý = 0;
        int nakit = 0;
        int masaSayac1 = 0;
        int masaSayac2 = 0;
        int masaSayac3 = 0;
        int hamburger,makarna,su,cay,pizza,turk,mesrubat,ayran;
       
        
















        private void button2_Click(object sender, EventArgs e)
        {
            String siparis;
            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);

            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Hamburger";

                richTextBox1.AppendText("Masa 1   ------>   HAMBURGER   |  " + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Hamburger";

                richTextBox1.AppendText("Masa 2   ------>   HAMBURGER   |   " + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }

            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Hamburger";

                richTextBox1.AppendText("Masa 3   ------>   HAMBURGER   |   " + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }

            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }















        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 0)
            {
                panel1.BackColor = Color.FromArgb(69, 74, 82);
                panel2.BackColor = Color.FromArgb(69, 74, 82);
                timer2.Stop();
                timer1.Start();


            }

            else
            {
                panel1.BackColor = Color.FromArgb(255, 102, 0);
                panel2.BackColor = Color.FromArgb(255, 102, 0);
                timer1.Stop();
                timer2.Start();


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 10;

            if (panel1.Width == 250)
            {
                timer1.Stop();

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Width -= 10;

            if (panel1.Width == 0)
            {
                timer2.Stop();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 0;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            groupBox14.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox3.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String siparis;



            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);


            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Pizza";

                richTextBox1.AppendText("Masa 1   ------>  PÝZZA   |   " + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Pizza";

                richTextBox1.AppendText("Masa 2   ------>  PÝZZA   |   " + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }





            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Pizza";

                richTextBox1.AppendText("Masa 3   ------>   PÝZZA   |    " + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }






            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            String siparis;



            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);


            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Makarna";

                richTextBox1.AppendText("Masa 1   ------>  MAKARNA   |   " + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Makarna";

                richTextBox1.AppendText("Masa 2   ------>   MAKARNA   |   " + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }





            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Makarna";

                richTextBox1.AppendText("Masa 3   ------>   MAKARNA   |   " + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }






            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            
            groupBox7.Visible = false;
            groupBox14.Visible = false;
            groupBox3.Visible = false;
            groupBox8.Visible = false;
            groupBox5.Visible = true;
            label19.Text = "0";

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(hamburger);
            textBox5.Text = Convert.ToString(pizza);
            textBox6.Text = Convert.ToString(makarna);
            textBox7.Text = Convert.ToString(su);
            textBox8.Text = Convert.ToString(turk);
            textBox9.Text = Convert.ToString(ayran);
            textBox10.Text = Convert.ToString(cay);
            textBox11.Text = Convert.ToString(mesrubat);
           
            textBox3.Text = Convert.ToString(toplam);
            groupBox7.Visible = false;
            groupBox3.Visible = false;
            groupBox8.Visible = false;
            groupBox5.Visible = false;
            groupBox14.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {


            String MasaNumara;



            MasaNumara = Interaction.InputBox("Lütfen Hangi Masanýn Hesabýný Görmek Ýstiyorsanýz Numarasýný Yazýný", "Hesap", "1", 500, 500);
            Convert.ToInt32(MasaNumara);

            if (MasaNumara == "1" && label19.Text=="0")
            {

                int pizzaSayac = 0;
                int makarnaSayac = 0;
                int hamburgerSayac = 0;
                int ayranSayac = 0;
                int turkSayac = 0;
                int sogukSayac = 0;
                int caySayac = 0;
                int suSayac = 0;

                foreach (String i in masa1Siparis)
                {

                    if (i == "Hamburger")
                    {
                        masa1Toplam = masa1Toplam + 25;
                        hamburgerSayac++;
                        hamburger = hamburger + hamburgerSayac;
                    }

                    else if (i == "Pizza")
                    {
                        masa1Toplam = masa1Toplam + 50;
                        pizzaSayac++;
                        pizza = pizza + pizzaSayac;

                    }

                    else if (i == "Makarna")
                    {
                        masa1Toplam = masa1Toplam + 30;
                        makarnaSayac++;
                        makarna = makarna + makarnaSayac;


                    }
                    else if (i == "Cay")
                    {
                        masa1Toplam = masa1Toplam + 10;
                        caySayac++;
                        cay=cay+caySayac;

                    }


                    else if (i == "Ayran")
                    {
                        masa1Toplam = masa1Toplam + 10;
                        ayranSayac++;
                        ayran = ayran + ayranSayac;

                    }





                    else if (i == "Soguk")
                    {
                        masa1Toplam = masa1Toplam + 25;
                        sogukSayac++;
                        mesrubat = mesrubat + sogukSayac;

                    }


                    else if (i == "Turk")
                    {
                        masa1Toplam = masa1Toplam + 30;
                        turkSayac++;
                        turk= turk+turkSayac;

                    }




                    else if (i == "Su")
                    {
                        masa1Toplam = masa1Toplam + 10;
                        suSayac++;
                        su=suSayac + su;

                    }























                }
















                richTextBox2.AppendText("HAMBURGER " + " " + "X" + hamburgerSayac + " = " + hamburgerSayac * 25 + Environment.NewLine);

                richTextBox2.AppendText("PÝZZA " + " " + "X" + pizzaSayac + " = " + pizzaSayac * 50 + Environment.NewLine);

                richTextBox2.AppendText("MAKARNA " + " " + "X" + makarnaSayac + " = " + makarnaSayac * 30 + Environment.NewLine);

                richTextBox2.AppendText("AYRAN " + " " + "X" + ayranSayac + " = " + ayranSayac * 15 + Environment.NewLine);



                richTextBox2.AppendText("ÇAY " + " " + "X" + caySayac + " = " + caySayac * 10 + Environment.NewLine);


                richTextBox2.AppendText("SOÐUK MESRUBAT " + " " + "X" + sogukSayac + " = " + sogukSayac * 25 + Environment.NewLine);
                richTextBox2.AppendText("TÜRK KAHVESÝ " + " " + "X" + turkSayac + " = " + turkSayac * 30 + Environment.NewLine);
                richTextBox2.AppendText("SU " + " " + "X" + suSayac + " = " + suSayac * 10 + Environment.NewLine);








                label8.Text = "Toplam Tutar = ";
                label19.Text = Convert.ToString(masa1Toplam);
                toplam = toplam + masa1Toplam;

            }



            else if (MasaNumara == "2" && label19.Text=="0")
            {

                int pizzaSayac = 0;
                int makarnaSayac = 0;
                int hamburgerSayac = 0;
                

                int ayranSayac = 0;
                int turkSayac = 0;
                int sogukSayac = 0;
                int caySayac = 0;
                int suSayac = 0;
                foreach (String i in masa2Siparis)
                {

                    if (i == "Hamburger")
                    {
                        masa2Toplam = masa2Toplam + 25;
                        hamburgerSayac++;
                        hamburger = hamburger + hamburgerSayac;

                    }

                    else if (i == "Pizza")
                    {
                        masa2Toplam = masa2Toplam + 50;
                        pizzaSayac++;
                        pizza = pizza + pizzaSayac;


                    }

                    else if (i == "Makarna")
                    {
                        masa2Toplam = masa2Toplam + 30;
                        makarnaSayac++;
                        makarna = makarna + makarnaSayac;

                    }
                    else if (i == "Cay")
                    {
                        masa2Toplam = masa2Toplam + 10;
                        caySayac++;
                        cay=caySayac + cay;

                    }


                    else if (i == "Ayran")
                    {
                        masa2Toplam = masa2Toplam + 10;
                        ayranSayac++;
                        ayran = ayran + ayranSayac;

                    }





                    else if (i == "Soguk")
                    {
                        masa2Toplam = masa2Toplam + 25;
                        sogukSayac++;
                        mesrubat = mesrubat + sogukSayac;

                    }


                    else if (i == "Turk")
                    {
                        masa2Toplam = masa2Toplam + 30;
                        turkSayac++;
                        turk=turk+ turkSayac;

                    }




                    else if (i == "Su")
                    {
                        masa2Toplam = masa2Toplam + 10;
                        suSayac++;
                        su = su + suSayac;

                    }





                }
















                richTextBox2.AppendText("HAMBURGER " + " " + "X" + hamburgerSayac + " = " + hamburgerSayac * 25 + Environment.NewLine);

                richTextBox2.AppendText("PÝZZA " + " " + "X" + pizzaSayac + " = " + pizzaSayac * 50 + Environment.NewLine);

                richTextBox2.AppendText("MAKARNA " + " " + "X" + makarnaSayac + " = " + makarnaSayac * 30 + Environment.NewLine);
                richTextBox2.AppendText("AYRAN " + " " + "X" + ayranSayac + " = " + ayranSayac * 15 + Environment.NewLine);



                richTextBox2.AppendText("ÇAY " + " " + "X" + caySayac + " = " + caySayac * 10 + Environment.NewLine);


                richTextBox2.AppendText("SOÐUK MESRUBAT " + " " + "X" + sogukSayac + " = " + sogukSayac * 25 + Environment.NewLine);
                richTextBox2.AppendText("TÜRK KAHVESÝ " + " " + "X" + turkSayac + " = " + turkSayac * 30 + Environment.NewLine);
                richTextBox2.AppendText("SU " + " " + "X" + suSayac + " = " + suSayac * 10 + Environment.NewLine);



                label8.Text = "Toplam Tutar = ";
                label19.Text = Convert.ToString(masa2Toplam);
                toplam = toplam + masa2Toplam;
            }



            else if (MasaNumara == "3" && label19.Text=="0")
            {
                int pizzaSayac = 0;
                int makarnaSayac = 0;
                int hamburgerSayac = 0;
                
                int ayranSayac = 0;
                int turkSayac = 0;
                int sogukSayac = 0;
                int caySayac = 0;
                int suSayac = 0;
                foreach (String i in masa3Siparis)
                {

                    if (i == "Hamburger")
                    {
                        masa3Toplam = masa3Toplam + 25;
                        hamburgerSayac++;
                        hamburger = hamburger + hamburgerSayac;
                    }

                    else if (i == "Pizza")
                    {
                        masa3Toplam = masa3Toplam + 50;
                        pizzaSayac++;
                        pizza = pizzaSayac + pizza;
                    }

                    else if (i == "Makarna")
                    {
                        masa3Toplam = masa3Toplam + 30;
                        makarnaSayac++;
                        makarna = makarna + makarnaSayac;


                    }
                    else if (i == "Cay")
                    {
                        masa3Toplam = masa3Toplam + 10;
                        caySayac++;
                        cay = cay + caySayac;

                    }


                    else if (i == "Ayran")
                    {
                        masa3Toplam = masa3Toplam + 10;
                        ayranSayac++;
                        ayran = ayran + ayranSayac;

                    }





                    else if (i == "Soguk")
                    {
                        masa3Toplam = masa3Toplam + 25;
                        sogukSayac++;
                        mesrubat = mesrubat + sogukSayac;

                    }


                    else if (i == "Turk")
                    {
                        masa3Toplam = masa3Toplam + 30;
                        turkSayac++;
                        turk = turk + turkSayac;

                    }




                    else if (i == "Su")
                    {
                        masa3Toplam = masa3Toplam + 10;
                        suSayac++;
                        su=su + suSayac;

                    }





                }
















                richTextBox2.AppendText("HAMBURGER " + " " + "X" + hamburgerSayac + " = " + hamburgerSayac * 25 + Environment.NewLine);

                richTextBox2.AppendText("PÝZZA " + " " + "X" + pizzaSayac + " = " + pizzaSayac * 50 + Environment.NewLine);

                richTextBox2.AppendText("MAKARNA " + " " + "X" + makarnaSayac + " = " + makarnaSayac * 30 + Environment.NewLine);
                richTextBox2.AppendText("AYRAN " + " " + "X" + ayranSayac + " = " + ayranSayac * 15 + Environment.NewLine);



                richTextBox2.AppendText("ÇAY " + " " + "X" + caySayac + " = " + caySayac * 10 + Environment.NewLine);


                richTextBox2.AppendText("SOÐUK MESRUBAT " + " " + "X" + sogukSayac + " = " + sogukSayac * 25 + Environment.NewLine);
                richTextBox2.AppendText("TÜRK KAHVESÝ " + " " + "X" + turkSayac + " = " + turkSayac * 30 + Environment.NewLine);
                richTextBox2.AppendText("SU " + " " + "X" + suSayac + " = " + suSayac * 10 + Environment.NewLine);



                label8.Text = "Toplam Tutar = ";
                label19.Text = Convert.ToString(masa3Toplam);
                toplam = toplam + masa3Toplam;





            }














            else
            {

                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Veya Önce Ekraný Temizlemeniz Gerekiyor Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


























        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            label19.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(69, 74, 82);
            button2.ForeColor = Color.White; // Düðme metin rengini kýrmýzý yapar
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(69, 74, 82);
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(69, 74, 82);
            button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            groupBox14.Visible = false;
            groupBox8.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            groupBox14.Visible = false;
            groupBox8.Visible = true;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;




        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {






            String siparis;



            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);


            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Ayran";

                richTextBox1.AppendText("Masa 1   ------>  AYRAN  |  " + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Ayran";

                richTextBox1.AppendText("Masa 2   ------>  AYRAN  |  " + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }





            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Ayran";

                richTextBox1.AppendText("Masa 3   ------>   AYRAN  |  " + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }






            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }





















        }

        private void button10_Click(object sender, EventArgs e)
        {






            String siparis;



            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);


            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Su";

                richTextBox1.AppendText("Masa 1   ------>  SU" + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Su";

                richTextBox1.AppendText("Masa 2   ------>  SU" + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }





            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Su";

                richTextBox1.AppendText("Masa 3   ------>   SU" + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }






            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }











        }

        private void button11_Click(object sender, EventArgs e)
        {



            String siparis;



            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);


            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Soguk";

                richTextBox1.AppendText("Masa 1   ------>  MEÞRUBAT" + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Soguk";

                richTextBox1.AppendText("Masa 2   ------>  MEÞRUBAT" + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }





            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Soguk";

                richTextBox1.AppendText("Masa 3   ------>  MEÞRUBAT" + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }






            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }





















        }

        private void button12_Click(object sender, EventArgs e)
        {



            String siparis;



            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);


            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Cay";

                richTextBox1.AppendText("Masa 1   ------>  ÇAY" + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Cay";

                richTextBox1.AppendText("Masa 2   ------>  ÇAY" + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }





            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Cay";

                richTextBox1.AppendText("Masa 3   ------>  ÇAY" + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }






            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }












        }

        private void button13_Click(object sender, EventArgs e)
        {

            String siparis;



            siparis = Interaction.InputBox("Lütfen Sipariþin Hangi Masaya Gidiceðini Yazýnýz", "SÝPARÝÞ GÖNDER", "Masa 1", 500, 500);


            if (siparis == "Masa 1")
            {

                masa1Siparis[masaSayac1] = "Turk";

                richTextBox1.AppendText("Masa 1   ------>  Türk Kahvesi" + DateAndTime.Now + Environment.NewLine);
                masaSayac1++;
            }

            else if (siparis == "Masa 2")
            {

                masa2Siparis[masaSayac2] = "Turk";

                richTextBox1.AppendText("Masa 2   ------>  Türk Kahvesi" + DateAndTime.Now + Environment.NewLine);
                masaSayac2++;
            }





            else if (siparis == "Masa 3")
            {

                masa3Siparis[masaSayac3] = "Turk";

                richTextBox1.AppendText("Masa 3   ------>  Türk Kahvesi" + DateAndTime.Now + Environment.NewLine);
                masaSayac3++;
            }






            else
            {
                MessageBox.Show("Hatalý Bir Masa Seçimi Yaptýnýz Tekrar Deneyin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }





        }

        private void button7_Click(object sender, EventArgs e)
        {

            String x;
            int k;


            x = Interaction.InputBox("Lütfen Aldýðýnýz Nakit Tutarý Giriniz ", "GÖNDER", " ", 500, 500);

            k = Convert.ToInt32(x) - Convert.ToInt32(label19.Text);


            textBox1.Text = "Lütfen" + Convert.ToString(k) + "   TL  Para  Üstü  Veriniz";



        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Teþekkürler Yine Bekleriz ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string masaNo;
            masaNo = Interaction.InputBox("Lütfen Hesabýný Kapatmak Ýstediðiniz Masa Numarasýný Giriniz ", "GÖNDER", " ", 500, 500);
            if (Convert.ToInt32(masaNo) == 1)
            {
               
               
                MessageBox.Show(" Masa 1 Hesap Kapandý ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                masa1Toplam = 0;
                label19.Text = " ";
                masa1Siparis = new String[99];


            }

            else if (Convert.ToInt32(masaNo) == 2)
            {
               
                MessageBox.Show(" Masa 2 Hesap Kapandý ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                masa2Toplam = 0;
                label19.Text = " ";
                masa2Siparis = new String[99];

            }


            else if (Convert.ToInt32(masaNo) == 3)
            {

               
                MessageBox.Show(" Masa 3  Hesap Kapandý", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                masa3Toplam = 0;
                label19.Text = " ";
                masa3Siparis = new String[99];
            }




        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
