using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;
using System.Runtime.InteropServices;

namespace TreeTest
{
	public partial class MainForm : Form
	{
		private ITree<Element> _Tree;
		private ITree<Element> _TreeClipboard;

		public MainForm()
		{
			InitializeComponent();

			_Mode.RefreshTree += delegate( object sender, EventArgs args ) { OnViewRefresh(); };

			_Mode.SetTreeClipboard += new EventHandler<TreeEventArgs>( Mode_SetClipboard );

			_Tree = NodeTree<Element>.NewTree();

			HookTreeEvents( _Tree );

			OnFileNew();

			OnNewTreeClipboard();
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			//_Mode.Focus();
		}

		private void _NewTree_Click( object sender, EventArgs e )
		{
			OnFileNew();
		}

		private void _ClearTree_Click( object sender, EventArgs e )
		{
			_Tree.Clear();

			OnViewRefresh();

			_NewTreeIndex = 0;

			_Mode.OnNewTree();
		}

		private void ClearEvents_Click( object sender, EventArgs e )
		{
			EventOutput.Clear();
		}

		private void _NewTreeClipboard_Click( object sender, EventArgs e )
		{
			OnNewTreeClipboard();
		}

		private void _ClearTreeClipboard_Click( object sender, EventArgs e )
		{
			_TreeClipboard.Clear();

			_Mode.TreeClipboard = _TreeClipboard;

			OnViewRefresh();
		}

		private void TreeView_AfterSelect( object sender, TreeViewEventArgs e )
		{
			INode<Element> n = e.Node.Tag as INode<Element>;

			_Mode.CurrentNode = n;
		}

		void Mode_SetClipboard( object sender, TreeEventArgs e )
		{
			_TreeClipboard = e.Tree;

			_Mode.TreeClipboard = _TreeClipboard;

			OnViewRefresh();
		}

	}
}