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
           textBox1.Text=("��� ����� �� ���� ���� �������");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������  �� -128 �� 127");
        }

        private void button7_Click(object sender, EventArgs e)
        {
           MessageBox.Show("�������� �� 0 �� 255");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �� -32 768 �� 32 767");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �� 0 �� 65 535");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �� 0 �� 18 446 744 073 709 551 615");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �� -2 147 483 648 �� 2 147 483 647");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �� 0 �� 4 294 967 295");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �� -9 223 372 036 854 775 808 �� 9 223 372 036 854 775 807");
        }
    }
}