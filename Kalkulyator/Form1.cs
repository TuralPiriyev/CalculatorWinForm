namespace Kalkulyator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            decimal N1 = Convert.ToInt16(Number1.Text);
            decimal N2 = Convert.ToInt16(Number2.Text);
            decimal result = N1 + N2;
            label1.Text = result.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            decimal N1 = Convert.ToInt16(Number1.Text);
            decimal N2 = Convert.ToInt16(Number2.Text);
            decimal result = N1 - N2;
            label1.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            decimal N1 = Convert.ToInt16(Number1.Text);
            decimal N2 = Convert.ToInt16(Number2.Text);
            decimal result = N1 / N2;
            label1.Text = result.ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            decimal N1 = Convert.ToInt16(Number1.Text);
            decimal N2 = Convert.ToInt16(Number2.Text);
            decimal result = (N1 / N2) * 100;
            label1.Text = result.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            decimal N1 = Convert.ToInt16(Number1.Text);
            decimal N2 = Convert.ToInt16(Number2.Text);
            decimal result = N1 * N2;
            label1.Text = result.ToString();
        }
    }
}