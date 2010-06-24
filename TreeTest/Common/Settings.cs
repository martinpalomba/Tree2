using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;
using System.Diagnostics;

using Microsoft.Win32;

namespace Common
{
	
//-----------------------------------------------------------------------------

	internal enum Hive
	{
		HKCU,
		HKLM,
	}

//-----------------------------------------------------------------------------

	internal class Settings
	{

//-----------------------------------------------------------------------------

		public static string DefaultRegistrySettingsPath = "Software\\" + Application.CompanyName + "\\" + Application.ProductName + "\\Settings";

//-----------------------------------------------------------------------------
// Get

		// bool
		public static bool Get( string sValueName, bool bDefault )
		{
			return Get( null, sValueName, bDefault );
		}

		public static bool Get( string sPath, string sValueName, bool bDefault )
		{
			return Get( null, sPath, sValueName, bDefault );
		}

		public static bool Get( string sRoot, string sPath, string sValueName, bool bDefault )
		{
			return Get( Hive.HKCU, sRoot, sPath, sValueName, bDefault );
		}

		public static bool Get( Hive hive, string sRoot, string sPath, string sValueName, bool bDefault )
		{
			object o = GetObject( hive, sRoot, sPath, sValueName );
			if ( o == null ) return bDefault;

			if ( ! ( o is string ) ) return bDefault;

			return ( string.Compare( (string) o, "False", true, CultureInfo.InvariantCulture ) != 0 );
		}

		// int
		public static int Get( string sValueName, int iDefault )
		{
			return Get( null, sValueName, iDefault );
		}

		public static int Get( string sPath, string sValueName, int iDefault )
		{
			return Get( null, sPath, sValueName, iDefault );
		}

		public static int Get( string sRoot, string sPath, string sValueName, int iDefault )
		{
			return Get( Hive.HKCU, sRoot, sPath, sValueName, iDefault );
		}

		public static int Get( Hive hive, string sRoot, string sPath, string sValueName, int iDefault )
		{
			object o = GetObject( hive, sRoot, sPath, sValueName );
			if ( o == null ) return iDefault;

			if ( ! ( o is int ) ) return iDefault;

			return (int) o;
		}

		// string
		public static string Get( string sValueName, string sDefault )
		{
			return Get( null, sValueName, sDefault );
		}

		public static string Get( string sPath, string sValueName, string sDefault )
		{
			return Get( null, sPath, sValueName, sDefault );
		}

		public static string Get( string sRoot, string sPath, string sValueName, string sDefault )
		{
			return Get( Hive.HKCU, sRoot, sPath, sValueName, sDefault );
		}

		public static string Get( Hive hive, string sRoot, string sPath, string sValueName, string sDefault )
		{
			object o = GetObject( hive, sRoot, sPath, sValueName );
			if ( o == null ) return sDefault;

			if ( ! ( o is string ) ) return sDefault;

			return (string) o;
		}

		// binary
		public static byte[] Get( string sValueName, byte[] iDefault )
		{
			return Get( null, sValueName, iDefault );
		}

		public static byte[] Get( string sPath, string sValueName, byte[] iDefault )
		{
			return Get( null, sPath, sValueName, iDefault );
		}

		public static byte[] Get( string sRoot, string sPath, string sValueName, byte[] iDefault )
		{
			return Get( Hive.HKCU, sRoot, sPath, sValueName, iDefault );
		}

		public static byte[] Get( Hive hive, string sRoot, string sPath, string sValueName, byte[] iDefault )
		{
			object o = GetObject( hive, sRoot, sPath, sValueName );
			if ( o == null ) return iDefault;

			if ( ! ( o is byte[] ) ) return iDefault;

			return ( byte[] ) o;
		}

		// object
		public static object GetObject( string sValueName )
		{
			return GetObject( null, sValueName );
		}

		public static object GetObject( string sPath, string sValueName )
		{
			return GetObject( null, sPath, sValueName );
		}

		public static object GetObject( string sRoot, string sPath, string sValueName )
		{
			string s = DefaultRegistrySettingsPath;
			if ( sRoot != null && sRoot.Length > 0 ) s = sRoot;
			if ( sPath != null && sPath.Length > 0 ) s += "\\" + sPath;

			RegistryKey key = Registry.CurrentUser.OpenSubKey( s );
			if ( key == null ) return null;
			
			object o = key.GetValue( sValueName );

			key.Close();

			return o;
		}

		public static object GetObject( Hive hive, string sRoot, string sPath, string sValueName )
		{
			string s = DefaultRegistrySettingsPath;
			if ( sRoot != null && sRoot.Length > 0 ) s = sRoot;
			if ( sPath != null && sPath.Length > 0 ) s += "\\" + sPath;

			RegistryKey key;

			switch ( hive )
			{
			case Hive.HKCU : key = Registry.CurrentUser .OpenSubKey( s ); break;
			case Hive.HKLM : key = Registry.LocalMachine.OpenSubKey( s ); break;
			default: throw new ArgumentException( "Unknown hive" );
			}

			if ( key == null ) return null;
			
			object o = key.GetValue( sValueName );

			key.Close();

			return o;
		}

//-----------------------------------------------------------------------------
// Set

		// bool
		public static void Set( string sValueName, bool value )
		{
			Set( null, sValueName, value );
		}

		public static void Set( string sPath, string sValueName, bool value )
		{
			Set( null, sPath, sValueName, value );
		}

		public static void Set( string sRoot, string sPath, string sValueName, bool value )
		{
			Set( sRoot, sPath, sValueName, (object) ( value ? "True" : "False" ) );
		}

		// object
		public static void Set( string sValueName, object value )
		{
			Set( null, sValueName, value );
		}

