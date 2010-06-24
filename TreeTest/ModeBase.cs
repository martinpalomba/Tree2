using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeBase : UserControl
	{
		private INode<Element> _CurrentNode = null;
		private ITree<Element> _TreeClipboard = null;

		public virtual INode<Element> CurrentNode
		{
			protected get { return _CurrentNode; }
			set { _CurrentNode = value; }
		}

		public virtual ITree<Element> TreeClipboard
		{
			protected get { return _TreeClipboard; }
			set { _TreeClipboard = value; }
		}

		public ModeBase()
		{
			InitializeComponent();
		}

		[Browsable( false )]
		public virtual Mode Mode { get { return Mode.None; } }

		public virtual void OnNewTree() { }

		public event EventHandler RefreshTree;
		protected virtual void OnRefreshTree()
		{
			if ( RefreshTree != null ) RefreshTree( this, EventArgs.Empty );
		}

		public event EventHandler<TreeEventArgs> SetTreeClipboard;
		protected virtual void OnSetTreeClipboard( ITree<Element> tree )
		{
			if ( SetTreeClipboard != null ) SetTreeClipboard( this, new TreeEventArgs( tree ) );
		}
	}

	public class TreeEventArgs : EventArgs
	{
		private ITree<Element> _Tree;

		public ITree<Element> Tree { get { return _Tree; } }

		public TreeEventArgs( ITree<Element> tree )
		{
			_Tree = tree;
		}
	}
}
