Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Imports System.Windows.Forms
Namespace TreeViewAdvNodeId
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.integerTextBox1 = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.integerTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeViewAdv1
            ' 
            Me.treeViewAdv1.BackColor = System.Drawing.Color.White
            Me.treeViewAdv1.BeforeTouchSize = New System.Drawing.Size(250, 274)
            Me.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.CanSelectDisabledNode = False
            ' 
            ' 
            ' 
            Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.HelpTextControl.Name = "helpText"
            Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
            Me.treeViewAdv1.HelpTextControl.TabIndex = 0
            Me.treeViewAdv1.HelpTextControl.Text = "help text"
            Me.treeViewAdv1.Location = New System.Drawing.Point(25, 39)
            Me.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
            Me.treeViewAdv1.Name = "treeViewAdv1"
            Me.treeViewAdv1.SelectedNodeBackground = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))))
            Me.treeViewAdv1.ShowFocusRect = False
            Me.treeViewAdv1.Size = New System.Drawing.Size(250, 274)
            Me.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro
            Me.treeViewAdv1.TabIndex = 0
            Me.treeViewAdv1.Text = "treeViewAdv1"
            ' 
            ' 
            ' 
            Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
            Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
            Me.treeViewAdv1.ToolTipControl.TabIndex = 1
            Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.treeViewAdv1)
            Me.groupBox1.Location = New System.Drawing.Point(34, 40)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(311, 349)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "TreeViewAdv"
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(425, 116)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(98, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Type Node ID here"
            ' 
            ' integerTextBox1
            ' 
            Me.integerTextBox1.BackGroundColor = System.Drawing.SystemColors.Window
            Me.integerTextBox1.BeforeTouchSize = New System.Drawing.Size(141, 20)
            Me.integerTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.integerTextBox1.IntegerValue = (CLng(Fix(1)))
            Me.integerTextBox1.Location = New System.Drawing.Point(428, 157)
            Me.integerTextBox1.Metrocolor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(211))))), (CInt(Fix((CByte(212))))))
            Me.integerTextBox1.Name = "integerTextBox1"
            Me.integerTextBox1.NullString = ""
            Me.integerTextBox1.Size = New System.Drawing.Size(141, 20)
            Me.integerTextBox1.TabIndex = 6
            Me.integerTextBox1.Text = "1"
            ' 
            ' buttonAdv1
            ' 
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
            Me.buttonAdv1.BeforeTouchSize = New System.Drawing.Size(141, 46)
            Me.buttonAdv1.ForeColor = System.Drawing.Color.White
            Me.buttonAdv1.IsBackStageButton = False
            Me.buttonAdv1.Location = New System.Drawing.Point(428, 204)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(141, 46)
            Me.buttonAdv1.TabIndex = 7
            Me.buttonAdv1.Text = "Click here to see the node corresponding to the ID"
            Me.buttonAdv1.Appearance = ButtonAppearance.Metro
            Me.buttonAdv1.UseVisualStyle = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.SystemColors.MenuHighlight
            Me.BorderThickness = 2
            Me.CaptionBarColor = System.Drawing.SystemColors.MenuHighlight
            Me.CaptionButtonColor = System.Drawing.Color.White
            Me.CaptionForeColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(678, 460)
            Me.Controls.Add(Me.buttonAdv1)
            Me.Controls.Add(Me.integerTextBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.groupBox1)
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "Form1"
            Me.Text = "TreeViewAdv"
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.integerTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label2 As Label
        Private integerTextBox1 As IntegerTextBox
        Private buttonAdv1 As ButtonAdv
    End Class
End Namespace