Namespace MapCoordinatePatterns
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer3 As New DevExpress.XtraMap.ImageLayer()
            Dim openStreetMapDataProvider3 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.map = New DevExpress.XtraMap.MapControl()
            Me.cbYCoordinatePattern = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbXCoordinatePattern = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciXCoordinatePattern = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciYCoordinatePattern = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciMap = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.map, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbYCoordinatePattern.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.cbXCoordinatePattern.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciXCoordinatePattern, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciYCoordinatePattern, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciMap, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' map
            ' 
            imageTilesLayer3.DataProvider = openStreetMapDataProvider3
            Me.map.Layers.Add(imageTilesLayer3)
            Me.map.Location = New System.Drawing.Point(4, 28)
            Me.map.Name = "map"
            Me.map.Size = New System.Drawing.Size(616, 289)
            Me.map.TabIndex = 0
            ' 
            ' cbYCoordinatePattern
            ' 
            Me.cbYCoordinatePattern.Location = New System.Drawing.Point(441, 4)
            Me.cbYCoordinatePattern.Name = "cbYCoordinatePattern"
            Me.cbYCoordinatePattern.Properties.AutoComplete = False
            Me.cbYCoordinatePattern.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbYCoordinatePattern.Size = New System.Drawing.Size(179, 20)
            Me.cbYCoordinatePattern.StyleController = Me.layoutControl1
            Me.cbYCoordinatePattern.TabIndex = 1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.map)
            Me.layoutControl1.Controls.Add(Me.cbXCoordinatePattern)
            Me.layoutControl1.Controls.Add(Me.cbYCoordinatePattern)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(624, 321)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbXCoordinatePattern
            ' 
            Me.cbXCoordinatePattern.Location = New System.Drawing.Point(113, 4)
            Me.cbXCoordinatePattern.Name = "cbXCoordinatePattern"
            Me.cbXCoordinatePattern.Properties.AutoComplete = False
            Me.cbXCoordinatePattern.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbXCoordinatePattern.Properties.DropDownRows = 8
            Me.cbXCoordinatePattern.Size = New System.Drawing.Size(179, 20)
            Me.cbXCoordinatePattern.StyleController = Me.layoutControl1
            Me.cbXCoordinatePattern.TabIndex = 0
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciXCoordinatePattern, Me.lciYCoordinatePattern, Me.lciMap})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(624, 321)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciXCoordinatePattern
            ' 
            Me.lciXCoordinatePattern.Control = Me.cbXCoordinatePattern
            Me.lciXCoordinatePattern.Location = New System.Drawing.Point(0, 0)
            Me.lciXCoordinatePattern.Name = "lciXCoordinatePattern"
            Me.lciXCoordinatePattern.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 20, 2, 2)
            Me.lciXCoordinatePattern.Size = New System.Drawing.Size(310, 24)
            Me.lciXCoordinatePattern.Text = "X-Coordinate Pattern:"
            Me.lciXCoordinatePattern.TextSize = New System.Drawing.Size(106, 13)
            ' 
            ' lciYCoordinatePattern
            ' 
            Me.lciYCoordinatePattern.Control = Me.cbYCoordinatePattern
            Me.lciYCoordinatePattern.Location = New System.Drawing.Point(310, 0)
            Me.lciYCoordinatePattern.Name = "lciYCoordinatePattern"
            Me.lciYCoordinatePattern.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
            Me.lciYCoordinatePattern.Size = New System.Drawing.Size(310, 24)
            Me.lciYCoordinatePattern.Text = "Y-Coordinate Pattern:"
            Me.lciYCoordinatePattern.TextSize = New System.Drawing.Size(106, 13)
            ' 
            ' lciMap
            ' 
            Me.lciMap.Control = Me.map
            Me.lciMap.Location = New System.Drawing.Point(0, 24)
            Me.lciMap.Name = "lciMap"
            Me.lciMap.Size = New System.Drawing.Size(620, 293)
            Me.lciMap.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMap.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.map, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbYCoordinatePattern.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.cbXCoordinatePattern.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciXCoordinatePattern, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciYCoordinatePattern, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciMap, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private map As DevExpress.XtraMap.MapControl
        Private WithEvents cbYCoordinatePattern As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents cbXCoordinatePattern As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciXCoordinatePattern As DevExpress.XtraLayout.LayoutControlItem
        Private lciYCoordinatePattern As DevExpress.XtraLayout.LayoutControlItem
        Private lciMap As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

