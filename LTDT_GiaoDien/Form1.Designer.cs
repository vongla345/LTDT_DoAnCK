namespace LTDT_GiaoDien
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.ListMain = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDiaDiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtHang = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtShipper = new MaterialSkin.Controls.MaterialTextBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbKhuVuc = new MaterialSkin.Controls.MaterialComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearShip = new MaterialSkin.Controls.MaterialButton();
            this.btnSuaShip = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaShip = new MaterialSkin.Controls.MaterialButton();
            this.btnThemShip = new MaterialSkin.Controls.MaterialButton();
            this.btnThoatShip = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ListShipper = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.txtTenShip = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbDiaDiem = new MaterialSkin.Controls.MaterialComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListHang = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.column = new System.Windows.Forms.ColumnHeader();
            this.txtTenHang = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnClearHang = new MaterialSkin.Controls.MaterialButton();
            this.btnSuaHang = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaHang = new MaterialSkin.Controls.MaterialButton();
            this.btnThemHang = new MaterialSkin.Controls.MaterialButton();
            this.btnThoatHang = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThoiGianDuKien = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTongQuangDuongDi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDuongDiNganNhat = new MaterialSkin.Controls.MaterialTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbViTriCanToi = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbViTriHienTai = new MaterialSkin.Controls.MaterialComboBox();
            this.btnTimDuong = new MaterialSkin.Controls.MaterialButton();
            this.btnThoatDiaDiem = new MaterialSkin.Controls.MaterialButton();
            this.label6 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabMenu.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.tabPage4);
            this.TabMenu.Controls.Add(this.tabPage1);
            this.TabMenu.Controls.Add(this.tabPage2);
            this.TabMenu.Controls.Add(this.tabPage3);
            this.TabMenu.Depth = 0;
            this.TabMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabMenu.ImageList = this.imageList1;
            this.TabMenu.Location = new System.Drawing.Point(6, 67);
            this.TabMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMenu.Multiline = true;
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(903, 919);
            this.TabMenu.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.btnThoat);
            this.tabPage4.Controls.Add(this.btnRefresh);
            this.tabPage4.Controls.Add(this.ListMain);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.txtDiaDiem);
            this.tabPage4.Controls.Add(this.txtHang);
            this.tabPage4.Controls.Add(this.txtShipper);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.ImageKey = "icons8-house-96.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(895, 876);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trang chủ";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_logout_64;
            this.btnThoat.Location = new System.Drawing.Point(732, 834);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(154, 36);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_update_64;
            this.btnRefresh.Location = new System.Drawing.Point(711, 410);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(142, 36);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ListMain
            // 
            this.ListMain.AutoSizeTable = false;
            this.ListMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListMain.Depth = 0;
            this.ListMain.FullRowSelect = true;
            this.ListMain.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListMain.Location = new System.Drawing.Point(44, 364);
            this.ListMain.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListMain.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListMain.MouseState = MaterialSkin.MouseState.OUT;
            this.ListMain.Name = "ListMain";
            this.ListMain.OwnerDraw = true;
            this.ListMain.Size = new System.Drawing.Size(608, 481);
            this.ListMain.TabIndex = 7;
            this.ListMain.UseCompatibleStateImageBehavior = false;
            this.ListMain.View = System.Windows.Forms.View.Details;
            this.ListMain.SelectedIndexChanged += new System.EventHandler(this.ListMain_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "Tên shipper";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 3;
            this.columnHeader2.Text = "Tên món hàng";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Địa điểm giao";
            this.columnHeader3.Width = 200;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(305, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(405, 41);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "QUẢN LÝ LỊCH GIAO HÀNG";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.AnimateReadOnly = false;
            this.txtDiaDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDiaDiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiaDiem.Depth = 0;
            this.txtDiaDiem.Enabled = false;
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiaDiem.HideSelection = true;
            this.txtDiaDiem.LeadingIcon = null;
            this.txtDiaDiem.Location = new System.Drawing.Point(653, 100);
            this.txtDiaDiem.MaxLength = 32767;
            this.txtDiaDiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.PasswordChar = '\0';
            this.txtDiaDiem.PrefixSuffixText = null;
            this.txtDiaDiem.ReadOnly = false;
            this.txtDiaDiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiaDiem.SelectedText = "";
            this.txtDiaDiem.SelectionLength = 0;
            this.txtDiaDiem.SelectionStart = 0;
            this.txtDiaDiem.ShortcutsEnabled = true;
            this.txtDiaDiem.Size = new System.Drawing.Size(235, 48);
            this.txtDiaDiem.TabIndex = 2;
            this.txtDiaDiem.TabStop = false;
            this.txtDiaDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiaDiem.TrailingIcon = null;
            this.txtDiaDiem.UseSystemPasswordChar = false;
            // 
            // txtHang
            // 
            this.txtHang.AnimateReadOnly = false;
            this.txtHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHang.Depth = 0;
            this.txtHang.Enabled = false;
            this.txtHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHang.HideSelection = true;
            this.txtHang.LeadingIcon = null;
            this.txtHang.Location = new System.Drawing.Point(177, 184);
            this.txtHang.MaxLength = 32767;
            this.txtHang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHang.Name = "txtHang";
            this.txtHang.PasswordChar = '\0';
            this.txtHang.PrefixSuffixText = null;
            this.txtHang.ReadOnly = false;
            this.txtHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHang.SelectedText = "";
            this.txtHang.SelectionLength = 0;
            this.txtHang.SelectionStart = 0;
            this.txtHang.ShortcutsEnabled = true;
            this.txtHang.Size = new System.Drawing.Size(250, 48);
            this.txtHang.TabIndex = 2;
            this.txtHang.TabStop = false;
            this.txtHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHang.TrailingIcon = null;
            this.txtHang.UseSystemPasswordChar = false;
            // 
            // txtShipper
            // 
            this.txtShipper.AnimateReadOnly = false;
            this.txtShipper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtShipper.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtShipper.Depth = 0;
            this.txtShipper.Enabled = false;
            this.txtShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtShipper.HideSelection = true;
            this.txtShipper.LeadingIcon = null;
            this.txtShipper.Location = new System.Drawing.Point(177, 100);
            this.txtShipper.MaxLength = 32767;
            this.txtShipper.MouseState = MaterialSkin.MouseState.OUT;
            this.txtShipper.Name = "txtShipper";
            this.txtShipper.PasswordChar = '\0';
            this.txtShipper.PrefixSuffixText = null;
            this.txtShipper.ReadOnly = false;
            this.txtShipper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtShipper.SelectedText = "";
            this.txtShipper.SelectionLength = 0;
            this.txtShipper.SelectionStart = 0;
            this.txtShipper.ShortcutsEnabled = true;
            this.txtShipper.Size = new System.Drawing.Size(250, 48);
            this.txtShipper.TabIndex = 2;
            this.txtShipper.TabStop = false;
            this.txtShipper.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtShipper.TrailingIcon = null;
            this.txtShipper.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên địa điểm cần giao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên món hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên shipper:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.cbbKhuVuc);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnClearShip);
            this.tabPage1.Controls.Add(this.btnSuaShip);
            this.tabPage1.Controls.Add(this.btnXoaShip);
            this.tabPage1.Controls.Add(this.btnThemShip);
            this.tabPage1.Controls.Add(this.btnThoatShip);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.ListShipper);
            this.tabPage1.Controls.Add(this.txtTenShip);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "icons8-supplier-96 (1).png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 876);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách shipper";
            // 
            // cbbKhuVuc
            // 
            this.cbbKhuVuc.AutoResize = false;
            this.cbbKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbKhuVuc.Depth = 0;
            this.cbbKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbKhuVuc.DropDownHeight = 174;
            this.cbbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhuVuc.DropDownWidth = 121;
            this.cbbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbKhuVuc.FormattingEnabled = true;
            this.cbbKhuVuc.IntegralHeight = false;
            this.cbbKhuVuc.ItemHeight = 43;
            this.cbbKhuVuc.Location = new System.Drawing.Point(604, 110);
            this.cbbKhuVuc.MaxDropDownItems = 4;
            this.cbbKhuVuc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbKhuVuc.Name = "cbbKhuVuc";
            this.cbbKhuVuc.Size = new System.Drawing.Size(248, 49);
            this.cbbKhuVuc.StartIndex = 0;
            this.cbbKhuVuc.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Khu vực hoạt động:";
            // 
            // btnClearShip
            // 
            this.btnClearShip.AutoSize = false;
            this.btnClearShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearShip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearShip.Depth = 0;
            this.btnClearShip.HighEmphasis = true;
            this.btnClearShip.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_clear_symbol_64;
            this.btnClearShip.Location = new System.Drawing.Point(714, 201);
            this.btnClearShip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearShip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearShip.Name = "btnClearShip";
            this.btnClearShip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearShip.Size = new System.Drawing.Size(158, 36);
            this.btnClearShip.TabIndex = 4;
            this.btnClearShip.Text = "Nhập lại";
            this.btnClearShip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearShip.UseAccentColor = false;
            this.btnClearShip.UseVisualStyleBackColor = true;
            this.btnClearShip.Click += new System.EventHandler(this.btnClearShip_Click);
            // 
            // btnSuaShip
            // 
            this.btnSuaShip.AutoSize = false;
            this.btnSuaShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaShip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSuaShip.Depth = 0;
            this.btnSuaShip.HighEmphasis = true;
            this.btnSuaShip.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_update_64;
            this.btnSuaShip.Location = new System.Drawing.Point(507, 201);
            this.btnSuaShip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaShip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaShip.Name = "btnSuaShip";
            this.btnSuaShip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSuaShip.Size = new System.Drawing.Size(158, 36);
            this.btnSuaShip.TabIndex = 4;
            this.btnSuaShip.Text = "Sửa";
            this.btnSuaShip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSuaShip.UseAccentColor = false;
            this.btnSuaShip.UseVisualStyleBackColor = true;
            this.btnSuaShip.Click += new System.EventHandler(this.btnSuaShip_Click);
            // 
            // btnXoaShip
            // 
            this.btnXoaShip.AutoSize = false;
            this.btnXoaShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaShip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaShip.Depth = 0;
            this.btnXoaShip.HighEmphasis = true;
            this.btnXoaShip.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_remove_64;
            this.btnXoaShip.Location = new System.Drawing.Point(288, 201);
            this.btnXoaShip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaShip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaShip.Name = "btnXoaShip";
            this.btnXoaShip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaShip.Size = new System.Drawing.Size(158, 36);
            this.btnXoaShip.TabIndex = 4;
            this.btnXoaShip.Text = "Xóa";
            this.btnXoaShip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaShip.UseAccentColor = false;
            this.btnXoaShip.UseVisualStyleBackColor = true;
            this.btnXoaShip.Click += new System.EventHandler(this.btnXoaShip_Click);
            // 
            // btnThemShip
            // 
            this.btnThemShip.AutoSize = false;
            this.btnThemShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemShip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemShip.Depth = 0;
            this.btnThemShip.HighEmphasis = true;
            this.btnThemShip.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_add_new_64;
            this.btnThemShip.Location = new System.Drawing.Point(65, 201);
            this.btnThemShip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemShip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemShip.Name = "btnThemShip";
            this.btnThemShip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemShip.Size = new System.Drawing.Size(158, 36);
            this.btnThemShip.TabIndex = 4;
            this.btnThemShip.Text = "Thêm";
            this.btnThemShip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemShip.UseAccentColor = false;
            this.btnThemShip.UseVisualStyleBackColor = true;
            this.btnThemShip.Click += new System.EventHandler(this.btnThemShip_Click);
            // 
            // btnThoatShip
            // 
            this.btnThoatShip.AutoSize = false;
            this.btnThoatShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoatShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatShip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoatShip.Depth = 0;
            this.btnThoatShip.HighEmphasis = true;
            this.btnThoatShip.Icon = null;
            this.btnThoatShip.Location = new System.Drawing.Point(730, 831);
            this.btnThoatShip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoatShip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoatShip.Name = "btnThoatShip";
            this.btnThoatShip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoatShip.Size = new System.Drawing.Size(158, 36);
            this.btnThoatShip.TabIndex = 4;
            this.btnThoatShip.Text = "Thoát";
            this.btnThoatShip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoatShip.UseAccentColor = false;
            this.btnThoatShip.UseVisualStyleBackColor = true;
            this.btnThoatShip.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(241, 19);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(477, 41);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "QUẢN LÝ DANH SÁCH SHIPPER";
            // 
            // ListShipper
            // 
            this.ListShipper.AutoSizeTable = false;
            this.ListShipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListShipper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListShipper.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader8});
            this.ListShipper.Depth = 0;
            this.ListShipper.FullRowSelect = true;
            this.ListShipper.Location = new System.Drawing.Point(49, 272);
            this.ListShipper.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListShipper.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListShipper.MouseState = MaterialSkin.MouseState.OUT;
            this.ListShipper.Name = "ListShipper";
            this.ListShipper.OwnerDraw = true;
            this.ListShipper.Size = new System.Drawing.Size(823, 531);
            this.ListShipper.TabIndex = 2;
            this.ListShipper.UseCompatibleStateImageBehavior = false;
            this.ListShipper.View = System.Windows.Forms.View.Details;
            this.ListShipper.SelectedIndexChanged += new System.EventHandler(this.ListShipper_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên shipper";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Khu vực hoạt động";
            this.columnHeader8.Width = 200;
            // 
            // txtTenShip
            // 
            this.txtTenShip.AnimateReadOnly = false;
            this.txtTenShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenShip.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenShip.Depth = 0;
            this.txtTenShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenShip.HideSelection = true;
            this.txtTenShip.LeadingIcon = null;
            this.txtTenShip.Location = new System.Drawing.Point(159, 110);
            this.txtTenShip.MaxLength = 32767;
            this.txtTenShip.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenShip.Name = "txtTenShip";
            this.txtTenShip.PasswordChar = '\0';
            this.txtTenShip.PrefixSuffixText = null;
            this.txtTenShip.ReadOnly = false;
            this.txtTenShip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenShip.SelectedText = "";
            this.txtTenShip.SelectionLength = 0;
            this.txtTenShip.SelectionStart = 0;
            this.txtTenShip.ShortcutsEnabled = true;
            this.txtTenShip.Size = new System.Drawing.Size(250, 48);
            this.txtTenShip.TabIndex = 1;
            this.txtTenShip.TabStop = false;
            this.txtTenShip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenShip.TrailingIcon = null;
            this.txtTenShip.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên shipper:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.cbbDiaDiem);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ListHang);
            this.tabPage2.Controls.Add(this.txtTenHang);
            this.tabPage2.Controls.Add(this.btnClearHang);
            this.tabPage2.Controls.Add(this.btnSuaHang);
            this.tabPage2.Controls.Add(this.btnXoaHang);
            this.tabPage2.Controls.Add(this.btnThemHang);
            this.tabPage2.Controls.Add(this.btnThoatHang);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.ImageKey = "icons8-product-96.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 876);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách món hàng";
            // 
            // cbbDiaDiem
            // 
            this.cbbDiaDiem.AutoResize = false;
            this.cbbDiaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbDiaDiem.Depth = 0;
            this.cbbDiaDiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbDiaDiem.DropDownHeight = 174;
            this.cbbDiaDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiaDiem.DropDownWidth = 121;
            this.cbbDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDiaDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbDiaDiem.FormattingEnabled = true;
            this.cbbDiaDiem.IntegralHeight = false;
            this.cbbDiaDiem.ItemHeight = 43;
            this.cbbDiaDiem.Location = new System.Drawing.Point(613, 90);
            this.cbbDiaDiem.MaxDropDownItems = 4;
            this.cbbDiaDiem.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbDiaDiem.Name = "cbbDiaDiem";
            this.cbbDiaDiem.Size = new System.Drawing.Size(248, 49);
            this.cbbDiaDiem.StartIndex = 0;
            this.cbbDiaDiem.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa điểm cần giao:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ListHang
            // 
            this.ListHang.AutoSizeTable = false;
            this.ListHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.column});
            this.ListHang.Depth = 0;
            this.ListHang.FullRowSelect = true;
            this.ListHang.Location = new System.Drawing.Point(42, 277);
            this.ListHang.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListHang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListHang.MouseState = MaterialSkin.MouseState.OUT;
            this.ListHang.Name = "ListHang";
            this.ListHang.OwnerDraw = true;
            this.ListHang.Size = new System.Drawing.Size(821, 533);
            this.ListHang.TabIndex = 4;
            this.ListHang.UseCompatibleStateImageBehavior = false;
            this.ListHang.View = System.Windows.Forms.View.Details;
            this.ListHang.SelectedIndexChanged += new System.EventHandler(this.ListHang_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên món hàng";
            this.columnHeader5.Width = 200;
            // 
            // column
            // 
            this.column.Text = "Địa điểm cần giao";
            this.column.Width = 200;
            // 
            // txtTenHang
            // 
            this.txtTenHang.AnimateReadOnly = false;
            this.txtTenHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenHang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenHang.Depth = 0;
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenHang.HideSelection = true;
            this.txtTenHang.LeadingIcon = null;
            this.txtTenHang.Location = new System.Drawing.Point(198, 90);
            this.txtTenHang.MaxLength = 32767;
            this.txtTenHang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.PasswordChar = '\0';
            this.txtTenHang.PrefixSuffixText = null;
            this.txtTenHang.ReadOnly = false;
            this.txtTenHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenHang.SelectedText = "";
            this.txtTenHang.SelectionLength = 0;
            this.txtTenHang.SelectionStart = 0;
            this.txtTenHang.ShortcutsEnabled = true;
            this.txtTenHang.Size = new System.Drawing.Size(250, 48);
            this.txtTenHang.TabIndex = 3;
            this.txtTenHang.TabStop = false;
            this.txtTenHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenHang.TrailingIcon = null;
            this.txtTenHang.UseSystemPasswordChar = false;
            // 
            // btnClearHang
            // 
            this.btnClearHang.AutoSize = false;
            this.btnClearHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearHang.Depth = 0;
            this.btnClearHang.HighEmphasis = true;
            this.btnClearHang.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_clear_symbol_64;
            this.btnClearHang.Location = new System.Drawing.Point(730, 198);
            this.btnClearHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearHang.Name = "btnClearHang";
            this.btnClearHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearHang.Size = new System.Drawing.Size(158, 36);
            this.btnClearHang.TabIndex = 2;
            this.btnClearHang.Text = "Nhập lại";
            this.btnClearHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearHang.UseAccentColor = false;
            this.btnClearHang.UseVisualStyleBackColor = true;
            this.btnClearHang.Click += new System.EventHandler(this.btnClearHang_Click);
            // 
            // btnSuaHang
            // 
            this.btnSuaHang.AutoSize = false;
            this.btnSuaHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSuaHang.Depth = 0;
            this.btnSuaHang.HighEmphasis = true;
            this.btnSuaHang.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_update_64;
            this.btnSuaHang.Location = new System.Drawing.Point(516, 198);
            this.btnSuaHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaHang.Name = "btnSuaHang";
            this.btnSuaHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSuaHang.Size = new System.Drawing.Size(158, 36);
            this.btnSuaHang.TabIndex = 2;
            this.btnSuaHang.Text = "Sửa";
            this.btnSuaHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSuaHang.UseAccentColor = false;
            this.btnSuaHang.UseVisualStyleBackColor = true;
            this.btnSuaHang.Click += new System.EventHandler(this.btnSuaHang_Click);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.AutoSize = false;
            this.btnXoaHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaHang.Depth = 0;
            this.btnXoaHang.HighEmphasis = true;
            this.btnXoaHang.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_remove_64;
            this.btnXoaHang.Location = new System.Drawing.Point(290, 198);
            this.btnXoaHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaHang.Size = new System.Drawing.Size(158, 36);
            this.btnXoaHang.TabIndex = 2;
            this.btnXoaHang.Text = "Xóa";
            this.btnXoaHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaHang.UseAccentColor = false;
            this.btnXoaHang.UseVisualStyleBackColor = true;
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.AutoSize = false;
            this.btnThemHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemHang.Depth = 0;
            this.btnThemHang.HighEmphasis = true;
            this.btnThemHang.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_add_new_64;
            this.btnThemHang.Location = new System.Drawing.Point(67, 198);
            this.btnThemHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemHang.Size = new System.Drawing.Size(158, 36);
            this.btnThemHang.TabIndex = 2;
            this.btnThemHang.Text = "Thêm";
            this.btnThemHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemHang.UseAccentColor = false;
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // btnThoatHang
            // 
            this.btnThoatHang.AutoSize = false;
            this.btnThoatHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoatHang.Depth = 0;
            this.btnThoatHang.HighEmphasis = true;
            this.btnThoatHang.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_logout_64;
            this.btnThoatHang.Location = new System.Drawing.Point(730, 831);
            this.btnThoatHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoatHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoatHang.Name = "btnThoatHang";
            this.btnThoatHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoatHang.Size = new System.Drawing.Size(158, 36);
            this.btnThoatHang.TabIndex = 2;
            this.btnThoatHang.Text = "Thoát";
            this.btnThoatHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoatHang.UseAccentColor = false;
            this.btnThoatHang.UseVisualStyleBackColor = true;
            this.btnThoatHang.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên món hàng:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(241, 24);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(520, 41);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "QUẢN LÝ DANH SÁCH MÓN HÀNG";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtThoiGianDuKien);
            this.tabPage3.Controls.Add(this.txtTongQuangDuongDi);
            this.tabPage3.Controls.Add(this.txtDuongDiNganNhat);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cbbViTriCanToi);
            this.tabPage3.Controls.Add(this.cbbViTriHienTai);
            this.tabPage3.Controls.Add(this.btnTimDuong);
            this.tabPage3.Controls.Add(this.btnThoatDiaDiem);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.ImageKey = "icons8-map-pinpoint-96.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(895, 876);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách địa điểm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 60);
            this.label12.TabIndex = 13;
            this.label12.Text = "Thời gian dự kiến:\r\n(4 km/h)\r\n\r\n";
            // 
            // txtThoiGianDuKien
            // 
            this.txtThoiGianDuKien.AnimateReadOnly = false;
            this.txtThoiGianDuKien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThoiGianDuKien.Depth = 0;
            this.txtThoiGianDuKien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtThoiGianDuKien.LeadingIcon = null;
            this.txtThoiGianDuKien.Location = new System.Drawing.Point(249, 431);
            this.txtThoiGianDuKien.MaxLength = 50;
            this.txtThoiGianDuKien.MouseState = MaterialSkin.MouseState.OUT;
            this.txtThoiGianDuKien.Multiline = false;
            this.txtThoiGianDuKien.Name = "txtThoiGianDuKien";
            this.txtThoiGianDuKien.Size = new System.Drawing.Size(562, 50);
            this.txtThoiGianDuKien.TabIndex = 12;
            this.txtThoiGianDuKien.Text = "";
            this.txtThoiGianDuKien.TrailingIcon = null;
            // 
            // txtTongQuangDuongDi
            // 
            this.txtTongQuangDuongDi.AnimateReadOnly = false;
            this.txtTongQuangDuongDi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongQuangDuongDi.Depth = 0;
            this.txtTongQuangDuongDi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTongQuangDuongDi.LeadingIcon = null;
            this.txtTongQuangDuongDi.Location = new System.Drawing.Point(249, 326);
            this.txtTongQuangDuongDi.MaxLength = 50;
            this.txtTongQuangDuongDi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTongQuangDuongDi.Multiline = false;
            this.txtTongQuangDuongDi.Name = "txtTongQuangDuongDi";
            this.txtTongQuangDuongDi.Size = new System.Drawing.Size(562, 50);
            this.txtTongQuangDuongDi.TabIndex = 11;
            this.txtTongQuangDuongDi.Text = "";
            this.txtTongQuangDuongDi.TrailingIcon = null;
            // 
            // txtDuongDiNganNhat
            // 
            this.txtDuongDiNganNhat.AnimateReadOnly = false;
            this.txtDuongDiNganNhat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuongDiNganNhat.Depth = 0;
            this.txtDuongDiNganNhat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDuongDiNganNhat.LeadingIcon = null;
            this.txtDuongDiNganNhat.Location = new System.Drawing.Point(249, 529);
            this.txtDuongDiNganNhat.MaxLength = 50;
            this.txtDuongDiNganNhat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDuongDiNganNhat.Multiline = false;
            this.txtDuongDiNganNhat.Name = "txtDuongDiNganNhat";
            this.txtDuongDiNganNhat.Size = new System.Drawing.Size(562, 50);
            this.txtDuongDiNganNhat.TabIndex = 10;
            this.txtDuongDiNganNhat.Text = "";
            this.txtDuongDiNganNhat.TrailingIcon = null;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tổng quảng đường đi:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Đường đi ngắn nhất:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Vị trí cần tới:";
            // 
            // cbbViTriCanToi
            // 
            this.cbbViTriCanToi.AutoResize = false;
            this.cbbViTriCanToi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbViTriCanToi.Depth = 0;
            this.cbbViTriCanToi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbViTriCanToi.DropDownHeight = 174;
            this.cbbViTriCanToi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbViTriCanToi.DropDownWidth = 121;
            this.cbbViTriCanToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbViTriCanToi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbViTriCanToi.FormattingEnabled = true;
            this.cbbViTriCanToi.IntegralHeight = false;
            this.cbbViTriCanToi.ItemHeight = 43;
            this.cbbViTriCanToi.Location = new System.Drawing.Point(615, 89);
            this.cbbViTriCanToi.MaxDropDownItems = 4;
            this.cbbViTriCanToi.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbViTriCanToi.Name = "cbbViTriCanToi";
            this.cbbViTriCanToi.Size = new System.Drawing.Size(226, 49);
            this.cbbViTriCanToi.StartIndex = 0;
            this.cbbViTriCanToi.TabIndex = 6;
            // 
            // cbbViTriHienTai
            // 
            this.cbbViTriHienTai.AutoResize = false;
            this.cbbViTriHienTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbViTriHienTai.Depth = 0;
            this.cbbViTriHienTai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbViTriHienTai.DropDownHeight = 174;
            this.cbbViTriHienTai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbViTriHienTai.DropDownWidth = 121;
            this.cbbViTriHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbViTriHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbViTriHienTai.FormattingEnabled = true;
            this.cbbViTriHienTai.IntegralHeight = false;
            this.cbbViTriHienTai.ItemHeight = 43;
            this.cbbViTriHienTai.Location = new System.Drawing.Point(168, 89);
            this.cbbViTriHienTai.MaxDropDownItems = 4;
            this.cbbViTriHienTai.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbViTriHienTai.Name = "cbbViTriHienTai";
            this.cbbViTriHienTai.Size = new System.Drawing.Size(225, 49);
            this.cbbViTriHienTai.StartIndex = 0;
            this.cbbViTriHienTai.TabIndex = 5;
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.AutoSize = false;
            this.btnTimDuong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimDuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimDuong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimDuong.Depth = 0;
            this.btnTimDuong.HighEmphasis = true;
            this.btnTimDuong.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_add_new_64;
            this.btnTimDuong.Location = new System.Drawing.Point(363, 218);
            this.btnTimDuong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimDuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimDuong.Size = new System.Drawing.Size(159, 36);
            this.btnTimDuong.TabIndex = 4;
            this.btnTimDuong.Text = "Tìm đường";
            this.btnTimDuong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimDuong.UseAccentColor = false;
            this.btnTimDuong.UseVisualStyleBackColor = true;
            this.btnTimDuong.Click += new System.EventHandler(this.btnTimDuong_Click);
            // 
            // btnThoatDiaDiem
            // 
            this.btnThoatDiaDiem.AutoSize = false;
            this.btnThoatDiaDiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoatDiaDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatDiaDiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoatDiaDiem.Depth = 0;
            this.btnThoatDiaDiem.HighEmphasis = true;
            this.btnThoatDiaDiem.Icon = global::LTDT_GiaoDien.Properties.Resources.icons8_logout_64;
            this.btnThoatDiaDiem.Location = new System.Drawing.Point(682, 752);
            this.btnThoatDiaDiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoatDiaDiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoatDiaDiem.Name = "btnThoatDiaDiem";
            this.btnThoatDiaDiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoatDiaDiem.Size = new System.Drawing.Size(159, 36);
            this.btnThoatDiaDiem.TabIndex = 4;
            this.btnThoatDiaDiem.Text = "Thoát";
            this.btnThoatDiaDiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoatDiaDiem.UseAccentColor = false;
            this.btnThoatDiaDiem.UseVisualStyleBackColor = true;
            this.btnThoatDiaDiem.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vị trí hiện tại:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(249, 28);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(424, 41);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "TÌM ĐƯỜNG ĐI NGẮN NHẤT";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-house-96.png");
            this.imageList1.Images.SetKeyName(1, "icons8-supplier-96 (1).png");
            this.imageList1.Images.SetKeyName(2, "icons8-product-96.png");
            this.imageList1.Images.SetKeyName(3, "icons8-map-pinpoint-96.png");
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(915, 992);
            this.Controls.Add(this.TabMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabMenu;
            this.DrawerWidth = 220;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch giao hàng ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabMenu.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabMenu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox2 txtDiaDiem;
        private MaterialSkin.Controls.MaterialTextBox2 txtHang;
        private MaterialSkin.Controls.MaterialTextBox2 txtShipper;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialListView ListMain;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialListView ListShipper;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenShip;
        private Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnClearShip;
        private MaterialSkin.Controls.MaterialButton btnSuaShip;
        private MaterialSkin.Controls.MaterialButton btnXoaShip;
        private MaterialSkin.Controls.MaterialButton btnThemShip;
        private MaterialSkin.Controls.MaterialButton btnThoatShip;
        private ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialListView ListHang;
        private ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenHang;
        private MaterialSkin.Controls.MaterialButton btnClearHang;
        private MaterialSkin.Controls.MaterialButton btnSuaHang;
        private MaterialSkin.Controls.MaterialButton btnXoaHang;
        private MaterialSkin.Controls.MaterialButton btnThemHang;
        private MaterialSkin.Controls.MaterialButton btnThoatHang;
        private Label label5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnTimDuong;
        private MaterialSkin.Controls.MaterialButton btnThoatDiaDiem;
        private Label label6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private ColumnHeader columnHeader7;
        private Label label7;
        private ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialComboBox cbbDiaDiem;
        private Label label8;
        private MaterialSkin.Controls.MaterialComboBox cbbKhuVuc;
        private Label label11;
        private Label label10;
        private Label label9;
        private MaterialSkin.Controls.MaterialComboBox cbbViTriCanToi;
        private MaterialSkin.Controls.MaterialComboBox cbbViTriHienTai;
        private Label label12;
        private MaterialSkin.Controls.MaterialTextBox txtThoiGianDuKien;
        private MaterialSkin.Controls.MaterialTextBox txtTongQuangDuongDi;
        private MaterialSkin.Controls.MaterialTextBox txtDuongDiNganNhat;
        private ColumnHeader column;
    }
}