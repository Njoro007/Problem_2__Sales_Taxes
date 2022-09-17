using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public static class RoundFigures
    {
        public static double RoundOffToFifthHundredths(double roundFigure)
        {
            roundFigure = Math.Round(roundFigure / 0.05) * 0.05;
            return roundFigure;
        }

        public static double RoundOffToHundredths(double roundFigure)
        {
            roundFigure = Math.Round(roundFigure, 2, MidpointRounding.AwayFromZero);
            return roundFigure;
        }
    }
}
