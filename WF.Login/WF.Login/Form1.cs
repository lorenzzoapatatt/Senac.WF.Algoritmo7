namespace WF.Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Usuário")
            {
                textBox2.Text = string.Empty;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "Usuário";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Senha")
            {
                textBox1.Text = string.Empty;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "Senha";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Você deseja fechar a janela",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
