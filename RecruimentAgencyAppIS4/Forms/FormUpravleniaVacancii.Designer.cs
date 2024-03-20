namespace RecruimentAgencyAppIS4.Forms
{
    partial class FormUpravleniaVacancii
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonObnovit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonIzmenit = new System.Windows.Forms.Button();
            this.buttonDobavit = new System.Windows.Forms.Button();
            this.dataGridViewVacansii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacansii)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(648, 391);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 47);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonObnovit
            // 
            this.buttonObnovit.Location = new System.Drawing.Point(450, 391);
            this.buttonObnovit.Name = "buttonObnovit";
            this.buttonObnovit.Size = new System.Drawing.Size(140, 47);
            this.buttonObnovit.TabIndex = 8;
            this.buttonObnovit.Text = "Обновить";
            this.buttonObnovit.UseVisualStyleBackColor = true;
            this.buttonObnovit.Click += new System.EventHandler(this.buttonObnovit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(304, 391);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 47);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonIzmenit
            // 
            this.buttonIzmenit.Location = new System.Drawing.Point(158, 391);
            this.buttonIzmenit.Name = "buttonIzmenit";
            this.buttonIzmenit.Size = new System.Drawing.Size(140, 47);
            this.buttonIzmenit.TabIndex = 7;
            this.buttonIzmenit.Text = "Изменить";
            this.buttonIzmenit.UseVisualStyleBackColor = true;
            this.buttonIzmenit.Click += new System.EventHandler(this.buttonIzmenit_Click);
            // 
            // buttonDobavit
            // 
            this.buttonDobavit.Location = new System.Drawing.Point(12, 391);
            this.buttonDobavit.Name = "buttonDobavit";
            this.buttonDobavit.Size = new System.Drawing.Size(140, 47);
            this.buttonDobavit.TabIndex = 6;
            this.buttonDobavit.Text = "Добавить";
            this.buttonDobavit.UseVisualStyleBackColor = true;
            this.buttonDobavit.Click += new System.EventHandler(this.buttonDobavit_Click);
            // 
            // dataGridViewVacansii
            // 
            this.dataGridViewVacansii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacansii.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVacansii.Name = "dataGridViewVacansii";
            this.dataGridViewVacansii.RowHeadersWidth = 51;
            this.dataGridViewVacansii.RowTemplate.Height = 24;
            this.dataGridViewVacansii.Size = new System.Drawing.Size(776, 373);
            this.dataGridViewVacansii.TabIndex = 5;
            // 
            // FormUpravleniaVacancii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonObnovit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonIzmenit);
            this.Controls.Add(this.buttonDobavit);
            this.Controls.Add(this.dataGridViewVacansii);
            this.Name = "FormUpravleniaVacancii";
            this.Text = "Форма управления вакансиями";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacansii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonObnovit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonIzmenit;
        private System.Windows.Forms.Button buttonDobavit;
        private System.Windows.Forms.DataGridView dataGridViewVacansii;
    }
}