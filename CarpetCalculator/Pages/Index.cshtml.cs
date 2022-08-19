using CarpetCalculator.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarpetCalculator.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        [Display(Name = "Enter the Room Width")]
        public double RoomWidth { get; set; }

        [Display(Name = "Enter the RoomLength")]
        public double RoomLength { get; set; }

        [Display(Name = "Result")]
        public double Result { get; set; }

        [Display(Name = "Add underlay")]
        public bool isUnderlay { get; set; } = false;

        [Display(Name = "Add Installation")]

        public bool isInstalled { get; set; } = false;


        public string? CarpetOperationSelection { get; set; }

        [Display(Name = "CarpetOperations")]
        public List<SelectListItem> CarpetOperations = new List<SelectListItem>
        {
                new SelectListItem {Value ="100", Text = "Cheap" },
                new SelectListItem {Value ="200", Text = "Home" },
                new SelectListItem { Value = "300", Text = "Luxurious" },
                };

        //Bounding the page holding all the answer in the static list
        public List<string> Answers = new List<string>();


        public void OnGet()
        {

        }

        public void OnPost()


        {
            if (CarpetOperationSelection == "Cheap")
            {

                Result = RoomWidth * RoomLength;
            }
            if (CarpetOperationSelection == "Home")
            {

                Result = RoomWidth * RoomLength;
            }
            if (CarpetOperationSelection == "Luxurious")
            {

                Result = RoomWidth * RoomLength;
            }

            // the static List is adding the data as it is stored as the page refeshes.

            StaticAnswerList.AnswerList.Add(RoomWidth + "" + CarpetOperationSelection + "" + RoomLength + " + " + Result);

            Answers.AddRange(StaticAnswerList.AnswerList);
        }
    }
}