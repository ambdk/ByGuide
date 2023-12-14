
// By: Jesper H�jlund

using ByGuide.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Experience
{
    public class GetAllExperiencesModel : PageModel
    {
        #region Properties
        public List<Models.Experience> Experiences { get; set; } = new List<Models.Experience>()
        {
            new Models.Experience(
                1,
                "Udenfor lands lov og ret",
                "K�r i en stor bue uden om Venslev. De er farlige. De plyndrer enhver der kommer i n�rheden af dem, stj�ler fra hinanden og sl�r ihjel for et godt ord. De er udenfor p�dagogisk r�kkevide - ville man ha sagt i dag, Men s� bliver Politiassessor Peter Munthe Brun sat p� sagen, han form�r at f� de anklagede til at tale hvor alle andre har givet op. Et Psykologisk drama om at forst� mennesker i stedet for at tage afstand til dem",
                "Skuespil",
                120,
                "Kyndel�se Strandvej 22, Kirke Hyllinge",
                "https://www.parkteatret.dk/#select/114607",
                true,
                "",
                new Dictionary<string, string>
                {
                    { "Mandag", "Lukket" },
                    { "Tirsdag", "9 - 17" },
                    { "Onsdag", "9 - 17" },
                    { "Torsdag", "9 - 17" },
                    { "Fredag", "9 - 17" },
                    { "L�rdag", "10 - 20" },
                    { "S�ndag", "Lukket" },
                }),
            new Models.Experience(
                2,
                "Tim Christensen",
                "Dizzy Mizz Lizzy-frontfiguren tager for f�rste gang i over 10 �r p� band-turn� i eget navn og genbes�ger sit mest popul�re album. Tim Christensens album.",
                "Koncert",
                350,
                "Helligkorsvej 2, Roskilde",
                "https://www.kultunaut.dk/perl/billet/type-fjordlandet?ArrNr=16490795",
                true,
                "",
                new Dictionary<string, string>
                {
                    { "Mandag", "Lukket" },
                    { "Tirsdag", "9 - 17" },
                    { "Onsdag", "9 - 17" },
                    { "Torsdag", "9 - 17" },
                    { "Fredag", "9 - 17" },
                    { "L�rdag", "10 - 20" },
                    { "S�ndag", "Lukket" },

                }),
            new Models.Experience(
                3,
                "Roskilde H�ndbold Herrer - FIF 2",
                "Kom og se og st�t Roskildes bedste hold! Det er utrolig vigtigt, at Roskilde p� hjemmebane har s� mange, der kommer til kampene og st�tter op om holdet.",
                "Koncert",
                50,
                "M�llehusvej 15, Roskilde",
                "https://www.billetsalg.dk/Event/Roskilde%20H%C3%A5ndbold%20Herrer%20-%20FIF%202/4994?",
                true,
                "",
                new Dictionary<string, string>
                {
                    { "Mandag", "Lukket" },
                    { "Tirsdag", "9 - 17" },
                    { "Onsdag", "9 - 17" },
                    { "Torsdag", "9 - 17" },
                    { "Fredag", "9 - 17" },
                    { "L�rdag", "10 - 20" },
                    { "S�ndag", "Lukket" },
                })
        };
        #endregion

        #region Methods
        public void OnGet()
        {
        }
        #endregion
    }
}
