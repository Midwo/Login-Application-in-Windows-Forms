namespace Login_Application
{
    partial class all
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agent2214_db1portfolioDataSet = new Login_Application.agent2214_db1portfolioDataSet();
            this.agent2214db1portfolioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logininfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_infoTableAdapter = new Login_Application.agent2214_db1portfolioDataSetTableAdapters.Login_infoTableAdapter();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent2214_db1portfolioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent2214db1portfolioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logininfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logininfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // agent2214_db1portfolioDataSet
            // 
            this.agent2214_db1portfolioDataSet.DataSetName = "agent2214_db1portfolioDataSet";
            this.agent2214_db1portfolioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agent2214db1portfolioDataSetBindingSource
            // 
            this.agent2214db1portfolioDataSetBindingSource.DataSource = this.agent2214_db1portfolioDataSet;
            this.agent2214db1portfolioDataSetBindingSource.Position = 0;
            // 
            // logininfoBindingSource
            // 
            this.logininfoBindingSource.DataMember = "Login_info";
            this.logininfoBindingSource.DataSource = this.agent2214db1portfolioDataSetBindingSource;
            // 
            // login_infoTableAdapter
            // 
            this.login_infoTableAdapter.ClearBeforeFill = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "all";
            this.Text = "all";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.all_FormClosed);
            this.Load += new System.EventHandler(this.all_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent2214_db1portfolioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent2214db1portfolioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logininfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource agent2214db1portfolioDataSetBindingSource;
        private agent2214_db1portfolioDataSet agent2214_db1portfolioDataSet;
        private System.Windows.Forms.BindingSource logininfoBindingSource;
        private agent2214_db1portfolioDataSetTableAdapters.Login_infoTableAdapter login_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}