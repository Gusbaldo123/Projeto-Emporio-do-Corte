namespace Jaguar.ScreenTools
{
    partial class Screen_ListUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_ListUser));
            this.dgv_Select = new System.Windows.Forms.DataGridView();
            this.PcBox_Person = new System.Windows.Forms.PictureBox();
            this.bt_AddPerson = new System.Windows.Forms.Button();
            this.txt_PersonCellphone = new System.Windows.Forms.MaskedTextBox();
            this.ch_PersonCellphone = new System.Windows.Forms.CheckBox();
            this.lbl_PersonCellphone = new System.Windows.Forms.Label();
            this.txt_PersonPhone = new System.Windows.Forms.MaskedTextBox();
            this.ch_PersonPhone = new System.Windows.Forms.CheckBox();
            this.lbl_PersonPhone = new System.Windows.Forms.Label();
            this.txt_PersonName = new System.Windows.Forms.TextBox();
            this.lbl_PersonName = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Person)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Select
            // 
            this.dgv_Select.AllowUserToAddRows = false;
            this.dgv_Select.AllowUserToDeleteRows = false;
            this.dgv_Select.AllowUserToResizeColumns = false;
            this.dgv_Select.AllowUserToResizeRows = false;
            this.dgv_Select.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgv_Select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Select.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Select.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Select.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Select.EnableHeadersVisualStyles = false;
            this.dgv_Select.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgv_Select.Location = new System.Drawing.Point(14, 102);
            this.dgv_Select.Name = "dgv_Select";
            this.dgv_Select.ReadOnly = true;
            this.dgv_Select.RowHeadersVisible = false;
            this.dgv_Select.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Select.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Select.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_Select.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Select.Size = new System.Drawing.Size(585, 218);
            this.dgv_Select.TabIndex = 1;
            this.dgv_Select.TabStop = false;
            this.dgv_Select.DataSourceChanged += new System.EventHandler(this.dgv_Select_DataSourceChanged);
            this.dgv_Select.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Select_CellClick);
            this.dgv_Select.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Select_CellDoubleClick);
            // 
            // PcBox_Person
            // 
            this.PcBox_Person.Image = ((System.Drawing.Image)(resources.GetObject("PcBox_Person.Image")));
            this.PcBox_Person.Location = new System.Drawing.Point(273, 0);
            this.PcBox_Person.Name = "PcBox_Person";
            this.PcBox_Person.Size = new System.Drawing.Size(76, 81);
            this.PcBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBox_Person.TabIndex = 26;
            this.PcBox_Person.TabStop = false;
            // 
            // bt_AddPerson
            // 
            this.bt_AddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_AddPerson.Enabled = false;
            this.bt_AddPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddPerson.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_AddPerson.Location = new System.Drawing.Point(504, 397);
            this.bt_AddPerson.Name = "bt_AddPerson";
            this.bt_AddPerson.Size = new System.Drawing.Size(95, 37);
            this.bt_AddPerson.TabIndex = 12;
            this.bt_AddPerson.Text = "Confirma";
            this.bt_AddPerson.UseVisualStyleBackColor = false;
            this.bt_AddPerson.Click += new System.EventHandler(this.bt_AddPerson_Click);
            // 
            // txt_PersonCellphone
            // 
            this.txt_PersonCellphone.Enabled = false;
            this.txt_PersonCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonCellphone.Location = new System.Drawing.Point(101, 406);
            this.txt_PersonCellphone.Mask = "( 99 ) 99999-9999";
            this.txt_PersonCellphone.Name = "txt_PersonCellphone";
            this.txt_PersonCellphone.Size = new System.Drawing.Size(107, 18);
            this.txt_PersonCellphone.TabIndex = 6;
            this.txt_PersonCellphone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ch_PersonCellphone
            // 
            this.ch_PersonCellphone.AutoSize = true;
            this.ch_PersonCellphone.Enabled = false;
            this.ch_PersonCellphone.Location = new System.Drawing.Point(80, 410);
            this.ch_PersonCellphone.Name = "ch_PersonCellphone";
            this.ch_PersonCellphone.Size = new System.Drawing.Size(15, 14);
            this.ch_PersonCellphone.TabIndex = 5;
            this.ch_PersonCellphone.UseVisualStyleBackColor = true;
            this.ch_PersonCellphone.CheckedChanged += new System.EventHandler(this.ch_PersonCellphone_CheckedChanged);
            // 
            // lbl_PersonCellphone
            // 
            this.lbl_PersonCellphone.AutoSize = true;
            this.lbl_PersonCellphone.Enabled = false;
            this.lbl_PersonCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PersonCellphone.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_PersonCellphone.Location = new System.Drawing.Point(14, 408);
            this.lbl_PersonCellphone.Name = "lbl_PersonCellphone";
            this.lbl_PersonCellphone.Size = new System.Drawing.Size(49, 15);
            this.lbl_PersonCellphone.TabIndex = 42;
            this.lbl_PersonCellphone.Text = "Celular:";
            // 
            // txt_PersonPhone
            // 
            this.txt_PersonPhone.Enabled = false;
            this.txt_PersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonPhone.Location = new System.Drawing.Point(101, 386);
            this.txt_PersonPhone.Mask = "( 99 ) 9999-9999";
            this.txt_PersonPhone.Name = "txt_PersonPhone";
            this.txt_PersonPhone.Size = new System.Drawing.Size(107, 18);
            this.txt_PersonPhone.TabIndex = 3;
            this.txt_PersonPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ch_PersonPhone
            // 
            this.ch_PersonPhone.AutoSize = true;
            this.ch_PersonPhone.Enabled = false;
            this.ch_PersonPhone.Location = new System.Drawing.Point(80, 388);
            this.ch_PersonPhone.Name = "ch_PersonPhone";
            this.ch_PersonPhone.Size = new System.Drawing.Size(15, 14);
            this.ch_PersonPhone.TabIndex = 2;
            this.ch_PersonPhone.UseVisualStyleBackColor = true;
            this.ch_PersonPhone.CheckedChanged += new System.EventHandler(this.ch_PersonPhone_CheckedChanged);
            // 
            // lbl_PersonPhone
            // 
            this.lbl_PersonPhone.AutoSize = true;
            this.lbl_PersonPhone.Enabled = false;
            this.lbl_PersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PersonPhone.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_PersonPhone.Location = new System.Drawing.Point(14, 386);
            this.lbl_PersonPhone.Name = "lbl_PersonPhone";
            this.lbl_PersonPhone.Size = new System.Drawing.Size(58, 15);
            this.lbl_PersonPhone.TabIndex = 39;
            this.lbl_PersonPhone.Text = "Telefone:";
            // 
            // txt_PersonName
            // 
            this.txt_PersonName.Enabled = false;
            this.txt_PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonName.Location = new System.Drawing.Point(80, 353);
            this.txt_PersonName.Name = "txt_PersonName";
            this.txt_PersonName.Size = new System.Drawing.Size(316, 20);
            this.txt_PersonName.TabIndex = 1;
            // 
            // lbl_PersonName
            // 
            this.lbl_PersonName.AutoSize = true;
            this.lbl_PersonName.Enabled = false;
            this.lbl_PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PersonName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_PersonName.Location = new System.Drawing.Point(14, 353);
            this.lbl_PersonName.Name = "lbl_PersonName";
            this.lbl_PersonName.Size = new System.Drawing.Size(53, 18);
            this.lbl_PersonName.TabIndex = 30;
            this.lbl_PersonName.Text = "Nome:";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(504, 354);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(95, 37);
            this.bt_Cancel.TabIndex = 48;
            this.bt_Cancel.Text = "Cancela";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(14, 76);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(100, 20);
            this.txt_Search.TabIndex = 49;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Search.Location = new System.Drawing.Point(120, 76);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(21, 20);
            this.bt_Search.TabIndex = 50;
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Edit.Enabled = false;
            this.bt_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Edit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Edit.Image")));
            this.bt_Edit.Location = new System.Drawing.Point(567, 64);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(32, 32);
            this.bt_Edit.TabIndex = 51;
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Remove.Enabled = false;
            this.bt_Remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Remove.Image = ((System.Drawing.Image)(resources.GetObject("bt_Remove.Image")));
            this.bt_Remove.Location = new System.Drawing.Point(529, 64);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(32, 32);
            this.bt_Remove.TabIndex = 53;
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // Screen_ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_AddPerson);
            this.Controls.Add(this.txt_PersonCellphone);
            this.Controls.Add(this.ch_PersonCellphone);
            this.Controls.Add(this.lbl_PersonCellphone);
            this.Controls.Add(this.txt_PersonPhone);
            this.Controls.Add(this.ch_PersonPhone);
            this.Controls.Add(this.lbl_PersonPhone);
            this.Controls.Add(this.txt_PersonName);
            this.Controls.Add(this.lbl_PersonName);
            this.Controls.Add(this.PcBox_Person);
            this.Controls.Add(this.dgv_Select);
            this.Name = "Screen_ListUser";
            this.Size = new System.Drawing.Size(622, 447);
            this.Load += new System.EventHandler(this.Screen_ListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Select;
        private System.Windows.Forms.PictureBox PcBox_Person;
        private System.Windows.Forms.Button bt_AddPerson;
        private System.Windows.Forms.MaskedTextBox txt_PersonCellphone;
        private System.Windows.Forms.CheckBox ch_PersonCellphone;
        private System.Windows.Forms.Label lbl_PersonCellphone;
        private System.Windows.Forms.MaskedTextBox txt_PersonPhone;
        private System.Windows.Forms.CheckBox ch_PersonPhone;
        private System.Windows.Forms.Label lbl_PersonPhone;
        private System.Windows.Forms.TextBox txt_PersonName;
        private System.Windows.Forms.Label lbl_PersonName;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Remove;
    }
}
