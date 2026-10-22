namespace QuanLySinhVien
{
    partial class FormThemKhoa
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
            label1 = new Label();
            lblTenKhoa = new Label();
            txtTenKhoa = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 16);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "Thêm khoa mới";
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblTenKhoa.Location = new Point(16, 65);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(72, 16);
            lblTenKhoa.TabIndex = 2;
            lblTenKhoa.Text = "Tên khoa";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            txtTenKhoa.Location = new Point(94, 62);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(211, 22);
            txtTenKhoa.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnLuu.Location = new Point(145, 107);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.AccessibleRole = AccessibleRole.ButtonDropDown;
            btnHuy.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnHuy.Location = new Point(251, 107);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormThemKhoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 160);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtTenKhoa);
            Controls.Add(lblTenKhoa);
            Controls.Add(label1);
            Name = "FormThemKhoa";
            Text = "FormThemKhoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTenKhoa;
        private TextBox txtTenKhoa;
        private Button btnLuu;
        private Button btnHuy;
    }
}