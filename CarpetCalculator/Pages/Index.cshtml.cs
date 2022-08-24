using CarpetCalculator.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarpetCalculator.Pages
{
    [BindProperties]


    public class IndexModel : PageModel
    {

        public Carpet carpetObject { get; set; }

        public Calculations CarpCalc = new Calculations();

        public void OnPostAsync()
        {
            carpetObject.Result = CarpCalc.CarpetCalculation(carpetObject);

        }
        public void OnGet()
        {
            carpetObject = new Carpet();

        }



    }
}