namespace ImageEditor
{
    partial class frmCropProfile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCropProfile));
            this.cropProfileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cropProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cropProfileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvCropProfiles = new System.Windows.Forms.DataGridView();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CropColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetColor = new System.Windows.Forms.Button();
            this.btnGetDir = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cropProfileBindingNavigator)).BeginInit();
            this.cropProfileBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCropProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // cropProfileBindingNavigator
            // 
            this.cropProfileBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cropProfileBindingNavigator.BindingSource = this.cropProfileBindingSource;
            this.cropProfileBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cropProfileBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cropProfileBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cropProfileBindingNavigatorSaveItem});
            this.cropProfileBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cropProfileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cropProfileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cropProfileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cropProfileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cropProfileBindingNavigator.Name = "cropProfileBindingNavigator";
            this.cropProfileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cropProfileBindingNavigator.Size = new System.Drawing.Size(927, 25);
            this.cropProfileBindingNavigator.TabIndex = 0;
            this.cropProfileBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // cropProfileBindingSource
            // 
            this.cropProfileBindingSource.DataSource = typeof(ImageEditor.CropProfile);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cropProfileBindingNavigatorSaveItem
            // 
            this.cropProfileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cropProfileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cropProfileBindingNavigatorSaveItem.Image")));
            this.cropProfileBindingNavigatorSaveItem.Name = "cropProfileBindingNavigatorSaveItem";
            this.cropProfileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cropProfileBindingNavigatorSaveItem.Text = "Save Data";
            this.cropProfileBindingNavigatorSaveItem.Click += new System.EventHandler(this.cropProfileBindingNavigatorSaveItem_Click);
            // 
            // dgvCropProfiles
            // 
            this.dgvCropProfiles.AutoGenerateColumns = false;
            this.dgvCropProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCropProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileName,
            this.DefaultHeight,
            this.DefaultWidth,
            this.CropColor,
            this.DefaultDirectory});
            this.dgvCropProfiles.DataSource = this.cropProfileBindingSource;
            this.dgvCropProfiles.Location = new System.Drawing.Point(12, 105);
            this.dgvCropProfiles.MultiSelect = false;
            this.dgvCropProfiles.Name = "dgvCropProfiles";
            this.dgvCropProfiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCropProfiles.Size = new System.Drawing.Size(899, 196);
            this.dgvCropProfiles.TabIndex = 1;
            this.dgvCropProfiles.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCropProfiles_CellEnter);
            this.dgvCropProfiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCropProfiles_RowEnter);
            this.dgvCropProfiles.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvCropProfiles_Paint);
            // 
            // ProfileName
            // 
            this.ProfileName.DataPropertyName = "Name";
            this.ProfileName.HeaderText = "Profile Name";
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Width = 150;
            // 
            // DefaultHeight
            // 
            this.DefaultHeight.DataPropertyName = "Height";
            this.DefaultHeight.HeaderText = "Default Height";
            this.DefaultHeight.Name = "DefaultHeight";
            this.DefaultHeight.Width = 60;
            // 
            // DefaultWidth
            // 
            this.DefaultWidth.DataPropertyName = "Width";
            this.DefaultWidth.HeaderText = "Default Width";
            this.DefaultWidth.Name = "DefaultWidth";
            this.DefaultWidth.Width = 60;
            // 
            // CropColor
            // 
            this.CropColor.DataPropertyName = "CropColor";
            this.CropColor.HeaderText = "Crop Color";
            this.CropColor.Name = "CropColor";
            this.CropColor.Width = 80;
            // 
            // DefaultDirectory
            // 
            this.DefaultDirectory.DataPropertyName = "ImageDirectory";
            this.DefaultDirectory.HeaderText = "Default Image Directory";
            this.DefaultDirectory.Name = "DefaultDirectory";
            this.DefaultDirectory.Width = 500;
            // 
            // btnGetColor
            // 
            this.btnGetColor.Enabled = false;
            this.btnGetColor.Location = new System.Drawing.Point(329, 76);
            this.btnGetColor.Name = "btnGetColor";
            this.btnGetColor.Size = new System.Drawing.Size(75, 23);
            this.btnGetColor.TabIndex = 2;
            this.btnGetColor.Text = "Get Color";
            this.btnGetColor.UseVisualStyleBackColor = true;
            this.btnGetColor.Click += new System.EventHandler(this.btnGetColor_Click);
            // 
            // btnGetDir
            // 
            this.btnGetDir.Enabled = false;
            this.btnGetDir.Location = new System.Drawing.Point(410, 76);
            this.btnGetDir.Name = "btnGetDir";
            this.btnGetDir.Size = new System.Drawing.Size(98, 23);
            this.btnGetDir.TabIndex = 3;
            this.btnGetDir.Text = "Get Directory";
            this.btnGetDir.UseVisualStyleBackColor = true;
            this.btnGetDir.Click += new System.EventHandler(this.btnGetDir_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(78, 330);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 43);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(214, 330);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 43);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmCropProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 395);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnGetDir);
            this.Controls.Add(this.btnGetColor);
            this.Controls.Add(this.dgvCropProfiles);
            this.Controls.Add(this.cropProfileBindingNavigator);
            this.Name = "frmCropProfile";
            this.ShowInTaskbar = false;
            this.Text = "frmCropProfile";
            ((System.ComponentModel.ISupportInitialize)(this.cropProfileBindingNavigator)).EndInit();
            this.cropProfileBindingNavigator.ResumeLayout(false);
            this.cropProfileBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCropProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cropProfileBindingSource;
        private System.Windows.Forms.BindingNavigator cropProfileBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cropProfileBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvCropProfiles;
        private System.Windows.Forms.Button btnGetColor;
        private System.Windows.Forms.Button btnGetDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn CropColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultDirectory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnLoad;
    }
}