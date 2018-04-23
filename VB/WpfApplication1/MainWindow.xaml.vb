Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports DevExpress.Xpf.Gauges

Namespace WpfApplication1

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnCreepingLineAnimationCompleted(ByVal sender As Object, ByVal e As EventArgs)
			Dim blinking As New BlinkingAnimation()
			matrix.Animation = blinking
			digitalGaugeControl1.Text = "www.devexpress.com"
		End Sub

	End Class
End Namespace
