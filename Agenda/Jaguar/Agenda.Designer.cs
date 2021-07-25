namespace Jaguar
{
    partial class Form_Home
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.Pn_Home = new System.Windows.Forms.Panel();
            this.bt_Schedule = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Home = new System.Windows.Forms.Button();
            this.bt_AddSchedule = new System.Windows.Forms.Button();
            this.bt_AddPerson = new System.Windows.Forms.Button();
            this.bt_Person = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pn_Home
            // 
            this.Pn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Pn_Home.Location = new System.Drawing.Point(56, 0);
            this.Pn_Home.Name = "Pn_Home";
            this.Pn_Home.Size = new System.Drawing.Size(622, 447);
            this.Pn_Home.TabIndex = 0;
            // 
            // bt_Schedule
            // 
            this.bt_Schedule.BackgroundImage = global::Jaguar.Properties.Resources.bt_Schedule;
            this.bt_Schedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Schedule.Location = new System.Drawing.Point(6, 206);
            this.bt_Schedule.Name = "bt_Schedule";
            this.bt_Schedule.Size = new System.Drawing.Size(49, 47);
            this.bt_Schedule.TabIndex = 1;
            this.bt_Schedule.TabStop = false;
            this.bt_Schedule.UseVisualStyleBackColor = true;
            this.bt_Schedule.Click += new System.EventHandler(this.bt_Schedule_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Exit.BackgroundImage")));
            this.bt_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Location = new System.Drawing.Point(684, 10);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(45, 45);
            this.bt_Exit.TabIndex = 5;
            this.bt_Exit.TabStop = false;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Home
            // 
            this.bt_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Home.BackgroundImage")));
            this.bt_Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Home.Location = new System.Drawing.Point(6, 10);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.Size = new System.Drawing.Size(45, 45);
            this.bt_Home.TabIndex = 4;
            this.bt_Home.TabStop = false;
            this.bt_Home.UseVisualStyleBackColor = true;
            this.bt_Home.Click += new System.EventHandler(this.bt_Home_Click);
            // 
            // bt_AddSchedule
            // 
            this.bt_AddSchedule.BackgroundImage = global::Jaguar.Properties.Resources.bt_AddSchedule;
            this.bt_AddSchedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_AddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddSchedule.Location = new System.Drawing.Point(680, 204);
            this.bt_AddSchedule.Name = "bt_AddSchedule";
            this.bt_AddSchedule.Size = new System.Drawing.Size(49, 49);
            this.bt_AddSchedule.TabIndex = 3;
            this.bt_AddSchedule.TabStop = false;
            this.bt_AddSchedule.UseVisualStyleBackColor = true;
            this.bt_AddSchedule.Click += new System.EventHandler(this.bt_AddSchedule_Click);
            // 
            // bt_AddPerson
            // 
            this.bt_AddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_AddPerson.BackgroundImage")));
            this.bt_AddPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddPerson.Location = new System.Drawing.Point(684, 109);
            this.bt_AddPerson.Name = "bt_AddPerson";
            this.bt_AddPerson.Size = new System.Drawing.Size(45, 45);
            this.bt_AddPerson.TabIndex = 2;
            this.bt_AddPerson.TabStop = false;
            this.bt_AddPerson.Text = ";";
            this.bt_AddPerson.UseVisualStyleBackColor = true;
            this.bt_AddPerson.Click += new System.EventHandler(this.bt_AddPerson_Click);
            // 
            // bt_Person
            // 
            this.bt_Person.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Person.BackgroundImage")));
            this.bt_Person.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bt_Person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Person.Location = new System.Drawing.Point(6, 109);
            this.bt_Person.Name = "bt_Person";
            this.bt_Person.Size = new System.Drawing.Size(45, 45);
            this.bt_Person.TabIndex = 0;
            this.bt_Person.TabStop = false;
            this.bt_Person.UseVisualStyleBackColor = true;
            this.bt_Person.Click += new System.EventHandler(this.bt_Person_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(737, 444);
            this.Controls.Add(this.bt_AddSchedule);
            this.Controls.Add(this.bt_Schedule);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Home);
            this.Controls.Add(this.bt_AddPerson);
            this.Controls.Add(this.bt_Person);
            this.Controls.Add(this.Pn_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_Person;
        private System.Windows.Forms.Button bt_Schedule;
        private System.Windows.Forms.Button bt_AddPerson;
        private System.Windows.Forms.Button bt_AddSchedule;
        private System.Windows.Forms.Button bt_Home;
        private System.Windows.Forms.Button bt_Exit;
        public System.Windows.Forms.Panel Pn_Home;
    }
}

