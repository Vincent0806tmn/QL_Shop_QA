
namespace SuongSuon.UI
{
    partial class TaoDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TaoDonHang = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tạo đơn hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(1036, 10);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(118, 39);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TaoDonHang
            // 
            this.btn_TaoDonHang.Location = new System.Drawing.Point(1160, 10);
            this.btn_TaoDonHang.Name = "btn_TaoDonHang";
            this.btn_TaoDonHang.Size = new System.Drawing.Size(118, 39);
            this.btn_TaoDonHang.TabIndex = 6;
            this.btn_TaoDonHang.Text = "Tạo đơn hàng";
            this.btn_TaoDonHang.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_TaoDonHang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label1);
            this.Name = "TaoDonHang";
            this.Size = new System.Drawing.Size(1291, 674);
            this.Load += new System.EventHandler(this.TaoDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_TaoDonHang;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private System.Windows.Forms.Label label1;
    }
}
