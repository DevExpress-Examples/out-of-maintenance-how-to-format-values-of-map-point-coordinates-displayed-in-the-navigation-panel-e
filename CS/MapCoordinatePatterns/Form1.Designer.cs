namespace MapCoordinatePatterns {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageLayer imageTilesLayer3 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider3 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.map = new DevExpress.XtraMap.MapControl();
            this.cbYCoordinatePattern = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbXCoordinatePattern = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciXCoordinatePattern = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciYCoordinatePattern = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMap = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYCoordinatePattern.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbXCoordinatePattern.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciXCoordinatePattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYCoordinatePattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMap)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            imageTilesLayer3.DataProvider = openStreetMapDataProvider3;
            this.map.Layers.Add(imageTilesLayer3);
            this.map.Location = new System.Drawing.Point(4, 28);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(616, 289);
            this.map.TabIndex = 0;
            // 
            // cbYCoordinatePattern
            // 
            this.cbYCoordinatePattern.Location = new System.Drawing.Point(441, 4);
            this.cbYCoordinatePattern.Name = "cbYCoordinatePattern";
            this.cbYCoordinatePattern.Properties.AutoComplete = false;
            this.cbYCoordinatePattern.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbYCoordinatePattern.Size = new System.Drawing.Size(179, 20);
            this.cbYCoordinatePattern.StyleController = this.layoutControl1;
            this.cbYCoordinatePattern.TabIndex = 1;
            this.cbYCoordinatePattern.SelectedIndexChanged += new System.EventHandler(this.OnYCoordinatePatternSelectedIndexChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.map);
            this.layoutControl1.Controls.Add(this.cbXCoordinatePattern);
            this.layoutControl1.Controls.Add(this.cbYCoordinatePattern);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(624, 321);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbXCoordinatePattern
            // 
            this.cbXCoordinatePattern.Location = new System.Drawing.Point(113, 4);
            this.cbXCoordinatePattern.Name = "cbXCoordinatePattern";
            this.cbXCoordinatePattern.Properties.AutoComplete = false;
            this.cbXCoordinatePattern.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbXCoordinatePattern.Properties.DropDownRows = 8;
            this.cbXCoordinatePattern.Size = new System.Drawing.Size(179, 20);
            this.cbXCoordinatePattern.StyleController = this.layoutControl1;
            this.cbXCoordinatePattern.TabIndex = 0;
            this.cbXCoordinatePattern.SelectedIndexChanged += new System.EventHandler(this.OnXCoordinatePatternSelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciXCoordinatePattern,
            this.lciYCoordinatePattern,
            this.lciMap});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(624, 321);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciXCoordinatePattern
            // 
            this.lciXCoordinatePattern.Control = this.cbXCoordinatePattern;
            this.lciXCoordinatePattern.Location = new System.Drawing.Point(0, 0);
            this.lciXCoordinatePattern.Name = "lciXCoordinatePattern";
            this.lciXCoordinatePattern.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 20, 2, 2);
            this.lciXCoordinatePattern.Size = new System.Drawing.Size(310, 24);
            this.lciXCoordinatePattern.Text = "X-Coordinate Pattern:";
            this.lciXCoordinatePattern.TextSize = new System.Drawing.Size(106, 13);
            // 
            // lciYCoordinatePattern
            // 
            this.lciYCoordinatePattern.Control = this.cbYCoordinatePattern;
            this.lciYCoordinatePattern.Location = new System.Drawing.Point(310, 0);
            this.lciYCoordinatePattern.Name = "lciYCoordinatePattern";
            this.lciYCoordinatePattern.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2);
            this.lciYCoordinatePattern.Size = new System.Drawing.Size(310, 24);
            this.lciYCoordinatePattern.Text = "Y-Coordinate Pattern:";
            this.lciYCoordinatePattern.TextSize = new System.Drawing.Size(106, 13);
            // 
            // lciMap
            // 
            this.lciMap.Control = this.map;
            this.lciMap.Location = new System.Drawing.Point(0, 24);
            this.lciMap.Name = "lciMap";
            this.lciMap.Size = new System.Drawing.Size(620, 293);
            this.lciMap.TextSize = new System.Drawing.Size(0, 0);
            this.lciMap.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYCoordinatePattern.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbXCoordinatePattern.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciXCoordinatePattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYCoordinatePattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl map;
        private DevExpress.XtraEditors.ComboBoxEdit cbYCoordinatePattern;
        private DevExpress.XtraEditors.ComboBoxEdit cbXCoordinatePattern;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciXCoordinatePattern;
        private DevExpress.XtraLayout.LayoutControlItem lciYCoordinatePattern;
        private DevExpress.XtraLayout.LayoutControlItem lciMap;
    }
}

