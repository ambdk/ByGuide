using ByGuide.Models;

namespace ByGuide.Service
{
	public interface IEventService

	{
		void AddEvent(Event events);
		IEnumerable<Event> EventSearch(string name);
		void UpdateEvent(Event events);
		Event DeleteEvent(string name);
		Event GetEvent(string name);
		List<Event> GetEvents();
	}
}
