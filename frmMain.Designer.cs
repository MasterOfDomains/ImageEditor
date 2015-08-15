namespace ImageEditor
{
    partial class frmMain
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
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.splLeft = new System.Windows.Forms.SplitContainer();
            this.splTopLeft = new System.Windows.Forms.SplitContainer();
            this.pnlImgFileControls = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCurrentImg = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.pnlImgSizeControls = new System.Windows.Forms.Panel();
            this.nudImageSize = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtImgWidth = new System.Windows.Forms.TextBox();
            this.txtImgHeight = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblAdjustSize = new System.Windows.Forms.Label();
            this.splBottomLeft = new System.Windows.Forms.SplitContainer();
            this.pnlCropControls = new System.Windows.Forms.Panel();
            this.btnSetBounds = new System.Windows.Forms.Button();
            this.lblBoundWidth = new System.Windows.Forms.Label();
            this.lblCroppedHeight = new System.Windows.Forms.Label();
            this.txtBoundWidth = new System.Windows.Forms.TextBox();
            this.btnSelectBoundary = new System.Windows.Forms.Button();
            this.txtBoundHeight = new System.Windows.Forms.TextBox();
            this.btnCropColor = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRollBack = new System.Windows.Forms.Button();
            this.splRight = new System.Windows.Forms.SplitContainer();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnChangeImageDir = new System.Windows.Forms.Button();
            this.txtDefaultImageDir = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splLeft)).BeginInit();
            this.splLeft.Panel1.SuspendLayout();
            this.splLeft.Panel2.SuspendLayout();
            this.splLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splTopLeft)).BeginInit();
            this.splTopLeft.Panel1.SuspendLayout();
            this.splTopLeft.Panel2.SuspendLayout();
            this.splTopLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlImgSizeControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splBottomLeft)).BeginInit();
            this.splBottomLeft.Panel1.SuspendLayout();
            this.splBottomLeft.Panel2.SuspendLayout();
            this.splBottomLeft.SuspendLayout();
            this.pnlCropControls.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splRight)).BeginInit();
            this.splRight.Panel1.SuspendLayout();
            this.splRight.Panel2.SuspendLayout();
            this.splRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(0, 24);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.splLeft);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.splRight);
            this.splMain.Size = new System.Drawing.Size(840, 534);
            this.splMain.SplitterDistance = 277;
            this.splMain.TabIndex = 0;
            // 
            // splLeft
            // 
            this.splLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splLeft.Location = new System.Drawing.Point(0, 0);
            this.splLeft.Name = "splLeft";
            this.splLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splLeft.Panel1
            // 
            this.splLeft.Panel1.Controls.Add(this.splTopLeft);
            // 
            // splLeft.Panel2
            // 
            this.splLeft.Panel2.Controls.Add(this.splBottomLeft);
            this.splLeft.Size = new System.Drawing.Size(277, 534);
            this.splLeft.SplitterDistance = 217;
            this.splLeft.TabIndex = 1;
            // 
            // splTopLeft
            // 
            this.splTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splTopLeft.Location = new System.Drawing.Point(0, 0);
            this.splTopLeft.Name = "splTopLeft";
            this.splTopLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splTopLeft.Panel1
            // 
            this.splTopLeft.Panel1.Controls.Add(this.panel3);
            this.splTopLeft.Panel1.Controls.Add(this.pnlImgFileControls);
            // 
            // splTopLeft.Panel2
            // 
            this.splTopLeft.Panel2.Controls.Add(this.pnlImgSizeControls);
            this.splTopLeft.Panel2.MouseEnter += new System.EventHandler(this.splTopLeft_Panel2_MouseEnter);
            this.splTopLeft.Size = new System.Drawing.Size(277, 217);
            this.splTopLeft.SplitterDistance = 85;
            this.splTopLeft.TabIndex = 0;
            // 
            // pnlImgFileControls
            // 
            this.pnlImgFileControls.Location = new System.Drawing.Point(3, 10);
            this.pnlImgFileControls.Name = "pnlImgFileControls";
            this.pnlImgFileControls.Size = new System.Drawing.Size(265, 72);
            this.pnlImgFileControls.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.txtCurrentImg);
            this.panel3.Controls.Add(this.btnOpenImage);
            this.panel3.Location = new System.Drawing.Point(35, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 72);
            this.panel3.TabIndex = 0;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // txtCurrentImg
            // 
            this.txtCurrentImg.Location = new System.Drawing.Point(6, 41);
            this.txtCurrentImg.Name = "txtCurrentImg";
            this.txtCurrentImg.ReadOnly = true;
            this.txtCurrentImg.Size = new System.Drawing.Size(174, 20);
            this.txtCurrentImg.TabIndex = 8;
            this.txtCurrentImg.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(6, 12);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(111, 23);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "Get Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pnlImgSizeControls
            // 
            this.pnlImgSizeControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlImgSizeControls.Controls.Add(this.nudImageSize);
            this.pnlImgSizeControls.Controls.Add(this.lblHeight);
            this.pnlImgSizeControls.Controls.Add(this.txtImgWidth);
            this.pnlImgSizeControls.Controls.Add(this.txtImgHeight);
            this.pnlImgSizeControls.Controls.Add(this.lblWidth);
            this.pnlImgSizeControls.Controls.Add(this.lblAdjustSize);
            this.pnlImgSizeControls.Location = new System.Drawing.Point(24, 14);
            this.pnlImgSizeControls.Name = "pnlImgSizeControls";
            this.pnlImgSizeControls.Size = new System.Drawing.Size(223, 106);
            this.pnlImgSizeControls.TabIndex = 19;
            this.pnlImgSizeControls.MouseEnter += new System.EventHandler(this.pnlImgSizeControls_MouseEnter);
            // 
            // nudImageSize
            // 
            this.nudImageSize.DecimalPlaces = 1;
            this.nudImageSize.Enabled = false;
            this.nudImageSize.Location = new System.Drawing.Point(89, 66);
            this.nudImageSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudImageSize.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nudImageSize.Name = "nudImageSize";
            this.nudImageSize.Size = new System.Drawing.Size(91, 20);
            this.nudImageSize.TabIndex = 8;
            this.nudImageSize.ValueChanged += new System.EventHandler(this.nudImageSize_ValueChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(45, 22);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // txtImgWidth
            // 
            this.txtImgWidth.Location = new System.Drawing.Point(89, 40);
            this.txtImgWidth.Name = "txtImgWidth";
            this.txtImgWidth.ReadOnly = true;
            this.txtImgWidth.Size = new System.Drawing.Size(76, 20);
            this.txtImgWidth.TabIndex = 6;
            // 
            // txtImgHeight
            // 
            this.txtImgHeight.Location = new System.Drawing.Point(89, 15);
            this.txtImgHeight.Name = "txtImgHeight";
            this.txtImgHeight.ReadOnly = true;
            this.txtImgHeight.Size = new System.Drawing.Size(76, 20);
            this.txtImgHeight.TabIndex = 2;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(45, 47);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width";
            // 
            // lblAdjustSize
            // 
            this.lblAdjustSize.AutoSize = true;
            this.lblAdjustSize.Location = new System.Drawing.Point(24, 73);
            this.lblAdjustSize.Name = "lblAdjustSize";
            this.lblAdjustSize.Size = new System.Drawing.Size(56, 13);
            this.lblAdjustSize.TabIndex = 7;
            this.lblAdjustSize.Text = "AdjustSize";
            // 
            // splBottomLeft
            // 
            this.splBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.splBottomLeft.Name = "splBottomLeft";
            this.splBottomLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splBottomLeft.Panel1
            // 
            this.splBottomLeft.Panel1.Controls.Add(this.pnlCropControls);
            // 
            // splBottomLeft.Panel2
            // 
            this.splBottomLeft.Panel2.Controls.Add(this.pnlSave);
            this.splBottomLeft.Size = new System.Drawing.Size(277, 313);
            this.splBottomLeft.SplitterDistance = 195;
            this.splBottomLeft.TabIndex = 2;
            // 
            // pnlCropControls
            // 
            this.pnlCropControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCropControls.Controls.Add(this.btnSetBounds);
            this.pnlCropControls.Controls.Add(this.lblBoundWidth);
            this.pnlCropControls.Controls.Add(this.lblCroppedHeight);
            this.pnlCropControls.Controls.Add(this.txtBoundWidth);
            this.pnlCropControls.Controls.Add(this.btnSelectBoundary);
            this.pnlCropControls.Controls.Add(this.txtBoundHeight);
            this.pnlCropControls.Controls.Add(this.btnCropColor);
            this.pnlCropControls.Controls.Add(this.btnCrop);
            this.pnlCropControls.Location = new System.Drawing.Point(12, 3);
            this.pnlCropControls.Name = "pnlCropControls";
            this.pnlCropControls.Size = new System.Drawing.Size(256, 189);
            this.pnlCropControls.TabIndex = 18;
            this.pnlCropControls.MouseEnter += new System.EventHandler(this.pnlCropControls_MouseEnter);
            // 
            // btnSetBounds
            // 
            this.btnSetBounds.Enabled = false;
            this.btnSetBounds.Location = new System.Drawing.Point(192, 9);
            this.btnSetBounds.Name = "btnSetBounds";
            this.btnSetBounds.Size = new System.Drawing.Size(55, 45);
            this.btnSetBounds.TabIndex = 9;
            this.btnSetBounds.Text = "Set";
            this.btnSetBounds.UseVisualStyleBackColor = true;
            this.btnSetBounds.Click += new System.EventHandler(this.btnSetBounds_Click);
            // 
            // lblBoundWidth
            // 
            this.lblBoundWidth.AutoSize = true;
            this.lblBoundWidth.Location = new System.Drawing.Point(12, 41);
            this.lblBoundWidth.Name = "lblBoundWidth";
            this.lblBoundWidth.Size = new System.Drawing.Size(83, 13);
            this.lblBoundWidth.TabIndex = 19;
            this.lblBoundWidth.Text = "Boundary Width";
            // 
            // lblCroppedHeight
            // 
            this.lblCroppedHeight.AutoSize = true;
            this.lblCroppedHeight.Location = new System.Drawing.Point(9, 16);
            this.lblCroppedHeight.Name = "lblCroppedHeight";
            this.lblCroppedHeight.Size = new System.Drawing.Size(86, 13);
            this.lblCroppedHeight.TabIndex = 17;
            this.lblCroppedHeight.Text = "Boundary Height";
            // 
            // txtBoundWidth
            // 
            this.txtBoundWidth.AcceptsReturn = true;
            this.txtBoundWidth.AcceptsTab = true;
            this.txtBoundWidth.Enabled = false;
            this.txtBoundWidth.Location = new System.Drawing.Point(101, 34);
            this.txtBoundWidth.Name = "txtBoundWidth";
            this.txtBoundWidth.Size = new System.Drawing.Size(76, 20);
            this.txtBoundWidth.TabIndex = 20;
            this.txtBoundWidth.Leave += new System.EventHandler(this.txtBoundWidth_Leave);
            // 
            // btnSelectBoundary
            // 
            this.btnSelectBoundary.Enabled = false;
            this.btnSelectBoundary.Location = new System.Drawing.Point(54, 70);
            this.btnSelectBoundary.Name = "btnSelectBoundary";
            this.btnSelectBoundary.Size = new System.Drawing.Size(165, 35);
            this.btnSelectBoundary.TabIndex = 9;
            this.btnSelectBoundary.Text = "Add Boundary";
            this.btnSelectBoundary.UseVisualStyleBackColor = true;
            this.btnSelectBoundary.Click += new System.EventHandler(this.btnSelectBoundary_Click);
            // 
            // txtBoundHeight
            // 
            this.txtBoundHeight.AcceptsReturn = true;
            this.txtBoundHeight.AcceptsTab = true;
            this.txtBoundHeight.Enabled = false;
            this.txtBoundHeight.Location = new System.Drawing.Point(101, 9);
            this.txtBoundHeight.Name = "txtBoundHeight";
            this.txtBoundHeight.Size = new System.Drawing.Size(76, 20);
            this.txtBoundHeight.TabIndex = 18;
            this.txtBoundHeight.Leave += new System.EventHandler(this.txtBoundHeight_Leave);
            // 
            // btnCropColor
            // 
            this.btnCropColor.Enabled = false;
            this.btnCropColor.Location = new System.Drawing.Point(54, 152);
            this.btnCropColor.Name = "btnCropColor";
            this.btnCropColor.Size = new System.Drawing.Size(165, 35);
            this.btnCropColor.TabIndex = 16;
            this.btnCropColor.Text = "Change Bound Color";
            this.btnCropColor.UseVisualStyleBackColor = true;
            this.btnCropColor.Click += new System.EventHandler(this.btnCropColor_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Enabled = false;
            this.btnCrop.Location = new System.Drawing.Point(54, 111);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(165, 35);
            this.btnCrop.TabIndex = 14;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnRollBack);
            this.pnlSave.Location = new System.Drawing.Point(4, 3);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(270, 103);
            this.pnlSave.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 70);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRollBack
            // 
            this.btnRollBack.Location = new System.Drawing.Point(12, 14);
            this.btnRollBack.Name = "btnRollBack";
            this.btnRollBack.Size = new System.Drawing.Size(119, 71);
            this.btnRollBack.TabIndex = 0;
            this.btnRollBack.Text = "Roll Back";
            this.btnRollBack.UseVisualStyleBackColor = true;
            this.btnRollBack.Click += new System.EventHandler(this.btnRollBack_Click);
            // 
            // splRight
            // 
            this.splRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splRight.Location = new System.Drawing.Point(0, 0);
            this.splRight.Name = "splRight";
            this.splRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splRight.Panel1
            // 
            this.splRight.Panel1.Controls.Add(this.pbxImage);
            this.splRight.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splRight.Panel2
            // 
            this.splRight.Panel2.Controls.Add(this.btnChangeImageDir);
            this.splRight.Panel2.Controls.Add(this.txtDefaultImageDir);
            this.splRight.Panel2.MouseEnter += new System.EventHandler(this.splRight_Panel2_MouseEnter);
            this.splRight.Size = new System.Drawing.Size(559, 534);
            this.splRight.SplitterDistance = 438;
            this.splRight.TabIndex = 0;
            this.splRight.MouseLeave += new System.EventHandler(this.splRight_MouseLeave);
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImage.Location = new System.Drawing.Point(10, 10);
            this.pbxImage.Margin = new System.Windows.Forms.Padding(10);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(539, 418);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            this.pbxImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxImage_Paint);
            this.pbxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxImage_MouseDown);
            this.pbxImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxImage_MouseMove);
            this.pbxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxImage_MouseUp);
            // 
            // btnChangeImageDir
            // 
            this.btnChangeImageDir.Location = new System.Drawing.Point(16, 13);
            this.btnChangeImageDir.Name = "btnChangeImageDir";
            this.btnChangeImageDir.Size = new System.Drawing.Size(169, 23);
            this.btnChangeImageDir.TabIndex = 2;
            this.btnChangeImageDir.Text = "Change  Default Directory";
            this.btnChangeImageDir.UseVisualStyleBackColor = true;
            this.btnChangeImageDir.Click += new System.EventHandler(this.btnChangeImageDir_Click);
            // 
            // txtDefaultImageDir
            // 
            this.txtDefaultImageDir.Location = new System.Drawing.Point(16, 42);
            this.txtDefaultImageDir.Name = "txtDefaultImageDir";
            this.txtDefaultImageDir.Size = new System.Drawing.Size(455, 20);
            this.txtDefaultImageDir.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.saveToolStripMenuItem2});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Load";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.loadProfileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.saveProfileToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 558);
            this.Controls.Add(this.splMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Image Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.splLeft.Panel1.ResumeLayout(false);
            this.splLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splLeft)).EndInit();
            this.splLeft.ResumeLayout(false);
            this.splTopLeft.Panel1.ResumeLayout(false);
            this.splTopLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splTopLeft)).EndInit();
            this.splTopLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlImgSizeControls.ResumeLayout(false);
            this.pnlImgSizeControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageSize)).EndInit();
            this.splBottomLeft.Panel1.ResumeLayout(false);
            this.splBottomLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBottomLeft)).EndInit();
            this.splBottomLeft.ResumeLayout(false);
            this.pnlCropControls.ResumeLayout(false);
            this.pnlCropControls.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.splRight.Panel1.ResumeLayout(false);
            this.splRight.Panel2.ResumeLayout(false);
            this.splRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splRight)).EndInit();
            this.splRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnChangeImageDir;
        private System.Windows.Forms.TextBox txtDefaultImageDir;
        private System.Windows.Forms.TextBox txtCurrentImg;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnSelectBoundary;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.SplitContainer splRight;
        private System.Windows.Forms.Button btnCropColor;
        private System.Windows.Forms.Panel pnlImgFileControls;
        private System.Windows.Forms.Panel pnlImgSizeControls;
        private System.Windows.Forms.Panel pnlCropControls;
        private System.Windows.Forms.Button btnSetBounds;
        private System.Windows.Forms.Label lblBoundWidth;
        private System.Windows.Forms.Label lblCroppedHeight;
        private System.Windows.Forms.TextBox txtBoundWidth;
        private System.Windows.Forms.TextBox txtBoundHeight;
        private System.Windows.Forms.SplitContainer splLeft;
        private System.Windows.Forms.SplitContainer splTopLeft;
        private System.Windows.Forms.SplitContainer splBottomLeft;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRollBack;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.NumericUpDown nudImageSize;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtImgWidth;
        private System.Windows.Forms.TextBox txtImgHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblAdjustSize;
    }
}

