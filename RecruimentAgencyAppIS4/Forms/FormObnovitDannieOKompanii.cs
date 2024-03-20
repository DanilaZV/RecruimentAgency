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
    public partial class FormObnovitDannieOKompanii : Form
    {
        public FormObnovitDannieOKompanii()
        {
            InitializeComponent();
            loadComboBox();
        }

        private void loadComboBox()
        {
            KompaniNaimenovanie kompaniNaimenovanie = new KompaniNaimenovanie();
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            var kompaniImy = context.KompaniNaimenovanie.ToList();
            comboBoxNaimenovanieKompanii.DataSource = kompaniImy;
            comboBoxNaimenovanieKompanii.DisplayMember = "NaimenovanieKompani";
            comboBoxNaimenovanieKompanii.ValueMember = "id";
        }
    }
}
