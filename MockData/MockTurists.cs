using ByGuide.Models;
using ByGuide.MockData;
using Microsoft.Extensions.Hosting;

namespace ByGuide.MockData
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