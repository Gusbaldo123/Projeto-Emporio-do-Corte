namespace Jaguar.ScreenTools
{
    partial class Screen_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_Home));
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.pcbox_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Schedule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Welcome.Location = new System.Drawing.Point(215, 333);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(194, 42);
            this.lbl_Welcome.TabIndex = 4;
            this.lbl_Welcome.Text = "Bem vindo";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pcbox_Logo
            // 
            this.pcbox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pcbox_Logo.Image")));
            this.pcbox_Logo.Location = new System.Drawing.Point(24, 29);
            this.pcbox_Logo.Name = "pcbox_Logo";
            this.pcbox_Logo.Size = new System.Drawing.Size(557, 346);
            this.pcbox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbox_Logo.TabIndex = 2;
            this.pcbox_Logo.TabStop = false;
            // 
            // lbl_Schedule
            // 
            this.lbl_Schedule.AutoSize = true;
            this.lbl_Schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Schedule.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Schedule.Location = new System.Drawing.Point(89, 29);
            this.lbl_Schedule.Name = "lbl_Schedule";
            this.lbl_Schedule.Size = new System.Drawing.Size(449, 42);
            this.lbl_Schedule.TabIndex = 5;
            this.lbl_Schedule.Text = "Agenda Empório do Corte";
            this.lbl_Schedule.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Screen_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.lbl_Schedule);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pcbox_Logo);
            this.Name = "Screen_Home";
            this.Size = new System.Drawing.Size(622, 447);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.PictureBox pcbox_Logo;
        private System.Windows.Forms.Label lbl_Schedule;
    }
}
