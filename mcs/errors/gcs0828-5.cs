// CS0828: An anonymous type property `Value' cannot be initialized with `void'
// Line: 13
// Compiler options: -langversion:linq

public class Test
{
	static void Error ()
	{
	}
	
	static void Main ()
	{
		var v = new { Value = Error () };
	}
}
