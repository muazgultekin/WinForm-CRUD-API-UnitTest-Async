
namespace Employees
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttonSerch = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 14);
            this.dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMain.Size = new System.Drawing.Size(776, 380);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellDoubleClick);
            this.dataGridViewMain.DoubleClick += new System.EventHandler(this.dataGridViewMain_DoubleClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(713, 398);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(12, 398);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(75, 23);
            this.buttonNewUser.TabIndex = 2;
            this.buttonNewUser.Text = "New User";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(93, 400);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 3;
            // 
            // buttonSerch
            // 
            this.buttonSerch.Location = new System.Drawing.Point(199, 398);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(98, 23);
            this.buttonSerch.TabIndex = 4;
            this.buttonSerch.Text = "Search By Id";
            this.buttonSerch.UseVisualStyleBackColor = true;
            this.buttonSerch.Click += new System.EventHandler(this.buttonSerch_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(632, 397);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(75, 23);
            this.buttonExcel.TabIndex = 5;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button buttonSerch;
        private System.Windows.Forms.Button buttonExcel;
    }
}

