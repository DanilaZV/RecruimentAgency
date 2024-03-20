using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormDanieOKompanii : Form
    {
        private string _finalRole;

        public FormDanieOKompanii(string role)
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
            dataGridViewKompaniya.Columns.Add("id", "Код");
            dataGridViewKompaniya.Columns.Add("naimenovanieKompanii", "Наименование компании");
            dataGridViewKompaniya.Columns.Add("inn", "ИНН");
            dataGridViewKompaniya.Columns.Add("ogrn", "ОГРН");
            dataGridViewKompaniya.Columns.Add("dataRegistracii", "Дата регистрации");
            dataGridViewKompaniya.Columns.Add("uridicheskiiAdress", "Юридический адресс");
            dataGridViewKompaniya.Columns.Add("rukovoditel", "Руководитель");
            dataGridViewKompaniya.Columns.Add("opisanieKompanii", "Описание компании");
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            var kompaniiList = context.Kompanii;

            int i = 0;

            foreach (var item in kompaniiList)
            {
                dataGridViewKompaniya.Rows.Add
                    (item.id,
                    item.KompaniNaimenovanie.NaimenovanieKompani,
                    item.INN,
                    item.OGRN,
                    item.DataRegistratia,
                    item.UridicheskiyAdres,
                    item.Rukovoditel,
                    item.OpisanieKompanii);
                i++;
            }
            return dataGridViewKompaniya;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormUpravlenia formUpravlenia = new FormUpravlenia(_finalRole);
            formUpravlenia.Show();
            this.Hide();
        }

        private void refreshTable()
        {
            dataGridViewKompaniya.Rows.Clear();
            dataGridViewKompaniya.Columns.Clear();
            LoadTable();
        }

        private void buttonObnovit_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            FormObnovitDannieOKompanii formObnovitDannieOKompanii = new FormObnovitDannieOKompanii();

            DialogResult result = formObnovitDannieOKompanii.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                formObnovitDannieOKompanii.Close();
            }
            if (result == DialogResult.OK)
            {
                Kompanii kompanii = new Kompanii();
                KompaniNaimenovanie kompaniNaimenovanie = (KompaniNaimenovanie)formObnovitDannieOKompanii.comboBoxNaimenovanieKompanii.SelectedItem;
                kompanii.idNaimenovanieKompanii = kompaniNaimenovanie.id;
                kompanii.INN = Convert.ToInt64(formObnovitDannieOKompanii.textBoxINN.Text);
                kompanii.OGRN = Convert.ToInt64(formObnovitDannieOKompanii.textBoxOGRN.Text);
                kompanii.DataRegistratia = formObnovitDannieOKompanii.dateTimePickerDataRegistracii.Value;
                kompanii.UridicheskiyAdres = formObnovitDannieOKompanii.textBoxUridicheskiyAdres.Text;
                kompanii.Rukovoditel = formObnovitDannieOKompanii.textBoxRukovoditel.Text;
                kompanii.OpisanieKompanii = formObnovitDannieOKompanii.textBoxOpisanieKompanii.Text;
                context.Kompanii.Add(kompanii);
                context.SaveChanges();
                MessageBox.Show("Объект добавлен", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }

        private void buttonIzmenit_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            if (dataGridViewKompaniya.SelectedRows.Count > 0)
            {

                var codeId = dataGridViewKompaniya.CurrentCell.Value.ToString();
                int code = Convert.ToInt32(codeId);
                var kompaniya = context.Kompanii.Where(x => x.id == code).Single();
                FormObnovitDannieOKompanii formObnovitDannieOKompanii = new FormObnovitDannieOKompanii();
                formObnovitDannieOKompanii.textBoxINN.Text = Convert.ToString(kompaniya.INN);
                formObnovitDannieOKompanii.textBoxOGRN.Text = Convert.ToString(kompaniya.OGRN);
                formObnovitDannieOKompanii.textBoxUridicheskiyAdres.Text = kompaniya.UridicheskiyAdres;
                formObnovitDannieOKompanii.textBoxRukovoditel.Text = kompaniya.Rukovoditel;
                formObnovitDannieOKompanii.textBoxOpisanieKompanii.Text = kompaniya.OpisanieKompanii;
                DialogResult result = formObnovitDannieOKompanii.ShowDialog(this);

                if (result == DialogResult.Cancel)
                {
                    return;
                }

                Kompanii kompanii = new Kompanii();
                KompaniNaimenovanie kompaniNaimenovanie = (KompaniNaimenovanie)formObnovitDannieOKompanii.comboBoxNaimenovanieKompanii.SelectedItem;
                kompaniya.idNaimenovanieKompanii = kompaniNaimenovanie.id;
                kompaniya.INN = Convert.ToInt64(formObnovitDannieOKompanii.textBoxINN.Text);
                kompaniya.OGRN = Convert.ToInt64(formObnovitDannieOKompanii.textBoxOGRN.Text);
                kompaniya.DataRegistratia = formObnovitDannieOKompanii.dateTimePickerDataRegistracii.Value;
                kompaniya.UridicheskiyAdres = formObnovitDannieOKompanii.textBoxUridicheskiyAdres.Text;
                kompaniya.Rukovoditel = formObnovitDannieOKompanii.textBoxRukovoditel.Text;
                kompaniya.OpisanieKompanii = formObnovitDannieOKompanii.textBoxOpisanieKompanii.Text;

                context.Entry(kompaniya).State = EntityState.Modified;
                context.SaveChanges();

                MessageBox.Show("Объект обновлён", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            if (dataGridViewKompaniya.SelectedRows.Count > 0)
            {
                var codeId = dataGridViewKompaniya.CurrentCell.Value.ToString();
                int code = Convert.ToInt32(codeId);
                var kompaniya = context.Kompanii.Where(x => x.id == code).Single();
                context.Kompanii.Remove(kompaniya);
                context.SaveChanges();
                MessageBox.Show("Объект удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshTable();
        }
    }
}
