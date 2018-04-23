Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class RibbonForm1
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
			Me.ribbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.beiValueA = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.beiOperation = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.beiValueB = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.bsiResult = New DevExpress.XtraBars.BarStaticItem()
			Me.beiShowProgress = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.beiProgress = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.clientPanel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbon
			' 
			Me.ribbon.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbon.ExpandCollapseItem.Id = 0
			Me.ribbon.ExpandCollapseItem.Name = ""
			Me.ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbon.ExpandCollapseItem, Me.beiValueA, Me.beiOperation, Me.beiValueB, Me.bsiResult, Me.beiShowProgress, Me.beiProgress})
			Me.ribbon.Location = New System.Drawing.Point(0, 0)
			Me.ribbon.MaxItemId = 7
			Me.ribbon.Name = "ribbon"
			Me.ribbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2})
			Me.ribbon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemComboBox1, Me.repositoryItemSpinEdit2, Me.repositoryItemCheckEdit1, Me.repositoryItemProgressBar1})
			Me.ribbon.SelectedPage = Me.ribbonPage1
			Me.ribbon.Size = New System.Drawing.Size(707, 153)
			Me.ribbon.StatusBar = Me.ribbonStatusBar
			' 
			' beiValueA
			' 
			Me.beiValueA.Caption = "Value A"
			Me.beiValueA.Edit = Me.repositoryItemSpinEdit1
			Me.beiValueA.Id = 1
			Me.beiValueA.Name = "beiValueA"
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' beiOperation
			' 
			Me.beiOperation.Caption = "Operation"
			Me.beiOperation.Edit = Me.repositoryItemComboBox1
			Me.beiOperation.Id = 2
			Me.beiOperation.Name = "beiOperation"
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "Plus", "Minus"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' beiValueB
			' 
			Me.beiValueB.Caption = "Value B"
			Me.beiValueB.Edit = Me.repositoryItemSpinEdit2
			Me.beiValueB.Id = 3
			Me.beiValueB.Name = "beiValueB"
			' 
			' repositoryItemSpinEdit2
			' 
			Me.repositoryItemSpinEdit2.AutoHeight = False
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.repositoryItemSpinEdit2.IsFloatValue = False
			Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' bsiResult
			' 
			Me.bsiResult.Caption = "Result ="
			Me.bsiResult.Id = 4
			Me.bsiResult.Name = "bsiResult"
			Me.bsiResult.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' beiShowProgress
			' 
			Me.beiShowProgress.Caption = "Show progress"
			Me.beiShowProgress.Edit = Me.repositoryItemCheckEdit1
			Me.beiShowProgress.Id = 5
			Me.beiShowProgress.Name = "beiShowProgress"
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' beiProgress
			' 
			Me.beiProgress.Edit = Me.repositoryItemProgressBar1
			Me.beiProgress.Id = 6
			Me.beiProgress.Name = "beiProgress"
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.beiValueA)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.beiOperation, True)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.beiValueB, True)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.ItemLinks.Add(Me.beiProgress)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.bsiResult)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "ribbonPageGroup2"
			' 
			' ribbonPageGroup3
			' 
			Me.ribbonPageGroup3.ItemLinks.Add(Me.beiShowProgress)
			Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
			Me.ribbonPageGroup3.Text = "Options"
			' 
			' ribbonPage2
			' 
			Me.ribbonPage2.Name = "ribbonPage2"
			Me.ribbonPage2.Text = "ribbonPage2"
			' 
			' ribbonStatusBar
			' 
			Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 418)
			Me.ribbonStatusBar.Name = "ribbonStatusBar"
			Me.ribbonStatusBar.Ribbon = Me.ribbon
			Me.ribbonStatusBar.Size = New System.Drawing.Size(707, 31)
			' 
			' clientPanel
			' 
			Me.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.clientPanel.Location = New System.Drawing.Point(0, 153)
			Me.clientPanel.Name = "clientPanel"
			Me.clientPanel.Size = New System.Drawing.Size(707, 265)
			Me.clientPanel.TabIndex = 2
			' 
			' RibbonForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(707, 449)
			Me.Controls.Add(Me.clientPanel)
			Me.Controls.Add(Me.ribbonStatusBar)
			Me.Controls.Add(Me.ribbon)
			Me.Name = "RibbonForm1"
			Me.Ribbon = Me.ribbon
			Me.StatusBar = Me.ribbonStatusBar
			Me.Text = "RibbonForm1"
			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbon As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private clientPanel As DevExpress.XtraEditors.PanelControl
		Private beiValueA As DevExpress.XtraBars.BarEditItem
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private beiOperation As DevExpress.XtraBars.BarEditItem
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private beiValueB As DevExpress.XtraBars.BarEditItem
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private bsiResult As DevExpress.XtraBars.BarStaticItem
		Private beiShowProgress As DevExpress.XtraBars.BarEditItem
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private beiProgress As DevExpress.XtraBars.BarEditItem
		Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
	End Class
End Namespace