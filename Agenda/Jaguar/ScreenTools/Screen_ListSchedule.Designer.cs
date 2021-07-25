namespace Jaguar.ScreenTools
{
    partial class Screen_ListSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_ListSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PcBox_Person = new System.Windows.Forms.PictureBox();
            this.dgv_SelectClose = new System.Windows.Forms.DataGridView();
            this.txt_SearchClose = new System.Windows.Forms.TextBox();
            this.bt_SearchClose = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Block = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_AddPerson = new System.Windows.Forms.Button();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.cb_State = new System.Windows.Forms.ComboBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.dt_Prize = new System.Windows.Forms.DateTimePicker();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.dt_Open = new System.Windows.Forms.DateTimePicker();
            this.lbl_Open = new System.Windows.Forms.Label();
            this.ch_Paid = new System.Windows.Forms.CheckBox();
            this.lbl_Paid = new System.Windows.Forms.Label();
            this.dt_Close = new System.Windows.Forms.DateTimePicker();
            this.lbl_Prize = new System.Windows.Forms.Label();
            this.dgv_SelectOpen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // PcBox_Person
            // 
            this.PcBox_Person.Image = ((System.Drawing.Image)(resources.GetObject("PcBox_Person.Image")));
            this.PcBox_Person.Location = new System.Drawing.Point(273, 0);
            this.PcBox_Person.Name = "PcBox_Person";
            this.PcBox_Person.Size = new System.Drawing.Size(76, 81);
            this.PcBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBox_Person.TabIndex = 27;
            this.PcBox_Person.TabStop = false;
            // 
            // dgv_SelectClose
            // 
            this.dgv_SelectClose.AllowUserToAddRows = false;
            this.dgv_SelectClose.AllowUserToDeleteRows = false;
            this.dgv_SelectClose.AllowUserToResizeColumns = false;
            this.dgv_SelectClose.AllowUserToResizeRows = false;
            this.dgv_SelectClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgv_SelectClose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SelectClose.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SelectClose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_SelectClose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SelectClose.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_SelectClose.EnableHeadersVisualStyles = false;
            this.dgv_SelectClose.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgv_SelectClose.Location = new System.Drawing.Point(14, 102);
            this.dgv_SelectClose.Name = "dgv_SelectClose";
            this.dgv_SelectClose.ReadOnly = true;
            this.dgv_SelectClose.RowHeadersVisible = false;
            this.dgv_SelectClose.RowHeadersWidth = 20;
            this.dgv_SelectClose.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_SelectClose.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_SelectClose.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_SelectClose.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SelectClose.Size = new System.Drawing.Size(269, 177);
            this.dgv_SelectClose.TabIndex = 57;
            this.dgv_SelectClose.TabStop = false;
            this.dgv_SelectClose.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectClose_CellClick);
            this.dgv_SelectClose.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectClose_CellDoubleClick);
            // 
            // txt_SearchClose
            // 
            this.txt_SearchClose.Location = new System.Drawing.Point(14, 76);
            this.txt_SearchClose.Name = "txt_SearchClose";
            this.txt_SearchClose.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchClose.TabIndex = 54;
            // 
            // bt_SearchClose
            // 
            this.bt_SearchClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_SearchClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_SearchClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SearchClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchClose.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_SearchClose.Location = new System.Drawing.Point(120, 76);
            this.bt_SearchClose.Name = "bt_SearchClose";
            this.bt_SearchClose.Size = new System.Drawing.Size(21, 20);
            this.bt_SearchClose.TabIndex = 55;
            this.bt_SearchClose.UseVisualStyleBackColor = false;
            this.bt_SearchClose.Click += new System.EventHandler(this.bt_SearchClose_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Edit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Edit.Image")));
            this.bt_Edit.Location = new System.Drawing.Point(291, 137);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(32, 32);
            this.bt_Edit.TabIndex = 60;
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Remove.Image = ((System.Drawing.Image)(resources.GetObject("bt_Remove.Image")));
            this.bt_Remove.Location = new System.Drawing.Point(291, 175);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(32, 32);
            this.bt_Remove.TabIndex = 62;
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Block
            // 
            this.bt_Block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Block.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Block.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Block.Image = ((System.Drawing.Image)(resources.GetObject("bt_Block.Image")));
            this.bt_Block.Location = new System.Drawing.Point(292, 213);
            this.bt_Block.Name = "bt_Block";
            this.bt_Block.Size = new System.Drawing.Size(32, 32);
            this.bt_Block.TabIndex = 63;
            this.bt_Block.UseVisualStyleBackColor = false;
            this.bt_Block.Click += new System.EventHandler(this.bt_Block_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(504, 367);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(95, 37);
            this.bt_Cancel.TabIndex = 95;
            this.bt_Cancel.Text = "Cancela";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_AddPerson
            // 
            this.bt_AddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_AddPerson.Enabled = false;
            this.bt_AddPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddPerson.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_AddPerson.Location = new System.Drawing.Point(504, 410);
            this.bt_AddPerson.Name = "bt_AddPerson";
            this.bt_AddPerson.Size = new System.Drawing.Size(95, 37);
            this.bt_AddPerson.TabIndex = 94;
            this.bt_AddPerson.Text = "Confirma";
            this.bt_AddPerson.UseVisualStyleBackColor = false;
            this.bt_AddPerson.Click += new System.EventHandler(this.bt_AddPerson_Click);
            // 
            // txt_Desc
            // 
            this.txt_Desc.Enabled = false;
            this.txt_Desc.Location = new System.Drawing.Point(14, 367);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(484, 80);
            this.txt_Desc.TabIndex = 93;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Enabled = false;
            this.lbl_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Desc.Location = new System.Drawing.Point(11, 346);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(80, 18);
            this.lbl_Desc.TabIndex = 92;
            this.lbl_Desc.Text = "Descrição:";
            // 
            // cb_State
            // 
            this.cb_State.Enabled = false;
            this.cb_State.FormattingEnabled = true;
            this.cb_State.Items.AddRange(new object[] {
            "Urgente",
            "Normal",
            "Em espera"});
            this.cb_State.Location = new System.Drawing.Point(387, 323);
            this.cb_State.Name = "cb_State";
            this.cb_State.Size = new System.Drawing.Size(100, 21);
            this.cb_State.TabIndex = 91;
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Enabled = false;
            this.lbl_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_State.Location = new System.Drawing.Point(316, 327);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(65, 13);
            this.lbl_State.TabIndex = 90;
            this.lbl_State.Text = "Importancia:";
            // 
            // dt_Prize
            // 
            this.dt_Prize.Enabled = false;
            this.dt_Prize.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Prize.Location = new System.Drawing.Point(77, 323);
            this.dt_Prize.Name = "dt_Prize";
            this.dt_Prize.Size = new System.Drawing.Size(212, 20);
            this.dt_Prize.TabIndex = 89;
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.Enabled = false;
            this.lbl_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Close.Location = new System.Drawing.Point(11, 323);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(63, 18);
            this.lbl_Close.TabIndex = 88;
            this.lbl_Close.Text = "Entrega:";
            // 
            // dt_Open
            // 
            this.dt_Open.Enabled = false;
            this.dt_Open.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Open.Location = new System.Drawing.Point(77, 297);
            this.dt_Open.Name = "dt_Open";
            this.dt_Open.Size = new System.Drawing.Size(212, 20);
            this.dt_Open.TabIndex = 87;
            // 
            // lbl_Open
            // 
            this.lbl_Open.AutoSize = true;
            this.lbl_Open.Enabled = false;
            this.lbl_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Open.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Open.Location = new System.Drawing.Point(11, 297);
            this.lbl_Open.Name = "lbl_Open";
            this.lbl_Open.Size = new System.Drawing.Size(63, 18);
            this.lbl_Open.TabIndex = 86;
            this.lbl_Open.Text = "Abertura";
            // 
            // ch_Paid
            // 
            this.ch_Paid.AutoSize = true;
            this.ch_Paid.Enabled = false;
            this.ch_Paid.Location = new System.Drawing.Point(584, 329);
            this.ch_Paid.Name = "ch_Paid";
            this.ch_Paid.Size = new System.Drawing.Size(15, 14);
            this.ch_Paid.TabIndex = 96;
            this.ch_Paid.UseVisualStyleBackColor = true;
            // 
            // lbl_Paid
            // 
            this.lbl_Paid.AutoSize = true;
            this.lbl_Paid.Enabled = false;
            this.lbl_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Paid.Location = new System.Drawing.Point(493, 325);
            this.lbl_Paid.Name = "lbl_Paid";
            this.lbl_Paid.Size = new System.Drawing.Size(89, 18);
            this.lbl_Paid.TabIndex = 97;
            this.lbl_Paid.Text = "Já foi pago?";
            // 
            // dt_Close
            // 
            this.dt_Close.Enabled = false;
            this.dt_Close.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Close.Location = new System.Drawing.Point(387, 295);
            this.dt_Close.Name = "dt_Close";
            this.dt_Close.Size = new System.Drawing.Size(212, 20);
            this.dt_Close.TabIndex = 99;
            // 
            // lbl_Prize
            // 
            this.lbl_Prize.AutoSize = true;
            this.lbl_Prize.Enabled = false;
            this.lbl_Prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prize.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Prize.Location = new System.Drawing.Point(312, 301);
            this.lbl_Prize.Name = "lbl_Prize";
            this.lbl_Prize.Size = new System.Drawing.Size(69, 13);
            this.lbl_Prize.TabIndex = 98;
            this.lbl_Prize.Text = "Fechamento:";
            // 
            // dgv_SelectOpen
            // 
            this.dgv_SelectOpen.AllowUserToAddRows = false;
            this.dgv_SelectOpen.AllowUserToDeleteRows = false;
            this.dgv_SelectOpen.AllowUserToResizeColumns = false;
            this.dgv_SelectOpen.AllowUserToResizeRows = false;
            this.dgv_SelectOpen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgv_SelectOpen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SelectOpen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SelectOpen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_SelectOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SelectOpen.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_SelectOpen.EnableHeadersVisualStyles = false;
            this.dgv_SelectOpen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgv_SelectOpen.Location = new System.Drawing.Point(330, 102);
            this.dgv_SelectOpen.Name = "dgv_SelectOpen";
            this.dgv_SelectOpen.ReadOnly = true;
            this.dgv_SelectOpen.RowHeadersVisible = false;
            this.dgv_SelectOpen.RowHeadersWidth = 20;
            this.dgv_SelectOpen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_SelectOpen.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_SelectOpen.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_SelectOpen.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SelectOpen.Size = new System.Drawing.Size(269, 177);
            this.dgv_SelectOpen.TabIndex = 100;
            this.dgv_SelectOpen.TabStop = false;
            this.dgv_SelectOpen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectOpen_CellClick);
            this.dgv_SelectOpen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectOpen_CellDoubleClick);
            this.dgv_SelectOpen.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SelectOpen_ColumnHeaderMouseClick);
            // 
            // Screen_ListSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.dgv_SelectOpen);
            this.Controls.Add(this.dt_Close);
            this.Controls.Add(this.lbl_Prize);
            this.Controls.Add(this.lbl_Paid);
            this.Controls.Add(this.ch_Paid);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_AddPerson);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.cb_State);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.dt_Prize);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.dt_Open);
            this.Controls.Add(this.lbl_Open);
            this.Controls.Add(this.bt_Block);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_SearchClose);
            this.Controls.Add(this.dgv_SelectClose);
            this.Controls.Add(this.txt_SearchClose);
            this.Controls.Add(this.PcBox_Person);
            this.Name = "Screen_ListSchedule";
            this.Size = new System.Drawing.Size(622, 447);
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcBox_Person;
        private System.Windows.Forms.DataGridView dgv_SelectClose;
        private System.Windows.Forms.TextBox txt_SearchClose;
        private System.Windows.Forms.Button bt_SearchClose;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Block;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_AddPerson;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.ComboBox cb_State;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.DateTimePicker dt_Prize;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.DateTimePicker dt_Open;
        private System.Windows.Forms.Label lbl_Open;
        private System.Windows.Forms.CheckBox ch_Paid;
        private System.Windows.Forms.Label lbl_Paid;
        private System.Windows.Forms.DateTimePicker dt_Close;
        private System.Windows.Forms.Label lbl_Prize;
        private System.Windows.Forms.DataGridView dgv_SelectOpen;
    }
}
