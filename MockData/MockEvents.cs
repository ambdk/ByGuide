using ByGuide.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ByGuide.MockData
{
    public class MockEvents
    {
        #region Static Fields
        private static List<Event> _events = new List<Event>()
        {
            new Event(
                "Fortryllende fotoshoot Kom og få taget et flot billede i vores Narnia-univers. Måske du kan bruge det til at lave årets eventyrligste julekort?",
                0,
                2023-12-19,
                new Uri("https://www.kultunaut.dk/perl/arrmore/type-nynaut?ArrNr=16724375"),
                true
            ),
            new Event(
                "BANKO Byens hyggeligste banko for medlemmer vi hygger os vi har plads til 80 spillere der er kaffe brød osv ti rimelige priser.",
                0,
                2023-12-19,
                new Uri("https://www.roskildelive.dk/perl/arrmore/type-roskilde5?ArrNr=16887725"),
                true
            ),
            new Event(
                "Plexus Roskilde Åbningsdag - Juleafslutning\r\nPlexus Roskilde er et mødested for ensomme unge i alderen 18-35 år. På en åbningsdag handler vi ind, laver mad og spiser sammen. Derudover spiller vi en masse spil og har en masse hyggeligt samvær i trygge rammer.",
                0,
                2023-12-21,
                new Uri("https://www.roskildelive.dk/perl/arrmore/type-roskilde5?ArrNr=17078187"),
                true
            ),
            new Event(
                "Køb dit juletræ og støt FDF Roskilde, Køb dit juletræ hos FDF Roskilde. Vi har et bredt udvalg af nordmannsgran og rødgran. Når du køber dit juletræ hos os, støtter du samtidig FDF Roskilde.",
                0,
                2023-12-25,
                new Uri("https://www.fdfroskilde.dk/2023/11/16/juletrae/"),
                true
            ),
            new Event(
                "Koncert med Martin Dale (irsk folkemusik & rock/pop classics)\r\n\"Den britiske sanger, guitarist og entertainer Martin Dale er en meget dygtig og erfaren musiker, men det er hans evne til at underholde, der imponerer mest, når man oplever hans meget eftertragtede troubadour-show.",
                50,
                2023-12-22,
                new Uri("https://www.roskildelive.dk/perl/arrmore/type-roskilde5?ArrNr=16972878"),
                true
            ),
            new Event(
                "Julekonkurrence: Find nissen?",
                0,
                2023-12-30,
                new Uri("https://www.roskildelive.dk/perl/arrmore/type-roskilde5?ArrNr=17139267"),
                true
            ),
        };
        #endregion

        #region Methods
        public static List<Event> GetMockEvents()
        {
            return _events;
        }
        #endregion
    }
}