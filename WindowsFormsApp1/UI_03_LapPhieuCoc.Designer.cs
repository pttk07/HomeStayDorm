namespace WindowsFormsApp1
{
    partial class UI_03_LapPhieuCoc
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
            this.lblSelectedRoom = new System.Windows.Forms.Label();
            this.txtSelectedRoom = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositDate = new System.Windows.Forms.Label();
            this.dtpDepositDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lập Phiếu Đặt Cọc";
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
            this.txtCustomerName.Location = new System.Drawing.Point(190, 77);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblSelectedRoom
            // 
            this.lblSelectedRoom.AutoSize = true;
            this.lblSelectedRoom.Location = new System.Drawing.Point(40, 120);
            this.lblSelectedRoom.Name = "lblSelectedRoom";
            this.lblSelectedRoom.Size = new System.Drawing.Size(81, 16);
            this.lblSelectedRoom.TabIndex = 3;
            this.lblSelectedRoom.Text = "Phòng chọn:";
            // 
            // txtSelectedRoom
            // 
            this.txtSelectedRoom.Location = new System.Drawing.Point(190, 117);
            this.txtSelectedRoom.Name = "txtSelectedRoom";
            this.txtSelectedRoom.Size = new System.Drawing.Size(250, 22);
            this.txtSelectedRoom.TabIndex = 4;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(40, 160);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(76, 16);
            this.lblDepositAmount.TabIndex = 5;
            this.lblDepositAmount.Text = "Số tiền cọc:";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(190, 157);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(250, 22);
            this.txtDepositAmount.TabIndex = 6;
            // 
            // lblDepositDate
            // 
            this.lblDepositDate.AutoSize = true;
            this.lblDepositDate.Location = new System.Drawing.Point(40, 200);
            this.lblDepositDate.Name = "lblDepositDate";
            this.lblDepositDate.Size = new System.Drawing.Size(90, 16);
            this.lblDepositDate.TabIndex = 7;
            this.lblDepositDate.Text = "Ngày đặt cọc:";
            // 
            // dtpDepositDate
            // 
            this.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepositDate.CustomFormat = " ";
            this.dtpDepositDate.Location = new System.Drawing.Point(190, 197);
            this.dtpDepositDate.Name = "dtpDepositDate";
            this.dtpDepositDate.Size = new System.Drawing.Size(250, 22);
            this.dtpDepositDate.TabIndex = 8;
            this.dtpDepositDate.ValueChanged += new System.EventHandler(this.dtpDepositDate_ValueChanged);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(40, 240);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(139, 16);
            this.lblCheckIn.TabIndex = 9;
            this.lblCheckIn.Text = "Thời gian nhận phòng:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.CustomFormat = " ";
            this.dtpCheckIn.Location = new System.Drawing.Point(190, 237);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(250, 22);
            this.dtpCheckIn.TabIndex = 10;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(190, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Xác nhận lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.btnSave);
            this.panelContent.Controls.Add(this.dtpCheckIn);
            this.panelContent.Controls.Add(this.lblCheckIn);
            this.panelContent.Controls.Add(this.dtpDepositDate);
            this.panelContent.Controls.Add(this.lblDepositDate);
            this.panelContent.Controls.Add(this.txtDepositAmount);
            this.panelContent.Controls.Add(this.lblDepositAmount);
            this.panelContent.Controls.Add(this.txtSelectedRoom);
            this.panelContent.Controls.Add(this.lblSelectedRoom);
            this.panelContent.Controls.Add(this.txtCustomerName);
            this.panelContent.Controls.Add(this.lblCustomerName);
            this.panelContent.Controls.Add(this.lblTitle);
            // 
            // UI_03_LapPhieuCoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 360);
            this.Controls.Add(this.panelContent);
            this.Name = "UI_03_LapPhieuCoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Đặt Cọc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblSelectedRoom;
        private System.Windows.Forms.TextBox txtSelectedRoom;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositDate;
        private System.Windows.Forms.DateTimePicker dtpDepositDate;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelContent;
    }
}
