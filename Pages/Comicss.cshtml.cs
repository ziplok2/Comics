using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Comics.Model;
using Comics.Repozitoriy;

namespace Comics.Pages
{
    public class ComicssModel : PageModel
    {
        public ComicssModel(Icomics icomics)
        {
            icomics = icomics;
        }
        private Icomics icomics;
        public Comics.Model.Comics? comics { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }

        public IActionResult OnGet(int id)
        {
            comics = icomics.GetComicsById(id);
            comics = new();
            return Page();
        }

        public IActionResult OnPost(Comics.Model.Comics userForm)
        {

            var comicDB = icomics.UpdateUser(userForm);
            if (comicDB == null) return NotFound();
            return Page();
        }
    }
}
      