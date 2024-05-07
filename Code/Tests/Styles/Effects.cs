using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

public class Effects : Panel
{
	public Effects()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;
		Style.Set( "background-image: url( /ui/tests/background.png ); background-repeat: repeat; font-size: 10px; width: 100%;" );
		StyleSheet.Parse( "label { padding: 10px; background-color: rgba(0,0,0,0.4); color: white; margin: 5px; width: 100px; height: 100px; justify-content: center; align-items: center;  }" );

		//AddTest( "Background Blur 2px", "backdrop-filter: blur(2px);" );
		//AddTest( "Background Blur 10px", "backdrop-filter: blur( 10px );" );
		//AddTest( "Background Blur 10px And Unsaturated", "backdrop-filter: blur( 10px ) saturate(0);" );
		//AddTest( "Very Saturated", "backdrop-filter: saturate(200%);" );

		AddTest( "Gradient", "background: linear-gradient(to left, #e66465, #9198e5);" );
		AddTest( "Gradient", "background: linear-gradient(0.25turn, #3f87a6, #ebf8e1, #f69d3c);" );
		AddTest( "Gradient with Rotation", "background: linear-gradient( 12.5% , #f69d3c, #ebf8e1, #f69d3c);" );
		AddTest( "Gradient with offset and rotation", "background: linear-gradient(to right, #3f87a6, #ebf8e1 25%, #f69d3c);" ); // Todo: Needs bg repeat finished
		AddTest( "Rainbow", "background: linear-gradient( rgba(255,0,0,1), rgba(255,154,0,1), rgba(208,222,33,1), rgba(79,220,74,1), rgba(63,218,216,1), rgba(47,201,226,1), rgba(28,127,238,1), rgba(95,21,242,1), rgba(186,12,248,1), rgba(251,7,217,1), rgba(255,0,0,1) )" );
		AddTest( "Gradient with direction", "background: linear-gradient(to left, #333, #333 50%, #eee 75%, #333 75%);" );

		AddTest( "Gradient", "background: radial-gradient(#e66465, #9198e5);" );
		AddTest( "Gradient", "background: radial-gradient(orange, yellow, red, magenta, blue, transparent);" );

		AddTest( "Conic Gradient", "border-radius: 50%; background: conic-gradient(red, yellow, green);" );
	}

	private void AddTest( string label, string v )
	{
		var p = Add.Label( label );
		p.Style.Set( v );
	}
}
