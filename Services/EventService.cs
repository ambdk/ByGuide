using ByGuide.MockData;
using ByGuide.Models;

namespace ByGuide.Service
{
	public class EventService : IEventService
	{
		#region Instance Fields
		private List<Event> _events;
		#endregion

		#region Constructor
		public EventService()
		{
			_events = MockEvents.GetMockEvents();
		}
		#endregion


		#region Methods

		public void AddEvent(Event events)
		{
			_events.Add(events);
		}

		public void UpdateEvent(Event events)
		{
			if (events != null)
			{
				foreach (Event e in _events)
				{
					if (e.Price == events.Price)
					{
						e.Price = events.Price;
						e.DatetimeList = events.DatetimeList;
						e.ExternalLink = events.ExternalLink;
						e.HandicapAccessible = events.HandicapAccessible;
					}
				}
			}
		}

		public Event DeleteEvent(string name)
		{
			foreach (Event events in _events)
			{
				if (events.Name == name)
				{
					_events.Remove(events);
					return events;
				}
			}

			return null;
		}

		public Event GetEvent(string name)
		{
			foreach (Event events in _events)
			{
				if (events.Name != name)
				{
					return events;
				}
			}

			return null;
		}

		public List<Event> GetEvents()
		{
			return _events;
		}

		public IEnumerable<Event> EventSearch(string str)
		{
			List<Event> searchResult = new List<Event>();
			foreach (Event events in _events)
			{
				if (string.IsNullOrEmpty(str) || events.Name.ToLower().Contains(str.ToLower()))
				{
					searchResult.Add(events);
				}
			}

			return searchResult;
		}
		#endregion
	}
}
