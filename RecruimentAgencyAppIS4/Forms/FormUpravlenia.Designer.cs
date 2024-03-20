namespace RecruimentAgencyAppIS4.Forms
{
    partial class FormUpravlenia
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
            this.buttonDanieOKompanii = new System.Windows.Forms.Button();
            this.buttonUpravleniiVacanciyami = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonAplicant = new System.Windows.Forms.Button();
            this.buttonSmenaParola = new System.Windows.Forms.Button();
            this.buttonVuvodVacancii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDanieOKompanii
            // 
            this.buttonDanieOKompanii.Location = new System.Drawing.Point(242, 95);
            this.buttonDanieOKompanii.Name = "buttonDanieOKompanii";
            this.buttonDanieOKompanii.Size = new System.Drawing.Size(151, 55);
            this.buttonDanieOKompanii.TabIndex = 0;
            this.buttonDanieOKompanii.Text = "Данные о компании";
            this.buttonDanieOKompanii.UseVisualStyleBackColor = true;
            this.buttonDanieOKompanii.Click += new System.EventHandler(this.buttonDanieOKompanii_Click);
            // 
            // buttonUpravleniiVacanciyami
            // 
            this.buttonUpravleniiVacanciyami.Location = new System.Drawing.Point(242, 217);
            this.buttonUpravleniiVacanciyami.Name = "buttonUpravleniiVacanciyami";
            this.buttonUpravleniiVacanciyami.Size = new System.Drawing.Size(151, 55);
            this.buttonUpravleniiVacanciyami.TabIndex = 1;
            this.buttonUpravleniiVacanciyami.Text = "Управление вакансиями";
            this.buttonUpravleniiVacanciyami.UseVisualStyleBackColor = true;
            this.buttonUpravleniiVacanciyami.Click += new System.EventHandler(this.buttonUpravleniiVacanciyami_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(399, 156);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(151, 55);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(399, 217);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(151, 55);
            this.buttonGoBack.TabIndex = 4;
            this.buttonGoBack.Text = "Назад";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonAplicant
            // 
            this.buttonAplicant.Location = new System.Drawing.Point(242, 156);
            this.buttonAplicant.Name = "buttonAplicant";
            this.buttonAplicant.Size = new System.Drawing.Size(151, 55);
            this.buttonAplicant.TabIndex = 5;
            this.buttonAplicant.Text = "Соискатели";
            this.buttonAplicant.UseVisualStyleBackColor = true;
            this.buttonAplicant.Click += new System.EventHandler(this.buttonAplicant_Click);
            // 
            // buttonSmenaParola
            // 
            this.buttonSmenaParola.Location = new System.Drawing.Point(399, 95);
            this.buttonSmenaParola.Name = "buttonSmenaParola";
            this.buttonSmenaParola.Size = new System.Drawing.Size(151, 55);
            this.buttonSmenaParola.TabIndex = 6;
            this.buttonSmenaParola.Text = "Сменить пароль";
            this.buttonSmenaParola.UseVisualStyleBackColor = true;
            this.buttonSmenaParola.Click += new System.EventHandler(this.buttonSmenaParola_Click);
            // 
            // buttonVuvodVacancii
            // 
            this.buttonVuvodVacancii.Location = new System.Drawing.Point(242, 217);
            this.buttonVuvodVacancii.Name = "buttonVuvodVacancii";
            this.buttonVuvodVacancii.Size = new System.Drawing.Size(151, 55);
            this.buttonVuvodVacancii.TabIndex = 2;
            this.buttonVuvodVacancii.Text = "Вывод вакансий";
            this.buttonVuvodVacancii.UseVisualStyleBackColor = true;
            // 
            // FormUpravlenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSmenaParola);
            this.Controls.Add(this.buttonAplicant);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUpravleniiVacanciyami);
            this.Controls.Add(this.buttonDanieOKompanii);
            this.Controls.Add(this.buttonVuvodVacancii);
            this.Name = "FormUpravlenia";
            this.Text = "Управление";
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Button buttonDanieOKompanii;
        protected internal System.Windows.Forms.Button buttonUpravleniiVacanciyami;
        protected internal System.Windows.Forms.Button buttonExit;
        protected internal System.Windows.Forms.Button buttonGoBack;
        protected internal System.Windows.Forms.Button buttonAplicant;
        protected internal System.Windows.Forms.Button buttonSmenaParola;
        protected internal System.Windows.Forms.Button buttonVuvodVacancii;
    }
}