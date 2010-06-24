using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TreeTest
{
	//-----------------------------------------------------------------------------
	// Element

	[Serializable]
	public class Element //: IDeepCopy
	{
		private string _Data = String.Empty;

		public string Data
		{
			get { return _Data; }
			set { _Data = value; }
		}

		// Support XmlSerialization
		private Element() { }

		public Element( string s )
		{
			_Data = s;
		}

#if true
		public Element( Element o )
		{
			_Data = o._Data + " *COPYCTOR*";
		}
#endif
		public override bool Equals( object obj )
		{
			if ( obj == null ) return false;

			Element o = obj as Element;
			if ( o == null ) { Debug.Assert( false ); return false; }

			return _Data == o._Data;
		}

		public override int GetHashCode()
		{
			return _Data.GetHashCode();
		}

		public override string ToString()
		{
			return _Data;
		}

		public object CreateDeepCopy()
		{
			return new Element( _Data + " *DEEPCOPY*" );
		}
	}

	//-----------------------------------------------------------------------------

}
