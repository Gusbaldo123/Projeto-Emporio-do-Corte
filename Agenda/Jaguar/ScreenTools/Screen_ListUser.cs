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
    public partial class Screen_ListUser : UserControl
    {
        public Screen_ListUser()
        {
            InitializeComponent();
        }
        public bool isEdit = false;
        public int index = 0;
        Classes.Person p1;

        void Enabler()
        {
            isEdit = !isEdit;

            dgv_Select.Enabled = !isEdit;
            bt_Edit.Enabled = !isEdit;
            bt_Remove.Enabled = !isEdit;

            if (dgv_Select.Rows.Count == 0)
            {
                isEdit = false;
                dgv_Select.Enabled = isEdit;
                bt_Edit.Enabled = isEdit;
                bt_Remove.Enabled = isEdit;
            }
            lbl_PersonCellphone.Enabled = isEdit;
            lbl_PersonName.Enabled = isEdit;
            lbl_PersonPhone.Enabled = isEdit;
            txt_PersonName.Enabled = isEdit;
            txt_PersonName.Text = "";
            ch_PersonPhone.Enabled = isEdit;
            ch_PersonPhone.Checked = isEdit;
            txt_PersonPhone.Enabled = isEdit;
            txt_PersonPhone.Text = "";
            ch_PersonCellphone.Enabled = isEdit;
            ch_PersonCellphone.Checked = isEdit;
            txt_PersonCellphone.Enabled = isEdit;
            txt_PersonCellphone.Text = "";
            bt_AddPerson.Enabled = isEdit;
            bt_Cancel.Enabled = isEdit;
        }
        void Edit(Classes.Person p)
        {
            txt_PersonName.Text = p.Name;
            txt_PersonPhone.Text = p.Phone;
            if (p.Phone == "") ch_PersonPhone.Checked = false;
            txt_PersonCellphone.Text = p.Cellphone;
            if (p.Cellphone == "") ch_PersonCellphone.Checked = false;
        }
        void PhoneChecker()
        {
            if (txt_PersonPhone.Enabled == false && txt_PersonCellphone.Enabled == false && isEdit)
            {
                txt_PersonPhone.Enabled = true;
                ch_PersonPhone.Checked = true;
            }
        }
        void EditPerso()
        {
            try
            {
                p1 = new Classes.Person();
                Enabler();
                DataGridViewRow row = dgv_Select.Rows[index];
                Classes.Person p = new Classes.Person();
                p.ID = Convert.ToInt16(row.Cells[0].Value);
                p.Name = row.Cells[2].Value.ToString();
                p.Phone = row.Cells[3].Value.ToString();
                p.Cellphone = row.Cells[4].Value.ToString();
                p1 = p;
                Edit(p);
            }
            catch
            {

            }
        }
        void Check()
        {
            if (dgv_Select.Rows.Count == 0)
            {
                bt_Edit.Enabled = false;
                bt_Remove.Enabled = false;
            }
            else {
                bt_Edit.Enabled = true;
                bt_Remove.Enabled = true;
            }
        }
        string AddChecker(Classes.Person p2)
        {
            if (p2.Phone.Length < 10 && p2.Phone != "") return "Telefone com informações incorretas";
            if (ch_PersonPhone.Checked && p2.Phone == "") return "Telefone com informações incorretas";
            if (p2.Cellphone.Length < 11 && p2.Cellphone != "") return "Celular com informações incorretas";
            if (ch_PersonCellphone.Checked && p2.Cellphone == "") return "Celular com informações incorretas";
            if (p2.Phone == "")
                p2.Phone = null;
            if (p2.Cellphone == "")
                p2.Cellphone = null;
            if (p2.Name == "" || (p2.Cellphone == null && p2.Phone == null)) return "Informações incorretas";
            Classes.DBase p = new Classes.DBase();
            string sql = "UPDATE `person` SET `name`=@name,`phone`=@phone,`cellphone`=@cellphone WHERE id = "+p2.ID;
            string msg = p.DbUpdate(sql, p2);
            return msg;
        }
        void loader()
        {
            if (txt_Search.Text != "")
            {
                string sea = txt_Search.Text;
                Classes.DBase b = new Classes.DBase();
                string sql = "SELECT `id` as ID, `name` as Nome, `phone` as Telefone" +
                    ", `cellphone` as Celular FROM `person` where name like '%" + sea + "%'LIMIT 500";
                DataTable res = b.DbReader(sql);
                dgv_Select.DataSource = res;
            }
            else
            {
                Check();
                Classes.DBase b = new Classes.DBase();
                string sql = "SELECT `id` as ID, `name` as Nome, `phone` as Telefone,`cellphone` as Celular FROM `person` LIMIT 500";
                DataTable res = b.DbReader(sql);
                dgv_Select.DataSource = res;
            }
        }

        private void Screen_ListUser_Load(object sender, EventArgs e)
        {
            loader();
        }

        private void dgv_Select_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditPerso();
        }

        private void bt_AddPerson_Click(object sender, EventArgs e)
        {
            p1.Name = txt_PersonName.Text;
            p1.Phone = txt_PersonPhone.Text;
            p1.Cellphone = txt_PersonCellphone.Text;

            MessageBox.Show(AddChecker(p1));
            p1 = new Classes.Person();
            Enabler();

            loader();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            p1 = new Classes.Person();
            Enabler();
            loader();
        }

        private void ch_PersonPhone_CheckedChanged(object sender, EventArgs e)
        {
            txt_PersonPhone.Enabled = !txt_PersonPhone.Enabled;
            if (txt_PersonPhone.Enabled == false) txt_PersonPhone.Clear();
            PhoneChecker();
        }

        private void ch_PersonCellphone_CheckedChanged(object sender, EventArgs e)
        {
            txt_PersonCellphone.Enabled = !txt_PersonCellphone.Enabled;
            if (txt_PersonCellphone.Enabled == false) txt_PersonCellphone.Clear();
            PhoneChecker();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            loader();
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                p1 = new Classes.Person();
                DataGridViewRow row = dgv_Select.Rows[index];
                Classes.Person p = new Classes.Person();
                p.ID = Convert.ToInt16(row.Cells[0].Value);
                p.Name = row.Cells[2].Value.ToString();
                p1 = p;

                string conf = MessageBox.Show("Certeza que deseja deletar " + p1.Name + "?","Deletar?",MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString();
                if (conf == "Yes")
                {
                    Classes.DBase db = new Classes.DBase();
                    string sql = "DELETE FROM `person` WHERE id ="+p1.ID;
                    string msg = db.DbDel(sql, p1);
                    MessageBox.Show(msg,"Deletar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loader();
                }
            }
            catch
            {

            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            EditPerso();
            loader();
        }

        private void dgv_Select_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgv_Select_DataSourceChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
