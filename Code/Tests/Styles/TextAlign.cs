using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

public class TextAlign : Panel
{
	public TextAlign() 
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center; 
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;

		AddTest( "text-align: left" );
		AddTest( "text-align: right" );
		AddTest( "text-align: center" );
	}

	private void AddTest( string style )
	{
		var p = Add.Label( "Hello this is some text. \nAnd a new line." );
		p.Style.Set( $"{style}; padding: 20px; margin: 30px; border-radius: 10px; box-shadow: 2px 2px 5px black; color: white; width: 256px; height: 256px;" );
	}
}
