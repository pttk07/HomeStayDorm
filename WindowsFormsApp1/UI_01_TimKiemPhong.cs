using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_01_TimKiemPhong : Form
    {
        private Label lblTitle;
        private GroupBox gbFilters;
        private Label lblLocation;
        private ComboBox cbLocation;
        private Label lblRoomType;
        private ComboBox cbRoomType;
        private Label lblGender;
        private ComboBox cbGender;
        private Label lblMinPrice;
        private NumericUpDown numMinPrice;
        private Label lblMaxPrice;
        private NumericUpDown numMaxPrice;
        private Button btnSearch;
        
        private GroupBox gbResults;
        private DataGridView dgvResults;
        private Button btnSelectRoom;

        public UI_01_TimKiemPhong()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.numMinPrice = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.numMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).BeginInit();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRA CỨU PHÒNG TRỐNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // gbFilters
            // 
            this.gbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilters.Controls.Add(this.lblLocation);
            this.gbFilters.Controls.Add(this.cbLocation);
            this.gbFilters.Controls.Add(this.lblRoomType);
            this.gbFilters.Controls.Add(this.cbRoomType);
            this.gbFilters.Controls.Add(this.lblGender);
            this.gbFilters.Controls.Add(this.cbGender);
            this.gbFilters.Controls.Add(this.lblMinPrice);
            this.gbFilters.Controls.Add(this.numMinPrice);
            this.gbFilters.Controls.Add(this.lblMaxPrice);
            this.gbFilters.Controls.Add(this.numMaxPrice);
            this.gbFilters.Controls.Add(this.btnSearch);
            this.gbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilters.Location = new System.Drawing.Point(30, 70);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(820, 140);
            this.gbFilters.TabIndex = 1;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Bộ lọc tìm kiếm";
            
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(20, 35);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(40, 18);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Vị trí:";
            
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Tất cả",
            "Quận 1",
            "Quận 3",
            "Thủ Đức"});
            this.cbLocation.Location = new System.Drawing.Point(90, 32);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(160, 26);
            this.cbLocation.TabIndex = 1;
            
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(280, 35);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 18);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Loại phòng:";
            
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Tất cả",
            "Phòng thường",
            "Phòng Master",
            "Giường Dorm"});
            this.cbRoomType.Location = new System.Drawing.Point(375, 32);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(160, 26);
            this.cbRoomType.TabIndex = 3;
            
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(560, 35);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 18);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính:";
            
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ",
            "Nam/Nữ"});
            this.cbGender.Location = new System.Drawing.Point(635, 32);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(160, 26);
            this.cbGender.TabIndex = 5;
            
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Location = new System.Drawing.Point(20, 85);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(51, 18);
            this.lblMinPrice.TabIndex = 6;
            this.lblMinPrice.Text = "Giá từ:";
            
            // 
            // numMinPrice
            // 
            this.numMinPrice.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numMinPrice.Location = new System.Drawing.Point(90, 83);
            this.numMinPrice.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numMinPrice.Name = "numMinPrice";
            this.numMinPrice.Size = new System.Drawing.Size(160, 24);
            this.numMinPrice.TabIndex = 7;
            
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Location = new System.Drawing.Point(280, 85);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(36, 18);
            this.lblMaxPrice.TabIndex = 8;
            this.lblMaxPrice.Text = "đến:";
            
            // 
            // numMaxPrice
            // 
            this.numMaxPrice.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numMaxPrice.Location = new System.Drawing.Point(375, 83);
            this.numMaxPrice.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numMaxPrice.Name = "numMaxPrice";
            this.numMaxPrice.Size = new System.Drawing.Size(160, 24);
            this.numMaxPrice.TabIndex = 9;
            this.numMaxPrice.Value = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(635, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            // 
            // gbResults
            // 
            this.gbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResults.Controls.Add(this.dgvResults);
            this.gbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResults.Location = new System.Drawing.Point(30, 230);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(820, 300);
            this.gbResults.TabIndex = 2;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Danh sách kết quả";
            
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 20);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(814, 277);
            this.dgvResults.TabIndex = 0;
            
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelectRoom.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRoom.ForeColor = System.Drawing.Color.White;
            this.btnSelectRoom.Location = new System.Drawing.Point(360, 550);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(160, 40);
            this.btnSelectRoom.TabIndex = 3;
            this.btnSelectRoom.Text = "Chọn phòng";
            this.btnSelectRoom.UseVisualStyleBackColor = false;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            
            // 
            // UI_01_TimKiemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.lblTitle);
            this.Name = "UI_01_TimKiemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu phòng trống";
            this.Load += new System.EventHandler(this.UI_01_TimKiemPhong_Load);
            
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).EndInit();
            this.gbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UI_01_TimKiemPhong_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho ComboBox
            cbLocation.SelectedIndex = 0;
            cbRoomType.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;

            // Thiết lập các cột cho DataGridView theo đúng Use Case
            dgvResults.ColumnCount = 4;
            dgvResults.Columns[0].Name = "Số phòng";
            dgvResults.Columns[1].Name = "Vị trí giường";
            dgvResults.Columns[2].Name = "Đơn giá";
            dgvResults.Columns[3].Name = "Trạng thái hiện tại";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            
            // Lấy điều kiện tìm kiếm
            string location = cbLocation.Text;
            string roomType = cbRoomType.Text;
            
            // Xử lý tìm kiếm giả lập
            if (location == "Tất cả" || (location == "Quận 1" && roomType == "Phòng thường"))
            {
               dgvResults.Rows.Add("101", "N/A", "2,000,000", "Trống");
               dgvResults.Rows.Add("102", "Giường tầng 1", "1,500,000", "Trống");
            }
            else
            {
                // Dòng sự kiện phụ: Không tìm thấy kết quả
                MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvResults.SelectedRows[0];
                string status = row.Cells[3].Value?.ToString();

                if (status != "Trống" && status != "Đang trống")
                {
                    MessageBox.Show("Vui lòng chọn phòng có trạng thái 'Trống' để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin phòng đã chọn và mở UI_01a
                UI_01a_GhiNhanKetQuaChonPhong confirmForm = new UI_01a_GhiNhanKetQuaChonPhong();
                confirmForm.RoomNumber = row.Cells[0].Value?.ToString();
                confirmForm.BedPosition = row.Cells[1].Value?.ToString();
                confirmForm.Price = row.Cells[2].Value?.ToString();
                
                confirmForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}