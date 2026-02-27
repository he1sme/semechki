using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        internal Cart cart;
        public Form1()
        {
            InitializeComponent();
            cart = new Cart();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMainScreen();
        }

        private void showScreen(UserControl screen)
        {
            main_panel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            main_panel.Controls.Add(screen);
        }

        private void showMainScreen()
        {
            var uc2 = new UserControl2();
            var uc1 = new UserControl1();
            uc1.CartItems = cart.getList();

            uc2.onCart += () =>
            {
                showCart(uc1);
            };

            uc2.onAddCart2 += card =>
            {
                if (card != null)
                {
                    cart.add(card);
                }
            };

            showScreen(uc2);
        }

        private void showCart(UserControl1? custom)
        {
            var uc1 = custom;
            if (uc1 == null)
            {
                uc1 = new UserControl1();
            }

            uc1.OnBack += () =>
            {
                showMainScreen();
            };
            uc1.OnCartDelete += card =>
            {
                if (card != null)
                {
                    cart.remove(card);
                }
            };

            showScreen(uc1);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
