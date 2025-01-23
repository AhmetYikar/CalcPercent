namespace CalcPercent
{
    partial class CalculatePercent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatePercent));
            txtOldValue = new TextBox();
            txtNewValue = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            txtResultName = new TextBox();
            btnSave = new Button();
            dgvResults = new DataGridView();
            btnLoadResults = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // txtOldValue
            // 
            txtOldValue.Font = new Font("Segoe UI", 11F);
            txtOldValue.Location = new Point(36, 38);
            txtOldValue.Name = "txtOldValue";
            txtOldValue.PlaceholderText = "Old value";
            txtOldValue.Size = new Size(150, 37);
            txtOldValue.TabIndex = 0;
            // 
            // txtNewValue
            // 
            txtNewValue.Font = new Font("Segoe UI", 11F);
            txtNewValue.Location = new Point(204, 38);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.PlaceholderText = "New value";
            txtNewValue.Size = new Size(150, 37);
            txtNewValue.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 11F);
            btnCalculate.Location = new Point(393, 38);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 36);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13F);
            lblResult.Location = new Point(604, 38);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(33, 36);
            lblResult.TabIndex = 3;
            lblResult.Text = "...";
            // 
            // txtResultName
            // 
            txtResultName.Font = new Font("Segoe UI", 11F);
            txtResultName.Location = new Point(106, 97);
            txtResultName.Name = "txtResultName";
            txtResultName.PlaceholderText = "Result name";
            txtResultName.Size = new Size(200, 37);
            txtResultName.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.Location = new Point(322, 97);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvResults
            // 
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResults.Location = new Point(12, 200);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvResults.RowHeadersWidth = 62;
            dgvResults.Size = new Size(1159, 385);
            dgvResults.TabIndex = 6;
            // 
            // btnLoadResults
            // 
            btnLoadResults.Location = new Point(901, 154);
            btnLoadResults.Name = "btnLoadResults";
            btnLoadResults.Size = new Size(270, 31);
            btnLoadResults.TabIndex = 7;
            btnLoadResults.Text = "Load Results";
            btnLoadResults.UseVisualStyleBackColor = true;
            btnLoadResults.Click += btnLoadResults_Click;
            // 
            // CalculatePercent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 597);
            Controls.Add(btnLoadResults);
            Controls.Add(dgvResults);
            Controls.Add(btnSave);
            Controls.Add(txtResultName);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtNewValue);
            Controls.Add(txtOldValue);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculatePercent";
            Text = "Calculate Percent";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOldValue;
        private TextBox txtNewValue;
        private Button btnCalculate;
        private Label lblResult;
        private TextBox txtResultName;
        private Button btnSave;
        private DataGridView dgvResults;
        private Button btnLoadResults;
    }
}
