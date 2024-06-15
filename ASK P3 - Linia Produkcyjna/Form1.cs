using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ASK_P3___Linia_Produkcyjna
{
    public partial class Form1 : Form
    {
        private List<Uzytkownik> zarejestrowani = new List<Uzytkownik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            string nazwa = Login_text.Text;
            string haslo = Haslo_text.Text;

            var uzytkownik = zarejestrowani.FirstOrDefault(user => user.Username == nazwa && user.Password == haslo);

            if (string.IsNullOrEmpty(nazwa) || string.IsNullOrEmpty(haslo))
            {
                MessageBox.Show("Uzupełnij pola z loginem i hasłem, aby się zalogować!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (uzytkownik == null)
            {
                MessageBox.Show("Brak użytkownika w systemie. Logowanie nieudane.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Logowanie udane.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2(this);
                form2.Show();
                this.Hide();
            }
        }

        private void Create_account_Click(object sender, EventArgs e)
        {
            string nowy_login = Nowy_login_text.Text;
            string nowe_haslo = Nowe_haslo_text.Text;

            if (string.IsNullOrEmpty(nowy_login) || string.IsNullOrEmpty(nowe_haslo))
            {
                MessageBox.Show("Uzupełnij pola z loginem i hasłem, aby utworzyć konto!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                zarejestrowani.Add(new Uzytkownik { Username = nowy_login, Password = nowe_haslo });
                MessageBox.Show("Nowy użytkownik zarejestrowany!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nowy_login_text.Text = "";
                Nowe_haslo_text.Text = "";
            }
        }
    }

    public class Uzytkownik
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
