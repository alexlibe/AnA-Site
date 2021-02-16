using System.IO;
using AnA_Site.Interfaces;

namespace AnA_Site.Services
{
    public class SearchService : ISearchService
    {
        public string[] Search(string search)
        {
            return Directory.GetFiles("Videos/");
        }
    }
}