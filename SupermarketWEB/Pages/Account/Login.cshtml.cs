using Autenticacion.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace SupermarketWEB.Pages.Account
{
    public class LoginModel : PageModel
    {
        
        
            [BindProperty]
            public User User { get; set; }
            public void OnGet()
            {
            }
            public async Task<IActionResult> OnPostAsync()
            {
                if (!ModelState.IsValid) return Page();

                if (User.Email == "correo@gmail.com" && User.Password == "12345")
                {
                    //se crea los claim, datos a almacenar en la cookie
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email,User.Email),
                };
                    //se asocia los claims creados a un nombre de una cookie
                    var identity = new ClaimsIdentity(claims, "MyCookiesAuth");
                    //se  agrega la identidad creada al ClaumsPrincipal de la aplicacion 
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    //se registra exitosamente la autenticacion y se crea la cookie en el navegador
                    await HttpContext.SignInAsync("MyCookiesAuth", claimsPrincipal);
                    return RedirectToPage("/index");
                }
                return Page();
            }
        
    }
}
