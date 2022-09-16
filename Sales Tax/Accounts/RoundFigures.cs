using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public static class RoundFigures
    {
        public static double RoundOffToHundredths(double roundedFigure)
        {
            roundedFigure = Math.Round(roundedFigure, 2, MidpointRounding.AwayFromZero);

            return roundedFigure;
        }
    }
}
