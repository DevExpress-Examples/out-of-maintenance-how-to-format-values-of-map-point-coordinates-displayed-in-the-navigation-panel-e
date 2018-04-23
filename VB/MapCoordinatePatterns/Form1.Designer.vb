Imports Microsoft.VisualBasic
Imports System
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
			Dim imageTilesLayer1 As New DevExpress.XtraMap.ImageTilesLayer()
			Dim openStreetMapDataProvider1 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.cbLongitude = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbLatitude = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.cbLongitude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLatitude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mapControl1
			' 
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			imageTilesLayer1.DataProvider = openStreetMapDataProvider1
			Me.mapControl1.Layers.Add(imageTilesLayer1)
			Me.mapControl1.Location = New System.Drawing.Point(0, 56)
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(664, 350)
			Me.mapControl1.TabIndex = 0
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.cbLongitude)
			Me.panel1.Controls.Add(Me.cbLatitude)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(664, 56)
			Me.panel1.TabIndex = 1
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(295, 25)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(94, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Longitude Pattern:"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(28, 25)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(85, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Latitude Pattern:"
			' 
			' cbLongitude
			' 
			Me.cbLongitude.Location = New System.Drawing.Point(405, 22)
			Me.cbLongitude.Name = "cbLongitude"
			Me.cbLongitude.Properties.AutoComplete = False
			Me.cbLongitude.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLongitude.Size = New System.Drawing.Size(129, 20)
			Me.cbLongitude.TabIndex = 1
'			Me.cbLongitude.EditValueChanged += New System.EventHandler(Me.cbLongitude_EditValueChanged);
			' 
			' cbLatitude
			' 
			Me.cbLatitude.Location = New System.Drawing.Point(119, 22)
			Me.cbLatitude.Name = "cbLatitude"
			Me.cbLatitude.Properties.AutoComplete = False
			Me.cbLatitude.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLatitude.Properties.DropDownRows = 8
			Me.cbLatitude.Size = New System.Drawing.Size(130, 20)
			Me.cbLatitude.TabIndex = 0
'			Me.cbLatitude.EditValueChanged += New System.EventHandler(Me.cbLatitude_EditValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(664, 406)
			Me.Controls.Add(Me.mapControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.cbLongitude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLatitude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private mapControl1 As DevExpress.XtraMap.MapControl
		Private panel1 As System.Windows.Forms.Panel
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents cbLongitude As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbLatitude As DevExpress.XtraEditors.ComboBoxEdit

	End Class
End Namespace

