using CarpetCalculator.Model;
namespace CarpetCalculator.Pages

{
    public class Calculations
    {

        public double CarpetCalculation(Carpet carpetCalc)
        {
            double area = carpetCalc.RoomWidth * carpetCalc.RoomLength;
            double installFee = area * carpetCalc.InstallFee;
            double underlayFee = area * carpetCalc.UnderlayFee;

            if (carpetCalc.CarpetChoice == 100)
            {
                carpetCalc.Result = area * carpetCalc.CarpetChoice;

            }

            if (carpetCalc.CarpetChoice == 200)
            {
                carpetCalc.Result = area * carpetCalc.CarpetChoice;
            }


            if (carpetCalc.CarpetChoice == 300)
            {
                carpetCalc.Result = area * carpetCalc.CarpetChoice;
            }

            if (carpetCalc.IsInstall == true)
            {

                carpetCalc.Result = carpetCalc.Result + (installFee);
            }

            if (carpetCalc.IsUnderlay == true)
            {
                carpetCalc.Result = carpetCalc.Result + (underlayFee);
            }




            return carpetCalc.Result;
        }



    }
}