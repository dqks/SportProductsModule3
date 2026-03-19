
using SportProducts.Models;

namespace SportProducts
{
    public partial class FormLogin : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "admin@sport.ru";
            textBoxPassword.Text = "qwerty123";
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text) && String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new SportProductsContext())
            {


                User user = db.Users.Where(w => w.Password == textBoxPassword.Text && w.Login == textBoxLogin.Text).FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;

                    FormProducts form = new FormProducts(CurrentUser, IsGuest);
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;

            FormProducts form = new FormProducts(CurrentUser, IsGuest);
            this.Hide();

            form.FormClosed += (s, args) =>
            {
                this.Close();
            };

            form.Show();
        }
    }
}
