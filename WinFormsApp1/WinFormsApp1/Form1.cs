using OOP_NesneyeYönelikProgramlama_;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           

            if (txtDogumYili != null)
            { 
                lblSonuc.Text = "Yaşınız: " + Insan.YasHesaplama(Convert.ToInt32(txtDogumYili.Text));
            }
            else
            {
                lblSonuc.Text = "Değer Giriniz";
            }
           



        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}