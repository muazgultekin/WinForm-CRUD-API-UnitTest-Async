using Employees.Controllers;
using Employees.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, System.EventArgs e)
        {
            // Get All Users
            buttonLoad.Enabled = !buttonLoad.Enabled;
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Task<string> result = employeeRepository.GetUsers(null);
            Root root = JsonConvert.DeserializeObject<Root>(result.Result);
            dataGridViewMain.DataSource = root.data;
            dataGridViewMain.Refresh();
            buttonLoad.Enabled = !buttonLoad.Enabled;
        }

        private void buttonSerch_Click(object sender, System.EventArgs e)
        {
            // Search By Id. We can Improve for each column
            try
            {
                int id = System.Convert.ToInt32(textBoxid.Text);
                EmployeeRepository employeeRepository = new EmployeeRepository();
                Task<string> result = employeeRepository.GetUsers($"?id={id}");
                Root root = JsonConvert.DeserializeObject<Root>(result.Result);
                dataGridViewMain.DataSource = root.data;
                dataGridViewMain.Refresh();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Please Enter Numeric Value", "SEARCH MESSAGE", MessageBoxButtons.OKCancel);
                textBoxid.Clear();
                textBoxid.Focus();
            }
        }
        private void buttonNewUser_Click(object sender, System.EventArgs e)
        {
            // Create Editable Form for New User
            FormEdit formEdit = new FormEdit();
            formEdit.ShowDialog();
        }

        private void dataGridViewMain_DoubleClick(object sender, System.EventArgs e)
        {
           //sender
        }

        private void dataGridViewMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get Clicked Row and show via Editable Form. Instead Of DataGridViewRow we can use DevExpress Ribon to create more user friendly user interface
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[e.RowIndex];
                int id = (int)row.Cells["id"].Value;
                FormEdit formEdit = new FormEdit(id);
                formEdit.ShowDialog();                
            }
        }

        private void buttonExcel_Click(object sender, System.EventArgs e)
        {
            // This is the simplest way. Instead Of we can use CLOSEDXML to create professional excel sheet
            if (dataGridViewMain.Rows.Count == 0) return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)                
            {
                StringBuilder csv = new StringBuilder();
                foreach (DataGridViewRow row in dataGridViewMain.Rows)
                {
                    int id = (int)row.Cells["id"].Value;
                    string name = (string)row.Cells["name"].Value;
                    string email = (string)row.Cells["email"].Value;
                    string gender = (string)row.Cells["gender"].Value;
                    string status = (string)row.Cells["status"].Value;
                    csv.AppendLine($"{id}{';'}{name}{';'}{email}{';'}{gender}{';'}{status}");
                }
                File.WriteAllText(saveFileDialog.FileName, csv.ToString());
            }
        }
    }
}
