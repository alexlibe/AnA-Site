using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

using AnA_Site.Interfaces;

namespace AnA_Site.Pages
{
    public class SearchModel : PageModel
    {
        [Required(ErrorMessage = "Search bar must have something")]
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public string[] Videos { get; private set; }

        private readonly ISearchService _searchService;

        public SearchModel(ISearchService searchService)
        {
            _searchService = searchService;
        }
        
        public IActionResult OnGet()
        {
            if (!ModelState.IsValid) return Page();
            
            Videos = _searchService.Search(Search);
            return Page();
        }
    }
}
