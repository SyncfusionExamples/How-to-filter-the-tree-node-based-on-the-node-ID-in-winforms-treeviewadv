# How to filter the tree node based on the node ID in WinForms TreeViewAdv?

In the [WinForms TreeViewAdv](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.TreeViewAdv.html), [TreeNodeAdv](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.TreeNodeAdv.html) can be filtered based on its value by performing the iteration process. The following code example demonstrates the same.

**C# Code snippet:**

```C#

for(int nodeId = 0; nodeId <= 10000; nodeId++)
{
     //Custom node for ID property
    CustomTreeNodeAdv customNode = new CustomTreeNodeAdv();
    customNode.ID = nodeId;
    customNode.Text = "Node" + nodeId.ToString();
    this.treeViewAdv1.Nodes.Add(customNode);
}

//Iterates the nodes in the TreeViewAdv
foreach (CustomTreeNodeAdv item in this.treeViewAdv1.Nodes)
{
    //Gets the TextBox value
    string textvalue = item.ID.ToString();
    if(this.integerTextBox1.Text == textvalue)
    {
       //Gets the node by its ID
       MessageBox.Show(item.Text);
    }
}

```

**VB.Net Code snippet:**

```VB
' Add 10,001 custom nodes to the TreeViewAdv
For nodeId As Integer = 0 To 10000
    'Create a custom node with an ID property
    Dim customNode As New CustomTreeNodeAdv()
    customNode.ID = nodeId
    customNode.Text = "Node" & nodeId.ToString()
    Me.treeViewAdv1.Nodes.Add(customNode)
Next nodeId

'Iterates the nodes in the TreeViewAdv
For Each item As CustomTreeNodeAdv In Me.treeViewAdv1.Nodes
    'Gets the TextBox value
    Dim textvalue As String = item.ID.ToString()
    If Me.integerTextBox1.Text = textvalue Then
       'Gets the node by its ID
       MessageBox.Show(item.Text)
    End If
Next item

```
