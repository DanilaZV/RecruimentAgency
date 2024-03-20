using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormObnovitUpravlenieVacancii : Form
    {
        public FormObnovitUpravlenieVacancii()
        {
            InitializeComponent();
            loadComboBox();
        }
        private void loadComboBox()
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            var kompaniImy = context.KompaniNaimenovanie.ToList();
            comboBoxNaimenovanieKompanii.DataSource = kompaniImy;
            comboBoxNaimenovanieKompanii.DisplayMember = "NaimenovanieKompani";
            comboBoxNaimenovanieKompanii.ValueMember = "id";

            var vacansiiNaimenovanie = context.NaimenovanieVacanciy.ToList();
            comboBoxNaimenovanieVacansii.DataSource = vacansiiNaimenovanie;
            comboBoxNaimenovanieVacansii.DisplayMember = "NaimenovanieVacancii";
            comboBoxNaimenovanieVacansii.ValueMember = "id";

            var doljnostNaimenovanie = context.Doljnost.ToList();
            comboBoxNaimenovsnieDoljnosti.DataSource = doljnostNaimenovanie;
            comboBoxNaimenovsnieDoljnosti.DisplayMember = "NaimenovanieDoljnosti";
            comboBoxNaimenovsnieDoljnosti.ValueMember = "id";

            var region = context.RegionNaimenovanie.ToList();
            comboBoxRegion.DataSource = region;
            comboBoxRegion.DisplayMember = "NaimenovanieRegion";
            comboBoxRegion.ValueMember = "id";

        }
    }
}
