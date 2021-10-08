
namespace Employees
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.comboBoxstatus = new System.Windows.Forms.ComboBox();
            this.labelstatus = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(41, 12);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(15, 13);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "id";
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(62, 9);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.ReadOnly = true;
            this.textBoxid.Size = new System.Drawing.Size(237, 20);
            this.textBoxid.TabIndex = 0;
            this.textBoxid.Text = "0";            
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(62, 35);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(237, 20);
            this.textBoxname.TabIndex = 1;            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "name";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(62, 61);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(237, 20);
            this.textBoxemail.TabIndex = 2;            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "email";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(62, 141);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "gender";
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBoxgender.Location = new System.Drawing.Point(62, 87);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(237, 21);
            this.comboBoxgender.TabIndex = 3;          
            // 
            // comboBoxstatus
            // 
            this.comboBoxstatus.FormattingEnabled = true;
            this.comboBoxstatus.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.comboBoxstatus.Location = new System.Drawing.Point(62, 114);
            this.comboBoxstatus.Name = "comboBoxstatus";
            this.comboBoxstatus.Size = new System.Drawing.Size(237, 21);
            this.comboBoxstatus.TabIndex = 4;           
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(21, 117);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(35, 13);
            this.labelstatus.TabIndex = 11;
            this.labelstatus.Text = "status";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(143, 141);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(224, 141);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 181);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxstatus);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.labelId);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.ComboBox comboBoxstatus;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}