using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace _19Data.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Input { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Age { get; set; }

        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";

        public IndexModel()
        {
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
            {
                HttpContext.Session.SetString(SessionKeyName, "Default");
                HttpContext.Session.SetInt32(SessionKeyAge, 69);
            }
            Name = HttpContext.Session.GetString(SessionKeyName);
            Age = (int)HttpContext.Session.GetInt32(SessionKeyAge);
        }

        public ActionResult OnPost()
        {
            return RedirectToPage("/Page2", new { input = Input });
        }

        public ActionResult OnPostName()
        {
            HttpContext.Session.SetString(SessionKeyName, Name);
            return RedirectToPage("/Index");
        }

        public ActionResult OnPostAge()
        {
            HttpContext.Session.SetInt32(SessionKeyAge, Age);
            return RedirectToPage("/Index");
        }
    }
}