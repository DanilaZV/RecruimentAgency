using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormSmenaParolia : Form
    {
        public FormSmenaParolia()
        {
            InitializeComponent();
        }
        private void buttonSochranit_Click(object sender, EventArgs e)
        {
            try
            {
                RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
                if (
                    string.IsNullOrEmpty(textBoxLogin.Text)
                    && string.IsNullOrEmpty(textBoxStaruiParol.Text)
                    && string.IsNullOrEmpty(textBoxNovuiParol.Text)
                    && string.IsNullOrEmpty(textBoxPovtorNovuiParol.Text))
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string login = textBoxLogin.Text;
                string staruiParol = textBoxStaruiParol.Text;
                string novuiParol = textBoxNovuiParol.Text;
                string povtorNovuiParol = textBoxPovtorNovuiParol.Text;
                var polz = context.Polzovateli.Where(x => x.Login == login && x.Password == staruiParol).FirstOrDefault();
                if (polz == null)
                {
                    MessageBox.Show("Пользователя не существует!" + polz, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (novuiParol != staruiParol && novuiParol == povtorNovuiParol)
                {
                    polz.Password = novuiParol;
                    context.Entry(polz).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Пароль успешно изменен!", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormUpravlenia formUpravlenia = new FormUpravlenia();
                    formUpravlenia.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пользователя не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }
        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            FormUpravlenia formUpravlenia = new FormUpravlenia();
            formUpravlenia.Show();
            this.Hide();
        }
    }
}
