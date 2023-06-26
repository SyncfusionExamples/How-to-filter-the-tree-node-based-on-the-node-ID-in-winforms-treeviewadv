using Syncfusion.Windows.Forms.Tools;

namespace TreeViewAdvNodeId
{
    //Creating custom class
    public class CustomTreeNodeAdv : TreeNodeAdv
	{
		public CustomTreeNodeAdv()
		{
			//do something
		}

		private int m_NodeId;
		/// <summary>
		/// Gets/Sets the Id in TreeNodeAdv
		/// </summary>
		public int ID
		{
			get
			{
				return m_NodeId;
			}
			set
			{
				m_NodeId = value;
			}
		}
	}
}