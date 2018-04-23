Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports System.Threading
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class RibbonForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm
		Public Sub New()
			InitializeComponent()
			InitValues()
			Calculate()
			For Each item As RepositoryItem In ribbon.Manager.RepositoryItems
				AddHandler item.EditValueChanged, AddressOf item_EditValueChanged
			Next item
		End Sub

		Private Sub item_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If TypeOf sender Is CheckEdit Then
				If (TryCast(sender, CheckEdit)).Checked Then
					beiProgress.Visibility = BarItemVisibility.Always
				Else
					beiProgress.Visibility = BarItemVisibility.Never
				End If
				Return
			End If
			ribbon.Manager.ActiveEditItemLink.PostEditor()
			ShowProgress()
			Calculate()
		End Sub
		Private Sub InitValues()
			beiValueA.EditValue = 1
			beiOperation.EditValue = "Plus"
			beiValueB.EditValue = 2
			beiShowProgress.EditValue = True
		End Sub

		Private Sub ShowProgress()
			If beiProgress.Visibility = BarItemVisibility.Never Then
				Return
			End If
			For i As Integer = repositoryItemProgressBar1.Minimum To repositoryItemProgressBar1.Maximum - 1
				beiProgress.EditValue = i
				Application.DoEvents()
				Thread.Sleep(1)
			Next i
		End Sub
		Private Sub Calculate()
			Dim operation As Integer
			If Object.Equals(beiOperation.EditValue, "Minus") Then
				operation = -1
			Else
				operation = 1
			End If
			Dim result As Single = Convert.ToInt32(beiValueA.EditValue) + Convert.ToInt32(beiValueB.EditValue) * operation
			bsiResult.Caption ="Result = " & result
		End Sub
	End Class
End Namespace