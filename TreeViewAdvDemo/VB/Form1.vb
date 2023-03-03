Imports Syncfusion.Windows.Forms
Imports System
Imports System.Windows.Forms

Namespace TreeViewAdvNodeId
    Partial Public Class Form1
        Inherits MetroForm
#Region "Constructor"
        Public Sub New()
            InitializeComponent()
            For nodeId As Integer = 0 To 10000
                'Custom node for ID propety
                Dim customNode As New CustomTreeNodeAdv()
                customNode.ID = nodeId
                customNode.Text = "Node" & nodeId.ToString()
                Me.treeViewAdv1.Nodes.Add(customNode)
            Next nodeId
            AddHandler Me.buttonAdv1.Click, AddressOf buttonAdv1_Click
        End Sub
#End Region

        Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Iterating the nodes in the TreeViewAdv
            For Each item As CustomTreeNodeAdv In Me.treeViewAdv1.Nodes
                'To get the TextBox value
                Dim textvalue As String = item.ID.ToString()
                If Me.integerTextBox1.Text = textvalue Then
                    'Get the node by its ID
                    MessageBox.Show(item.Text)
                End If
            Next item
        End Sub
    End Class
End Namespace