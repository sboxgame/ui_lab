using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

[StyleSheet]
public class BorderRadius : Panel
{
	public BorderRadius()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;


		for (int i=0; i<13; i++ )
		AddTest( $"border-radius: {i}px;", $"{i}px" );

		for ( int i = 1; i < 12; i++ )
			AddTest( $"border-radius: {i*5}px;", $"{i*5}px" );

		AddTest( $"border-radius: 50px 0px 0px 0px;", $"top left" );
		AddTest( $"border-radius: 0px 50px 0px 0px;", $"top right" );
		AddTest( $"border-radius: 0px 0px 50px 0px;", $"bottom right" );
		AddTest( $"border-radius: 0px 0px 0px 50px;", $"bottom left" );
		AddTest( $"border-bottom-right-radius: 50px;", $"border-bottom-right-radius" );
		AddTest( $"border-bottom-left-radius: 50px;", $"border-bottom-left-radius" );
		AddTest( $"border-top-left-radius: 50px;", $"border-top-left-radius" );
		AddTest( $"border-top-right-radius: 50px;", $"border-top-right-radius" );
	}

	void AddTest( string styles, string text )
	{
		var p = Add.Label( text, "panel" );
		p.Style.Set( styles );

		var img = Add.Image( "/content/background.png", "image" );
		img.Style.Set( styles );
	}
}
