using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeElement : TreeTest.ModeBase
	{
		public ModeElement()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Element; } }

		private Element CreateElement()
		{
			return new Element( Element.Text );
		}

		public override INode<Element> CurrentNode
		{
			set
			{
				base.CurrentNode = value;

				ContainsElement.Checked = CurrentNode.Contains( CreateElement() );
			}
		}

		private void Element_TextChanged( object sender, EventArgs e )
		{
			ContainsElement.Checked = CurrentNode.Contains( CreateElement() );
		}

		private void Cut_Click( object sender, EventArgs e )
		{
			ITree<Element> tree = CurrentNode.Cut( CreateElement() );

			OnSetTreeClipboard( tree );
		}

		private void Copy_Click( object sender, EventArgs e )
		{
			ITree<Element> tree = CurrentNode.Copy( CreateElement() );

			OnSetTreeClipboard( tree );
		}

		private void DeepCopy_Click( object sender, EventArgs e )
		{
			ITree<Element> tree = CurrentNode.DeepCopy( CreateElement() );

			OnSetTreeClipboard( tree );
		}

		private void Remove_Click( object sender, EventArgs e )
		{
			CurrentNode.Remove( CreateElement() );

			OnRefreshTree();
		}
	}
}

