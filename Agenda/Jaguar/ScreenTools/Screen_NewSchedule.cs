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
    public partial class Screen_NewSchedule : UserControl
    {
        string Name = "Nenhum";
        public Screen_NewSchedule()
        {
            InitializeComponent();
        }

        private void bt_AddSche_Click(object sender, EventArgs e)
        {
            if (txt_ScheduleID.Text == "")
                MessageBox.Show("Cliente não encontrado", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else try
                {
                    var s = new Classes.Schedule();
                    s.ID = Convert.ToInt32(txt_ScheduleID.Text);
                    s.DtOpen = dt_ScheduleOpen.Value;
                    s.DtPrize = dt_SchedulePrize.Value;
                    s.State = cb_ScheduleState.Text;
                    s.Desc = txt_ScheduleDesc.Text;
                    MessageBox.Show(AddChecker(s), "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
                catch { }
        }
        string AddChecker(Classes.Schedule s)
        {
            if (Name == "Nenhum") return "Cliente não encontrado";
            if (s.State == "") return "Insira a importancia do pedido";
            if (s.Desc == "") return "Insira alguma descrição";
            Classes.DBase p = new Classes.DBase();
            string datePrize = s.DtPrize.Year + "-" + s.DtPrize.Month + "-" + s.DtPrize.Day;
            string dateOpen = s.DtOpen.Year + "-" + s.DtOpen.Month + "-" + s.DtOpen.Day;
            string sql = "INSERT INTO `opensche` (`DtaAbertura`, `state`, `Descricao`, `idperson`, `DtaEntrega`) VALUES " +
                "('" + dateOpen + "','" + s.State + "','" + s.Desc + "'," + s.ID + ",'" + datePrize + "')";
            Clipboard.SetText(sql);
            string msg = p.DbScheAdd(sql);
            return msg;
        }
        void Clean()
        {
            dt_ScheduleOpen.Value = DateTime.Now;
            //ch_ScheduleImportant.Checked = false;
            txt_ScheduleDesc.Text = "";
        }

        private void txt_ScheduleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_ScheduleID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Classes.DBase b = new Classes.DBase();
                string sql = "SELECT `name` FROM `person` where id =" + Convert.ToInt32(txt_ScheduleID.Text) + " LIMIT 1";
                DataTable res = b.DbReader(sql);
                Name = res.Rows[0][0].ToString();
                lbl_ScheduleClientName.Text = res.Rows[0][0].ToString();
            }
            catch 
            { 
                lbl_ScheduleClientName.Text = "Nenhum";
                Name = "Nenhum";
            }
        }
    }
}
