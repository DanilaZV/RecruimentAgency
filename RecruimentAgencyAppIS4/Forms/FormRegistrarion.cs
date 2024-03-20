using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruimentAgencyAppIS4.Forms
{
    public partial class FormRegistrarion : Form
    {
        public FormRegistrarion()
        {
            InitializeComponent();
            loadComboBox();
        }

        private void loadComboBox()
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            var role = context.Roles.ToList();
            comboBoxRole.DataSource = role;
            comboBoxRole.DisplayMember = "NaimenovanieRole";
            comboBoxRole.ValueMember = "id";

            var naimenovanieKompanii = context.KompaniNaimenovanie.ToList();
            comboBoxNaimenovanieKompanii.DataSource = naimenovanieKompanii;
            comboBoxNaimenovanieKompanii.DisplayMember = "NaimenovanieKompani";
            comboBoxNaimenovanieKompanii.ValueMember = "id";

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

        private void SokrutieElementov(int comboBoxResult)
        {
            try
            {
                
                if (comboBoxResult == 0 || comboBoxResult == 3)//Администратор или гость
                {
                    groupBoxAvtorizatia.Visible = false;
                    groupBoxKompania.Visible = false;
                    groupBoxSoiskatel.Visible = false;
                    this.Size = new System.Drawing.Size(500, 150);
                    
                }
                else if (comboBoxResult == 1)//Работодатель
                {
                    groupBoxAvtorizatia.Visible = true;
                    groupBoxKompania.Visible = true;
                    groupBoxSoiskatel.Visible = false;
                    ObnulenieElementov();
                    this.Size = new System.Drawing.Size(470, 610);
                }
                else if (comboBoxRole.SelectedIndex == 2)//Соискатель
                {
                    groupBoxAvtorizatia.Visible = true;
                    groupBoxKompania.Visible = false;
                    groupBoxSoiskatel.Visible = true;
                    ObnulenieElementov();
                    this.Size = new System.Drawing.Size(790, 670);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObnulenieElementov()
        {
            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            comboBoxNaimenovanieKompanii.SelectedIndex = 0;
            textBoxINN.Text = string.Empty;
            textBoxOGRN.Text = string.Empty;
            dateTimePickerDataRegistracii.Value = DateTime.Now;
            textBoxUridicheskiyAdres.Text = string.Empty;
            textBoxRukovoditel.Text = string.Empty;
            textBoxOpisanieKompanii.Text = string.Empty;
            
            textBoxFIO.Text = string.Empty;
            comboBoxGorod.SelectedIndex = 0;
            dateTimePickerDataRojenia.Value = DateTime.Now;
            comboBoxPol.SelectedIndex = 0;
            comboBoxGrajdanstvo.SelectedIndex = 0;
            textBoxOpitRabotu.Text = string.Empty;
            comboBoxMestoRabotu.SelectedIndex = 0;
            textBoxNachaloRabotu.Text = string.Empty;
            textBoxOkonchanieRabotu.Text = string.Empty;
            comboBoxDoljnost.SelectedIndex = 0;
            textBoxObyazonosti.Text = string.Empty;
            textBoxInfoOSebe.Text = string.Empty;
            textBoxKluchevieNavuki.Text = string.Empty;
            comboBoxSpecialnost.SelectedIndex = 0;
            comboBoxJelaemaiDoljnost.SelectedIndex = 0;
            textBoxZarplata.Text = string.Empty;
        }


        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            SokrutieElementov(comboBoxRole.SelectedIndex);
           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormVhoda formVhoda = new FormVhoda();
            formVhoda.Show();
            Hide();
        }

        private void buttonRegRabotodatel_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            Roles roles = (Roles)comboBoxRole.SelectedItem;
            KompaniNaimenovanie kompaniaNaimenovanie = (KompaniNaimenovanie)comboBoxNaimenovanieKompanii.SelectedItem;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            int soiskatelId = 1;
            var polzovatel = context.Polzovateli.Where(x=> x.Login == login && x.Password == password).FirstOrDefault();
            if (polzovatel == null)
            {
                polzovatel = new Polzovateli();
                Kompanii kompanii = new Kompanii();
                polzovatel.Login = login;
                polzovatel.Password = password;
                polzovatel.idRole = roles.id;
                polzovatel.idApplicant = soiskatelId;
                kompanii.idNaimenovanieKompanii = kompaniaNaimenovanie.id;
                kompanii.INN = Convert.ToInt64(textBoxINN.Text);
                kompanii.OGRN = Convert.ToInt64(textBoxOGRN.Text);
                kompanii.DataRegistratia = dateTimePickerDataRegistracii.Value;
                kompanii.UridicheskiyAdres = textBoxUridicheskiyAdres.Text;
                kompanii.Rukovoditel = textBoxRukovoditel.Text;
                kompanii.OpisanieKompanii = textBoxOpisanieKompanii.Text;
                polzovatel.Kompanii = kompanii;
                context.Polzovateli.Add(polzovatel);
                context.SaveChanges();
                MessageBox.Show("Все успешно сохранено!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Логин и пароль уже заняты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegSoiskatel_Click(object sender, EventArgs e)
        {
            RecruimentAgencyEntities1 context = new RecruimentAgencyEntities1();
            Roles roles = (Roles)comboBoxRole.SelectedItem;
            Goroda goroda = (Goroda)comboBoxGorod.SelectedItem;
            Pol pol = (Pol)comboBoxPol.SelectedItem;
            Grajdanstvo grajdanstvo = (Grajdanstvo)comboBoxGrajdanstvo.SelectedItem;
            MestoRabotu mestoRabotu = (MestoRabotu)comboBoxMestoRabotu.SelectedItem;
            Doljnost doljnost = (Doljnost)comboBoxDoljnost.SelectedItem;
            Specialnost specialnost = (Specialnost)comboBoxSpecialnost.SelectedItem;
            Doljnost jelaemaiDoljnost = (Doljnost)comboBoxJelaemaiDoljnost.SelectedItem;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            int kompaniaId = 1;
            //int graj = 1;
            var polzovatel = context.Polzovateli.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            try
            {
                if (polzovatel == null)
                {
                    polzovatel = new Polzovateli();
                    Applicant soiskatel = new Applicant();
                    polzovatel.Login = login;
                    polzovatel.Password = password;
                    polzovatel.idRole = roles.id;
                    polzovatel.idKompanii = kompaniaId;
                    soiskatel.FIO = textBoxFIO.Text;
                    soiskatel.idGoroda = goroda.id;
                    soiskatel.DataRojenia = dateTimePickerDataRojenia.Value;
                    soiskatel.idPola = pol.id;
                    soiskatel.idGrajdanstva = grajdanstvo.id;
                    soiskatel.OpitRabotu = textBoxOpitRabotu.Text;
                    soiskatel.idMestaRabotu = mestoRabotu.id;
                    soiskatel.NachaloRabotu = textBoxNachaloRabotu.Text;
                    soiskatel.OkonchanieRabotu = textBoxOkonchanieRabotu.Text;
                    soiskatel.idDoljnosti = doljnost.id;
                    soiskatel.Obyzonasti = textBoxObyazonosti.Text;
                    soiskatel.InformaciaOSebe = textBoxInfoOSebe.Text;
                    soiskatel.KluchevieNaviki = textBoxKluchevieNavuki.Text;
                    soiskatel.idSpecialnost = specialnost.id;
                    soiskatel.idJelaimayaDoljnost = jelaemaiDoljnost.id;
                    soiskatel.Zarplata = textBoxZarplata.Text;

                    polzovatel.Applicant = soiskatel;
                    context.Polzovateli.Add(polzovatel);
                    context.SaveChanges();
                    MessageBox.Show("Все успешно сохранено!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Логин и пароль уже заняты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






        //private Polzovateli GetLoginAndPasssword()
        //{
        //    string login = textBoxLogin.Text;
        //    string password = textBoxPassword.Text;
        //    Polzovateli polzovateli = new Polzovateli();
        //    if (!string.IsNullOrWhiteSpace(textBoxLogin.Text))
        //    {
        //        polzovateli.Login = textBoxLogin.Text;
        //    }
        //    if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
        //    {
        //        polzovateli.Password = textBoxPassword.Text;
        //    }

        //    if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
        //    {
        //        MessageBox.Show("Заполните данные авторизации!!!");
        //        return null;
        //    }
        //    Roles roles = (Roles)comboBoxRole.SelectedItem;
        //    Polzovateli.

        //    //Polzovateli.idRoles = roles.id;
        //    //return avtorizatia;

        //}

        //private Sotrudniki GetDataSotrudnik()
        //{
        //    Sotrudniki sotrudniki = new Sotrudniki();
        //    Doljnost doljnost = (Doljnost)comboBoxDoljnost.SelectedItem;
        //    if (!string.IsNullOrWhiteSpace(textBoxFirstName.Text))
        //    {
        //        sotrudniki.imy = textBoxFirstName.Text;
        //    }
        //    if (!string.IsNullOrWhiteSpace(textBoxLastName.Text))
        //    {
        //        sotrudniki.familia = textBoxLastName.Text;
        //    }
        //    if (!string.IsNullOrWhiteSpace(textBoxPatronomyc.Text))
        //    {
        //        sotrudniki.otchestvo = textBoxPatronomyc.Text;
        //    }
        //    if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) && string.IsNullOrWhiteSpace(textBoxLastName.Text))
        //    {
        //        MessageBox.Show("Заполните поля имя и фамилия!!!");
        //        return null;
        //    }
        //    sotrudniki.nomerTelephona = textBoxPhoneNumber.Text;
        //    sotrudniki.dataRojenia = dateTimePickerDateBirth.Value;
        //    sotrudniki.idDoljnost = doljnost.id;
        //    //string lastname = textBoxLastName.Text;
        //    //string patronomyc = textBoxPatronomyc.Text;
        //    //string numberPhone = textBoxPhoneNumber.Text;
        //    //string dateBirth = dateTimePickerDateBirth.Value.ToShortDateString();
        //    //var idDoljnost = doljnost.id;
        //    //string login = textBoxLogin.Text;
        //    //string password = textBoxPassword.Text;

        //    YchetZayavokNaRemontOborudovaniaIS4Entities context = new YchetZayavokNaRemontOborudovaniaIS4Entities();

        //    var result = context.Sotrudniki;
        //    return sotrudniki;
        //}

        //private void GetDoljnost()
        //{
        //    Doljnost doljnost = new Doljnost();
        //    YchetZayavokNaRemontOborudovaniaIS4Entities context = new YchetZayavokNaRemontOborudovaniaIS4Entities();
        //    var res = context.Doljnost.ToList();
        //    comboBoxDoljnost.DataSource = res;
        //    comboBoxDoljnost.DisplayMember = "nazvanie";
        //    comboBoxDoljnost.ValueMember = "id";

        //    comboBoxDoljnost.SelectedIndexChanged += ComboBoxDoljnost_SelectedIndexChanged;
        //}

        //private void ComboBoxDoljnost_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Doljnost doljnost = (Doljnost)comboBoxDoljnost.SelectedItem;
        //    comboBoxDoljnost.Items.Add(doljnost);

        //}

        //private void RegistrMethod()
        //{

        //    Autorization avtorizatia = GetLoginAndPasssword();

        //    if (avtorizatia == null)
        //    {
        //        throw new Exception("Ошибка, поля пусты");

        //    }

        //    var idAvtoriz = AddLoginAndPassword(avtorizatia);
        //    if (idAvtoriz != 0)
        //    {
        //        var sotrudnik = GetDataSotrudnik();
        //        AddSotrudnik(sotrudnik, idAvtoriz);
        //    }




        //}

        //private void AddSotrudnik(Sotrudniki sotrudnik, int idAvtoriz)
        //{
        //    YchetZayavokNaRemontOborudovaniaIS4Entities context = new YchetZayavokNaRemontOborudovaniaIS4Entities();
        //    var sotrud = context.Sotrudniki.Where(x => x.familia == sotrudnik.familia && x.imy == sotrudnik.imy && x.nomerTelephona == sotrudnik.nomerTelephona).FirstOrDefault();
        //    if (sotrud == null)
        //    {
        //        sotrud = new Sotrudniki();
        //        sotrud.imy = sotrudnik.imy;
        //        sotrud.familia = sotrudnik.familia;
        //        sotrud.otchestvo = sotrudnik.otchestvo;
        //        sotrud.dataRojenia = sotrudnik.dataRojenia;
        //        sotrud.idDoljnost = sotrudnik.idDoljnost;
        //        sotrud.idAvtorization = idAvtoriz;
        //        sotrud.nomerTelephona = sotrudnik.nomerTelephona;
        //        context.Sotrudniki.Add(sotrud);
        //        context.SaveChanges();
        //        MessageBox.Show("Все успешно сохранено");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Неверные введенные данные");
        //    }
        //}

        //private int AddLoginAndPassword(Autorization avtorizatia)
        //{

        //    YchetZayavokNaRemontOborudovaniaIS4Entities context = new YchetZayavokNaRemontOborudovaniaIS4Entities();
        //    var loginAndPass = context.Autorization.Where(x => x.login == avtorizatia.login && x.password == avtorizatia.password && x.idRoles == avtorizatia.idRoles).FirstOrDefault();
        //    if (loginAndPass == null)
        //    {
        //        loginAndPass = new Autorization();
        //        loginAndPass.login = avtorizatia.login;
        //        loginAndPass.password = avtorizatia.password;
        //        loginAndPass.idRoles = avtorizatia.idRoles;
        //        context.Autorization.Add(loginAndPass);
        //        context.SaveChanges();

        //        loginAndPass = context.Autorization.Where(x => x.login == avtorizatia.login && x.password == avtorizatia.password && x.idRoles == avtorizatia.idRoles).FirstOrDefault();

        //        return loginAndPass.id;


        //    }
        //    else
        //    {
        //        MessageBox.Show("Данные уже есть!!!");
        //    }
        //    //try
        //    //{
        //    //    Doljnost doljnost = (Doljnost)comboBoxDoljnost.SelectedItem;
        //    //    string firstname = textBoxFirstName.Text;
        //    //    string lastname = textBoxLastName.Text;
        //    //    string patronomyc = textBoxPatronomyc.Text;
        //    //    string numberPhone = textBoxPhoneNumber.Text;
        //    //    string dateBirth = dateTimePickerDateBirth.Value.ToShortDateString();
        //    //    var idDoljnost = doljnost.id;
        //    //    string login = textBoxLogin.Text;
        //    //    string password = textBoxPassword.Text;


        //    //    var result = context.Sotrudniki;



        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show("Ошибка: " + ex);
        //    //}
        //    return 0;
        //}


        //private void buttonRegistration_Click(object sender, EventArgs e)
        //{
        //    RegistrMethod();
        //}
    }
}
