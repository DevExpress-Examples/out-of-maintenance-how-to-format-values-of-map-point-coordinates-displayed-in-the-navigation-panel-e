Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace MapCoordinatePatterns

    Partial Public Class Form1
        Inherits Form

        Private patterns() As String = { "{D:1}°{CP}", "{CP}{D:6}°", "{D}°{M:2}'{CP}", "{CP}{D}°{M:2}'", "{D}°{M}'{S:4}''{CP}", "{CP}{D}°{M}'{S:4}''", "Coordinates: {D}°{M}'{S:2}''{CP}" }

        Public Sub New()
            InitializeComponent()
            PopulateComboBox(cbXCoordinatePattern)
            PopulateComboBox(cbYCoordinatePattern)
        End Sub

        Private Sub PopulateComboBox(ByVal comboBox As ComboBoxEdit)
            comboBox.Properties.Items.AddRange(patterns)
            comboBox.EditValue = comboBox.Properties.Items(0)
        End Sub
        Private Sub OnXCoordinatePatternSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbXCoordinatePattern.SelectedIndexChanged
            map.NavigationPanelOptions.XCoordinatePattern = TryCast(cbXCoordinatePattern.EditValue, String)
        End Sub

        Private Sub OnYCoordinatePatternSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbYCoordinatePattern.SelectedIndexChanged
            map.NavigationPanelOptions.YCoordinatePattern = TryCast(cbYCoordinatePattern.EditValue, String)
        End Sub
    End Class
End Namespace
