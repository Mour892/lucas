namespace atividade_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 Cad = new Class1();
            Cad.nome = textBoxNome.Text;
            Cad.telefone = textBox2.Text;
            Cad.idade = textBox3.Text;
            Cad.peso = textBox4.Text;
            Cad.cidade = textBox5.Text;
            Cad.sexo = textBox6.Text;
            Cad.CPF = textBox7.Text;
            listBox1.Items.Add(Cad.nome);
            listBox1.Items.Add(Cad.telefone);
            listBox1.Items.Add(Cad.idade);
            listBox1.Items.Add(Cad.peso);
            listBox1.Items.Add(Cad.cidade);
            listBox1.Items.Add(Cad.sexo);
            listBox1.Items.Add(Cad.CPF);

        }
    }
}