namespace Jaguar.ScreenTools
{
    partial class Screen_NewUser
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_NewUser));
            this.txt_PersonName = new System.Windows.Forms.TextBox();
            this.lbl_PersonName = new System.Windows.Forms.Label();
            this.lbl_PersonPhone = new System.Windows.Forms.Label();
            this.ch_PersonPhone = new System.Windows.Forms.CheckBox();
            this.txt_PersonPhone = new System.Windows.Forms.MaskedTextBox();
            this.txt_PersonCellphone = new System.Windows.Forms.MaskedTextBox();
            this.ch_PersonCellphone = new System.Windows.Forms.CheckBox();
            this.lbl_PersonCellphone = new System.Windows.Forms.Label();
            this.PcBox_Person = new System.Windows.Forms.PictureBox();
            this.bt_AddPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Person)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PersonName
            // 
            this.txt_PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonName.Location = new System.Drawing.Point(190, 134);
            this.txt_PersonName.Name = "txt_PersonName";
            this.txt_PersonName.Size = new System.Drawing.Size(355, 34);
            this.txt_PersonName.TabIndex = 0;
            // 
            // lbl_PersonName
            // 
            this.lbl_PersonName.AutoSize = true;
            this.lbl_PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PersonName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_PersonName.Location = new System.Drawing.Point(58, 134);
            this.lbl_PersonName.Name = "lbl_PersonName";
            this.lbl_PersonName.Size = new System.Drawing.Size(101, 33);
            this.lbl_PersonName.TabIndex = 8;
            this.lbl_PersonName.Text = "Nome:";
            // 
            // lbl_PersonPhone
            // 
            this.lbl_PersonPhone.AutoSize = true;
            this.lbl_PersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PersonPhone.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_PersonPhone.Location = new System.Drawing.Point(43, 206);
            this.lbl_PersonPhone.Name = "lbl_PersonPhone";
            this.lbl_PersonPhone.Size = new System.Drawing.Size(116, 29);
            this.lbl_PersonPhone.TabIndex = 18;
            this.lbl_PersonPhone.Text = "Telefone:";
            // 
            // ch_PersonPhone
            // 
            this.ch_PersonPhone.AutoSize = true;
            this.ch_PersonPhone.Checked = true;
            this.ch_PersonPhone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_PersonPhone.Location = new System.Drawing.Point(169, 218);
            this.ch_PersonPhone.Name = "ch_PersonPhone";
            this.ch_PersonPhone.Size = new System.Drawing.Size(15, 14);
            this.ch_PersonPhone.TabIndex = 1;
            this.ch_PersonPhone.UseVisualStyleBackColor = true;
            this.ch_PersonPhone.CheckedChanged += new System.EventHandler(this.ch_PersonPhone_CheckedChanged);
            // 
            // txt_PersonPhone
            // 
            this.txt_PersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonPhone.Location = new System.Drawing.Point(190, 209);
            this.txt_PersonPhone.Mask = "( 99 ) 9999-9999";
            this.txt_PersonPhone.Name = "txt_PersonPhone";
            this.txt_PersonPhone.Size = new System.Drawing.Size(170, 30);
            this.txt_PersonPhone.TabIndex = 2;
            this.txt_PersonPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_PersonCellphone
            // 
            this.txt_PersonCellphone.Enabled = false;
            this.txt_PersonCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonCellphone.Location = new System.Drawing.Point(190, 277);
            this.txt_PersonCellphone.Mask = "( 99 ) 99999-9999";
            this.txt_PersonCellphone.Name = "txt_PersonCellphone";
            this.txt_PersonCellphone.Size = new System.Drawing.Size(170, 30);
            this.txt_PersonCellphone.TabIndex = 4;
            this.txt_PersonCellphone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ch_PersonCellphone
            // 
            this.ch_PersonCellphone.AutoSize = true;
            this.ch_PersonCellphone.Location = new System.Drawing.Point(169, 286);
            this.ch_PersonCellphone.Name = "ch_PersonCellphone";
            this.ch_PersonCellphone.Size = new System.Drawing.Size(15, 14);
            this.ch_PersonCellphone.TabIndex = 3;
            this.ch_PersonCellphone.UseVisualStyleBackColor = true;
            this.ch_PersonCellphone.CheckedChanged += new System.EventHandler(this.ch_PersonCellphone_CheckedChanged);
            // 
            // lbl_PersonCellphone
            // 
            this.lbl_PersonCellphone.AutoSize = true;
            this.lbl_PersonCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PersonCellphone.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_PersonCellphone.Location = new System.Drawing.Point(63, 277);
            this.lbl_PersonCellphone.Name = "lbl_PersonCellphone";
            this.lbl_PersonCellphone.Size = new System.Drawing.Size(96, 29);
            this.lbl_PersonCellphone.TabIndex = 21;
            this.lbl_PersonCellphone.Text = "Celular:";
            // 
            // PcBox_Person
            // 
            this.PcBox_Person.Image = ((System.Drawing.Image)(resources.GetObject("PcBox_Person.Image")));
            this.PcBox_Person.Location = new System.Drawing.Point(273, 0);
            this.PcBox_Person.Name = "PcBox_Person";
            this.PcBox_Person.Size = new System.Drawing.Size(76, 81);
            this.PcBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBox_Person.TabIndex = 25;
            this.PcBox_Person.TabStop = false;
            // 
            // bt_AddPerson
            // 
            this.bt_AddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_AddPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bt_AddPerson.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_AddPerson.Location = new System.Drawing.Point(353, 380);
            this.bt_AddPerson.Name = "bt_AddPerson";
            this.bt_AddPerson.Size = new System.Drawing.Size(170, 55);
            this.bt_AddPerson.TabIndex = 11;
            this.bt_AddPerson.Text = "Confirma";
            this.bt_AddPerson.UseVisualStyleBackColor = false;
            this.bt_AddPerson.Click += new System.EventHandler(this.bt_AddPerson_Click);
            // 
            // Screen_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.bt_AddPerson);
            this.Controls.Add(this.PcBox_Person);
            this.Controls.Add(this.txt_PersonCellphone);
            this.Controls.Add(this.ch_PersonCellphone);
            this.Controls.Add(this.lbl_PersonCellphone);
            this.Controls.Add(this.txt_PersonPhone);
            this.Controls.Add(this.ch_PersonPhone);
            this.Controls.Add(this.lbl_PersonPhone);
            this.Controls.Add(this.txt_PersonName);
            this.Controls.Add(this.lbl_PersonName);
            this.Name = "Screen_NewUser";
            this.Size = new System.Drawing.Size(622, 447);
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_PersonName;
        private System.Windows.Forms.Label lbl_PersonName;
        private System.Windows.Forms.Label lbl_PersonPhone;
        private System.Windows.Forms.CheckBox ch_PersonPhone;
        private System.Windows.Forms.MaskedTextBox txt_PersonPhone;
        private System.Windows.Forms.MaskedTextBox txt_PersonCellphone;
        private System.Windows.Forms.CheckBox ch_PersonCellphone;
        private System.Windows.Forms.Label lbl_PersonCellphone;
        private System.Windows.Forms.PictureBox PcBox_Person;
        private System.Windows.Forms.Button bt_AddPerson;
    }
}
