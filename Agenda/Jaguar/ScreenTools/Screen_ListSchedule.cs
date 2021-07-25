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
    public partial class Screen_ListSchedule : UserControl
    {
        int index = 0, state = 0;
        public bool isEdit = false;
        DataGridView table;
        Classes.Schedule sche;
        public Screen_ListSchedule()
        {
            InitializeComponent();
        }
        public void Start()
        {
            ClosedLoader();
            OpenLoader();
            table = dgv_SelectClose;
            txt_Desc.ScrollBars = ScrollBars.Vertical;
            txt_Desc.AcceptsReturn = true;
            txt_Desc.AcceptsTab = true;
            txt_Desc.WordWrap = true;
        }
        void Enabler()
        {
            dgv_SelectClose.Enabled = !isEdit;
            dgv_SelectOpen.Enabled = !isEdit;

            bt_Edit.Enabled = !isEdit;
            bt_Remove.Enabled = !isEdit;
            bt_Block.Enabled = !isEdit;

            dt_Open.Enabled = isEdit;
            dt_Prize.Enabled = isEdit;
            dt_Close.Enabled = isEdit;
            cb_State.Enabled = isEdit;
            ch_Paid.Enabled = isEdit;
            txt_Desc.Enabled = isEdit;
            lbl_Paid.Enabled = isEdit;
            lbl_State.Enabled = isEdit;
            lbl_Close.Enabled = isEdit;
            lbl_Desc.Enabled = isEdit;
            lbl_Prize.Enabled = isEdit;
            lbl_Open.Enabled = isEdit;
            bt_Cancel.Enabled = isEdit;
            bt_AddPerson.Enabled = isEdit;
        }
        void Paint()
        {
            foreach (DataGridViewRow row in dgv_SelectOpen.Rows)
            {
                var e = row.Cells[2].Value;
                if (e != null)
                {
                    if (e.ToString() == "Urgente")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(137, 30, 43);
                    }
                }
            }
        }
        void Cancel()
        {
            dt_Close.Value = DateTime.Today;
            dt_Open.Value = DateTime.Today;
            dt_Prize.Value = DateTime.Today;
            cb_State.Text = "";
            txt_Desc.Text = "";
            ch_Paid.Checked = false;
            isEdit = false;
            Enabler();
        }
        void EditSche()
        {
            try
            {
                //Enabler();
                DataGridViewRow row = table.Rows[index];
                Classes.Schedule s = new Classes.Schedule();
                if (table == dgv_SelectClose)
                {
                    sche = s;
                    ch_Paid.Enabled = true;
                    dt_Close.Enabled = true;
                    cb_State.Enabled = false;

                    s.ID = Convert.ToInt32(row.Cells[0].Value);
                    s.isPaid = Convert.ToBoolean(row.Cells[2].Value);
                    s.DtOpen = Convert.ToDateTime(row.Cells[3].Value);
                    s.DtClose = Convert.ToDateTime(row.Cells[4].Value);
                    s.DtPrize = Convert.ToDateTime(row.Cells[5].Value);
                    s.Desc = row.Cells[6].Value.ToString();
                }
                else
                {
                    ch_Paid.Enabled = false;
                    dt_Close.Enabled = false;
                    cb_State.Enabled = true;

                    s.ID = Convert.ToInt32(row.Cells[0].Value);
                    s.State = row.Cells[2].Value.ToString();
                    s.DtOpen = Convert.ToDateTime(row.Cells[3].Value);
                    s.DtPrize = Convert.ToDateTime(row.Cells[4].Value);
                    s.Desc = row.Cells[5].Value.ToString();
                }
                sche = s;
                state = 0;
                Edit(s);
            }
            catch
            {
            }
        }
        void BlockSche()
        {
            try
            {
                //Enabler();
                DataGridViewRow row = table.Rows[index];
                Classes.Schedule s = new Classes.Schedule();
                if (table == dgv_SelectOpen)
                {
                    sche = s;
                    lbl_Paid.Enabled = true;
                    ch_Paid.Enabled = true;

                    lbl_Close.Enabled = true;
                    dt_Close.Enabled = true;

                    lbl_State.Enabled = false;
                    cb_State.Enabled = false;

                    s.ID = Convert.ToInt32(row.Cells[0].Value);
                    s.isPaid = false;
                    s.DtOpen = Convert.ToDateTime(row.Cells[3].Value);
                    s.DtClose = Convert.ToDateTime(row.Cells[4].Value);
                    s.DtPrize = DateTime.Today;
                    s.Desc = row.Cells[5].Value.ToString();

                    state = 1;
                }
                else
                {
                    lbl_Paid.Enabled = false;
                    ch_Paid.Enabled = false;

                    lbl_Close.Enabled = false;
                    dt_Close.Enabled = false;

                    lbl_State.Enabled = true;
                    cb_State.Enabled = true;

                    s.ID = Convert.ToInt32(row.Cells[0].Value);
                    s.State = "Normal";
                    s.DtOpen = Convert.ToDateTime(row.Cells[3].Value);
                    s.DtPrize = Convert.ToDateTime(row.Cells[4].Value);
                    s.Desc = row.Cells[5].Value.ToString();


                    state = 2;
                }
                sche = s;
                Edit(s);
            }
            catch
            {
            }
        }
        void Edit(Classes.Schedule s)
        {
            cb_State.Text = s.State;
            ch_Paid.Checked = s.isPaid;
            txt_Desc.Text = s.Desc;
            dt_Open.Value = s.DtOpen;
            dt_Prize.Value = s.DtPrize;
            dt_Close.Value = s.DtClose;
        }
        void OpenLoader()
        {
            if (txt_SearchClose.Text != "")
            {
                //Check();
                Classes.DBase b = new Classes.DBase();
                string sql = "SELECT c.Id as 'ID', p.name as 'Cliente', c.State as 'Importancia', c.DtaAbertura as 'DtAbertura', c.DtaEntrega as 'DtEntrega', c.Descricao as 'Descrição' FROM opensche as c INNER JOIN person AS p ON p.id = c.idperson WHERE idperson = " + txt_SearchClose.Text + " LIMIT 20;";
                DataTable res = b.DbReader(sql);
                dgv_SelectOpen.DataSource = res;
            }
            else
            {
                //Check();
                Classes.DBase b = new Classes.DBase();
                string sql = "SELECT c.Id as 'ID', p.name as 'Cliente', c.State as 'Importancia', " +
                    "c.DtaAbertura as 'DtAbertura', c.DtaEntrega as 'DtEntrega', c.Descricao as 'Descrição' " +
                    "FROM opensche as c INNER JOIN person AS p ON p.id = c.idperson LIMIT 20;";
                DataTable res = b.DbReader(sql);
                dgv_SelectOpen.DataSource = res;
            }
            if (dgv_SelectClose.Rows.Count > 0)
            {
                //Sizer();
                Paint();
            }
        }
        void ClosedLoader()
        {
            if (txt_SearchClose.Text != "")
            {
                Classes.DBase b = new Classes.DBase();
                string sql = "SELECT c.Id as 'ID',p.name as 'Cliente', c.isPago as 'Foi Pago', c.DtaAbertura as 'DtAbertura'," +
                    " c.dtaEntrega as 'DtEntrega', c.DataFechamento as 'DtFechamento', c.Descricao as 'Descrição'" +
                    " FROM `closedsche` as c INNER JOIN person AS p ON p.id = c.idperson WHERE idperson = " + txt_SearchClose.Text + " LIMIT 20";
                DataTable res = b.DbReader(sql);
                dgv_SelectClose.DataSource = res;
            }
            else
            {
                //Check();
                Classes.DBase b = new Classes.DBase();
                string sql = "SELECT c.Id as 'ID',p.name as 'Cliente', c.isPago as 'Foi Pago', c.DtaAbertura as 'DtAbertura'," +
                    " c.dtaEntrega as 'DtEntrega', c.DataFechamento as 'DtFechamento', c.Descricao as 'Descrição'" +
                    " FROM `closedsche` as c INNER JOIN person AS p ON p.id = c.idperson LIMIT 20";
                DataTable res = b.DbReader(sql);
                dgv_SelectClose.DataSource = res;
            }
            if (dgv_SelectClose.Columns.Count > 1)
            {
                //Sizer();
            }
        }
        string AddChecker(Classes.Schedule sc)
        {
            if (table == dgv_SelectOpen)
            {
                Classes.DBase p = new Classes.DBase();
                string sql = "UPDATE opensche SET DtaAbertura = @DtOpen,DtaEntrega = @DtPrize, State = @State, Descricao = @Desc WHERE id = " + sc.ID;
                string msg = p.DbUpdateOpen(sql, sc);
                return msg;
            }
            else
            {
                Classes.DBase p = new Classes.DBase();
                string sql = "UPDATE opensche SET DtaAbertura =@name,DtaEntrega =@name,State =@name,DtaEntrega =@name WHERE id =" + sc.ID;
                string msg = p.DbUpdateClose(sql, sc);
                return msg;
            }
        }
        string OpenCheckerClose(Classes.Schedule sc)
        {
            string GetValue(int index2)
            {
                Classes.DBase b = new Classes.DBase();
                string sql2 = "SELECT * FROM `opensche` WHERE id = " + sc.ID + " LIMIT 20";
                DataTable res = b.DbReader(sql2);
                return res.Rows[0][index2].ToString();
            }
            var sch2 = new Classes.Schedule();
            sch2.ID = int.Parse(GetValue(0));
            sch2.IdPerson = int.Parse(GetValue(1));
            sch2.State = GetValue(2);

            string Op = sc.DtOpen.Year + "-" + sc.DtOpen.Month + "-" + sc.DtOpen.Day;
            string Cl = sc.DtClose.Year + "-" + sc.DtClose.Month + "-" + sc.DtClose.Day;
            string Pr = sc.DtPrize.Year + "-" + sc.DtPrize.Month + "-" + sc.DtPrize.Day;

            sch2.Desc = GetValue(5);

            string sql = "DELETE FROM opensche WHERE Id =" + sc.ID;
            new Classes.DBase().DbDelSche(sql, sc);

            string sql3 = "INSERT INTO `closedsche`(`idperson`, `isPago`, `DtaAbertura`, `DtaEntrega`, `DataFechamento`, `Descricao`)" +
                " VALUES("+sch2.IdPerson + "," +sc.isPaid + ",'"+ Op + "','"+ Pr + "','" + Cl + "','" + sc.Desc + "')";
            string msg = new Classes.DBase().DbScheAdd(sql3);
            return msg;
        }
        string CloseCheckerOpen(Classes.Schedule sc)
        {

            string GetValue(int index2)
            {
                Classes.DBase b = new Classes.DBase();
                string sql2 = "SELECT * FROM `closedsche` WHERE id = " + sc.ID + " LIMIT 20";
                DataTable res = b.DbReader(sql2);
                return res.Rows[0][index2].ToString();
            }
            var sch2 = new Classes.Schedule();
            sch2.IdPerson = int.Parse(GetValue(1));

            string Op = sc.DtOpen.Year + "-" + sc.DtOpen.Month + "-" + sc.DtOpen.Day;
            string Pr = sc.DtPrize.Year + "-" + sc.DtPrize.Month + "-" + sc.DtPrize.Day;

            sch2.Desc = GetValue(5);

            string sql = "DELETE FROM closedsche WHERE Id =" + sc.ID;
            new Classes.DBase().DbDelSche(sql, sc);

            string sql3 = "INSERT INTO `opensche`(`idperson`, `State`, " +
                "`DtaAbertura`, `DtaEntrega`, `Descricao`)" +
                " VALUES(" + sch2.IdPerson + ",'" + sc.State + "','" + Op
                + "','" + Pr + "','" + sc.Desc + "')";
            Clipboard.SetText(sql3);
            string msg = new Classes.DBase().DbScheAdd(sql3);
            return msg;
        }

        private void bt_SearchClose_Click(object sender, EventArgs e)
        {
            ClosedLoader();
            OpenLoader();
            Paint();
        }

        private void dgv_SelectOpen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                isEdit = true;
                Enabler();
                EditSche();
            }
        }

        private void dgv_SelectOpen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            table = dgv_SelectOpen;
        }

        private void dgv_SelectClose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            table = dgv_SelectClose;
        }

        private void dgv_SelectClose_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                isEdit = true;
                Enabler();
                EditSche();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void bt_AddPerson_Click(object sender, EventArgs e)
        {
            sche.DtOpen = dt_Open.Value;
            sche.DtClose = dt_Close.Value;
            sche.DtPrize = dt_Prize.Value;
            sche.State = cb_State.Text;
            sche.isPaid = ch_Paid.Checked;
            sche.Desc = txt_Desc.Text;

            switch (state)
            {
                case 0:
                    MessageBox.Show(AddChecker(sche));
                    break;
                case 1:
                    MessageBox.Show(OpenCheckerClose(sche));
                    break;
                case 2:
                    MessageBox.Show(CloseCheckerOpen(sche));
                    break;
            }
            sche = new Classes.Schedule();

            Enabler();
            OpenLoader();
            ClosedLoader();
            Cancel();
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            Enabler();
            EditSche();
        }

        private void bt_Block_Click(object sender, EventArgs e)
        {
            isEdit = true;
            Enabler();
            cb_State.Enabled = false;
            lbl_State.Enabled = false;

            BlockSche();
        }

        private void bt_Unblock_Click(object sender, EventArgs e)
        {
            isEdit = true;
            Enabler();
            lbl_Close.Enabled = true;
            dt_Close.Enabled = true;
            lbl_Paid.Enabled = true;
            ch_Paid.Enabled = true;

            BlockSche();
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                void Command(DataGridViewRow row)
                {
                    Classes.Schedule sc = new Classes.Schedule();
                    sc.ID = Convert.ToInt16(row.Cells[0].Value);
                    sche = sc;

                    string conf = MessageBox.Show("Certeza que deseja deletar " + sc.ID + "?", "Deletar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (conf == "Yes")
                    {
                        Classes.DBase db = new Classes.DBase();
                        string sql = "";
                        string msg = "";
                        if (table == dgv_SelectOpen)
                            sql = "DELETE FROM opensche WHERE Id =" + sc.ID;
                        else
                            sql = "DELETE FROM closedsche WHERE Id =" + sc.ID;

                        msg = db.DbDelSche(sql, sc);
                        MessageBox.Show(msg, "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClosedLoader();
                        OpenLoader();
                    }
                }

                sche = new Classes.Schedule();
                if (table == dgv_SelectOpen)
                {
                    DataGridViewRow row = dgv_SelectOpen.Rows[index];
                    Command(row);
                }
                else
                {
                    DataGridViewRow row = dgv_SelectClose.Rows[index];
                    Command(row);
                }
            }
            catch
            {

            }
        }

        private void dgv_SelectOpen_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Paint();
        }
    }
}
