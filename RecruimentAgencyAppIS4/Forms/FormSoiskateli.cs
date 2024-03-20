using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormSoiskateli : Form
    {
        private string _finalRole;
        public FormSoiskateli(string role)
        {
            _finalRole = role;
            InitializeComponent();
            LoadTable();
            Role();
        }
        private void GuestRole()
        {
            buttonDobavit.Hide();
            buttonIzmenit.Hide();
            buttonDelete.Hide();
        }
        private void Role()
        {
            if (_finalRole == "Гость")
                GuestRole();
        }
        private DataGridView LoadTable()
        {
            dataGridViewSoiskateli.Columns.Add("id", "Код");
            dataGridViewSoiskateli.Columns.Add("FIO", "ФИО");
            dataGridViewSoiskateli.Columns.Add("idGoroda", "Город");
            dataGridViewSoiskateli.Columns.Add("DataRojenia", "Дата рождения");
            dataGridViewSoiskateli.Columns.Add("idPola", "Пол");
            dataGridViewSoiskateli.Columns.Add("idGrajdanstva", "Гражданство");
            dataGridViewSoiskateli.Columns.Add("OpitRabotu", "Опыт работы");
            dataGridViewSoiskateli.Columns.Add("idMestaRabotu", "Место работы");
            dataGridViewSoiskateli.Columns.Add("NachaloRabotu", "Начало работы");
            dataGridViewSoiskateli.Columns.Add("OkonchanieRabotu", "Окончание работы");
            dataGridViewSoiskateli.Columns.Add("idDoljnosti", "Должность");
            dataGridViewSoiskateli.Columns.Add("Obyzonasti", "Обязанности");
            dataGridViewSoiskateli.Columns.Add("InformaciaOSebe", "Инфо о себе");
            dataGridViewSoiskateli.Columns.Add("KluchevieNaviki", "Ключевые навыки");
            dataGridViewSoiskateli.Columns.Add("idSpecialnost", "Специальность");
            dataGridViewSoiskateli.Columns.Add("idJelaimayaDoljnost", "Желаемая должность");
            dataGridViewSoiskateli.Columns.Add("Zarplata", "Зарплата");
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            var aplicantList = context.Applicant;
            int i = 0;

            foreach (var item in aplicantList)
            {
                dataGridViewSoiskateli.Rows.Add
                    (item.id,
                    item.FIO,
                    item.Goroda.NazvanieGoroda,
                    item.DataRojenia,
                    item.Pol.NaimenovaniePola,
                    item.Grajdanstvo.NaimenovanieGrajdanstva,
                    item.OpitRabotu,
                    item.MestoRabotu.NaimenovanieMestaRabotu,
                    item.NachaloRabotu,
                    item.OkonchanieRabotu,
                    item.Doljnost.NaimenovanieDoljnosti,
                    item.Obyzonasti,
                    item.InformaciaOSebe,
                    item.KluchevieNaviki,
                    item.Specialnost.NaimenovanieSpecialnosti,
                    item.Doljnost.NaimenovanieDoljnosti,
                    item.Zarplata);
                i++;
            }
            return dataGridViewSoiskateli;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormUpravlenia formUpravlenia = new FormUpravlenia(_finalRole);
            formUpravlenia.Show();
            this.Hide();
        }
        private void refreshTable()
        {
            dataGridViewSoiskateli.Rows.Clear();
            dataGridViewSoiskateli.Columns.Clear();
            LoadTable();
        }
        private void buttonObnovit_Click(object sender, EventArgs e)
        {
            refreshTable();
        }
        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            FormObnovitSoiskateli formObnovitSoiskateli = new FormObnovitSoiskateli();
            DialogResult result = formObnovitSoiskateli.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                formObnovitSoiskateli.Close();
            }
            if (result == DialogResult.OK)
            {
                Goroda goroda = (Goroda)formObnovitSoiskateli.comboBoxGorod.SelectedItem;
                Pol pol = (Pol)formObnovitSoiskateli.comboBoxPol.SelectedItem;
                Grajdanstvo grajdanstvo = (Grajdanstvo)formObnovitSoiskateli.comboBoxGrajdanstvo.SelectedItem;
                MestoRabotu mestoRabotu = (MestoRabotu)formObnovitSoiskateli.comboBoxMestoRabotu.SelectedItem;
                Doljnost doljnost = (Doljnost)formObnovitSoiskateli.comboBoxDoljnost.SelectedItem;
                Specialnost specialnost = (Specialnost)formObnovitSoiskateli.comboBoxSpecialnost.SelectedItem;
                Doljnost jelaemaiDoljnost = (Doljnost)formObnovitSoiskateli.comboBoxJelaemaiDoljnost.SelectedItem;
                Applicant soiskatel = new Applicant();
                soiskatel.FIO = formObnovitSoiskateli.textBoxFIO.Text;
                soiskatel.idGoroda = goroda.id;
                soiskatel.DataRojenia = formObnovitSoiskateli.dateTimePickerDataRojenia.Value;
                soiskatel.idPola = pol.id;
                soiskatel.idGrajdanstva = grajdanstvo.id;
                soiskatel.OpitRabotu = formObnovitSoiskateli.textBoxOpitRabotu.Text;
                soiskatel.idMestaRabotu = mestoRabotu.id;
                soiskatel.NachaloRabotu = formObnovitSoiskateli.textBoxNachaloRabotu.Text;
                soiskatel.OkonchanieRabotu = formObnovitSoiskateli.textBoxOkonchanieRabotu.Text;
                soiskatel.idDoljnosti = doljnost.id;
                soiskatel.Obyzonasti = formObnovitSoiskateli.textBoxObyazonosti.Text;
                soiskatel.InformaciaOSebe = formObnovitSoiskateli.textBoxInfoOSebe.Text;
                soiskatel.KluchevieNaviki = formObnovitSoiskateli.textBoxKluchevieNavuki.Text;
                soiskatel.idSpecialnost = specialnost.id;
                soiskatel.idJelaimayaDoljnost = jelaemaiDoljnost.id;
                soiskatel.Zarplata = formObnovitSoiskateli.textBoxZarplata.Text;
                context.Applicant.Add(soiskatel);
                context.SaveChanges();
                MessageBox.Show("Объект добавлен", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }
        private void buttonIzmenit_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            if (dataGridViewSoiskateli.SelectedRows.Count > 0)
            {
                var codeId = dataGridViewSoiskateli.CurrentCell.Value.ToString();
                int code = Convert.ToInt32(codeId);
                var soiskateli = context.Applicant.Where(x => x.id == code).Single();
                FormObnovitSoiskateli formObnovitSoiskateli = new FormObnovitSoiskateli();
                formObnovitSoiskateli.textBoxFIO.Text = soiskateli.FIO;
                formObnovitSoiskateli.textBoxOpitRabotu.Text = soiskateli.OpitRabotu;
                formObnovitSoiskateli.textBoxNachaloRabotu.Text = soiskateli.NachaloRabotu;
                formObnovitSoiskateli.textBoxOkonchanieRabotu.Text = soiskateli.OkonchanieRabotu;
                formObnovitSoiskateli.textBoxObyazonosti.Text = soiskateli.Obyzonasti;
                formObnovitSoiskateli.textBoxInfoOSebe.Text = soiskateli.InformaciaOSebe;
                formObnovitSoiskateli.textBoxKluchevieNavuki.Text = soiskateli.KluchevieNaviki;
                formObnovitSoiskateli.textBoxZarplata.Text = soiskateli.KluchevieNaviki;
                DialogResult result = formObnovitSoiskateli.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {return;}
                Goroda goroda = (Goroda)formObnovitSoiskateli.comboBoxGorod.SelectedItem;
                Pol pol = (Pol)formObnovitSoiskateli.comboBoxPol.SelectedItem;
                Grajdanstvo grajdanstvo = (Grajdanstvo)formObnovitSoiskateli.comboBoxGrajdanstvo.SelectedItem;
                MestoRabotu mestoRabotu = (MestoRabotu)formObnovitSoiskateli.comboBoxMestoRabotu.SelectedItem;
                Doljnost doljnost = (Doljnost)formObnovitSoiskateli.comboBoxDoljnost.SelectedItem;
                Specialnost specialnost = (Specialnost)formObnovitSoiskateli.comboBoxSpecialnost.SelectedItem;
                Doljnost jelaemaiDoljnost = (Doljnost)formObnovitSoiskateli.comboBoxJelaemaiDoljnost.SelectedItem;
                soiskateli.FIO = formObnovitSoiskateli.textBoxFIO.Text;
                soiskateli.idGoroda = goroda.id;
                soiskateli.DataRojenia = formObnovitSoiskateli.dateTimePickerDataRojenia.Value;
                soiskateli.idPola = pol.id;
                soiskateli.idGrajdanstva = grajdanstvo.id;
                soiskateli.OpitRabotu = formObnovitSoiskateli.textBoxOpitRabotu.Text;
                soiskateli.idMestaRabotu = mestoRabotu.id;
                soiskateli.NachaloRabotu = formObnovitSoiskateli.textBoxNachaloRabotu.Text;
                soiskateli.OkonchanieRabotu = formObnovitSoiskateli.textBoxOkonchanieRabotu.Text;
                soiskateli.idDoljnosti = doljnost.id;
                soiskateli.Obyzonasti = formObnovitSoiskateli.textBoxObyazonosti.Text;
                soiskateli.InformaciaOSebe = formObnovitSoiskateli.textBoxInfoOSebe.Text;
                soiskateli.KluchevieNaviki = formObnovitSoiskateli.textBoxKluchevieNavuki.Text;
                soiskateli.idSpecialnost = specialnost.id;
                soiskateli.idJelaimayaDoljnost = jelaemaiDoljnost.id;
                soiskateli.Zarplata = formObnovitSoiskateli.textBoxZarplata.Text;
                context.Entry(soiskateli).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Объект обновлён", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            if (dataGridViewSoiskateli.SelectedRows.Count > 0)
            {
                var codeId = dataGridViewSoiskateli.CurrentCell.Value.ToString();
                int code = Convert.ToInt32(codeId);
                var soiskatel = context.Applicant.Where(x => x.id == code).Single();
                context.Applicant.Remove(soiskatel);
                context.SaveChanges();
                MessageBox.Show("Объект удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }
    }
}
