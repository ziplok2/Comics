using Comics.Repozitoriy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Comics.Pages
{
    public class ComicsModel : PageModel
    {
        public ComicsModel(Icomics Icomics1) 
        {
            Icomics1 = Icomics;
        }
        private Icomics Icomics;
        public List<Comics.Model.Comics> comics { get; set; }
        public IActionResult OnGet()
        {
            comics = Icomics.GetAll();
            return Page();
        }
    }
}
