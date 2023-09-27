namespace SuongSuon.UI
{
    partial class BC_BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_BC_Doanhthu = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vScrollBar1 = new DevExpress.XtraEditors.VScrollBar();
            this.cbo_BC_Loai_BC = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.cbo_BC_Loai_BC);
            this.panel1.Controls.Add(this.cbo_BC_Doanhthu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 531);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOANH THU CỬA HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "7 ngày qua";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(599, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 531);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOANH THU CỬA HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "DOANH THU CỬA HÀNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "6,383,000";
            // 
            // cbo_BC_Doanhthu
            // 
            this.cbo_BC_Doanhthu.FormattingEnabled = true;
            this.cbo_BC_Doanhthu.Items.AddRange(new object[] {
            "Theo ngày giao hàng",
            "Theo nguồn bán hàng"});
            this.cbo_BC_Doanhthu.Location = new System.Drawing.Point(22, 79);
            this.cbo_BC_Doanhthu.Name = "cbo_BC_Doanhthu";
            this.cbo_BC_Doanhthu.Size = new System.Drawing.Size(158, 24);
            this.cbo_BC_Doanhthu.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(34, 124);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(415, 227);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1135, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(12, 658);
            this.vScrollBar1.TabIndex = 1;
            // 
            // cbo_BC_Loai_BC
            // 
            this.cbo_BC_Loai_BC.FormattingEnabled = true;
            this.cbo_BC_Loai_BC.Items.AddRange(new object[] {
            "Báo cáo bán hàng theo thời gian",
            "Báo cáo bán hàng theo nhân viên",
            "Báo cáo bán hàng theo sản phẩm",
            "báo cáo bán hàng theo đơn hàng",
            "Báo cáo bán hàng theo chi nhánh",
            "Báo cáo bán hàng theo nguồn bán hàng",
            "Báo cáo bán hàng theo khách hàng",
            "Báo cáo bán hàng theo nhóm khách hàng",
            "Báo cáo bán hàng theo thuế",
            ""});
            this.cbo_BC_Loai_BC.Location = new System.Drawing.Point(23, 412);
            this.cbo_BC_Loai_BC.Name = "cbo_BC_Loai_BC";
            this.cbo_BC_Loai_BC.Size = new System.Drawing.Size(488, 24);
            this.cbo_BC_Loai_BC.TabIndex = 2;
            // 
            // BC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BC_BanHang";
            this.Size = new System.Drawing.Size(1147, 658);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbo_BC_Doanhthu;
        private DevExpress.XtraEditors.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox cbo_BC_Loai_BC;
    }
}
