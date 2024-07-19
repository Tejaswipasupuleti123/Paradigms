using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(string operation)
        {
            if (!string.IsNullOrEmpty(operation))
            {
                double num1 = double.Parse(Request.Form["num1"]);
                double num2 = double.Parse(Request.Form["num2"]);

                if (operation == "+")
                {
                    ViewData["result"] = num1 + num2;
                }
                else if (operation == "-")
                {
                    ViewData["result"] = num1 - num2;
                }
                else if (operation == "*")
                {
                    ViewData["result"] = num1 * num2;
                }
                else if (operation == "/")
                {
                    ViewData["result"] = num1 / num2;
                }
                else if (operation == "power")
                {
                    ViewData["result"] = Math.Pow(num1, num2);
                }
                else if (operation == "square")
                {
                    ViewData["result"] = num1 * num1;
                }
                else if (operation == "cube")
                {
                    ViewData["result"] = num1 * num1 * num1;
                }
                else
                {
                    ViewData["result"] = "Invalid operation";
                }
            }
        }
    }
}
