using ASPCoreFormSelectDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreFormSelectDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleDataContext _pdc;

        public IEnumerable<Human> People { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PeopleDataContext pdc)
        {
            _logger = logger;
            _pdc = pdc;
        }

        public void OnGet()
        {
            People = _pdc.People.Include(p => p.EyeColor).AsNoTracking().AsEnumerable();
        }
    }
}