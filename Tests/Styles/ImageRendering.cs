using Sandbox.UI.Construct;

namespace Sandbox.UI.Tests.Styles;

[StyleSheet]
public class ImageRendering : Panel
{
	public ImageRendering()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;

		AddTest( $"image-rendering: auto;", $"auto" );
		AddTest( $"image-rendering: anisotropic;", $"anisotropic" );
		AddTest( $"image-rendering: bilinear;", $"bilinear" );
		AddTest( $"image-rendering: trilinear;", $"trilinear" );
		AddTest( $"image-rendering: point;", $"point" );
		AddTest( $"image-rendering: pixelated;", $"pixelated" );
		AddTest( $"image-rendering: nearest-neighbor;", $"nearest-neighbor" );
	}

	private void AddTest( string styles, string text )
	{
		var p = Add.Label( text, "panel" );
		p.Style.Set( styles );
	}
}
