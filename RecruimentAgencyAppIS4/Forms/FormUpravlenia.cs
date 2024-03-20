using System;
using System.Windows.Forms;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormUpravlenia : Form
    {
        private string _finalRole;
        public FormUpravlenia()
        {
            InitializeComponent();
        }

        public FormUpravlenia(string finalRole)
        {
            InitializeComponent();
            _finalRole = finalRole;
            Role();
        }
        private void GuestRole()
        {
            buttonUpravleniiVacanciyami.Hide();
        }
        private void AplicantRole()
        {
            buttonDanieOKompanii.Hide();
            buttonUpravleniiVacanciyami.Hide();
        }
        private void Role()
        {
            if(_finalRole=="Гость")
            {
                GuestRole();
            }
            else if (_finalRole=="Соиcкатель")
            {
                AplicantRole();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormVhoda formVhoda = new FormVhoda();
            this.Close();
            formVhoda.Close();
        }
        private void buttonDanieOKompanii_Click(object sender, EventArgs e)
        {
            FormDanieOKompanii formDanieOKompanii = new FormDanieOKompanii(_finalRole);
            formDanieOKompanii.Show();
            this.Hide();
        }
        private void buttonUpravleniiVacanciyami_Click(object sender, EventArgs e)
        {
            FormUpravleniaVacancii formUpravleniaVacancii = new FormUpravleniaVacancii(_finalRole);
            formUpravleniaVacancii.Show();
            this.Hide();
        }
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            FormVhoda formVhoda = new FormVhoda();
            formVhoda.Show();
            Hide();
        }
        private void buttonSmenaParola_Click(object sender, EventArgs e)
        {
            FormSmenaParolia formSmenaParolia = new FormSmenaParolia();
            formSmenaParolia.Show();
            this.Hide();
        }
        private void buttonAplicant_Click(object sender, EventArgs e)
        {
            FormSoiskateli formSoiskateli = new FormSoiskateli(_finalRole);
            formSoiskateli.Show();
            Hide();
        }
    }
}
