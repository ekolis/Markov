using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov
{
	class Program
	{
		static void Main(string[] args)
		{
			var gen = new Generator();

			// learn how to write
			gen.ReadChain(gen.ParseSentence("I like apples and bananas."));
			gen.ReadChain(gen.ParseSentence("I like apples and peaches."));
			gen.ReadChain(gen.ParseSentence("I like bananas and peaches."));
			gen.ReadChain(gen.ParseSentence("I hate spam and spam and spam and spam and spam and spam and eggs and spam!"));
			gen.ReadChain(gen.ParseSentence("Thou shalt not kill."));
			gen.ReadChain(gen.ParseSentence("Thou shalt not steal."));
			gen.ReadChain(gen.ParseSentence("Thou shalt not commit adultery."));
			gen.ReadChain(gen.ParseSentence("I'm afraid to commit to this relationship."));
			gen.ReadChain(gen.ParseSentence("Remember to commit your code before you leave work."));
			gen.ReadChain(gen.ParseSentence("You shall not pass!"));
			gen.ReadChain(gen.ParseSentence("Do or do not; there is no try."));
			gen.ReadChain(gen.ParseSentence("Remember the Alamo!"));
			gen.ReadChain(gen.ParseSentence("Remember me..."));
			gen.ReadChain(gen.ParseSentence("Delete! Delete! Delete all inferior life-forms!"));
			gen.ReadChain(gen.ParseSentence("Captain, I sense no intelligent life-forms on this planet."));
			gen.ReadChain(gen.ParseSentence("Beware of strange warp points!"));
			gen.ReadChain(gen.ParseSentence("Engage, warp factor 9!"));
			gen.ReadChain(gen.ParseSentence("Beware of dog!"));
			gen.ReadChain(gen.ParseSentence("He's dead, Jim."));
			gen.ReadChain(gen.ParseSentence("They're dead, Dave. All dead. Every single one of them."));
			gen.ReadChain(gen.ParseSentence("There are many rich deposits in the nearby asteroid fields."));
			gen.ReadChain(gen.ParseSentence("We must tax the rich if we have any hope to survive as a democracy."));
			gen.ReadChain(gen.ParseSentence("Hashtag Kony 2016! Let's revive this thing!"));
			gen.ReadChain(gen.ParseSentence("Trump for president 2016! Anyone's better than Sanders, right? Right?"));

			// babble on a bit
			for (var i = 0; i < 10; i++)
			{
				var chain = gen.WriteSentence(8, 20);
				Console.WriteLine(chain);
			}

#if DEBUG
			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
#endif
		}
	}
}
