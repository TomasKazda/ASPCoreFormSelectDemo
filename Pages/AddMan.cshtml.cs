using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPCoreFormSelectDemo.Models;

namespace ASPCoreFormSelectDemo.Pages
{
    public class AddManModel : PageModel
    {
        private readonly ASPCoreFormSelectDemo.Models.PeopleDataContext _context;

        public AddManModel(ASPCoreFormSelectDemo.Models.PeopleDataContext context)
        {
            _context = context;
        }

        public List<SelectListItem> Colors { get; set; }

        public IActionResult OnGet()
        {
            Colors = _context.CodeBook.Select(c => new SelectListItem(c.Color, c.Id.ToString())).ToList();
            return Page();
        }

        [BindProperty]
        public HumanIm Human { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }
            var color = _context.CodeBook.Where(c => c.Id == Human.EyeColor).SingleOrDefault();
            _context.People.Add(new Human() { Name = Human.Name, ShoeSize = Human.ShoeSize, EyeColor = color });
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
