using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Styles;

[StyleSheet]
public class BackdropFilter : Panel
{
	public Panel ExamplePanel { get; set; }
	public Panel BlurPanel { get; set; }

	[Property]
	[Range( 0, 1000, 1, false )]
	public float FilterBlur { get; set; } = 10;

	[Property]
	[Range( 0, 2, clamped: false )]
	public float FilterBrightness { get; set; } = 1.0f;

	[Property]
	[Range( 0, 2, clamped: false )]
	public float FilterContrast { get; set; } = 1.0f;

	[Property]
	[Range( 0, 2, clamped: false )]
	public float FilterSaturate { get; set; } = 1.0f;

	[Property]
	[Range( 0, 1, clamped: false )]
	public float FilterSepia { get; set; } = 1.0f;

	[Property]
	[Range( 0, 1, clamped: false )]
	public float FilterInvert { get; set; } = 0.0f;

	[Property( "hue-rotate", "Hue-Rotate", "The rotation of the hue" )]
	[Range( 0, 360 )]
	public float FilterHueRotate { get; set; } = 0.0f;

	[Property]
	public Color BackgroundColor { get; set; } = Color.Green.WithAlpha( 0.5f );

	[Property]
	[Range( 0, 100 )]
	public float BorderSize { get; set; } = 0.0f;

	[Property]
	[Range( 0, 50 )]
	public float BorderRadius { get; set; } = 25.0f;

	public BackdropFilter()
	{
		AddClass( "root has-form" );
		BlurPanel = AddChild<Panel>( "blur_panel" );
		ExamplePanel = AddChild<Panel>( "example_panel" );
	}

	public override void Tick()
	{
		base.Tick();

		Style.BackgroundPositionX = RealTime.Now * -10.0f;
		Style.BackgroundPositionY = MathF.Cos( RealTime.Now * 2.0f ) * 50.0f;
		Style.BackgroundRepeat = BackgroundRepeat.Repeat;

		BlurPanel.Style.BackdropFilterBlur = FilterBlur * 2;
		BlurPanel.Style.Right = ( MathF.Sin( RealTime.Now * 2.0f ) * 500.0f ) + 500.0f;
		BlurPanel.Style.ZIndex = Time.Now % ( 2.0f * MathF.PI ) > MathF.PI ? 10 : -10;
		BlurPanel.Style.Dirty();

		ExamplePanel.Style.BackdropFilterBlur = FilterBlur;
		ExamplePanel.Style.BackdropFilterBrightness = FilterBrightness;
		ExamplePanel.Style.BackdropFilterContrast = FilterContrast;
		ExamplePanel.Style.BackdropFilterSaturate = FilterSaturate;
		ExamplePanel.Style.BackdropFilterSepia = FilterSepia;
		ExamplePanel.Style.BackdropFilterInvert = FilterInvert;
		ExamplePanel.Style.BackdropFilterHueRotate = FilterHueRotate;
		ExamplePanel.Style.BackgroundColor = BackgroundColor;
		ExamplePanel.Style.Set( $"border: {BorderSize}px solid white;" );
		ExamplePanel.Style.Set( $"border-radius: {BorderRadius}%;" );
		ExamplePanel.Style.Dirty();

	}

}
