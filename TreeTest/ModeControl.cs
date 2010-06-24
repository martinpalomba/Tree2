using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeControl : ModeBase
	{
		private List<ModeBase> _Controls = new List<ModeBase>();

		private ModeCounts _Counts = new ModeCounts();
		private ModeRelationships _Relationships = new ModeRelationships();
		private ModeProperties _Properties = new ModeProperties();
		private ModeAddElement _AddElement = new ModeAddElement();
		private ModeAddTree _AddTree = new ModeAddTree();
		private ModeMove _Move = new ModeMove();
		private ModeNode _Node = new ModeNode();
		private ModeElement _Element = new ModeElement();
		private ModeEnumerators _Enumerators = new ModeEnumerators();
		private ModeSerialization _Serialization = new ModeSerialization();
		private ModeMemory _Memory = new ModeMemory();

		private Setting _Operation = new Setting( "Operation", ( int ) Mode.Counts );

		public ModeControl()
		{
			InitializeComponent();

			FieldInfo[] fields = GetType().GetFields( BindingFlags.Instance | BindingFlags.NonPublic );
			
			foreach ( FieldInfo field in fields )
				if ( field.FieldType.IsSubclassOf( typeof ( ModeBase ) ) )
					_Controls.Add( ( ModeBase ) field.GetValue( this ) );

			foreach ( ModeBase control in _Controls )
			{
				control.Location = _Panel.Location;
				control.Size = _Panel.Size;
				Controls.Add( control );

				control.RefreshTree += delegate( object sender, EventArgs args ) { OnRefreshTree(); };
				control.SetTreeClipboard += delegate( object sender, TreeEventArgs args ) { OnSetTreeClipboard( args.Tree ); };
			}

			foreach ( Mode mode in Enum.GetValues( typeof( Mode ) ) )
				if ( mode != Mode.None )
					_Mode.Items.Add( mode );

			_Mode.SelectedItem = ( Mode ) _Operation.Int;

			SetVisible();
		}

		private void ModeControl_Load( object sender, EventArgs e )
		{
		}

		public override INode<Element> CurrentNode
		{
			set
			{
				base.CurrentNode = value;

				foreach ( ModeBase control in _Controls ) control.CurrentNode = value;
			}
		}

		public override ITree<Element> TreeClipboard
		{
			set
			{
				base.TreeClipboard = value;

				foreach ( ModeBase control in _Controls ) control.TreeClipboard = value;
			}
		}

		public override void OnNewTree()
		{
			foreach ( ModeBase control in _Controls ) control.OnNewTree();
		}

		private void _Mode_SelectedIndexChanged( object sender, EventArgs e )
		{
			SetVisible();
		}

		private void SetVisible()
		{
			Mode mode = ( Mode ) _Mode.SelectedItem;

			_Operation.Set( ( int ) mode );

			foreach ( ModeBase control in _Controls ) control.Visible = ( control.Mode == mode );
		}
	}

	public enum Mode
	{
		None,
		Counts,
		Relationships,
		Properties,
		AddElement,
		AddTree,
		Move,
		Node,
		Element,
		Enumerators,
		Serialization,
		Memory,
	}

}
