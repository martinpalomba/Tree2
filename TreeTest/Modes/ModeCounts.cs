using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeCounts : ModeBase
	{
		public ModeCounts()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Counts; } }

		public override INode<Element> CurrentNode
		{
			set
			{
				base.CurrentNode = value;

				INode<Element> n = value;

				TreeCount.Text = ( n == null ) ? "NULL" : n.Tree.Count.ToString();
				NodeCount.Text = ( n == null ) ? "NULL" : n.Count.ToString();
				DirectChildCount.Text = ( n == null ) ? "NULL" : n.DirectChildCount.ToString();
				Depth.Text = ( n == null ) ? "NULL" : n.Depth.ToString();
				BranchCount.Text = ( n == null ) ? "NULL" : n.BranchCount.ToString();
				BranchIndex.Text = ( n == null ) ? "NULL" : n.BranchIndex.ToString();
			}
		}
	}
}
