using ByGuide.Models;

namespace ByGuide.MockData
{
	public class MockEvents
	{
		#region Static Fields
		private static List<Event> _events = new List<Event>();
			
		#endregion

		#region Methods
		public static List<Event> GetMockEvents()
		{
			return _events;
		}
		#endregion
	}
}
