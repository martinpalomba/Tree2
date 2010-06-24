using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

using Common;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace TreeTest
{
	public partial class ModeSerialization : TreeTest.ModeBase
	{
		public ModeSerialization()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Serialization; } }

		private string Filename
		{
			get
			{
				if ( Binary.Checked ) return "Tree.dat";

				if ( XML.Checked ) return "Tree.xml";

				throw new InvalidOperationException( "Unknown state" );
			}
		}

		private IFormatter Formatter
		{
			get
			{
				if ( Binary.Checked )
				{
					IFormatter f = new BinaryFormatter();
					//IFormatter f = new SoapFormatter();

					f.Binder = new ElementSerializationBinder();

					return f;
				}

				throw new InvalidOperationException( "Unknown state" );
			}
		}

		private void Serialize_Click( object sender, EventArgs e )
		{
			using ( Stream stream = File.Open( Filename, FileMode.Create, FileAccess.Write ) )
			{
				ITree<Element> tree = CurrentNode.Copy();

				if ( Binary.Checked ) Formatter.Serialize( stream, tree );

				if ( XML.Checked ) tree.XmlSerialize( stream );
			}
		}

		private void ViewFile_Click( object sender, EventArgs e )
		{
			if ( Binary.Checked ) System.Diagnostics.Process.Start( "Notepad", Filename );

			if ( XML.Checked ) System.Diagnostics.Process.Start( Filename );
		}

		private void Deserialize_Click( object sender, EventArgs e )
		{
			using ( Stream stream = File.Open( Filename, FileMode.Open, FileAccess.Read ) )
			{
				ITree<Element> tree = null;

				if ( Binary.Checked ) tree = ( NodeTree<Element> ) Formatter.Deserialize( stream );

				if ( XML.Checked ) tree = NodeTree<Element>.XmlDeserialize( stream );

				OnSetTreeClipboard( tree );
			}
		}

	}

	public class ElementSerializationBinder : SerializationBinder
	{
		private static readonly Regex _Assembly = new Regex( "(?<name>[^,]+)", RegexOptions.Compiled );

		private static readonly Regex _Version = new Regex( ", Version=\\d+\\.\\d+\\.\\d+\\.\\d+", RegexOptions.Compiled );
		private static readonly Regex _Culture = new Regex( ", Culture=neutral", RegexOptions.Compiled );
		private static readonly Regex _Token = new Regex( ", PublicKeyToken=\\w+", RegexOptions.Compiled );

		public override Type BindToType( string assemblyName, string typeName )
		{
			if ( typeName.StartsWith( "System" ) ) return null;
			if ( typeName.StartsWith( "Microsoft" ) ) return null;

			string a1 = assemblyName;
			string a2 = _Assembly.Match( a1 ).Groups[ "name" ].Value;

			string t1 = typeName;
			string t2 = _Version.Replace( t1, String.Empty );
			string t3 = _Culture.Replace( t2, String.Empty );
			string t4 = _Token.Replace( t3, String.Empty );

			string s = t4 + ", " + a2;

			Type t = Type.GetType( s );

			Debug.Assert( t != null );

			return t;
		}
	}
}

