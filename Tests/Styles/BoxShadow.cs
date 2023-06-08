using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

public class BoxShadow : Panel
{
	public BoxShadow()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;
		Style.Set( "font-size: 15px; font-weight: bolder; color: gray; width: 100%;" );

		AddTest( "5px 5px 0px black" );
		AddTest( "5px 5px 0px black; border-radius: 10px" );

		AddTest( "5px 5px 5px black" );
		AddTest( "5px 5px 5px black; border-radius: 10px" );

		AddTest( "5px 5px 20px black" );
		AddTest( "5px 5px 20px black; border-radius: 10px" );

		AddTest( "0px 0px 10px black" );
		AddTest( "0px 0px 25px black" );
		AddTest( "0px 0px 50px black" );
		AddTest( "0px 0px 100px black" );
		AddTest( "0px 0px 200px black" );

		AddTest( "0px 0px 10px 10px yellow" );
		AddTest( "0px 0px 25px red" );
		AddTest( "0px 0px 50px yellow" );
		AddTest( "0px 0px 100px yellow" );

		AddTest( "0px 0px 30px yellow, 0px 0px 10px 5px red; border-radius: 1000px" );

		AddTest( "0px 0px 20px 10px black" );
		AddTest( "0px 0px 30px 15px black" );
		AddTest( "0px 0px 50px 25px black" );
		AddTest( "0px 0px 60px 30px black" );

		AddTest( "5px 5px 0px black", "transparent" );
		AddTest( "5px 5px 0px black; border-radius: 10px", "transparent" );
	}

	private void AddTest( string v, string bgcolor = "white" )
	{
		var p = Add.Label( v );
		p.Style.Set( $"box-shadow: {v}; background-color: {bgcolor}; padding: 20px; margin: 30px;" );
	}
}
