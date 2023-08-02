using Sandbox.UI.Construct;

namespace Sandbox.UI.Tests.Styles;

[StyleSheet]
public class Background : Panel
{
	public Background()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;

		AddTest( "background: #ff00ff;", "#ff00ff" );
		AddTest( "background: #f0f;", "#f0f" );
		AddTest( "background: rgb( 0, 255, 0 );", "rgb( 0, 255, 0 )" );

		// https://files.facepunch.com/alexguthrie/1b3111b1/msedge_649G6y4aGd.png
		AddTest( "background: linear-gradient( to right, #feff00, #00ffee );", "linear-gradient" );

		// https://files.facepunch.com/alexguthrie/1b3111b1/msedge_8ssAg1Yfb7.png
		AddTest( "background: linear-gradient( 45deg, red, blue );", "angled linear-gradient" );

		// https://files.facepunch.com/alexguthrie/1b3111b1/msedge_QLWAjCI3cX.png
		AddTest( "background: url( https://files.facepunch.com/alexguthrie/1b3111b1/wave.png ) center / cover;", "url" );

		// https://files.facepunch.com/alexguthrie/1b3111b1/msedge_ZmsouzmjVW.png
		AddTest( "background: linear-gradient( to top, black, white );", "linear-gradient to top" );

		AddTest( "background: linear-gradient(black, rgba(#23fe1c, 0));", "mixed gradient color sources" );

		AddTest( "background: linear-gradient( to top, rgba( #222, 0.3 ), rgba( #222, 0.9 ) 95% );", "gradient" );

		Add.Label( "variable gradient", "image variable-gradient" );
	}

	void AddTest( string styles, string text )
	{
		var p = Add.Label( text, "image" );
		p.Style.Set( styles );
	}
}
