using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

[StyleSheet]
public class BackgroundPosition : Panel
{
	public BackgroundPosition()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;

		AddTest( "background-position: left top;", "left top" );
		AddTest( "background-position: right top;", "right top" );
		AddTest( "background-position: center;", "center" );
		AddTest( "background-position: right bottom;", "bottom right" );
		AddTest( "background-position: left bottom;", "left bottom" );
		AddTest( "background-position: center top;", "center top" );
		AddTest( "background-position: 20px 0px;", "20px left" );
		AddTest( "background-position: 50% 50%;", "50% 50%" );
		AddTest( "background-position: 0px 20px;", "20px down" );

		// contain / cover
		AddTest( "background-size: cover;", "cover" );
		AddTest( "background-size: contain;", "contain" );
		AddTest( "background-size: 100%;", "100%" );

		AddTest( "background-size: cover; width: 200px;", "cover top left" );
		AddTest( "background-size: contain;  width: 200px;", "contain" );

		AddTest( "background-size: cover; height: 200px;", "cover" );
		AddTest( "background-size: contain; height: 200px;", "contain" );

		AddTest( "background-size: cover; background-position: center; height: 200px;", "cover center" );
		AddTest( "background-size: contain; background-position: center; height: 200px;", "contain center" );
	}

	void AddTest( string styles, string text )
	{
		var p = Add.Label( text, "image" );
		p.Style.Set( styles );
	}
}
