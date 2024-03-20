namespace RecruimentAgencyAppIS4.Forms
{
    partial class FormSmenaParolia
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
            this.textBoxStaruiParol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNovuiParol = new System.Windows.Forms.TextBox();
            this.textBoxPovtorNovuiParol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSochranit = new System.Windows.Forms.Button();
            this.buttonOtmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(354, 125);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(235, 22);
            this.textBoxLogin.TabIndex = 26;
            // 
            // textBoxStaruiParol
            // 
            this.textBoxStaruiParol.Location = new System.Drawing.Point(354, 167);
            this.textBoxStaruiParol.Name = "textBoxStaruiParol";
            this.textBoxStaruiParol.Size = new System.Drawing.Size(235, 22);
            this.textBoxStaruiParol.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Логин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Старый пароль";
            // 
            // textBoxNovuiParol
            // 
            this.textBoxNovuiParol.Location = new System.Drawing.Point(354, 210);
            this.textBoxNovuiParol.Name = "textBoxNovuiParol";
            this.textBoxNovuiParol.Size = new System.Drawing.Size(235, 22);
            this.textBoxNovuiParol.TabIndex = 30;
            // 
            // textBoxPovtorNovuiParol
            // 
            this.textBoxPovtorNovuiParol.Location = new System.Drawing.Point(354, 257);
            this.textBoxPovtorNovuiParol.Name = "textBoxPovtorNovuiParol";
            this.textBoxPovtorNovuiParol.Size = new System.Drawing.Size(235, 22);
            this.textBoxPovtorNovuiParol.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Новый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Повтор нового пароля";
            // 
            // buttonSochranit
            // 
            this.buttonSochranit.Location = new System.Drawing.Point(213, 308);
            this.buttonSochranit.Name = "buttonSochranit";
            this.buttonSochranit.Size = new System.Drawing.Size(151, 55);
            this.buttonSochranit.TabIndex = 34;
            this.buttonSochranit.Text = "Сохранить";
            this.buttonSochranit.UseVisualStyleBackColor = true;
            this.buttonSochranit.Click += new System.EventHandler(this.buttonSochranit_Click);
            // 
            // buttonOtmena
            // 
            this.buttonOtmena.Location = new System.Drawing.Point(370, 308);
            this.buttonOtmena.Name = "buttonOtmena";
            this.buttonOtmena.Size = new System.Drawing.Size(151, 55);
            this.buttonOtmena.TabIndex = 35;
            this.buttonOtmena.Text = "Отмена";
            this.buttonOtmena.UseVisualStyleBackColor = true;
            this.buttonOtmena.Click += new System.EventHandler(this.buttonOtmena_Click);
            // 
            // FormSmenaParolia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOtmena);
            this.Controls.Add(this.buttonSochranit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPovtorNovuiParol);
            this.Controls.Add(this.textBoxNovuiParol);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxStaruiParol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "FormSmenaParolia";
            this.Text = "Изменение пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox textBoxLogin;
        protected internal System.Windows.Forms.TextBox textBoxStaruiParol;
        protected internal System.Windows.Forms.TextBox textBoxNovuiParol;
        protected internal System.Windows.Forms.TextBox textBoxPovtorNovuiParol;
        protected internal System.Windows.Forms.Button buttonSochranit;
        protected internal System.Windows.Forms.Button buttonOtmena;
        protected internal System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
    }
}