Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace MapCoordinatePatterns

	Partial Public Class Form1
		Inherits Form

		Private patterns() As String = { "{D:1}°{CP}", "{CP}{D:6}°", "{D}°{M:2}'{CP}", "{CP}{D}°{M:2}'", "{D}°{M}'{S:4}''{CP}", "{CP}{D}°{M}'{S:4}''", "Coordinates: {D}°{M}'{S:2}''{CP}" }

		Public Sub New()
			InitializeComponent()
			FillLongitudePattern()
			FillLatitudePattern()
		End Sub

		Public Sub FillLongitudePattern()
			cbLongitude.EditValue = patterns(0)
			cbLongitude.Properties.Items.AddRange(patterns)
		End Sub

		Public Sub FillLatitudePattern()
			cbLatitude.EditValue = patterns(0)
			cbLatitude.Properties.Items.AddRange(patterns)
		End Sub

		Private Sub cbLatitude_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLatitude.EditValueChanged
			mapControl1.NavigationPanelOptions.LatitudePattern = cbLatitude.EditValue.ToString()
		End Sub

		Private Sub cbLongitude_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLongitude.EditValueChanged
			mapControl1.NavigationPanelOptions.LongitudePattern = cbLongitude.EditValue.ToString()
		End Sub
	End Class
End Namespace
