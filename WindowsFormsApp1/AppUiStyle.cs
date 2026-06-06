using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class AppUiStyle
    {
        private static readonly HashSet<Form> StyledForms = new HashSet<Form>();
        private static readonly Color Bg = Color.FromArgb(246, 248, 250);
        private static readonly Color Surface = Color.White;
        private static readonly Color Primary = Color.FromArgb(30, 64, 140);
        private static readonly Color Success = Color.FromArgb(15, 110, 86);
        private static readonly Color Warning = Color.FromArgb(133, 79, 11);
        private static readonly Color Danger = Color.FromArgb(163, 45, 45);
        private static readonly Color Text = Color.FromArgb(35, 45, 55);
        private static readonly Color Muted = Color.FromArgb(95, 110, 125);

        public static void ApplyToOpenForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (!StyledForms.Contains(form))
                {
                    Apply(form);
                    StyledForms.Add(form);
                }
            }
        }

        public static void Apply(Form form)
        {
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            if (form.BackColor == SystemColors.Control || form.BackColor == Color.Empty)
                form.BackColor = Bg;

            form.ControlAdded -= Form_ControlAdded;
            form.ControlAdded += Form_ControlAdded;
            StyleChildren(form);
        }

        private static void Form_ControlAdded(object sender, ControlEventArgs e)
        {
            StyleControlTree(e.Control);
        }

        private static void StyleChildren(Control root)
        {
            foreach (Control child in root.Controls)
                StyleControlTree(child);
        }

        private static void StyleControlTree(Control control)
        {
            StyleControl(control);
            foreach (Control child in control.Controls)
                StyleControlTree(child);
        }

        private static void StyleControl(Control control)
        {
            if (control is Button button)
            {
                StyleButton(button);
                return;
            }

            if (control is DataGridView grid)
            {
                StyleGrid(grid);
                return;
            }

            if (control is TextBox textBox)
            {
                StyleTextBox(textBox);
                return;
            }

            if (control is ComboBox comboBox)
            {
                comboBox.Font = new Font("Segoe UI", 9F);
                NormalizeComboBox(comboBox);
                return;
            }

            if (control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Font = new Font("Segoe UI", 9F);
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = dateTimePicker.ShowUpDown ? "dd/MM/yyyy HH:mm" : "dd/MM/yyyy";
                return;
            }

            if (control is GroupBox groupBox)
            {
                groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                groupBox.ForeColor = Text;
                if (groupBox.BackColor == SystemColors.Control || groupBox.BackColor == Color.Empty)
                    groupBox.BackColor = Surface;
                groupBox.Text = NormalizeText(groupBox.Text);
                return;
            }

            if (control is Label label)
            {
                StyleLabel(label);
                return;
            }

            if (control is Panel panel)
            {
                if (panel.BackColor == SystemColors.Control || panel.BackColor == Color.Empty)
                    panel.BackColor = Bg;
            }
        }

        private static void StyleButton(Button button)
        {
            button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
            button.Text = NormalizeText(button.Text);

            string text = button.Text.ToLowerInvariant();
            if (text.Contains("thoát") || text.Contains("hủy") || text.Contains("xóa") || text.Contains("đóng"))
                button.BackColor = Danger;
            else if (text.Contains("xác nhận") || text.Contains("lưu") || text.Contains("hoàn thành") || text.Contains("thêm"))
                button.BackColor = Success;
            else if (text.Contains("tải") || text.Contains("làm mới") || text.Contains("cập nhật"))
                button.BackColor = Warning;
            else
                button.BackColor = Primary;
        }

        private static void StyleTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 9F);
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = textBox.ReadOnly ? Color.FromArgb(248, 250, 252) : Surface;
            textBox.ForeColor = Text;
            textBox.Text = NormalizeText(textBox.Text);
        }

        private static void StyleLabel(Label label)
        {
            label.Text = NormalizeText(label.Text);
            if (label.ForeColor == SystemColors.ControlText || label.ForeColor == Color.Empty)
                label.ForeColor = Muted;

            bool title = label.Name.ToLowerInvariant().Contains("title")
                || label.Name.ToLowerInvariant().Contains("tieude")
                || (label.Text.Length > 0 && label.Text == label.Text.ToUpperInvariant() && label.Text.Length > 8);

            if (title)
            {
                label.Font = new Font("Segoe UI", Math.Max(label.Font.Size, 12F), FontStyle.Bold);
                if (label.ForeColor == Muted)
                    label.ForeColor = Primary;
            }
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.Font = new Font("Segoe UI", 9F);
            grid.RowTemplate.Height = 30;
            grid.ColumnHeadersHeight = 34;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Primary;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            foreach (DataGridViewColumn column in grid.Columns)
                column.HeaderText = NormalizeText(column.HeaderText);

            NormalizeGrid(grid);
            grid.RowsAdded -= Grid_RowsChanged;
            grid.RowsAdded += Grid_RowsChanged;
            grid.CellValueChanged -= Grid_CellValueChanged;
            grid.CellValueChanged += Grid_CellValueChanged;
            grid.DataBindingComplete -= Grid_DataBindingComplete;
            grid.DataBindingComplete += Grid_DataBindingComplete;
        }

        private static void Grid_RowsChanged(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NormalizeGrid((DataGridView)sender);
        }

        private static void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NormalizeGrid((DataGridView)sender);
        }

        private static void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            NormalizeGrid((DataGridView)sender);
        }

        private static void NormalizeGrid(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string value)
                        cell.Value = NormalizeText(value);
                }

                ApplyStatusColor(row);
            }
        }

        private static void ApplyStatusColor(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                string value = Convert.ToString(cell.Value) ?? string.Empty;
                string lower = value.ToLowerInvariant();
                if (lower.Contains("chờ") || lower.Contains("thiếu") || lower.Contains("chưa"))
                {
                    cell.Style.ForeColor = Warning;
                }
                else if (lower.Contains("hoàn tất") || lower.Contains("đã") || lower.Contains("trống") || lower.Contains("đang hoạt động"))
                {
                    cell.Style.ForeColor = Success;
                }
                else if (lower.Contains("khóa") || lower.Contains("hủy") || lower.Contains("hư hỏng"))
                {
                    cell.Style.ForeColor = Danger;
                }
            }
        }

        private static void NormalizeComboBox(ComboBox comboBox)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i] is string value)
                    comboBox.Items[i] = NormalizeText(value);
            }
        }

        private static string NormalizeText(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string result = value.Replace("VND", "VNĐ")
                .Replace(" vnđ", " VNĐ")
                .Replace("VNĐ/tháng", "VNĐ / tháng")
                .Replace("đ/giường", " VNĐ / giường")
                .Replace("VNĐ/giường", "VNĐ / giường")
                .Replace("N/A", "-");

            result = Regex.Replace(result, @"(?<![\w])(\d{1,3}(?:,\d{3})+)(\s*VNĐ)?", match =>
            {
                string number = match.Groups[1].Value.Replace(",", ".");
                string currency = match.Groups[2].Success ? " VNĐ" : string.Empty;
                return number + currency;
            });

            result = Regex.Replace(result, @"(?<![\w])(\d{1,3}(?:\.\d{3})+)đ\b", "$1 VNĐ");
            result = Regex.Replace(result, @"\s{2,}", " ");

            return result.Trim();
        }

        public static string Money(decimal amount)
        {
            return string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} VNĐ", amount).Replace(",", ".");
        }
    }
}
