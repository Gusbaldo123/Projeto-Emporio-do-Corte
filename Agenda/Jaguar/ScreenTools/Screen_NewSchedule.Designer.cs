using System.Windows.Forms;

namespace Jaguar.ScreenTools
{
    partial class Screen_NewSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_NewSchedule));
            this.bt_AddSche = new System.Windows.Forms.Button();
            this.dt_ScheduleOpen = new System.Windows.Forms.DateTimePicker();
            this.lbl_ScheduleOpen = new System.Windows.Forms.Label();
            this.lbl_ScheduleState = new System.Windows.Forms.Label();
            this.lbl_ScheduleDesc = new System.Windows.Forms.Label();
            this.txt_ScheduleDesc = new System.Windows.Forms.TextBox();
            this.lbl_ScheduleID = new System.Windows.Forms.Label();
            this.txt_ScheduleID = new System.Windows.Forms.TextBox();
            this.lbl_ScheduleClientName = new System.Windows.Forms.Label();
            this.lbl_SchedulePrize = new System.Windows.Forms.Label();
            this.cb_ScheduleState = new System.Windows.Forms.ComboBox();
            this.PcBox_Car = new System.Windows.Forms.PictureBox();
            this.dt_SchedulePrize = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AddSche
            // 
            this.bt_AddSche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bt_AddSche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_AddSche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddSche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bt_AddSche.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_AddSche.Location = new System.Drawing.Point(353, 380);
            this.bt_AddSche.Name = "bt_AddSche";
            this.bt_AddSche.Size = new System.Drawing.Size(170, 55);
            this.bt_AddSche.TabIndex = 12;
            this.bt_AddSche.Text = "Confirma";
            this.bt_AddSche.UseVisualStyleBackColor = false;
            this.bt_AddSche.Click += new System.EventHandler(this.bt_AddSche_Click);
            // 
            // dt_ScheduleOpen
            // 
            this.dt_ScheduleOpen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ScheduleOpen.Location = new System.Drawing.Point(229, 142);
            this.dt_ScheduleOpen.Name = "dt_ScheduleOpen";
            this.dt_ScheduleOpen.Size = new System.Drawing.Size(229, 20);
            this.dt_ScheduleOpen.TabIndex = 27;
            // 
            // lbl_ScheduleOpen
            // 
            this.lbl_ScheduleOpen.AutoSize = true;
            this.lbl_ScheduleOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScheduleOpen.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ScheduleOpen.Location = new System.Drawing.Point(9, 132);
            this.lbl_ScheduleOpen.Name = "lbl_ScheduleOpen";
            this.lbl_ScheduleOpen.Size = new System.Drawing.Size(203, 33);
            this.lbl_ScheduleOpen.TabIndex = 28;
            this.lbl_ScheduleOpen.Text = "Data Abertura:";
            // 
            // lbl_ScheduleState
            // 
            this.lbl_ScheduleState.AutoSize = true;
            this.lbl_ScheduleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScheduleState.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ScheduleState.Location = new System.Drawing.Point(99, 194);
            this.lbl_ScheduleState.Name = "lbl_ScheduleState";
            this.lbl_ScheduleState.Size = new System.Drawing.Size(113, 33);
            this.lbl_ScheduleState.TabIndex = 32;
            this.lbl_ScheduleState.Text = "Estado:";
            // 
            // lbl_ScheduleDesc
            // 
            this.lbl_ScheduleDesc.AutoSize = true;
            this.lbl_ScheduleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScheduleDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ScheduleDesc.Location = new System.Drawing.Point(12, 228);
            this.lbl_ScheduleDesc.Name = "lbl_ScheduleDesc";
            this.lbl_ScheduleDesc.Size = new System.Drawing.Size(127, 29);
            this.lbl_ScheduleDesc.TabIndex = 33;
            this.lbl_ScheduleDesc.Text = "Descrição:";
            // 
            // txt_ScheduleDesc
            // 
            this.txt_ScheduleDesc.Location = new System.Drawing.Point(17, 260);
            this.txt_ScheduleDesc.Multiline = true;
            this.txt_ScheduleDesc.Name = "txt_ScheduleDesc";
            this.txt_ScheduleDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ScheduleDesc.Size = new System.Drawing.Size(506, 114);
            this.txt_ScheduleDesc.TabIndex = 34;
            // 
            // lbl_ScheduleID
            // 
            this.lbl_ScheduleID.AutoSize = true;
            this.lbl_ScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScheduleID.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ScheduleID.Location = new System.Drawing.Point(11, 86);
            this.lbl_ScheduleID.Name = "lbl_ScheduleID";
            this.lbl_ScheduleID.Size = new System.Drawing.Size(191, 33);
            this.lbl_ScheduleID.TabIndex = 35;
            this.lbl_ScheduleID.Text = "ID do Cliente:";
            // 
            // txt_ScheduleID
            // 
            this.txt_ScheduleID.Location = new System.Drawing.Point(229, 99);
            this.txt_ScheduleID.Name = "txt_ScheduleID";
            this.txt_ScheduleID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ScheduleID.Size = new System.Drawing.Size(229, 20);
            this.txt_ScheduleID.TabIndex = 36;
            this.txt_ScheduleID.TextChanged += new System.EventHandler(this.txt_ScheduleID_TextChanged);
            this.txt_ScheduleID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ScheduleID_KeyPress);
            // 
            // lbl_ScheduleClientName
            // 
            this.lbl_ScheduleClientName.AutoSize = true;
            this.lbl_ScheduleClientName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ScheduleClientName.Location = new System.Drawing.Point(229, 126);
            this.lbl_ScheduleClientName.Name = "lbl_ScheduleClientName";
            this.lbl_ScheduleClientName.Size = new System.Drawing.Size(47, 13);
            this.lbl_ScheduleClientName.TabIndex = 37;
            this.lbl_ScheduleClientName.Text = "Nenhum";
            // 
            // lbl_SchedulePrize
            // 
            this.lbl_SchedulePrize.AutoSize = true;
            this.lbl_SchedulePrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SchedulePrize.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_SchedulePrize.Location = new System.Drawing.Point(20, 169);
            this.lbl_SchedulePrize.Name = "lbl_SchedulePrize";
            this.lbl_SchedulePrize.Size = new System.Drawing.Size(192, 29);
            this.lbl_SchedulePrize.TabIndex = 39;
            this.lbl_SchedulePrize.Text = "Data de Entrega:";
            // 
            // cb_ScheduleState
            // 
            this.cb_ScheduleState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ScheduleState.FormattingEnabled = true;
            this.cb_ScheduleState.IntegralHeight = false;
            this.cb_ScheduleState.Items.AddRange(new object[] {
            "Normal",
            "Em pausa",
            "Urgente"});
            this.cb_ScheduleState.Location = new System.Drawing.Point(229, 207);
            this.cb_ScheduleState.Name = "cb_ScheduleState";
            this.cb_ScheduleState.Size = new System.Drawing.Size(121, 21);
            this.cb_ScheduleState.TabIndex = 40;
            // 
            // PcBox_Car
            // 
            this.PcBox_Car.Image = ((System.Drawing.Image)(resources.GetObject("PcBox_Car.Image")));
            this.PcBox_Car.Location = new System.Drawing.Point(273, 0);
            this.PcBox_Car.Name = "PcBox_Car";
            this.PcBox_Car.Size = new System.Drawing.Size(87, 73);
            this.PcBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBox_Car.TabIndex = 26;
            this.PcBox_Car.TabStop = false;
            // 
            // dt_SchedulePrize
            // 
            this.dt_SchedulePrize.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_SchedulePrize.Location = new System.Drawing.Point(229, 175);
            this.dt_SchedulePrize.Name = "dt_SchedulePrize";
            this.dt_SchedulePrize.Size = new System.Drawing.Size(229, 20);
            this.dt_SchedulePrize.TabIndex = 41;
            // 
            // Screen_NewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.dt_SchedulePrize);
            this.Controls.Add(this.cb_ScheduleState);
            this.Controls.Add(this.lbl_SchedulePrize);
            this.Controls.Add(this.lbl_ScheduleClientName);
            this.Controls.Add(this.txt_ScheduleID);
            this.Controls.Add(this.lbl_ScheduleID);
            this.Controls.Add(this.txt_ScheduleDesc);
            this.Controls.Add(this.lbl_ScheduleDesc);
            this.Controls.Add(this.lbl_ScheduleState);
            this.Controls.Add(this.lbl_ScheduleOpen);
            this.Controls.Add(this.dt_ScheduleOpen);
            this.Controls.Add(this.PcBox_Car);
            this.Controls.Add(this.bt_AddSche);
            this.Name = "Screen_NewSchedule";
            this.Size = new System.Drawing.Size(622, 447);
            ((System.ComponentModel.ISupportInitialize)(this.PcBox_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AddSche;
        private System.Windows.Forms.PictureBox PcBox_Car;
        private System.Windows.Forms.DateTimePicker dt_ScheduleOpen;
        private System.Windows.Forms.Label lbl_ScheduleOpen;
        private System.Windows.Forms.Label lbl_ScheduleState;
        private System.Windows.Forms.Label lbl_ScheduleDesc;
        private System.Windows.Forms.TextBox txt_ScheduleDesc;
        private Label lbl_ScheduleID;
        private TextBox txt_ScheduleID;
        private Label lbl_ScheduleClientName;
        private Label lbl_SchedulePrize;
        private ComboBox cb_ScheduleState;
        private DateTimePicker dt_SchedulePrize;
    }
}
