using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecruimentAgencyAppIS4.Forms;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormUpravleniaVacancii : Form
    {
        private string _finalRole;
        public FormUpravleniaVacancii()
        {
            InitializeComponent();
            LoadTable();
        }

        public FormUpravleniaVacancii(string finalRole)
        {
            _finalRole = finalRole;
            InitializeComponent();
            LoadTable();
            Role();
        }

        private void Role()
        {
            if (_finalRole == "Гость")
                GuestRole();
        }

        private void GuestRole()
        {
            buttonDelete.Hide();
            buttonDobavit.Hide();
            buttonIzmenit.Hide();  
        }

        private DataGridView LoadTable()
        {
            dataGridViewVacansii.Columns.Add("id", "Код");
            dataGridViewVacansii.Columns.Add("naimenovanieVacancii", "Наименование вакансии");
            dataGridViewVacansii.Columns.Add("specializaciya", "Специализация");
            dataGridViewVacansii.Columns.Add("region", "Регион");
            dataGridViewVacansii.Columns.Add("zarabotnayPlata", "Заработная плата");
            dataGridViewVacansii.Columns.Add("uslovia", "Условия");
            dataGridViewVacansii.Columns.Add("obyazonosti", "Обязаности");
            dataGridViewVacansii.Columns.Add("trebovania", "Требования");
            dataGridViewVacansii.Columns.Add("kluchvieNaviki", "Ключевые навыки");

            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            var vacansiiList = context.Vacansies;

            int i = 0;

            foreach (var item in vacansiiList)
            {
                dataGridViewVacansii.Rows.Add
                    (item.id,
                    item.NaimenovanieVacanciy.NaimenovanieVacancii,
                    item.Doljnost.NaimenovanieDoljnosti,
                    item.RegionNaimenovanie.NaimenovanieRegion,
                    item.ZarabotnaiPlata,
                    item.Uslovia,
                    item.Obazanosti,
                    item.Trebovania);
                i++;
            }
            return dataGridViewVacansii;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormUpravlenia formUpravlenia = new FormUpravlenia(_finalRole);
            formUpravlenia.Show();
            this.Hide();
        }

        private void buttonObnovit_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            dataGridViewVacansii.Rows.Clear();
            dataGridViewVacansii.Columns.Clear();
            LoadTable();
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            FormObnovitUpravlenieVacancii formObnovitUpravlenieVacancii = new FormObnovitUpravlenieVacancii();

            DialogResult result = formObnovitUpravlenieVacancii.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                formObnovitUpravlenieVacancii.Close();
            }
            if (result == DialogResult.OK)
            {
                Vacansies vacansies = new Vacansies();
                KompaniNaimenovanie kompaniNaimenovanie = (KompaniNaimenovanie)formObnovitUpravlenieVacancii.comboBoxNaimenovanieKompanii.SelectedItem;
                NaimenovanieVacanciy naimenovanieVacanciy = (NaimenovanieVacanciy)formObnovitUpravlenieVacancii.comboBoxNaimenovanieVacansii.SelectedItem;
                Doljnost doljnost = (Doljnost)formObnovitUpravlenieVacancii.comboBoxNaimenovsnieDoljnosti.SelectedItem;
                RegionNaimenovanie region = (RegionNaimenovanie)formObnovitUpravlenieVacancii.comboBoxRegion.SelectedItem;
                vacansies.idKompanii = kompaniNaimenovanie.id;
                vacansies.idNaimenovaniaVacancia = naimenovanieVacanciy.id;
                vacansies.idDoljnosti = doljnost.id;
                vacansies.idRegion = region.id;
                vacansies.ZarabotnaiPlata = formObnovitUpravlenieVacancii.textBoxZarabotnaiPlata.Text;
                vacansies.Uslovia = formObnovitUpravlenieVacancii.textBoxUslovia.Text;
                vacansies.Obazanosti = formObnovitUpravlenieVacancii.textBoxObyazanosti.Text;
                vacansies.Trebovania = formObnovitUpravlenieVacancii.textBoxTrebonia.Text;
                context.Vacansies.Add(vacansies);
                context.SaveChanges();
                MessageBox.Show("Объект добавлен", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }

        private void buttonIzmenit_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            if (dataGridViewVacansii.SelectedRows.Count > 0)
            {

                var codeId = dataGridViewVacansii.CurrentCell.Value.ToString();
                int code = Convert.ToInt32(codeId);
                var vacancii = context.Vacansies.Where(x => x.id == code).Single();
                FormObnovitUpravlenieVacancii formObnovitUpravlenieVacancii = new FormObnovitUpravlenieVacancii();
                formObnovitUpravlenieVacancii.textBoxZarabotnaiPlata.Text = vacancii.ZarabotnaiPlata;
                formObnovitUpravlenieVacancii.textBoxUslovia.Text = vacancii.Uslovia;
                formObnovitUpravlenieVacancii.textBoxObyazanosti.Text = vacancii.Obazanosti;
                formObnovitUpravlenieVacancii.textBoxTrebonia.Text = vacancii.Trebovania;
                DialogResult result = formObnovitUpravlenieVacancii.ShowDialog(this);

                if (result == DialogResult.Cancel)
                {
                    return;
                }

                Vacansies vacansies = new Vacansies();
                KompaniNaimenovanie kompaniNaimenovanie = (KompaniNaimenovanie)formObnovitUpravlenieVacancii.comboBoxNaimenovanieKompanii.SelectedItem;
                NaimenovanieVacanciy naimenovanieVacanciy = (NaimenovanieVacanciy)formObnovitUpravlenieVacancii.comboBoxNaimenovanieVacansii.SelectedItem;
                Doljnost doljnost = (Doljnost)formObnovitUpravlenieVacancii.comboBoxNaimenovsnieDoljnosti.SelectedItem;
                RegionNaimenovanie region = (RegionNaimenovanie)formObnovitUpravlenieVacancii.comboBoxRegion.SelectedItem;
                vacancii.idKompanii = kompaniNaimenovanie.id;
                vacancii.idNaimenovaniaVacancia = naimenovanieVacanciy.id;
                vacancii.idDoljnosti = doljnost.id;
                vacancii.idRegion = region.id;
                vacancii.ZarabotnaiPlata = formObnovitUpravlenieVacancii.textBoxZarabotnaiPlata.Text;
                vacancii.Uslovia = formObnovitUpravlenieVacancii.textBoxUslovia.Text;
                vacancii.Obazanosti = formObnovitUpravlenieVacancii.textBoxObyazanosti.Text;
                vacancii.Trebovania = formObnovitUpravlenieVacancii.textBoxTrebonia.Text;

                context.Entry(vacancii).State = EntityState.Modified;
                context.SaveChanges();

                MessageBox.Show("Объект обновлён", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            if (dataGridViewVacansii.SelectedRows.Count > 0)
            {
                var codeId = dataGridViewVacansii.CurrentCell.Value.ToString();
                int code = Convert.ToInt32(codeId);
                var vacancii = context.Vacansies.Where(x => x.id == code).Single();
                context.Vacansies.Remove(vacancii);
                context.SaveChanges();
                MessageBox.Show("Объект удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }
    }
}
