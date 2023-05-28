using lista.modeldanych;

namespace lista
{
    public partial class Form1 : Form
    {
        Pobieracz pobieracz;
        public Form1()
        {
            InitializeComponent();
            pobieracz = new Pobieracz();
            pobieracz.PobierzDaneZBazy();
            PokazDane();
        }
        public void PokazDane()
        {
            TextBoxLista.Clear();
            foreach (Osoba osoba in pobieracz.ListaOsob)
                TextBoxLista.Text += osoba.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pobieracz.ListaOsob.Sort();
            PokazDane();
        }
    }
}