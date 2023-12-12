using Microsoft.Extensions.Hosting;
using TuristInfoV1.Models;


namespace TuristInfoV1.Services
{
	public interface ITuristService
	{
		void AddTurist(Turist turist);
		IEnumerable<Turist> TuristSearch(string name);
		void UpdateTurist(Turist turist);
		Turist DeleteTurist(int? id);
		Turist GetTurist(int Id);
		List<Turist> GetTurists();

	}	
}