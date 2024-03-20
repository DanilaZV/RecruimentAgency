namespace RecruimentAgencyAppIS4.Forms
{
    partial class FormRegistrarion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNaimenovanieKompanii = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataRegistracii = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxOpisanieKompanii = new System.Windows.Forms.TextBox();
            this.textBoxRukovoditel = new System.Windows.Forms.TextBox();
            this.textBoxUridicheskiyAdres = new System.Windows.Forms.TextBox();
            this.textBoxOGRN = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxGorod = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataRojenia = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPol = new System.Windows.Forms.ComboBox();
            this.comboBoxGrajdanstvo = new System.Windows.Forms.ComboBox();
            this.textBoxOpitRabotu = new System.Windows.Forms.TextBox();
            this.textBoxNachaloRabotu = new System.Windows.Forms.TextBox();
            this.comboBoxMestoRabotu = new System.Windows.Forms.ComboBox();
            this.textBoxOkonchanieRabotu = new System.Windows.Forms.TextBox();
            this.comboBoxDoljnost = new System.Windows.Forms.ComboBox();
            this.textBoxObyazonosti = new System.Windows.Forms.TextBox();
            this.textBoxInfoOSebe = new System.Windows.Forms.TextBox();
            this.textBoxKluchevieNavuki = new System.Windows.Forms.TextBox();
            this.comboBoxSpecialnost = new System.Windows.Forms.ComboBox();
            this.comboBoxJelaemaiDoljnost = new System.Windows.Forms.ComboBox();
            this.textBoxZarplata = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxKompania = new System.Windows.Forms.GroupBox();
            this.buttonRegRabotodatel = new System.Windows.Forms.Button();
            this.groupBoxSoiskatel = new System.Windows.Forms.GroupBox();
            this.buttonRegSoiskatel = new System.Windows.Forms.Button();
            this.groupBoxAvtorizatia = new System.Windows.Forms.GroupBox();
            this.groupBoxKompania.SuspendLayout();
            this.groupBoxSoiskatel.SuspendLayout();
            this.groupBoxAvtorizatia.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(10, 42);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(193, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(224, 42);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(193, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(23, 42);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(258, 24);
            this.comboBoxRole.TabIndex = 2;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Роль";
            // 
            // comboBoxNaimenovanieKompanii
            // 
            this.comboBoxNaimenovanieKompanii.FormattingEnabled = true;
            this.comboBoxNaimenovanieKompanii.Location = new System.Drawing.Point(203, 55);
            this.comboBoxNaimenovanieKompanii.Name = "comboBoxNaimenovanieKompanii";
            this.comboBoxNaimenovanieKompanii.Size = new System.Drawing.Size(235, 24);
            this.comboBoxNaimenovanieKompanii.TabIndex = 31;
            // 
            // dateTimePickerDataRegistracii
            // 
            this.dateTimePickerDataRegistracii.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerDataRegistracii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataRegistracii.Location = new System.Drawing.Point(203, 190);
            this.dateTimePickerDataRegistracii.Name = "dateTimePickerDataRegistracii";
            this.dateTimePickerDataRegistracii.Size = new System.Drawing.Size(235, 22);
            this.dateTimePickerDataRegistracii.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Описание компании";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Руководитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Юридический адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Дата регистрация";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "ОГРН";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "ИНН";
            // 
            // textBoxOpisanieKompanii
            // 
            this.textBoxOpisanieKompanii.Location = new System.Drawing.Point(203, 329);
            this.textBoxOpisanieKompanii.Multiline = true;
            this.textBoxOpisanieKompanii.Name = "textBoxOpisanieKompanii";
            this.textBoxOpisanieKompanii.Size = new System.Drawing.Size(235, 73);
            this.textBoxOpisanieKompanii.TabIndex = 23;
            // 
            // textBoxRukovoditel
            // 
            this.textBoxRukovoditel.Location = new System.Drawing.Point(203, 279);
            this.textBoxRukovoditel.Name = "textBoxRukovoditel";
            this.textBoxRukovoditel.Size = new System.Drawing.Size(235, 22);
            this.textBoxRukovoditel.TabIndex = 22;
            // 
            // textBoxUridicheskiyAdres
            // 
            this.textBoxUridicheskiyAdres.Location = new System.Drawing.Point(203, 232);
            this.textBoxUridicheskiyAdres.Name = "textBoxUridicheskiyAdres";
            this.textBoxUridicheskiyAdres.Size = new System.Drawing.Size(235, 22);
            this.textBoxUridicheskiyAdres.TabIndex = 21;
            // 
            // textBoxOGRN
            // 
            this.textBoxOGRN.Location = new System.Drawing.Point(203, 136);
            this.textBoxOGRN.Name = "textBoxOGRN";
            this.textBoxOGRN.Size = new System.Drawing.Size(235, 22);
            this.textBoxOGRN.TabIndex = 20;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(203, 94);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(235, 22);
            this.textBoxINN.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Наименование компании";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(180, 28);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(235, 22);
            this.textBoxFIO.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "ФИО";
            // 
            // comboBoxGorod
            // 
            this.comboBoxGorod.FormattingEnabled = true;
            this.comboBoxGorod.Location = new System.Drawing.Point(180, 56);
            this.comboBoxGorod.Name = "comboBoxGorod";
            this.comboBoxGorod.Size = new System.Drawing.Size(235, 24);
            this.comboBoxGorod.TabIndex = 36;
            // 
            // dateTimePickerDataRojenia
            // 
            this.dateTimePickerDataRojenia.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerDataRojenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataRojenia.Location = new System.Drawing.Point(180, 86);
            this.dateTimePickerDataRojenia.Name = "dateTimePickerDataRojenia";
            this.dateTimePickerDataRojenia.Size = new System.Drawing.Size(235, 22);
            this.dateTimePickerDataRojenia.TabIndex = 37;
            // 
            // comboBoxPol
            // 
            this.comboBoxPol.FormattingEnabled = true;
            this.comboBoxPol.Location = new System.Drawing.Point(180, 114);
            this.comboBoxPol.Name = "comboBoxPol";
            this.comboBoxPol.Size = new System.Drawing.Size(235, 24);
            this.comboBoxPol.TabIndex = 38;
            // 
            // comboBoxGrajdanstvo
            // 
            this.comboBoxGrajdanstvo.FormattingEnabled = true;
            this.comboBoxGrajdanstvo.Location = new System.Drawing.Point(180, 144);
            this.comboBoxGrajdanstvo.Name = "comboBoxGrajdanstvo";
            this.comboBoxGrajdanstvo.Size = new System.Drawing.Size(235, 24);
            this.comboBoxGrajdanstvo.TabIndex = 39;
            // 
            // textBoxOpitRabotu
            // 
            this.textBoxOpitRabotu.Location = new System.Drawing.Point(180, 174);
            this.textBoxOpitRabotu.Name = "textBoxOpitRabotu";
            this.textBoxOpitRabotu.Size = new System.Drawing.Size(235, 22);
            this.textBoxOpitRabotu.TabIndex = 40;
            // 
            // textBoxNachaloRabotu
            // 
            this.textBoxNachaloRabotu.Location = new System.Drawing.Point(180, 232);
            this.textBoxNachaloRabotu.Name = "textBoxNachaloRabotu";
            this.textBoxNachaloRabotu.Size = new System.Drawing.Size(235, 22);
            this.textBoxNachaloRabotu.TabIndex = 41;
            // 
            // comboBoxMestoRabotu
            // 
            this.comboBoxMestoRabotu.FormattingEnabled = true;
            this.comboBoxMestoRabotu.Location = new System.Drawing.Point(180, 202);
            this.comboBoxMestoRabotu.Name = "comboBoxMestoRabotu";
            this.comboBoxMestoRabotu.Size = new System.Drawing.Size(235, 24);
            this.comboBoxMestoRabotu.TabIndex = 42;
            // 
            // textBoxOkonchanieRabotu
            // 
            this.textBoxOkonchanieRabotu.Location = new System.Drawing.Point(180, 260);
            this.textBoxOkonchanieRabotu.Name = "textBoxOkonchanieRabotu";
            this.textBoxOkonchanieRabotu.Size = new System.Drawing.Size(235, 22);
            this.textBoxOkonchanieRabotu.TabIndex = 43;
            // 
            // comboBoxDoljnost
            // 
            this.comboBoxDoljnost.FormattingEnabled = true;
            this.comboBoxDoljnost.Location = new System.Drawing.Point(180, 288);
            this.comboBoxDoljnost.Name = "comboBoxDoljnost";
            this.comboBoxDoljnost.Size = new System.Drawing.Size(235, 24);
            this.comboBoxDoljnost.TabIndex = 44;
            // 
            // textBoxObyazonosti
            // 
            this.textBoxObyazonosti.Location = new System.Drawing.Point(180, 321);
            this.textBoxObyazonosti.Multiline = true;
            this.textBoxObyazonosti.Name = "textBoxObyazonosti";
            this.textBoxObyazonosti.Size = new System.Drawing.Size(235, 60);
            this.textBoxObyazonosti.TabIndex = 45;
            // 
            // textBoxInfoOSebe
            // 
            this.textBoxInfoOSebe.Location = new System.Drawing.Point(180, 387);
            this.textBoxInfoOSebe.Multiline = true;
            this.textBoxInfoOSebe.Name = "textBoxInfoOSebe";
            this.textBoxInfoOSebe.Size = new System.Drawing.Size(235, 60);
            this.textBoxInfoOSebe.TabIndex = 46;
            // 
            // textBoxKluchevieNavuki
            // 
            this.textBoxKluchevieNavuki.Location = new System.Drawing.Point(180, 453);
            this.textBoxKluchevieNavuki.Multiline = true;
            this.textBoxKluchevieNavuki.Name = "textBoxKluchevieNavuki";
            this.textBoxKluchevieNavuki.Size = new System.Drawing.Size(235, 60);
            this.textBoxKluchevieNavuki.TabIndex = 47;
            // 
            // comboBoxSpecialnost
            // 
            this.comboBoxSpecialnost.FormattingEnabled = true;
            this.comboBoxSpecialnost.Location = new System.Drawing.Point(180, 522);
            this.comboBoxSpecialnost.Name = "comboBoxSpecialnost";
            this.comboBoxSpecialnost.Size = new System.Drawing.Size(235, 24);
            this.comboBoxSpecialnost.TabIndex = 48;
            // 
            // comboBoxJelaemaiDoljnost
            // 
            this.comboBoxJelaemaiDoljnost.FormattingEnabled = true;
            this.comboBoxJelaemaiDoljnost.Location = new System.Drawing.Point(180, 552);
            this.comboBoxJelaemaiDoljnost.Name = "comboBoxJelaemaiDoljnost";
            this.comboBoxJelaemaiDoljnost.Size = new System.Drawing.Size(235, 24);
            this.comboBoxJelaemaiDoljnost.TabIndex = 49;
            // 
            // textBoxZarplata
            // 
            this.textBoxZarplata.Location = new System.Drawing.Point(180, 582);
            this.textBoxZarplata.Name = "textBoxZarplata";
            this.textBoxZarplata.Size = new System.Drawing.Size(235, 22);
            this.textBoxZarplata.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 51;
            this.label14.Text = "Город";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 16);
            this.label15.TabIndex = 52;
            this.label15.Text = "Дата рождения";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 16);
            this.label16.TabIndex = 53;
            this.label16.Text = "Пол";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 16);
            this.label17.TabIndex = 54;
            this.label17.Text = "Гражданство";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 16);
            this.label18.TabIndex = 55;
            this.label18.Text = "Опыт работы";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 16);
            this.label19.TabIndex = 56;
            this.label19.Text = "Место работы";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 16);
            this.label20.TabIndex = 57;
            this.label20.Text = "Начало работы";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 263);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 16);
            this.label21.TabIndex = 58;
            this.label21.Text = "Окончание работы";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 291);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 16);
            this.label22.TabIndex = 59;
            this.label22.Text = "Должность";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 321);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 16);
            this.label23.TabIndex = 60;
            this.label23.Text = "Обязанности";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 390);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(138, 16);
            this.label24.TabIndex = 61;
            this.label24.Text = "Информацио о себе";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 456);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 16);
            this.label25.TabIndex = 62;
            this.label25.Text = "Ключевые навыки";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 525);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 16);
            this.label26.TabIndex = 63;
            this.label26.Text = "Специальность";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 555);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(149, 16);
            this.label27.TabIndex = 64;
            this.label27.Text = "Желаемая должность";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 585);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 16);
            this.label28.TabIndex = 65;
            this.label28.Text = "Зарплата";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(307, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 57);
            this.buttonBack.TabIndex = 66;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxKompania
            // 
            this.groupBoxKompania.Controls.Add(this.buttonRegRabotodatel);
            this.groupBoxKompania.Controls.Add(this.comboBoxNaimenovanieKompanii);
            this.groupBoxKompania.Controls.Add(this.label10);
            this.groupBoxKompania.Controls.Add(this.textBoxINN);
            this.groupBoxKompania.Controls.Add(this.textBoxOGRN);
            this.groupBoxKompania.Controls.Add(this.textBoxUridicheskiyAdres);
            this.groupBoxKompania.Controls.Add(this.textBoxRukovoditel);
            this.groupBoxKompania.Controls.Add(this.textBoxOpisanieKompanii);
            this.groupBoxKompania.Controls.Add(this.label9);
            this.groupBoxKompania.Controls.Add(this.label8);
            this.groupBoxKompania.Controls.Add(this.label4);
            this.groupBoxKompania.Controls.Add(this.label5);
            this.groupBoxKompania.Controls.Add(this.label6);
            this.groupBoxKompania.Controls.Add(this.label7);
            this.groupBoxKompania.Controls.Add(this.dateTimePickerDataRegistracii);
            this.groupBoxKompania.Location = new System.Drawing.Point(23, 158);
            this.groupBoxKompania.Name = "groupBoxKompania";
            this.groupBoxKompania.Size = new System.Drawing.Size(499, 461);
            this.groupBoxKompania.TabIndex = 67;
            this.groupBoxKompania.TabStop = false;
            this.groupBoxKompania.Text = "Компания";
            // 
            // buttonRegRabotodatel
            // 
            this.buttonRegRabotodatel.Location = new System.Drawing.Point(303, 426);
            this.buttonRegRabotodatel.Name = "buttonRegRabotodatel";
            this.buttonRegRabotodatel.Size = new System.Drawing.Size(190, 29);
            this.buttonRegRabotodatel.TabIndex = 70;
            this.buttonRegRabotodatel.Text = "Зарегистрироваться";
            this.buttonRegRabotodatel.UseVisualStyleBackColor = true;
            this.buttonRegRabotodatel.Click += new System.EventHandler(this.buttonRegRabotodatel_Click);
            // 
            // groupBoxSoiskatel
            // 
            this.groupBoxSoiskatel.Controls.Add(this.buttonRegSoiskatel);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxFIO);
            this.groupBoxSoiskatel.Controls.Add(this.label13);
            this.groupBoxSoiskatel.Controls.Add(this.comboBoxGorod);
            this.groupBoxSoiskatel.Controls.Add(this.label28);
            this.groupBoxSoiskatel.Controls.Add(this.dateTimePickerDataRojenia);
            this.groupBoxSoiskatel.Controls.Add(this.label27);
            this.groupBoxSoiskatel.Controls.Add(this.comboBoxPol);
            this.groupBoxSoiskatel.Controls.Add(this.label26);
            this.groupBoxSoiskatel.Controls.Add(this.comboBoxGrajdanstvo);
            this.groupBoxSoiskatel.Controls.Add(this.label25);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxOpitRabotu);
            this.groupBoxSoiskatel.Controls.Add(this.label24);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxNachaloRabotu);
            this.groupBoxSoiskatel.Controls.Add(this.label23);
            this.groupBoxSoiskatel.Controls.Add(this.comboBoxMestoRabotu);
            this.groupBoxSoiskatel.Controls.Add(this.label22);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxOkonchanieRabotu);
            this.groupBoxSoiskatel.Controls.Add(this.label21);
            this.groupBoxSoiskatel.Controls.Add(this.comboBoxDoljnost);
            this.groupBoxSoiskatel.Controls.Add(this.label20);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxObyazonosti);
            this.groupBoxSoiskatel.Controls.Add(this.label19);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxInfoOSebe);
            this.groupBoxSoiskatel.Controls.Add(this.label18);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxKluchevieNavuki);
            this.groupBoxSoiskatel.Controls.Add(this.label17);
            this.groupBoxSoiskatel.Controls.Add(this.comboBoxSpecialnost);
            this.groupBoxSoiskatel.Controls.Add(this.label16);
            this.groupBoxSoiskatel.Controls.Add(this.comboBoxJelaemaiDoljnost);
            this.groupBoxSoiskatel.Controls.Add(this.label15);
            this.groupBoxSoiskatel.Controls.Add(this.textBoxZarplata);
            this.groupBoxSoiskatel.Controls.Add(this.label14);
            this.groupBoxSoiskatel.Location = new System.Drawing.Point(528, 7);
            this.groupBoxSoiskatel.Name = "groupBoxSoiskatel";
            this.groupBoxSoiskatel.Size = new System.Drawing.Size(429, 646);
            this.groupBoxSoiskatel.TabIndex = 68;
            this.groupBoxSoiskatel.TabStop = false;
            this.groupBoxSoiskatel.Text = "Соискатель";
            // 
            // buttonRegSoiskatel
            // 
            this.buttonRegSoiskatel.Location = new System.Drawing.Point(225, 610);
            this.buttonRegSoiskatel.Name = "buttonRegSoiskatel";
            this.buttonRegSoiskatel.Size = new System.Drawing.Size(190, 29);
            this.buttonRegSoiskatel.TabIndex = 71;
            this.buttonRegSoiskatel.Text = "Зарегистрироваться";
            this.buttonRegSoiskatel.UseVisualStyleBackColor = true;
            this.buttonRegSoiskatel.Click += new System.EventHandler(this.buttonRegSoiskatel_Click);
            // 
            // groupBoxAvtorizatia
            // 
            this.groupBoxAvtorizatia.Controls.Add(this.textBoxPassword);
            this.groupBoxAvtorizatia.Controls.Add(this.textBoxLogin);
            this.groupBoxAvtorizatia.Controls.Add(this.label1);
            this.groupBoxAvtorizatia.Controls.Add(this.label2);
            this.groupBoxAvtorizatia.Location = new System.Drawing.Point(23, 73);
            this.groupBoxAvtorizatia.Name = "groupBoxAvtorizatia";
            this.groupBoxAvtorizatia.Size = new System.Drawing.Size(499, 79);
            this.groupBoxAvtorizatia.TabIndex = 69;
            this.groupBoxAvtorizatia.TabStop = false;
            this.groupBoxAvtorizatia.Text = "Авторизация";
            // 
            // FormRegistrarion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 709);
            this.Controls.Add(this.groupBoxAvtorizatia);
            this.Controls.Add(this.groupBoxSoiskatel);
            this.Controls.Add(this.groupBoxKompania);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRole);
            this.Name = "FormRegistrarion";
            this.Text = "Форма регистрации";
            this.groupBoxKompania.ResumeLayout(false);
            this.groupBoxKompania.PerformLayout();
            this.groupBoxSoiskatel.ResumeLayout(false);
            this.groupBoxSoiskatel.PerformLayout();
            this.groupBoxAvtorizatia.ResumeLayout(false);
            this.groupBoxAvtorizatia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.ComboBox comboBoxNaimenovanieKompanii;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerDataRegistracii;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.TextBox textBoxOpisanieKompanii;
        protected internal System.Windows.Forms.TextBox textBoxRukovoditel;
        protected internal System.Windows.Forms.TextBox textBoxUridicheskiyAdres;
        protected internal System.Windows.Forms.TextBox textBoxOGRN;
        protected internal System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label13;
        protected internal System.Windows.Forms.ComboBox comboBoxGorod;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerDataRojenia;
        protected internal System.Windows.Forms.ComboBox comboBoxPol;
        protected internal System.Windows.Forms.ComboBox comboBoxGrajdanstvo;
        private System.Windows.Forms.TextBox textBoxOpitRabotu;
        private System.Windows.Forms.TextBox textBoxNachaloRabotu;
        protected internal System.Windows.Forms.ComboBox comboBoxMestoRabotu;
        private System.Windows.Forms.TextBox textBoxOkonchanieRabotu;
        protected internal System.Windows.Forms.ComboBox comboBoxDoljnost;
        private System.Windows.Forms.TextBox textBoxObyazonosti;
        private System.Windows.Forms.TextBox textBoxInfoOSebe;
        private System.Windows.Forms.TextBox textBoxKluchevieNavuki;
        protected internal System.Windows.Forms.ComboBox comboBoxSpecialnost;
        protected internal System.Windows.Forms.ComboBox comboBoxJelaemaiDoljnost;
        private System.Windows.Forms.TextBox textBoxZarplata;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxKompania;
        private System.Windows.Forms.GroupBox groupBoxSoiskatel;
        private System.Windows.Forms.GroupBox groupBoxAvtorizatia;
        private System.Windows.Forms.Button buttonRegRabotodatel;
        private System.Windows.Forms.Button buttonRegSoiskatel;
    }
}