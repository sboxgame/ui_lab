using Sandbox.UI.Construct;

namespace Sandbox.UI.Tests.Styles;

[StyleSheet]
public class Animations : Panel
{
	public Animations()
	{
		Style.FlexWrap = Wrap.Wrap;
		Style.JustifyContent = Justify.Center;
		Style.AlignItems = Align.Center;
		Style.AlignContent = Align.Center;
		
		AddTest( "animation-name: rainbow;" );
		AddTest( "animation: rainbow 10s;" );

		AddTest( "animation: infinite rainbow 10s ease-in;" );
		AddTest( "animation: 5s rainbow ease-in 1s 1 both" );
	}

	void AddTest( string styles )
	{
		var p = Add.Label( styles, "image" );
		p.Style.Set( styles );
	}
}
