using System;

namespace BlueBook
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("Presentation of making the frames in console C#.");
			Console.WriteLine();

			char hor1 = '\u2502'; // - size 1 horizontal
			char ver1 = '\u2500'; //- size 1 vertical
			char cor1 = '\u250C'; // - size 1 corner 1
			char cor2 = '\u2510'; // - size 1 corner 2
			char cor3 = '\u2518'; // - size 1 corner 3
			char cor4 = '\u2514'; // - size 1 corner 4
			char cor1a = '\u256D'; // - size 1 corner 1a
			char cor2a = '\u256E'; // - size 1 corner 2a
			char cor3a = '\u256F'; // - size 1 corner 3a
			char cor4a = '\u2570'; // - size 1 corner 4a		

			char hor2 = '\u2503'; //  - size 2 horizontal
			char ver2 = '\u2501'; //  - size 2 vertical
			char cor12 = '\u250F'; // - size 2 corner 1
			char cor22 = '\u2513'; // - size 2 corner 2
			char cor32 = '\u251B'; // - size 2 corner 3
			char cor42 = '\u2517'; // - size 2 corner 4

			char hor3 = '\u2551'; //  - size 3 horizontal
			char ver3 = '\u2550'; //  - size 3 vertical
			char cor13 = '\u2554'; // - size 3 corner 1
			char cor23 = '\u2557'; // - size 3 corner 2
			char cor33 = '\u255D'; // - size 3 corner 3
			char cor43 = '\u255A'; // - size 3 corner 4

			char hor4u = '\u2580'; //  - size 4 horizontal
			char hor4d = '\u2584'; //  - size 4 horizontal
			char ver4 = '\u2588'; //  - size 4 vertical
			
			// size 5 is made from double size 4
			char ver4a = '\u2591'; //  - size 5a vertical
			char ver4b = '\u2592'; //  - size 5b vertical
			char ver4c = '\u2593'; //  - size 5c vertical
			
			Console.WriteLine();
			Console.WriteLine("      " + cor1 + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + cor2);		
			Console.WriteLine("Press " + hor1 + " Enter " + hor1 + " to close the window!");
			Console.WriteLine("      " + cor4 + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + cor3);
			Console.WriteLine();
			Console.WriteLine("      " + cor1a + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + cor2a);		
			Console.WriteLine("Press " + hor1 + " Enter " + hor1 + " to close the window!");
			Console.WriteLine("      " + cor4a + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + ver1 + cor3a);			
			Console.WriteLine();
			Console.WriteLine("      " + cor12 + ver2 + ver2 + ver2 + ver2 + ver2 + ver2 + ver2 + cor22);		
			Console.WriteLine("Press " + hor2 + " Enter " + hor2 + " to close the window!");
			Console.WriteLine("      " + cor42 + ver2 + ver2 + ver2 + ver2 + ver2 + ver2 + ver2 + cor32);
			Console.WriteLine();
			Console.WriteLine("      " + cor13 + ver3 + ver3 + ver3 + ver3 + ver3 + ver3 + ver3 + cor23);		
			Console.WriteLine("Press " + hor3 + " Enter " + hor3 + " to close the window!");
			Console.WriteLine("      " + cor43 + ver3 + ver3 + ver3 + ver3 + ver3 + ver3 + ver3 + cor33);
			Console.WriteLine();
			Console.WriteLine("      " + ver4 + hor4u + hor4u + hor4u + hor4u + hor4u + hor4u + hor4u + ver4);		
			Console.WriteLine("Press " + ver4 + " Enter " + ver4 + " to close the window!");
			Console.WriteLine("      " + ver4 + hor4d + hor4d + hor4d + hor4d + hor4d + hor4d + hor4d + ver4);			
			Console.WriteLine();
			Console.WriteLine("      " + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4);		
			Console.WriteLine("Press " + ver4 + ver4 + " Enter " + ver4 + ver4 + " to close the window!");
			Console.WriteLine("      " + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4 + ver4);
			Console.WriteLine();
			Console.WriteLine("      " + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a);		
			Console.WriteLine("Press " + ver4a + ver4a + " Enter " + ver4a + ver4a + " to close the window!");
			Console.WriteLine("      " + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a + ver4a);
			Console.WriteLine();
			Console.WriteLine("      " + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b);		
			Console.WriteLine("Press " + ver4b + ver4b + " Enter " + ver4b + ver4b + " to close the window!");
			Console.WriteLine("      " + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b + ver4b);
			Console.WriteLine();
			Console.WriteLine("      " + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c);		
			Console.WriteLine("Press " + ver4c + ver4c + " Enter " + ver4c + ver4c + " to close the window!");
			Console.WriteLine("      " + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c + ver4c);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Press [Enter] to close the window!");
			Console.ReadKey();
		}
	}
}