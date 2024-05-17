using Microsoft.Extensions.DependencyInjection;
using ViveroEF2024.Servicios.Intefaces;

namespace ViveroEF2024.Windows
{
    public partial class frmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public frmPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnTiposDePlantas_Click(object sender, EventArgs e)
        {
            frmTiposDePlantas frm = new frmTiposDePlantas(_serviceProvider
                .GetService<ITiposDePlantasService>());
            frm.ShowDialog();
        }

        private void btnTiposDeEnvases_Click(object sender, EventArgs e)
        {
            frmTiposDeEnvases frm = new frmTiposDeEnvases(_serviceProvider
                .GetService<ITiposDeEnvasesService>());
            frm.ShowDialog();
        }

        private void btnPlantas_Click(object sender, EventArgs e)
        {
            frmPlantas frm = new frmPlantas(_serviceProvider
                .GetService<IPlantasService>(), _serviceProvider);
            frm.ShowDialog();
        }
    }
}
