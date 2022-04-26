namespace Quieres_ser_mi_novia
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void OnMouseOver(object sender, MouseEventArgs e)
        {
            Random randomValue = new Random();
            int randomHeight = randomValue.Next(0, 45);
            int randomWidht = randomValue.Next(100, 410);

            btnNo.Location = new Point(randomWidht, randomHeight);
        }

        private void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show("¡¡Siiiiiiiii!!", "Siiiiiii", MessageBoxButtons.OK);
        }
    }
}