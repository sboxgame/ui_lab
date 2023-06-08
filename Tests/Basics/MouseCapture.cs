using Sandbox.ModelEditor;
using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Basics;

public class MouseCapture : Panel
{
	Label label;
	Vector2 position;

	public MouseCapture()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;
		Style.Set( "font-size: 10px; width: 100%; overflow: hidden;" );
		StyleSheet.Parse( "label { text-align: right; font-size: 30px; padding: 20px; border-radius: 100px; background-color: #aaa3; color: white; }" );

		label = Add.Label( "Click on the background" );
	}

	protected override void OnMouseDown( MousePanelEvent e )
	{
		base.OnMouseDown( e );
		e.StopPropagation();
	}

	public override void OnButtonEvent( ButtonEvent e )
	{
		if ( e.Button == "mouseleft" )
		{
			SetMouseCapture( e.Pressed );
		}

		base.OnButtonEvent( e );
	}

	public override void Tick()
	{
		base.Tick();

		if ( HasMouseCapture )
		{
			position += Mouse.Delta;

			label.Text = $"{position.x}\n{position.y}";

			label.Style.Left = position.x;
			label.Style.Top = position.y;
			label.Style.Dirty();
		}

	}
}
