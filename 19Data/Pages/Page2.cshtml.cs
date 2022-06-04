using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _19Data.Pages
{
    public class Page2Model : PageModel
    {
        [BindProperty]
        public string Vstup { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";

        public void OnGet(string input)
        {
            Vstup = input;

            Name = HttpContext.Session.GetString(SessionKeyName);
            Age = (int)HttpContext.Session.GetInt32(SessionKeyAge);
        }
    }
}
