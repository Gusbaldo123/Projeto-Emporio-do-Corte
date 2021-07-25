using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaguar
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            ScreenTools.Screen_Home a = new ScreenTools.Screen_Home();
            Pn_Home.Controls.Clear();
            Pn_Home.Controls.Add(a);
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            string conf = MessageBox.Show("Deseja sair?","Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();
            if (conf == "Yes")
                Application.Exit();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            ScreenTools.Screen_Home a = new ScreenTools.Screen_Home();
            Pn_Home.Controls.Add(a);
        }

        private void bt_AddPerson_Click(object sender, EventArgs e)
        {
            ScreenTools.Screen_NewUser a = new ScreenTools.Screen_NewUser();
            Pn_Home.Controls.Clear();
            Pn_Home.Controls.Add(a);
        }

        private void bt_Person_Click(object sender, EventArgs e)
        {
            ScreenTools.Screen_ListUser a = new ScreenTools.Screen_ListUser();
            Pn_Home.Controls.Clear();
            Pn_Home.Controls.Add(a);
        }

        private void bt_AddSchedule_Click(object sender, EventArgs e)
        {
            ScreenTools.Screen_NewSchedule a = new ScreenTools.Screen_NewSchedule();
            Pn_Home.Controls.Clear();
            Pn_Home.Controls.Add(a);
        }

        private void bt_Schedule_Click(object sender, EventArgs e)
        {
            ScreenTools.Screen_ListSchedule a = new ScreenTools.Screen_ListSchedule();
            Pn_Home.Controls.Clear();
            Pn_Home.Controls.Add(a);
            a.Start();
        }
    }
}
