namespace LoginEmail
{
    public partial class Form1 : Form
    {
        readonly string Email = "ulfah@gmail.com";
        readonly string Password = "admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == Email && txtpassword.Text == Password)
            {
                MessageBox.Show("Yeee,,, Berhasil Login");
            }
            else if (txtemail.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Eits, Email sama Passwoardnya mana???");
            }
            else
            {
                MessageBox.Show("Yah, gagal masuk nih, coba lagi yooo");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            txtpassword.Clear();
        }
    }
}