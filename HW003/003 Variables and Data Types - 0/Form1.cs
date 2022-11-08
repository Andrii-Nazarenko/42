using System.Windows.Forms;

namespace _003_Variables_and_Data_Types___0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           textBox1.Text=("тут могла бы быть ваша реклама");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон  От -128 до 127");
        }

        private void button7_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Диапазон от 0 до 255");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от -32 768 до 32 767");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от 0 до 65 535");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от 0 до 18 446 744 073 709 551 615");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от -2 147 483 648 до 2 147 483 647");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от 0 до 4 294 967 295");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807");
        }
    }
}