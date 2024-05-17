using Microsoft.Extensions.DependencyInjection;
using System;
using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Servicios.Intefaces;

namespace ViveroEF2024.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarCombosPaginas(int pageCount, ref ComboBox cbo)
        {
            cbo.Items.Clear();
            for (int page = 1; page <= pageCount; page++)
            {
                cbo.Items.Add(page.ToString());
            }
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTiposPlantas(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ITiposDePlantasService>();

            var lista = servicio.GetLista();
            var defaultTipoPlanta = new TipoDePlanta
            {
                Descripcion = "Seleccione"
            };
            lista.Insert(0, defaultTipoPlanta);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoDePlantaId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTiposEnvases(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ITiposDeEnvasesService>();

            var lista = servicio.GetLista();
            var defaultTipoEnvase = new TipoDeEnvase
            {
                Descripcion = "Seleccione"
            };
            lista.Insert(0, defaultTipoEnvase);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoDeEnvaseId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTiposEnvases(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ITiposDeEnvasesService>();
            // Obtener la lista de tipos de envases del repositorio

            var lista = servicio.GetLista();
            var defaultTipoEnvase = new TipoDeEnvase
            {
                Descripcion = "Seleccione"
            };



            // Limpiar el ToolStripComboBox
            cbo.Items.Clear();
            lista.Insert(0, defaultTipoEnvase);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (TipoDeEnvase tipoDeEnvase in lista)
            {
                cbo.Items.Add(tipoDeEnvase.Descripcion);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }
        public static void CargarComboTiposPlantas(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ITiposDePlantasService>();
            // Obtener la lista de tipos de envases del repositorio

            var lista = servicio.GetLista();
            var defaultTipoPlanta = new TipoDePlanta
            {
                Descripcion = "Seleccione"
            };



            // Limpiar el ToolStripComboBox
            cbo.Items.Clear();
            lista.Insert(0, defaultTipoPlanta);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (TipoDePlanta tipoDePlanta in lista)
            {
                cbo.Items.Add(tipoDePlanta.Descripcion);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }

    }

}
