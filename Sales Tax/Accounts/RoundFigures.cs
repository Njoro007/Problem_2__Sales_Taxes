using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{ 
    public static class RoundFigures
    {
        /// <summary>
        /// This Method rounds off to the nearest hundredth e.g 0.54 will be rounded to 0.55
        /// </summary> 
        /// <param name="roundFigure"></param>
        /// <returns>Round off: e.g 0.54 will be rounded to 0.55</returns>
        public static double RoundOffToFifthHundredths(double roundFigure)
        {
            roundFigure = Math.Round(roundFigure / 0.05) * 0.05;
            return roundFigure;
        }


        /// <summary>
        /// This Method rounds off to the nearest hundredth e.g 0.5389 will be rounded to 0.54
        /// </summary>
        /// <param name="roundFigure">Pass double data type to be rounded off</param>
        /// <returns>Round off: e.g 0.5389 will be rounded to 0.54</returns>
        public static double RoundOffToHundredths(double roundFigure)
        {
            roundFigure = Math.Round(roundFigure, 2, MidpointRounding.AwayFromZero);
            return roundFigure;
        }
    }
}
