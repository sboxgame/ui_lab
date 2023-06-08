using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace Sandbox.UI.Tests.Basics;

[StyleSheet]
public class Opacity : Panel
{
	public Opacity()
	{
		AddTest( ( p ) => { p.Add.Label( "Hello" ).Style.Set( "color: white;" ); } );
		AddTest( ( p ) => { p.Add.Label( "Hello" ).Style.Set( "color: black;" ); } );
		AddTest( ( p ) => { p.Add.Label( "Hello" ).Style.Set( "color: white; text-shadow: 2px 2px 10px black;" ); } );
		AddTest( ( p ) => { p.Add.Panel().Style.Set( "background-color: white; width: 50px; height: 50px; border-radius: 10px;" ); } );
		AddTest( ( p ) => { p.Add.Panel().Style.Set( "background-color: black; width: 50px; height: 50px; border-radius: 10px;" ); } );
		AddTest( ( p ) => { p.Add.Panel().Style.Set( "border: 4px solid white; width: 50px; height: 50px; border-radius: 10px;" ); } );
		AddTest( ( p ) => { p.Add.Panel().Style.Set( "border: 4px solid black; width: 50px; height: 50px; border-radius: 10px;" ); } );
		AddTest( ( p ) => { p.Add.Panel().Style.Set( "background-image: url( /content/background.png ); background-size: cover; width: 50px; height: 50px; border-radius: 10px;" ); } );
	}

	private void AddTest( Action<Panel> p )
	{
		var group = Add.Panel( "group" );

		var a = group.Add.Panel( "a" );
		p( a );

		var b = group.Add.Panel( "b" );
		p( b );

		var c = group.Add.Panel( "c" );
		p( c );

		var d = group.Add.Panel( "d" );
		p( d );

		var e = group.Add.Panel( "e" );
		p( e );
	}
}
