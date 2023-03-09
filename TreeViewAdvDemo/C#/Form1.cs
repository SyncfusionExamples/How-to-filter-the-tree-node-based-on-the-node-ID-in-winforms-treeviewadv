using Syncfusion.Windows.Forms;
using System;
using System.Windows.Forms;

namespace TreeViewAdvNodeId
{
    public partial class Form1 : MetroForm
	{
        #region Constructor
        public Form1()
		{
			InitializeComponent();
            for (int nodeId = 0; nodeId <= 10000; nodeId++)
			{
				//Custom node for ID propety
				CustomTreeNodeAdv customNode = new CustomTreeNodeAdv();
                customNode.ID = nodeId;
                customNode.Text = "Node" + nodeId.ToString();
                this.treeViewAdv1.Nodes.Add(customNode);
			}
            this.buttonAdv1.Click += buttonAdv1_Click;
		}
        #endregion
        
        void buttonAdv1_Click(object sender, EventArgs e)
        {
            //Iterating the nodes in the TreeViewAdv
            foreach (CustomTreeNodeAdv item in this.treeViewAdv1.Nodes)
            {
                //To get the TextBox value
                string textvalue = item.ID.ToString();
                if (this.integerTextBox1.Text == textvalue)
                {
                    //Get the node by its ID
                    MessageBox.Show(item.Text);
                }
            }
        }
	}
}