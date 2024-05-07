using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

public class TextColor : Panel
{
	public TextColor()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;

		AddTest( "color: linear-gradient( 90deg, rgba(255,0,0,1), rgba(255,154,0,1), rgba(208,222,33,1), rgba(79,220,74,1), rgba(63,218,216,1), rgba(47,201,226,1), rgba(28,127,238,1), rgba(95,21,242,1), rgba(186,12,248,1), rgba(251,7,217,1), rgba(255,0,0,1) ); font-size: 20px; background-color: black" );

		AddTest( "color: white; font-size: 20px; background-color: white" );
		AddTest( "color: black; font-size: 20px; background-color: black" );

		AddTest( "color: gray; font-size: 20px; background-color: black" );
		AddTest( "color: white; font-size: 20px; background-color: black" );
		AddTest( "color: black; font-size: 20px; background-color: white" );
		AddTest( "color: red; font-size: 20px; background-color: white" );
		AddTest( "color: red; font-size: 20px; background-color: black" );

		AddTest( "color: white; font-size: 15px; background-color: black" );
		AddTest( "color: black; font-size: 15px; background-color: white" );
		AddTest( "color: red; font-size: 15px; background-color: white" );
		AddTest( "color: red; font-size: 15px; background-color: black" );

		AddTest( "color: white; font-size: 11px; background-color: black" );
		AddTest( "color: black; font-size: 11px; background-color: white" );
		AddTest( "color: red; font-size: 11px; background-color: white" );
		AddTest( "color: red; font-size: 11px; background-color: black" );

		AddTest( "color: white; font-size: 8px; background-color: black" );
		AddTest( "color: black; font-size: 8px; background-color: white" );
		AddTest( "color: red; font-size: 8px; background-color: white" );
		AddTest( "color: red; font-size: 8px; background-color: black" );

		AddTest( "color: rgb(255, 0, 255); font-size: 8px; background-color: black" );
		AddTest( "color: rgba(255, 255, 0, 100); font-size: 8px; background-color: black" );
		AddTest( "color: hsla(196, 100%, 50%, 0.8); font-size: 8px; background-color: black" );
		AddTest( "color: hsl(71, 100%, 50%); font-size: 8px; background-color: black" );
		AddTest( "color: hsla(8, 50%, 80%, 80%); font-size: 8px; background-color: black" );
	}

	private void AddTest( string style )
	{
		var p = Add.Label( "This Is Some Text 🎨 😋" );
		p.Style.Set( $"{style}; padding: 20px; margin: 30px; border-radius: 10px; box-shadow: 2px 2px 5px black;" );
	}
}
