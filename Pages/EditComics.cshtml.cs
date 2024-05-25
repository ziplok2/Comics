using Comics.Repozitoriy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Comics.Model;

namespace Comics.Pages
{
    //[Authorize]
    public class EditComicsModel : PageModel
    {
        public EditComicsModel(Icomics icomics)
        {
            _icomics = icomics;
        }

        private Icomics _icomics;
        public Comics.Model.Comics? comics{ get; set; }
        public IActionResult OnGet (int Id) 
        {
            comics = _icomics.GetComicsById(Id);
            comics ??= new();
            return Page();
        } 

        public IActionResult OnPost (Comics.Model.Comics? comicsForm) 
        {
            var userDB = _icomics.UpdateUser(comicsForm);
            if (userDB == null) return NotFound();
            return RedirectToPage("Comics228");
        }
    }
}
