using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;
using System.Diagnostics;

namespace TreeTest
{
	public partial class ModeMemory : TreeTest.ModeBase
	{
		private Setting _LastIterations = new Setting( "LastIterations", "1000" );
		private Setting _LastAddEventHandler = new Setting( "LastAddEventHandler", false );

		public ModeMemory()
		{
			InitializeComponent();

			_Iterations.Text = _LastIterations.String;
			_AddEventHandler.Checked = _LastAddEventHandler.Bool;
		}

		public override Mode Mode { get { return Mode.Memory; } }

		private void _Iterations_SelectedIndexChanged( object sender, EventArgs e )
		{
			_LastIterations.Set( _Iterations.Text );
		}

		private void _Iterations_TextUpdate( object sender, EventArgs e )
		{
			_LastIterations.Set( _Iterations.Text );
		}

		private void _AddEventHandler_CheckedChanged( object sender, EventArgs e )
		{
			_LastAddEventHandler.Set( _AddEventHandler.Checked );
		}

		private void _RunTest_Click( object sender, EventArgs e )
		{
			int count = Int32.Parse( _Iterations.Text );
			bool addEventHandler = _AddEventHandler.Checked;

			EventHandler<NodeTreeDataEventArgs<Int32>> NodeValidate = delegate( object s, NodeTreeDataEventArgs<Int32> a ) { };

			Stopwatch stopwatch = new Stopwatch();
			Debug.Assert( Stopwatch.IsHighResolution );
			double frequency = Stopwatch.Frequency;

			GC.Collect();
			long startMemory = GC.GetTotalMemory( true );

			ITree<Int32> tree = NodeTree<Int32>.NewTree();

			stopwatch.Start();

			for ( int i = 0 ; i < count ; i++ )
			{
				INode<Int32> node = tree.InsertChild( 42 );
				//INode<Int32> node = tree.AddChild( 42 );

				if ( addEventHandler ) node.Validate += NodeValidate;
			}

			stopwatch.Stop();

			GC.Collect();
			long endMemory = GC.GetTotalMemory( true );

			// stops optimization
			if ( tree.Root.Child.Data != 42 ) MessageBox.Show( "Wrong number" );

			tree = null;
			GC.Collect();
			long afterMemory = GC.GetTotalMemory( true );

			double time = stopwatch.ElapsedTicks * 1000 / frequency;

			long usedMemory = endMemory - startMemory;
			long residualMemory = afterMemory - startMemory;
			long memory = usedMemory;// - residualMemory;

			_Time.Text = ( time / count ).ToString( "0.000000" ) + " ms per node";
			_Memory.Text = ( memory / count ) + " bytes per node";
		}

	}
}