		public static void Set( string sPath, string sValueName, object value )
		{
			Set( null, sPath, sValueName, value );
		}

		public static void Set( string sRoot, string sPath, string sValueName, object value )
		{
			string s = DefaultRegistrySettingsPath;
			if ( sRoot != null && sRoot.Length > 0 ) s = sRoot;
			if ( sPath != null && sPath.Length > 0 ) s += "\\" + sPath;

			RegistryKey key = Registry.CurrentUser.CreateSubKey( s );
			key.Close();

			key = Registry.CurrentUser.OpenSubKey( s, true );

			key.SetValue( sValueName, value );

			key.Close();
		}

//-----------------------------------------------------------------------------

	} // Settings

//-----------------------------------------------------------------------------

	internal class Setting
	{
		private Hive _Hive = Hive.HKCU;
		private string _Root = String.Empty;
		private string _Path = String.Empty;
		private string _Name = String.Empty;
		private object _Default = null;

		public Setting( string name, object defaultValue )
		{
			_Name = name;
			_Default = defaultValue;
		}

		public Setting( Hive hive, string name, object defaultValue )
		{
			_Hive = hive;
			_Name = name;
			_Default = defaultValue;
		}

		public Setting( string path, string name, object defaultValue )
		{
			_Path = path;
			_Name = name;
			_Default = defaultValue;
		}

		public Setting( Hive hive, string path, string name, object defaultValue )
		{
			_Hive = hive;
			_Path = path;
			_Name = name;
			_Default = defaultValue;
		}

		public Setting( string root, string path, string name, object defaultValue )
		{
			_Root = root;
			_Path = path;
			_Name = name;
			_Default = defaultValue;
		}

		public bool Bool { get { return GetBool(); } }
		public int Int { get { return GetInt(); } }
		public string String { get { return GetString(); } }
		public byte[] Binary { get { return GetBinary(); } }

		public bool GetBool()
		{
			Debug.Assert( _Default is bool );
			return Settings.Get( _Hive, _Root, _Path, _Name, ( bool ) _Default );
		}

		public int GetInt()
		{
			Debug.Assert( _Default is int );
			return Settings.Get( _Hive, _Root, _Path, _Name, ( int ) _Default );
		}

		public string GetString()
		{
			Debug.Assert( _Default is string );
			return Settings.Get( _Hive, _Root, _Path, _Name, ( string ) _Default );
		}

		public byte[] GetBinary()
		{
			Debug.Assert( _Default == null || _Default is byte[] );
			return Settings.Get( _Hive, _Root, _Path, _Name, ( byte[] ) _Default );
		}

		public void Set( bool value )
		{
			Debug.Assert( _Default is bool );
			Settings.Set( _Root, _Path, _Name, value );
		}

		public void Set( int value )
		{
			Debug.Assert( _Default is int );
			Settings.Set( _Root, _Path, _Name, value );
		}

		public void Set( string value )
		{
			Debug.Assert( _Default is string );
			Settings.Set( _Root, _Path, _Name, value );
		}

		public void Set( byte[] value )
		{
			Debug.Assert( _Default == null || _Default is byte[] );
			Settings.Set( _Root, _Path, _Name, value );
		}
	}

//-----------------------------------------------------------------------------

	internal class ControlPosition
	{
		private const string _Key = "Positions";

		private static ArrayList _Positions = new ArrayList();

		public static ControlPosition Get( Control control )
		{
			foreach ( ControlPosition position in _Positions )
				if ( position._Control == control )
					return position;

			return null;
		}

		public static ControlPosition GetCreate( Control control )
		{
			ControlPosition position = Get( control );

			if ( position == null )
			{
				position = new ControlPosition( control );
				_Positions.Add( position );
			}

			return position;
		}

		public static ControlPosition Save( Control control )
		{
			ControlPosition position = GetCreate( control );

			position.Save();

			return position;
		}

		public static ControlPosition Restore( Control control )
		{
			ControlPosition position = GetCreate( control );

			position.Restore();

			return position;
		}

		private Control _Control = null;
		private Form _Form = null;

		private bool _IsForm = false;

		protected ControlPosition( Control control )
		{
			_Control = control;

			_Form = _Control.FindForm();

			_IsForm = ( _Control == _Form );

			_Control.HandleDestroyed += new EventHandler( _Control_HandleDestroyed );
		}

		protected virtual bool IsForm { get { return _IsForm; } }

		protected virtual string Key
		{
			get
			{
				if ( _IsForm ) return _Key + '\\' + _Form.Name;

				return _Key + '\\' + _Form.Name + '\\' + _Control.Name;
			}
		}

		private void _Control_HandleDestroyed( object sender, EventArgs e )
		{
			Debug.Assert( sender == _Control );

			Save();
		}

		public virtual void Save()
		{
			string s = Key;

			Settings.Set( s, "Top"    , _Control.Top    );
			Settings.Set( s, "Left"   , _Control.Left   );
			Settings.Set( s, "Width"  , _Control.Width  );
			Settings.Set( s, "Height" , _Control.Height );
		}

		public virtual void Restore()
		{
			string s = Key;

			_Control.Top    = Settings.Get( s, "Top"    , _Control.Top    );
			_Control.Left   = Settings.Get( s, "Left"   , _Control.Left   );
			_Control.Width  = Settings.Get( s, "Width"  , _Control.Width  );
			_Control.Height = Settings.Get( s, "Height" , _Control.Height );
		}
	}

	internal class FormPosition : ControlPosition
	{
		public FormPosition( Form form ) : base ( form )
		{
		}
	}

//-----------------------------------------------------------------------------

}
