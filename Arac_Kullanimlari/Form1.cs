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
            MessageBox.Show("Merhaba D�nya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Baran";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Emel";
            label7.Text = "�zt�rk";
            label8.Text = "��retmen";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yaz�l�m M�hendisli�i";
            label9.Text = textBox1.Text;
        }
    }
}