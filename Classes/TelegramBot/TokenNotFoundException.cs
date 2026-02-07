
namespace EventsPlannerBot
{
	
	[Serializable]
	public class TokenNotFoundException : Exception
	{
		public TokenNotFoundException() : base() { }
		public TokenNotFoundException(string message) : base(message) { }
		public TokenNotFoundException(string message, Exception inner) : base(message, inner) { }
	}
}
