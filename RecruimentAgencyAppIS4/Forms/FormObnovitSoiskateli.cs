using System.Linq;
using System.Windows.Forms;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormObnovitSoiskateli : Form
    {
        public FormObnovitSoiskateli()
        {
            InitializeComponent();
            loadComboBox();
        }
        private void loadComboBox()
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            var gorod = context.Goroda.ToList();
            comboBoxGorod.DataSource = gorod;
            comboBoxGorod.DisplayMember = "NazvanieGoroda";
            comboBoxGorod.ValueMember = "id";
            var pol = context.Pol.ToList();
            comboBoxPol.DataSource = pol;
            comboBoxPol.DisplayMember = "NaimenovaniePola";
            comboBoxPol.ValueMember = "id";
            var grajdan = context.Grajdanstvo.ToList();
            comboBoxGrajdanstvo.DataSource = grajdan;
            comboBoxGrajdanstvo.DisplayMember = "NaimenovanieGrajdanstva";
            comboBoxGrajdanstvo.ValueMember = "id";
            var mestoRabotu = context.MestoRabotu.ToList();
            comboBoxMestoRabotu.DataSource = mestoRabotu;
            comboBoxMestoRabotu.DisplayMember = "NaimenovanieMestaRabotu";
            comboBoxMestoRabotu.ValueMember = "id";
            var doljnost = context.Doljnost.ToList();
            comboBoxDoljnost.DataSource = doljnost;
            comboBoxDoljnost.DisplayMember = "NaimenovanieDoljnosti";
            comboBoxDoljnost.ValueMember = "id";
            var specialnost = context.Specialnost.ToList();
            comboBoxSpecialnost.DataSource = specialnost;
            comboBoxSpecialnost.DisplayMember = "NaimenovanieSpecialnosti";
            comboBoxSpecialnost.ValueMember = "id";
            var jelaimaiDoljnost = context.Doljnost.ToList();
            comboBoxJelaemaiDoljnost.DataSource = jelaimaiDoljnost;
            comboBoxJelaemaiDoljnost.DisplayMember = "NaimenovanieDoljnosti";
            comboBoxJelaemaiDoljnost.ValueMember = "id";
        }
    }
}
