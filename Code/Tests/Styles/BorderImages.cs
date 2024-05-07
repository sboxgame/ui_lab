using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

public class BorderImages : Panel
{
	public BorderImages()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center; 
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;
		Style.Set( "font-size: 10px; width: 100%;" );
		StyleSheet.Parse( "label { padding: 60px; background-color: #fff3d4; color: black; font-size: 20px; margin: 5px; width: 285px; height: 210px; justify-content: center; align-items: center; }" );

		// Sequentially, all 4 tests from mozilla: https://developer.mozilla.org/en-US/docs/Web/CSS/border-image
		AddTest( "This is a box with a border around it", "border-image: url( /content/border-diamonds.png ) 30;" );
		AddTest( "This is a box with a border around it", "border-image: url( /content/border-diamonds.png ) 30 / 19px round;" );
		AddTest( "This is a box with a border around it", "border-image: url( /content/border-diamonds.png ) 30 / 36px fill round;" );

		AddTest( "This is a box with a border around it", "border-image: url( /content/border-diamonds.png ) 60 / 60;" );

		// https://i.imgur.com/164m8Pw.png
		AddTest( "This element is surrounded by a bitmap-based border-image!", "border-image: url( /content/border-diamonds.png ) 30 / 36px 28px 18px 8px round;" );

		AddTest( "Masked Man:\nOr perhaps he's wondering, why would someone shoot a man, before throwing him out of a plane?",
				 "background-color: blue; color: white; width: 768px; height: 200px; align-items: stretch;" + 
				 "border-radius: 10px; font-family: monospace; font-size: 20px;  border: 6px solid black;" +
				 "border-image: url( /content/border-ff.png ) 30  round;"
				 );

		AddTest( "This is a box with a gradient border around it", "border-image: linear-gradient( #ff00ff, #00ff00 ) stretch; border-width: 32px;" );
		
	}

	private void AddTest( string label, string v )
	{
		var p = Add.Panel();
		p.Style.Set( v );
		p.AddChild( new Label() { Text = label } );
	}
}
