using TuristInfoV1.Models;
using TuristInfoV1.MockData;
using Microsoft.Extensions.Hosting;

namespace TuristInfoV1.MockData
{
	public class MockTurist
	{
		#region Static Fields
		private static List<Turist> _turists = new List<Turist>();
			//{
			///new Turist (1,
			/// <summary>
			/// new Turist (2
			/// </summary>new Turist,
				///Per
		///	new turist(3,
			///	Christian
		    ///};
			#endregion

			#region Methods
			public static List<Turist> GetMockTurist()
			{
				return _turists;
			}
			#endregion
	}
}