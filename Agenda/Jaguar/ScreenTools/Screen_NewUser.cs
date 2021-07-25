using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaguar.ScreenTools
{
    public partial class Screen_NewUser : UserControl
    {
        public Screen_NewUser()
        {
            InitializeComponent();
        }

        private void ch_PersonCellphone_CheckedChanged(object sender, EventArgs e)
        {
            txt_PersonCellphone.Enabled = !txt_PersonCellphone.Enabled;
            if(txt_PersonCellphone.Enabled == false) txt_PersonCellphone.Clear();
            PhoneChecker();
        }

        private void ch_PersonPhone_CheckedChanged(object sender, EventArgs e)
        {
            txt_PersonPhone.Enabled = !txt_PersonPhone.Enabled;
            if (txt_PersonPhone.Enabled == false) txt_PersonPhone.Clear();
            PhoneChecker();
        }
        void PhoneChecker()
        {
            if (txt_PersonPhone.Enabled == false && txt_PersonCellphone.Enabled == false)
            {
                txt_PersonPhone.Enabled = true;
                ch_PersonPhone.Checked = true;
            }
        }

        private void bt_AddPerson_Click(object sender, EventArgs e)
        {
            Classes.Person p1 = new Classes.Person();
            p1.Name = txt_PersonName.Text;
            p1.Cellphone = txt_PersonCellphone.Text.Replace(" ","");
            p1.Phone = txt_PersonPhone.Text.Replace(" ", "");
            MessageBox.Show(AddChecker(p1),"Inserção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clean();
        }
        string AddChecker(Classes.Person p1)
        { 
            if (p1.Phone.Length < 10 && p1.Phone != "") return "Telefone com informações incorretas";
            if (ch_PersonPhone.Checked&&p1.Phone == "") return "Telefone com informações incorretas";
            if (p1.Cellphone.Length < 11 && p1.Cellphone != "") return "Celular com informações incorretas";
            if (ch_PersonCellphone.Checked && p1.Cellphone == "") return "Celular com informações incorretas";
            if (p1.Name == "" || (p1.Cellphone == null && p1.Phone == null)) return "Informações incorretas";
            Classes.DBase p = new Classes.DBase();
            string sql = "INSERT INTO `person`(`name`, `phone`, `cellphone`) VALUES" +
                "('"+p1.Name+"','"+p1.Phone+"','"+p1.Cellphone+"')";
            string msg = p.DbCommand(sql, p1);
            return msg;
        }
        void Clean()
        {
            txt_PersonName.Text = "";
            txt_PersonCellphone.Text = "";
            txt_PersonPhone.Text = "";
        }
    }
}
