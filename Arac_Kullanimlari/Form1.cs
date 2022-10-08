namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Baran";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Emel";
            label7.Text = "Öztürk";
            label8.Text = "Öðretmen";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazýlým Mühendisliði";
            label9.Text = textBox1.Text;
        }
    }
}