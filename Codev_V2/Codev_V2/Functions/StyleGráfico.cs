using OxyPlot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codev_V2.Functions
{
    public static class StyleGráfico
    {
        public static PlotModel StylePadrão(string titulo)
        {
            return new PlotModel
            {
                Title = titulo,
                Background = OxyColor.Parse("#2A2D34"),
                PlotAreaBorderColor = OxyColor.Parse("#393C44"),
                TextColor = OxyColor.Parse("#E0E1E6"),
                TitleColor = OxyColor.Parse("#E0E1E6")
               
            };
        }
    }
}
