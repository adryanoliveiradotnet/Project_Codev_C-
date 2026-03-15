using OxyPlot.Series;
using OxyPlot;
using System.Windows.Controls;
using Codev_V2.Functions;

namespace Codev_V2.Páginas
{
    public partial class Pagina_Inicial : Page
    {
        public Pagina_Inicial()
        {
            InitializeComponent();
            CriarGrafico();
        }
        private void CriarGrafico()
        {
            var series = new BarSeries
            {
                FillColor = OxyColor.Parse("#2A7AFF")
            };
            var model = StyleGráfico.StylePadrão("TOTAL DE CLIENTES CADASTRADOS");
            series.Items.Add(new BarItem(10));
            series.Items.Add(new BarItem(20));
            series.Items.Add(new BarItem(30));
            model.Series.Add(series);
            GraficoClientes.Model = model;
        }
    }
}