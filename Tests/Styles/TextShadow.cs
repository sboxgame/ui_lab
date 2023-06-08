using System;
using System.ComponentModel;

namespace Sandbox.UI.Tests.Styles;

public class TextShadowProperties
{
	[Range( 10, 200 ), Category( "Text" )]
	public int TextSize { get; set; } = 50;

	[Category( "Text" )]
	public string TextValue { get; set; } = "🌈 TEXT with a Shadow! 😃";

	[Category( "Shadow" )]
	public bool Additive { get; set; } = false;

	[Category( "Text" )]
	public Color TextColor { get; set; } = Color.White;

	[Category( "Shadow" )]
	public Color BackgroundColor { get; set; } = Color.Parse( "#f44336" ) ?? default;

	[Category( "Shadow" )]
	[Range( 0, 100 )]
	public int BlurSize { get; set; } = 20;

	[Category( "Shadow" )]
	[Range( -100, 100 )]
	public int OffsetX { get; set; } = 0;

	[Category( "Shadow" )]
	[Range( -100, 100 )]
	public int OffsetY { get; set; } = 0;

	[Category( "Shadow" )]
	public Color ShadowColor { get; set; } = Color.Black;


	[Category( "Outline" )]
	public Color OutlineColor { get; set; } = Color.Black;

	[Category( "Outline" )]
	[Range( 0, 100 )]
	public float OutlineWidth { get; set; } = 0.0f;
}

[StyleSheet]
public class TextShadow : Panel
{
	public TextShadowProperties TextShadowProperties { get; set; } = new();

	public Label Label { get; set; }

	public TextShadow()
	{
		AddClass( "root has-form" );

		Label = AddChild<Panel>( "example_panel" ).AddChild<Label>();
	}

	public override void Tick()
	{
		base.Tick();

		Style.BackgroundColor = TextShadowProperties.BackgroundColor;

		Label.Text = TextShadowProperties.TextValue;
		Label.Style.FontSize = TextShadowProperties.TextSize;
		Label.Style.FontColor = TextShadowProperties.TextColor;

		Label.Style.TextShadow ??= new ShadowList();

		if ( Label.Style.TextShadow.Count == 0 )
		{
			Label.Style.TextShadow.Add( new Shadow() );
		}

		var shadow = new Shadow();
		shadow.Blur = TextShadowProperties.BlurSize;
		shadow.OffsetX = TextShadowProperties.OffsetX;
		shadow.OffsetY = TextShadowProperties.OffsetY;
		shadow.Color = TextShadowProperties.ShadowColor;

		Label.Style.MixBlendMode = TextShadowProperties.Additive ? "lighten" : "normal";

		Label.Style.TextShadow[0] = shadow;

		Label.Style.TextStrokeColor = TextShadowProperties.OutlineColor;
		Label.Style.TextStrokeWidth = TextShadowProperties.OutlineWidth;

		Label.Style.Dirty();

	}
}
