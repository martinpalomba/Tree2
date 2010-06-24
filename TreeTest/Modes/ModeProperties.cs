using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeProperties : ModeBase
	{
		public ModeProperties()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Properties; } }

		public override INode<Element> CurrentNode
		{
			set
			{
				base.CurrentNode = value;

				INode<Element> n = value;

				IsTree.Checked = ( n.IsTree );
				IsRoot.Checked = ( n.IsRoot );
				IsTop.Checked = ( n.IsTop );
				IsFirst.Checked = ( n.IsFirst );
				IsLast.Checked = ( n.IsLast );
				HasParent.Checked = ( n.HasParent );
				HasPrevious.Checked = ( n.HasPrevious );
				HasNext.Checked = ( n.HasNext );
				HasChild.Checked = ( n.HasChild );
			}
		}
	}
}
