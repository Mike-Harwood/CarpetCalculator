using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarpetCalculator.Model
{
    public class Carpet
    {

        [Display(Name = "Enter your Room Width")]

        public double RoomWidth { get; set; }


        [Display(Name = "Enter your Room Length")]

        public double RoomLength { get; set; }



        [Display(Name = "Do you want Installation")]

        public bool IsInstall { get; set; }

        [Display(Name = "Do you want Underlay")]

        public bool IsUnderlay { get; set; }



        [Display(Name = "Total cost")]

        public double Result { get; set; }


        public double InstallFee { get; set; } = 20;

        public double UnderlayFee { get; set; } = 20;


        public double CarpetChoice { get; set; }

        [Display(Name = "Choose you carpet")]

        public List<SelectListItem> CarpetSelection { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "100", Text = "Cheap" },
            new SelectListItem { Value = "200", Text = "Home" },
            new SelectListItem { Value = "300", Text = "Luxurious"  },

        };

        public double Results;

    }
}
