using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecruimentAgencyAppIS4.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecruimentAgencyAppIS4
{
    public partial class FormVhoda : Form
    {
        public FormVhoda()
        {
            InitializeComponent();
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistrarion formRegistrarion = new FormRegistrarion();
            formRegistrarion.Show();
            this.Hide();
        }
        private bool CheckAvtorization()
        {
            try
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                if (string.IsNullOrWhiteSpace(login) && string.IsNullOrWhiteSpace(password))
                {
                    return false;

                }
                RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
                var result = context.Polzovateli.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                if (result != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public string GetUserRole()
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            bool status = CheckAvtorization();
            if (status)
            {
                RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
                var user = context.Polzovateli.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null)
                {
                    return user.Roles.NaimenovanieRole;
                }
                else
                {
                    return null; // или другое значение, если пользователь не найден
                }
            }
            else
            {
                return null;
            }
        }
        private void buttonAvtorizatia_Click(object sender, EventArgs e)
        {
            string finalRole = GetUserRole();
            if (finalRole == null)
            {
                MessageBox.Show("Неверные учётные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormDanieOKompanii formDanieOKompanii = new FormDanieOKompanii(finalRole);
                FormUpravlenia formUpravlenia = new FormUpravlenia(finalRole);
                switch (finalRole)
                {
                    case "Администратор":                       
                        formUpravlenia.Show();
                        this.Hide();
                        MessageBox.Show($"Ваша роль: {finalRole}");
                        break;
                    case "Работадатель":
                        formUpravlenia.Show();
                        EmployerRole();
                        MessageBox.Show($"Ваша роль: {finalRole}");
                        break;
                    case "Соискатель":

                        formUpravlenia.Show();
                        AplicantRole(formUpravlenia);
                        this.Hide();
                        MessageBox.Show($"Ваша роль: {finalRole}");
                        break;
                    case "Гость":
                        formUpravlenia.Show();
                        MessageBox.Show($"Ваша роль: {finalRole}");
                        break;
                }
            }
            MessageBox.Show("Успешная работа кейсов");
        }
        private void EmployerRole()
        {
            MessageBox.Show("Функционал работодателя");
        }

        private void AplicantRole(FormUpravlenia formUpravlenia)
        {
            formUpravlenia.buttonDanieOKompanii.Hide();
            formUpravlenia.buttonUpravleniiVacanciyami.Hide();
        }
    }
}
