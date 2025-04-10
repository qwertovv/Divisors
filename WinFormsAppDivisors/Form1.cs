using ClassLibraryDeliteli;
namespace WinFormsAppDivisors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFindAllDiv_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDivN.Text, out int n))
            {
                string result = Deliteli.PrintDivisiors(n);
                textBoxResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFactorize_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDivN.Text, out int n))
            {
                string result = Deliteli.GetFactorizationString(n);
                textBoxResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFind5Div_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxM.Text, out int m) && (int.TryParse(textBoxN.Text, out int n)))
            {
                string result = Deliteli.PrintNumbersWith5Divisors(m, n);
                textBoxResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFirstN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDivN.Text, out int n))
            {
                string result = Deliteli.PrintFirstNPrimes(n);
                textBoxResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFirstNEratosfen_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDivN.Text, out int n))
            {
                string result = Deliteli.PrintPrimes(n);
                textBoxResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNOD_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxM1.Text, out int m) && (int.TryParse(textBoxN1.Text, out int n)))
            {
                int result = Deliteli.NOD(m, n);
                textBoxResult1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxM1.Text, out int m) && (int.TryParse(textBoxN1.Text, out int n)))
            {
                int result = Deliteli.NOK(m, n);
                textBoxResult1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "��� ������������ �����������:\n\n" +
                "1. ������� �������� ����� N (�����, �������������).\n" +
                "2. �������� ������ ��������.\n" +
                "3. ��� ������ ����� � ����� ���������� ������� ������� (�����, �������������).\n" +
                "4. ��������� ����������� � ���� \"���������\".\n\n",
                "�������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "��� ������������ �����������:\n\n" +
                "1. ������� �������� ����� N (�����, �������������).\n" +
                "2. �������� ������ ��������.\n" +
                "3. ��� ������ ����� � ����� ���������� ������� ������� (�����, �������������).\n" +
                "4. ��������� ����������� � ���� \"���������\".\n\n",
                "�������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
