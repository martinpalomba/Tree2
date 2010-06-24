using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeRelationships : ModeBase
	{
		public ModeRelationships()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Relationships; } }

		public override INode<Element> CurrentNode
		{
			set
			{
				base.CurrentNode = value;

				INode<Element> n = value;

				ParentNode.Text = ( n.Parent == null ) ? "NULL" : n.Parent.ToString();
				PreviousNode.Text = ( n.Previous == null ) ? "NULL" : n.Previous.ToString();
				NextNode.Text = ( n.Next == null ) ? "NULL" : n.Next.ToString();
				ChildNode.Text = ( n.Child == null ) ? "NULL" : n.Child.ToString();
				TreeNode.Text = ( n.Tree == null ) ? "NULL" : n.Tree.ToString();
				RootNode.Text = ( n.Root == null ) ? "NULL" : n.Root.ToString();
				TopNode.Text = ( n.Top == null ) ? "NULL" : n.Top.ToString();
				FirstNode.Text = ( n.First == null ) ? "NULL" : n.First.ToString();
				LastNode.Text = ( n.Last == null ) ? "NULL" : n.Last.ToString();
				LastChildNode.Text = ( n.LastChild == null ) ? "NULL" : n.LastChild.ToString();
			}
		}
	}
}
