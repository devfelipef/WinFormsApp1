namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = textBox1.Text;
            pessoa.Idade = Convert.ToInt32(textBox2.Text);
            pessoa.CPF1 = textBox3.Text;
            pessoa.Id = textBox4.Text;

            MessageBox.Show("Nome: " + pessoa.Nome + "\n" +
                            "Idade: " + pessoa.Idade + "\n" +
                            "CPF: " + pessoa.CPF1 + "\n" +
                            "ID: " + pessoa.Id);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            int x = Convert.ToInt32(textBox5.Text);
            cliente.comprar(x);
        }
    }
}