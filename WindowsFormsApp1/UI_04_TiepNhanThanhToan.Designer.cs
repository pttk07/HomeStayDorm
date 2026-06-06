namespace WindowsFormsApp1
{
    partial class UI_04_TiepNhanThanhToan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblRequiredAmount = new System.Windows.Forms.Label();
            this.txtRequiredAmount = new System.Windows.Forms.TextBox();
            this.lblReceivedAmount = new System.Windows.Forms.Label();
            this.txtReceivedAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tiếp Nhận Thanh Toán Cọc";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(40, 80);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(102, 16);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Tên / Mã khách:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(210, 77);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(220, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblRequiredAmount
            // 
            this.lblRequiredAmount.AutoSize = true;
            this.lblRequiredAmount.Location = new System.Drawing.Point(40, 120);
            this.lblRequiredAmount.Name = "lblRequiredAmount";
            this.lblRequiredAmount.Size = new System.Drawing.Size(126, 16);
            this.lblRequiredAmount.TabIndex = 3;
            this.lblRequiredAmount.Text = "Số tiền cọc yêu cầu:";
            // 
            // txtRequiredAmount
            // 
            this.txtRequiredAmount.Location = new System.Drawing.Point(210, 117);
            this.txtRequiredAmount.Name = "txtRequiredAmount";
            this.txtRequiredAmount.Size = new System.Drawing.Size(220, 22);
            this.txtRequiredAmount.TabIndex = 4;
            // 
            // lblReceivedAmount
            // 
            this.lblReceivedAmount.AutoSize = true;
            this.lblReceivedAmount.Location = new System.Drawing.Point(40, 160);
            this.lblReceivedAmount.Name = "lblReceivedAmount";
            this.lblReceivedAmount.Size = new System.Drawing.Size(110, 16);
            this.lblReceivedAmount.TabIndex = 5;
            this.lblReceivedAmount.Text = "Số tiền thực nhận:";
            // 
            // txtReceivedAmount
            // 
            this.txtReceivedAmount.Location = new System.Drawing.Point(210, 157);
            this.txtReceivedAmount.Name = "txtReceivedAmount";
            this.txtReceivedAmount.Size = new System.Drawing.Size(220, 22);
            this.txtReceivedAmount.TabIndex = 6;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(40, 200);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(128, 16);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Hình thức thanh toán:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(210, 197);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(220, 24);
            this.cmbPaymentMethod.TabIndex = 8;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(40, 240);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(107, 16);
            this.lblPaymentDate.TabIndex = 9;
            this.lblPaymentDate.Text = "Ngày thanh toán:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.CustomFormat = " ";
            this.dtpPaymentDate.Location = new System.Drawing.Point(210, 237);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(220, 22);
            this.dtpPaymentDate.TabIndex = 10;
            this.dtpPaymentDate.ValueChanged += new System.EventHandler(this.dtpPaymentDate_ValueChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(210, 290);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(220, 35);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Xác nhận thanh toán";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.btnConfirm);
            this.panelContent.Controls.Add(this.dtpPaymentDate);
            this.panelContent.Controls.Add(this.lblPaymentDate);
            this.panelContent.Controls.Add(this.cmbPaymentMethod);
            this.panelContent.Controls.Add(this.lblPaymentMethod);
            this.panelContent.Controls.Add(this.txtReceivedAmount);
            this.panelContent.Controls.Add(this.lblReceivedAmount);
            this.panelContent.Controls.Add(this.txtRequiredAmount);
            this.panelContent.Controls.Add(this.lblRequiredAmount);
            this.panelContent.Controls.Add(this.txtCustomerName);
            this.panelContent.Controls.Add(this.lblCustomerName);
            this.panelContent.Controls.Add(this.lblTitle);
            // 
            // UI_04_TiepNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 406);
            this.Controls.Add(this.panelContent);
            this.Name = "UI_04_TiepNhanThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp Nhận Thanh Toán Cọc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblRequiredAmount;
        private System.Windows.Forms.TextBox txtRequiredAmount;
        private System.Windows.Forms.Label lblReceivedAmount;
        private System.Windows.Forms.TextBox txtReceivedAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panelContent;
    }
}
