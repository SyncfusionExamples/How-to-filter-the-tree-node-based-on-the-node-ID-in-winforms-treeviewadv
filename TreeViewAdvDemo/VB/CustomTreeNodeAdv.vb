Imports Syncfusion.Windows.Forms.Tools

Namespace TreeViewAdvNodeId
    'Creating custom class
    Public Class CustomTreeNodeAdv
        Inherits TreeNodeAdv
        Public Sub New()
            'do something
        End Sub

        Private m_NodeId As Integer
        ''' <summary>
        ''' Gets/Sets the Id in TreeNodeAdv
        ''' </summary>
        Public Property ID() As Integer
            Get
                Return m_NodeId
            End Get
            Set(ByVal value As Integer)
                m_NodeId = value
            End Set
        End Property
    End Class
End Namespace