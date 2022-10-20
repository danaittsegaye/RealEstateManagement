namespace RealEstateManagmentSystem
{
    partial class FormContractsList
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
            this.tableListContracts = new System.Windows.Forms.DataGridView();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feePercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableListContracts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableListContracts
            // 
            this.tableListContracts.AllowUserToAddRows = false;
            this.tableListContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableListContracts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tableListContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableListContracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableListContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableListContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableListContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client,
            this.employee,
            this.contractType,
            this.paymentFrequency,
            this.transactionID,
            this.payment,
            this.feePercentage,
            this.feeAmount,
            this.dateSigned,
            this.startDate,
            this.endDate,
            this.ID});
            this.tableListContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableListContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.tableListContracts.Location = new System.Drawing.Point(0, 0);
            this.tableListContracts.Margin = new System.Windows.Forms.Padding(4);
            this.tableListContracts.Name = "tableListContracts";
            this.tableListContracts.ReadOnly = true;
            this.tableListContracts.RowHeadersWidth = 51;
            this.tableListContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableListContracts.Size = new System.Drawing.Size(800, 450);
            this.tableListContracts.TabIndex = 2;
            // 
            // client
            // 
            this.client.HeaderText = "Client";
            this.client.MinimumWidth = 6;
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // employee
            // 
            this.employee.HeaderText = "Employee";
            this.employee.MinimumWidth = 6;
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            // 
            // contractType
            // 
            this.contractType.HeaderText = "Contract Type";
            this.contractType.MinimumWidth = 6;
            this.contractType.Name = "contractType";
            this.contractType.ReadOnly = true;
            // 
            // paymentFrequency
            // 
            this.paymentFrequency.HeaderText = "Payment Frequency";
            this.paymentFrequency.MinimumWidth = 6;
            this.paymentFrequency.Name = "paymentFrequency";
            this.paymentFrequency.ReadOnly = true;
            // 
            // transactionID
            // 
            this.transactionID.HeaderText = "Transaction ID";
            this.transactionID.MinimumWidth = 6;
            this.transactionID.Name = "transactionID";
            this.transactionID.ReadOnly = true;
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            // 
            // feePercentage
            // 
            this.feePercentage.HeaderText = "Fee (%)";
            this.feePercentage.MinimumWidth = 6;
            this.feePercentage.Name = "feePercentage";
            this.feePercentage.ReadOnly = true;
            // 
            // feeAmount
            // 
            this.feeAmount.HeaderText = "Fee Amount";
            this.feeAmount.MinimumWidth = 6;
            this.feeAmount.Name = "feeAmount";
            this.feeAmount.ReadOnly = true;
            // 
            // dateSigned
            // 
            this.dateSigned.HeaderText = "Date Signed";
            this.dateSigned.MinimumWidth = 6;
            this.dateSigned.Name = "dateSigned";
            this.dateSigned.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start Date";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End Date";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnSearch.Location = new System.Drawing.Point(575, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearch.Location = new System.Drawing.Point(315, 12);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(227, 29);
            this.textBoxSearch.TabIndex = 6;
            // 
            // FormContractsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableListContracts);
            this.Name = "FormContractsList";
            this.Text = "FormContractsList";
            ((System.ComponentModel.ISupportInitialize)(this.tableListContracts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableListContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn feePercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}