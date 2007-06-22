// Compiler options: -langversion:linq
// Tests implicitly typed arrays

public class Test
{
	static int Main ()
	{
		string[] array = new [] { "Foo", "Bar", "Baz" };
		foreach (string s in array)
			if (s.Length != 3)
				return 1;

		string[] s1 = new[] { null, "a", default (string) };
		double[] s2 = new[] { 0, 1.0, 2 };
			
		var a1 = new[] { null, "a", default (string) };
		var a2 = new[] { 0, 1.0, 2 }; 
		var a3 = new[] { new Test (), null }; 
		var a4 = new[,] { { 1, 2, 3 }, { 4, 5, 6 } };
		var a5 = new[] { default (object) };
		
		const byte b = 100;
		var a6 = new[] { b, 10, b, 999, b };
		
		return 0;
	}
}
