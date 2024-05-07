using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

public class Borders : Panel
{
	public Borders()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center; 
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;
		Style.Set( "font-size: 10px; width: 100%;" );
		StyleSheet.Parse( "label { padding: 10px; background-color: #aaa3; color: white; margin: 5px; width: 100px; height: 100px; justify-content: center; align-items: center; }" );

		AddTest( "Uniform White Border", "border: 2px solid white;" );

		AddTest( "Border Bottom", "border-bottom: 10px solid white;" );
		AddTest( "Border Top", "border-top: 10px solid white;" );
		AddTest( "Border Left", "border-left: 10px solid white;" );
		AddTest( "Border Right", "border-right: 10px solid white;" );
		AddTest( "Border Mixed Size", "border: 10px solid white; border-top: 5px solid white; border-bottom: 0px solid white;" );
		AddTest( "Border Mixed Color", "border: 10px solid green; border-top: 5px solid red; border-bottom: 0px solid blue;" );
		AddTest( "Border Mixed Color 2", "border: 10px solid green; border-right: 20px; border-top: 10px solid red; border-bottom: 0px solid blue;" );
		AddTest( "Border Mixed Color Rotated 2", "border: 10px solid green; border-bottom: 20px; border-right: 10px solid red; border-left: 0px solid blue;" );

		AddTest( "Border Top And Down", "border-top: 10px solid white; border-bottom: 10px solid white;" );
		AddTest( "Border Two Corners", "border-right: 10px solid green; border-top: 10px solid red;" );
		
		// Expected https://files.facepunch.com/garry/c62de7d5-77dd-4814-bfdc-6bd0a5bf907d.png
		AddTest( "Bevel Button", "border-left: 10px solid #eee; border-right: 10px solid #aaa; border-top: 10px solid #fff; border-bottom: 10px solid #777; background-color: #ccc;" );

		// Expected https://files.facepunch.com/garry/652d3a2e-b7f7-4bbe-aae9-300025523792.png
		AddTest( "Rounded", "border-radius: 50px; border-left: 10px solid #eee; border-right: 10px solid #aaa; border-top: 10px solid #fff; border-bottom: 10px solid #777; background-color: #ccc;" );
		AddTest( "Semi Rounded", "border-radius: 20px; border-left: 10px solid #eee; border-right: 10px solid #aaa; border-top: 10px solid #fff; border-bottom: 10px solid #777; background-color: #ccc;" );

		AddTest( "Rounded Semi Borders", "border-radius: 50px; border-top: 10px solid #fff; border-bottom: 10px solid #777; background-color: #ccc;" );
		AddTest( "Semi Rounded Semi Borders", "border-radius: 20px; border-top: 10px solid #fff; border-bottom: 10px solid #777; background-color: #ccc;" );

		AddTest( "Rounded Two Corners", "border-radius: 50px; border-right: 10px solid green; border-top: 10px solid red;" );
		AddTest( "Semi Rounded Two Corners", "border-radius: 20px; border-right: 10px solid green; border-top: 10px solid red;" );

		 
		AddTest( "Border Same Color As Background", "border: 10px solid #FF0000; background-color: #FF0000;" );
		AddTest( "Border Same Color As Background", "border: 10px solid #00FF00; background-color: #00FF00;" );
		AddTest( "Border Same Color As Background", "border: 10px solid #0000FF; background-color: #0000FF;" );
		AddTest( "Border Same Color As Background", "border: 10px solid #aaa; background-color: #aaa;" );
		AddTest( "Rectangle", "width: 300px; border: 10px solid #fff; background-color: #aaa;" );
		AddTest( "Rectangle With Different Sized Borders", "width: 300px; border: 10px solid #fff;  border-bottom: 30px solid red; border-top: 0px solid green;" );
		AddTest( "Rectangle With Different Sized Borders With Radius", "border-radius: 100px; width: 300px; border: 10px solid #fff;  border-bottom: 30px solid red; border-top: 0px solid green;" );
		
		//https://files.slack.com/files-pri/T02GCKUNN-F01SF9X35SM/firefox_qlnqodq9gg.png
		AddTest( "Big filled ball","padding: 1px; border: 100px solid red; border-radius: 50%;" );

		AddTest( "Transparent Border", "border: 10px solid transparent; background-color: red;" );
		AddTest( "Partial Transparent Border", "border: 10px solid transparent; border-bottom: 10px solid white; background-color: red;" );

		//https://files.facepunch.com/layla/1b2611b1/deformed_ball.png
		AddTest( "Deformed Ball", "height: 200px; width: 200px; background-color: red; border: 20px solid black; border-radius: 50%; border-bottom-right-radius: 15%; border-left-color: orange; border-right-color: blue;" );

		// Box With Content - should appear as a white box
		{
			var p = Add.Panel();
			p.Style.Set( "border: 5px solid white; margin: 10px;" );

			var inner = p.Add.Panel();
			inner.Style.Set( "background-color: white; width: 100px; height: 100px;" );
		}
	}

	private void AddTest( string label, string v )
	{
		var p = Add.Label( label );
		p.Style.Set( v );
	}
}
