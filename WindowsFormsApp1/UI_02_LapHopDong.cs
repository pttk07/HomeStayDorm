using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_02_LapHopDong : Form
    {
        private Label lblTitle;
        private Label lblDepositCode;
        private TextBox txtDepositCode;
        private Button btnSearchDeposit;
        
        private GroupBox gbContractInfo;
        private Label lblContractCode;
        private TextBox txtContractCode;
        private Label lblCustomerInfo;
        private TextBox txtCustomerInfo;
        
        private DataGridView dgvRooms; // Thêm bảng dgvRooms
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colBedPosition;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStatus;
        
        private Label lblDuration;
        private TextBox txtDuration;
        private Label lblTotalCost;
        private TextBox txtTotalCost;
        private Label lblTerms;
        private TextBox txtTerms;
        
        private Button btnCreateContract;
        private Panel panelContent;

        public UI_02_LapHopDong()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepositCode = new System.Windows.Forms.Label();
            this.txtDepositCode = new System.Windows.Forms.TextBox();
            this.btnSearchDeposit = new System.Windows.Forms.Button();
            this.gbContractInfo = new System.Windows.Forms.GroupBox();
            this.lblContractCode = new System.Windows.Forms.Label();
            this.txtContractCode = new System.Windows.Forms.TextBox();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBedPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTerms = new System.Windows.Forms.Label();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.btnCreateContract = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.gbContractInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP HỢP ĐỒNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepositCode
            // 
            this.lblDepositCode.AutoSize = true;
            this.lblDepositCode.Location = new System.Drawing.Point(30, 70);
            this.lblDepositCode.Name = "lblDepositCode";
            this.lblDepositCode.Size = new System.Drawing.Size(112, 16);
            this.lblDepositCode.TabIndex = 1;
            this.lblDepositCode.Text = "Mã phiếu đặt cọc:";
            // 
            // txtDepositCode
            // 
            this.txtDepositCode.Location = new System.Drawing.Point(160, 67);
            this.txtDepositCode.Name = "txtDepositCode";
            this.txtDepositCode.Size = new System.Drawing.Size(200, 22);
            this.txtDepositCode.TabIndex = 2;
            // 
            // btnSearchDeposit
            // 
            this.btnSearchDeposit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDeposit.ForeColor = System.Drawing.Color.White;
            this.btnSearchDeposit.Location = new System.Drawing.Point(380, 65);
            this.btnSearchDeposit.Name = "btnSearchDeposit";
            this.btnSearchDeposit.Size = new System.Drawing.Size(150, 30);
            this.btnSearchDeposit.TabIndex = 3;
            this.btnSearchDeposit.Text = "Tra cứu phiếu cọc";
            this.btnSearchDeposit.UseVisualStyleBackColor = false;
            this.btnSearchDeposit.Click += new System.EventHandler(this.btnSearchDeposit_Click);
            // 
            // gbContractInfo
            // 
            this.gbContractInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContractInfo.Controls.Add(this.lblContractCode);
            this.gbContractInfo.Controls.Add(this.txtContractCode);
            this.gbContractInfo.Controls.Add(this.lblCustomerInfo);
            this.gbContractInfo.Controls.Add(this.txtCustomerInfo);
            this.gbContractInfo.Controls.Add(this.dgvRooms);
            this.gbContractInfo.Controls.Add(this.lblDuration);
            this.gbContractInfo.Controls.Add(this.txtDuration);
            this.gbContractInfo.Controls.Add(this.lblTotalCost);
            this.gbContractInfo.Controls.Add(this.txtTotalCost);
            this.gbContractInfo.Controls.Add(this.lblTerms);
            this.gbContractInfo.Controls.Add(this.txtTerms);
            this.gbContractInfo.Location = new System.Drawing.Point(30, 110);
            this.gbContractInfo.Name = "gbContractInfo";
            this.gbContractInfo.Size = new System.Drawing.Size(740, 410);
            this.gbContractInfo.TabIndex = 4;
            this.gbContractInfo.TabStop = false;
            this.gbContractInfo.Text = "Thông tin hợp đồng";
            // 
            // lblContractCode
            // 
            this.lblContractCode.AutoSize = true;
            this.lblContractCode.Location = new System.Drawing.Point(20, 40);
            this.lblContractCode.Name = "lblContractCode";
            this.lblContractCode.Size = new System.Drawing.Size(89, 16);
            this.lblContractCode.TabIndex = 0;
            this.lblContractCode.Text = "Mã hợp đồng:";
            // 
            // txtContractCode
            // 
            this.txtContractCode.BackColor = System.Drawing.Color.White;
            this.txtContractCode.Location = new System.Drawing.Point(150, 37);
            this.txtContractCode.Name = "txtContractCode";
            this.txtContractCode.ReadOnly = true;
            this.txtContractCode.Size = new System.Drawing.Size(200, 22);
            this.txtContractCode.TabIndex = 1;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Location = new System.Drawing.Point(20, 80);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(80, 16);
            this.lblCustomerInfo.TabIndex = 2;
            this.lblCustomerInfo.Text = "Khách hàng:";
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.BackColor = System.Drawing.Color.White;
            this.txtCustomerInfo.Location = new System.Drawing.Point(150, 77);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.ReadOnly = true;
            this.txtCustomerInfo.Size = new System.Drawing.Size(560, 22);
            this.txtCustomerInfo.TabIndex = 3;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomNumber,
            this.colBedPosition,
            this.colPrice,
            this.colStatus});
            this.dgvRooms.Location = new System.Drawing.Point(20, 117);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(690, 100);
            this.dgvRooms.TabIndex = 4;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.HeaderText = "Số phòng";
            this.colRoomNumber.MinimumWidth = 6;
            this.colRoomNumber.Name = "colRoomNumber";
            this.colRoomNumber.ReadOnly = true;
            // 
            // colBedPosition
            // 
            this.colBedPosition.HeaderText = "Vị trí giường";
            this.colBedPosition.MinimumWidth = 6;
            this.colBedPosition.Name = "colBedPosition";
            this.colBedPosition.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái hiện tại";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(20, 230);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(94, 16);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Thời gian thuê:";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.Location = new System.Drawing.Point(150, 227);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(560, 22);
            this.txtDuration.TabIndex = 7;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(20, 270);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(50, 16);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Chi phí:";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.Color.White;
            this.txtTotalCost.Location = new System.Drawing.Point(150, 267);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(200, 22);
            this.txtTotalCost.TabIndex = 9;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Location = new System.Drawing.Point(20, 310);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(77, 16);
            this.lblTerms.TabIndex = 10;
            this.lblTerms.Text = "Điều khoản:";
            // 
            // txtTerms
            // 
            this.txtTerms.BackColor = System.Drawing.Color.White;
            this.txtTerms.Location = new System.Drawing.Point(150, 307);
            this.txtTerms.Multiline = true;
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.ReadOnly = true;
            this.txtTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTerms.Size = new System.Drawing.Size(560, 90);
            this.txtTerms.TabIndex = 11;
            // 
            // btnCreateContract
            // 
            this.btnCreateContract.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateContract.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateContract.Enabled = false;
            this.btnCreateContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateContract.ForeColor = System.Drawing.Color.White;
            this.btnCreateContract.Location = new System.Drawing.Point(334, 515);
            this.btnCreateContract.Name = "btnCreateContract";
            this.btnCreateContract.Size = new System.Drawing.Size(150, 40);
            this.btnCreateContract.TabIndex = 5;
            this.btnCreateContract.Text = "Lập hợp đồng";
            this.btnCreateContract.UseVisualStyleBackColor = false;
            this.btnCreateContract.Click += new System.EventHandler(this.btnCreateContract_Click);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.btnCreateContract);
            this.panelContent.Controls.Add(this.gbContractInfo);
            this.panelContent.Controls.Add(this.btnSearchDeposit);
            this.panelContent.Controls.Add(this.txtDepositCode);
            this.panelContent.Controls.Add(this.lblDepositCode);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 560);
            this.panelContent.TabIndex = 0;
            // 
            // UI_02_LapHopDong
            // 
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.panelContent);
            this.Name = "UI_02_LapHopDong";
            this.Text = "Lập Hợp Đồng";
            this.Load += new System.EventHandler(this.UI_02_LapHopDong_Load);
            this.gbContractInfo.ResumeLayout(false);
            this.gbContractInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        private void UI_02_LapHopDong_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void btnSearchDeposit_Click(object sender, EventArgs e)
        {
            string depositCode = txtDepositCode.Text.Trim();
            if (string.IsNullOrEmpty(depositCode))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đặt cọc để tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (depositCode == "DC001")
            {
                txtCustomerInfo.Text = "Nguyễn Văn A - 0123456789 - CMND: 079123456789";
                
                // Clear existing and add mock room
                dgvRooms.Rows.Clear();
                dgvRooms.Rows.Add("101", "Giường Master", "5,000,000", "Trống");
                
                txtDuration.Text = "01/10/2023 - 01/10/2024 (12 tháng)";
                txtTotalCost.Text = "5,000,000 VNĐ/tháng";
                txtTerms.Text = "- Cọc 1 tháng tiền nhà.\r\n- Thanh toán vào ngày 1-5 hàng tháng.\r\n- Không được nuôi thú cưng.";
                
                btnCreateContract.Enabled = true; 
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu đặt cọc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            string newContractCode = "HD-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            txtContractCode.Text = newContractCode;
            
            MessageBox.Show("Hợp đồng đã được lập thành công!\nMã hợp đồng: " + newContractCode, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
