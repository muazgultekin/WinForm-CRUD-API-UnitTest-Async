using Employees.Controllers;
using Employees.Models;
using Employees.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Employees
{
    public partial class FormEdit : Form
    {
        public int id { get; set; }
        public FormEdit()
        {            
            InitializeComponent();
            buttonUpdate.Enabled = false;
            comboBoxstatus.SelectedIndex = 0;
            comboBoxstatus.Enabled = false;
        }

        public FormEdit(int id)
        {
            InitializeComponent();
            this.id = id;
            buttonCreate.Enabled = false;
            EmployeeRepository employeeRepository = new EmployeeRepository();

            Root root = JsonConvert.DeserializeObject<Root>(employeeRepository.GetUsers($"?id={id}").Result);
            textBoxid.Text = root.data[0].id.ToString();
            textBoxname.Text = root.data[0].name;
            textBoxemail.Text = root.data[0].email;
            comboBoxgender.Text = root.data[0].gender;
            comboBoxstatus.Text = root.data[0].status;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            PostOrTup(MethodType.POST);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            PostOrTup(MethodType.PUT);
        }

        private void PostOrTup(MethodType methodType)
        {
            if (string.IsNullOrWhiteSpace(textBoxname.Text))
            {
                MessageBox.Show("name is not be emply", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxemail.Text))
            {
                MessageBox.Show("email is not be emply", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxgender.SelectedIndex < 0)
            {
                MessageBox.Show("gender is not be emply", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Root root = new Root();
            root.data = new List<Personel>();
            root.data.Add(new Personel
            {
                id = Convert.ToInt32(textBoxid.Text),
                name = textBoxname.Text,
                email = textBoxemail.Text,
                gender = comboBoxgender.Text,
                status = comboBoxstatus.Text
            });

            EmployeeRepository employeeRepository = new Controllers.EmployeeRepository();
            SetRoot setRoot = JsonConvert.DeserializeObject<SetRoot>(employeeRepository.PostPutUsers(methodType, root).Result);
            string messageForm = string.Empty;
            string messageName = string.Empty;
            if (setRoot.code == (int)Helper.OperationType.POST || setRoot.code == (int)Helper.OperationType.EDIT)
            {
                if (setRoot.data != null)
                {
                    textBoxid.Text = setRoot.data.id.ToString();
                    textBoxname.Text = setRoot.data.name;
                    textBoxemail.Text = setRoot.data.email;
                    comboBoxgender.Text = setRoot.data.gender;
                    comboBoxstatus.Text = setRoot.data.status;
                }
                buttonCreate.Enabled = false;
                buttonUpdate.Enabled = true;

                if(setRoot.code == (int)Helper.OperationType.POST){
                    messageForm = "CREATE EMPLOYEE";
                    messageName = "Employee is Created Successfully  Employee ID = " + setRoot.data.id.ToString(); 
                }
                else
                {
                    messageForm = "UPDATE EMPLOYEE";
                    messageName = "Employee is Updated Successfully  Employee ID = " + setRoot.data.id.ToString();
                }

                DialogResult result = MessageBox.Show(messageName, messageForm, MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Employee is not Posted or Updated", "Create User", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string messageForm = string.Empty;
            string messageName = string.Empty;
            EmployeeRepository employeeRepository = new EmployeeRepository();
            SetRoot setRoot = JsonConvert.DeserializeObject<SetRoot>(employeeRepository.DeleteUsers(textBoxid.Text).Result);
            if (setRoot.code == (int)Helper.OperationType.DELETE)
            {
                messageForm = "DELETE EMPLOYEE";
                messageName = "User is DELETED Successfully  Employee ID = " + textBoxid.Text;
            }
            else
            {
                messageForm = "DELETE EMPLOYEE";
                messageName = "An Error Occured in Deleteing Employee  Employee ID = " + textBoxid.Text;
            }
            DialogResult result = MessageBox.Show(messageName, messageForm, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }        
    }
}
