namespace CarRent
{
    partial class ClientReports
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ContractDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarRentDataSet = new CarRent.CarRentDataSet();
            this.ContractDataTableAdapter = new CarRent.CarRentDataSetTableAdapters.ContractDataTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarRentDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContractDataBindingSource
            // 
            this.ContractDataBindingSource.DataMember = "ContractData";
            this.ContractDataBindingSource.DataSource = this.CarRentDataSet;
            // 
            // CarRentDataSet
            // 
            this.CarRentDataSet.DataSetName = "CarRentDataSet";
            this.CarRentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContractDataTableAdapter
            // 
            this.ContractDataTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 477);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ContractDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarRent.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(755, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ClientReports";
            this.Size = new System.Drawing.Size(755, 477);
            this.Load += new System.EventHandler(this.ClientReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarRentDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ContractDataBindingSource;
        private CarRentDataSet CarRentDataSet;
        private CarRentDataSetTableAdapters.ContractDataTableAdapter ContractDataTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
