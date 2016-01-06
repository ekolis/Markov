using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov
{
	/// <summary>
	/// LINQy type extension methods live here!
	/// </summary>
	public static class Linq
	{
		public static T PickWeighted<T>(this IDictionary<T, int> dict, Random r)
		{
			if (!dict.Any())
				throw new ArgumentException("Cannot pick a weighted item from an empty dictionary.");

			var total = dict.Sum(kvp => kvp.Value);
			var diceroll = r.Next(total);

			// TODO - this isn't really PRNG safe as dictionaries enumerate in arbitrary order
			var count = 0;
			foreach (var kvp in dict)
			{
				count += kvp.Value;
				if (diceroll < count)
					return kvp.Key;
			}

			throw new InvalidOperationException($"Failed to pick a weighted item from a dictionary containing {dict.Count} items totaling {total} weight with a dice roll of {diceroll}. Current count is {count}.");
		}
	}
}
