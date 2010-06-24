using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeMove : ModeBase
	{
		public ModeMove()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Move; } }

		public override INode<Element> CurrentNode
		{
			set
			{
				base.CurrentNode = value;

				CanMoveToParent.Checked = CurrentNode.CanMoveToParent;
				CanMoveToPrevious.Checked = CurrentNode.CanMoveToPrevious;
				CanMoveToNext.Checked = CurrentNode.CanMoveToNext;
				CanMoveToChild.Checked = CurrentNode.CanMoveToChild;
				CanMoveToFirst.Checked = CurrentNode.CanMoveToFirst;
				CanMoveToLast.Checked = CurrentNode.CanMoveToLast;
			}
		}

		private void MoveToParent_Click( object sender, EventArgs e )
		{
			CurrentNode.MoveToParent();
			OnRefreshTree();
		}

		private void MoveToPrevious_Click( object sender, EventArgs e )
		{
			CurrentNode.MoveToPrevious();
			OnRefreshTree();
		}

		private void MoveToNext_Click( object sender, EventArgs e )
		{
			CurrentNode.MoveToNext();
			OnRefreshTree();
		}

		private void MoveToChild_Click( object sender, EventArgs e )
		{
			CurrentNode.MoveToChild();
			OnRefreshTree();
		}

		private void MoveToFirst_Click( object sender, EventArgs e )
		{
			CurrentNode.MoveToFirst();
			OnRefreshTree();
		}

		private void MoveToLast_Click( object sender, EventArgs e )
		{
			CurrentNode.MoveToLast();
			OnRefreshTree();
		}

	}
}
