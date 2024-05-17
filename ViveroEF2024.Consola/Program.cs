using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using ViveroEF2024.Consola.Clases;
using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Entidades.Dto;
using ViveroEF2024.Entidades.Enums;
using ViveroEF2024.Ioc;
using ViveroEF2024.Servicios.Intefaces;
using ViveroEF2024.Shared;

namespace ViveroEF2024.Consola
{
    internal class Program
    {
        private static IServiceProvider? servicioProvider;
        static int pageSize = 15;
        static void Main(string[] args)
        {
            servicioProvider = DI.ConfigurarServicios();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Listado de Tipos de Plantas");
                Console.WriteLine("2. Ingresar un tipo de planta");
                Console.WriteLine("3. Borrar un tipo de planta");
                Console.WriteLine("4. Editar un tipo de planta");
                Console.WriteLine("5. Estadísticas por Tipo De Planta");
                
                Console.WriteLine("===============================");
                Console.WriteLine("10. Listado de Plantas");
                Console.WriteLine("11. Listado de Plantas Paginado");
                Console.WriteLine("12. Listado de Plantas Filtrado");
                Console.WriteLine("13. Listado de Plantas Ordenado por Precio");
                Console.WriteLine("14. Listado de objetos anónimos");
                Console.WriteLine("15. Listado de Plantas (con Dto)");
                Console.WriteLine("16. Agregar Planta");
                Console.WriteLine("17. Plantas por Tipo de Planta");
                Console.WriteLine("===============================");
                Console.WriteLine("20. Listado de Envases");
                Console.WriteLine("21. Ingreso de Envases");
                Console.WriteLine("22. Eliminar Envases");
                Console.WriteLine("23. Modificar Envases");

                Console.WriteLine("===============================");
                Console.WriteLine("30. Listado de Proveedores");


                Console.WriteLine("x. Salir");

                Console.Write("Por favor, seleccione una opción: ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        ListaDeTiposDePlantas();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "2":
                        InsertarTipoDePlanta();
                        break;
                    case "3":
                        BorrarTipoDePlanta();
                        break;
                    case "4":
                        EditarTipoDePlanta();
                        break;
                    case "5":
                        
                    case "10":
                        ListarPlantas();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "11":
                        ListarPlantasPaginado();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "12":
                        break;
                    case "13":
                        Console.Clear();
                        ListadoDePlantasOrdenado();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "14":
                        Console.Clear();
                        ListarPlantasAnonima();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "15":
                        Console.Clear();
                        ListarPlantasDto();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "16":
                        AgregarPlanta();
                        break;
                    case "17":
                        PlantasPorTipoDePlanta();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "20":
                        Console.Clear();
                        ListadoDeEnvases();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "21":
                        IngresoDeEnvases();
                        break;
                    case "22":
                        EliminarEnvase();
                        break;
                    case "23":
                        EditarEnvase();
                        break;
                    case "30":
                        ListadoProveedores();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "31":
                        ListarProveedorConPlantas();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "x":
                        exit = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

                Console.WriteLine(); // Añade una línea en blanco para mejorar la legibilidad
            }
        }

        private static void ListarProveedorConPlantas()
        {
            Console.Clear();
            Console.WriteLine("Plantas por Proveedor");
            ListadoProveedores();
            var proveedorId = ConsoleExtensions.ReadInt("Ingrese ID del proveedor:");
        }

        private static void ListadoProveedores()
        {
            Console.Clear();
            Console.WriteLine("Listado de Proveedores");

            var servicio = servicioProvider?.GetService<IProveedoresService>();
            var lista = servicio?.GetLista();
            var tabla = new ConsoleTable("ID", "Proveedor");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    tabla.AddRow(item.ProveedorId,
                        item.Nombre);
                        
                }
                tabla.Options.EnableCount = false;
                tabla.Write();

            }

        }

        private static void ListarPlantasDto()
        {
            Console.Clear();
            Console.WriteLine("Listado de Plantas");

            var servicio = servicioProvider?.GetService<IPlantasService>();
            var lista = servicio?.GetListaDto();
            var tabla = new ConsoleTable("ID", "Planta", "Tipo", "Envase", "Precio");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    tabla.AddRow(item.PlantaId,
                        item.Nombre,
                        item.Tipo,
                        item.Envase,
                        item.Precio);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();

            }

        }

        private static void PlantasPorTipoDePlanta()
        {
            Console.Clear();
            ListaDeTiposDePlantas();
            var servicioTipoPlantas = servicioProvider?
                .GetService<ITiposDePlantasService>();

            TipoDePlanta? tipoDePlanta;

            var listaChar = servicioTipoPlantas?
                .GetLista()
                .Select(x => x.TipoDePlantaId.ToString()).ToList();

            var tipoDePlantaId = ConsoleExtensions
                .GetValidOptions("Seleccione Tipo de Planta:", listaChar);

            tipoDePlanta = servicioTipoPlantas?
                .GetTipoDePlantaPorId(Convert.ToInt32(tipoDePlantaId));

            List<Planta>? lista = servicioTipoPlantas?.GetPlantas(tipoDePlanta);

            Console.WriteLine("Listado de Plantas");

            var tabla = new ConsoleTable("ID", "Planta", "Tipo", "Envase");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    tabla.AddRow(item.PlantaId,
                        item.Descripcion,
                        item.TipoDePlanta?.Descripcion,
                        item.TipoDeEnvase?.Descripcion);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();

            }


        }


        private static int CalcularCantidadPaginas(int cantidadRegistros,
            int cantidadPorPagina)
        {
            if (cantidadRegistros < cantidadPorPagina)
            {
                return 1;
            }
            else if (cantidadRegistros % cantidadPorPagina == 0)
            {
                return cantidadRegistros / cantidadPorPagina;
            }
            else
            {
                return cantidadRegistros / cantidadPorPagina + 1;
            }
        }

        private static void AgregarPlanta()
        {
            Console.Clear();
            var servicioTipoPlanta = servicioProvider?.GetService<ITiposDePlantasService>();
            var servicioEnvase = servicioProvider?.GetService<ITiposDeEnvasesService>();
            var servicioPlantas = servicioProvider?.GetService<IPlantasService>();

            TipoDePlanta? tipoDePlanta;
            TipoDeEnvase? tipoDeEnvase;

            Console.WriteLine("Agregar Planta");
            var descripcion = ConsoleExtensions.ReadString("Descripción:");
            ListaDeTiposDePlantas();
            var listaChar = servicioTipoPlanta?
                .GetLista()
                .Select(x => x.TipoDePlantaId.ToString()).ToList();
            var tipoDePlantaId = ConsoleExtensions
                .GetValidOptions("Seleccione Tipo de Planta (N para nuevo):", listaChar);
            if (tipoDePlantaId == "N")
            {
                tipoDePlantaId = "0";
                Console.WriteLine("Ingreso de nuevo tipo de Planta");
                var tipoDescripcion = ConsoleExtensions.ReadString("Ingrese descripción de tipo de Planta:");

                tipoDePlanta = new TipoDePlanta()
                {
                    TipoDePlantaId = 0,
                    Descripcion = tipoDescripcion
                };

            }
            else
            {
                tipoDePlanta = servicioTipoPlanta?
                    .GetTipoDePlantaPorId(Convert.ToInt32(tipoDePlantaId));

            }
            ListadoDeEnvases();
            var listaEnvaseChar = servicioEnvase?.GetLista()
                .Select(x => x.TipoDeEnvaseId.ToString()).ToList();
            var tipoDeEnvaseId = ConsoleExtensions.GetValidOptions("Seleccione Tipo de Envase (N para nuevo):",
                listaEnvaseChar);

            if (tipoDeEnvaseId == "N")
            {
                tipoDeEnvaseId = "0";
                Console.WriteLine("Ingreso de nuevo tipo de Envase");
                var tipoDescripcion = ConsoleExtensions.ReadString("Ingrese descripción de tipo de Envase:");

                tipoDeEnvase = new TipoDeEnvase()
                {
                    TipoDeEnvaseId = 0,
                    Descripcion = tipoDescripcion
                };

            }
            else
            {
                tipoDeEnvase = servicioEnvase?
                    .GetEnvasePorId(Convert.ToInt32(tipoDeEnvaseId));
            }


            var precioCosto = ConsoleExtensions
                .ReadDecimal("Ingrese un precio de Costo:", 1, 10000);
            var precioVenta = ConsoleExtensions.ReadDecimal("Ingrese el precio de venta:",
                precioCosto + 1, 20000);

            var planta = new Planta()
            {
                Descripcion = descripcion,
                TipoDePlantaId = Convert.ToInt32(tipoDePlantaId),
                TipoDeEnvaseId = Convert.ToInt32(tipoDeEnvaseId),
                TipoDePlanta = tipoDePlanta,
                TipoDeEnvase = tipoDeEnvase,
                PrecioCosto = precioCosto,
                PrecioVenta = precioVenta,

            };
            if (servicioPlantas != null)
            {
                if (!servicioPlantas.Existe(planta))
                {
                    servicioPlantas.Guardar(planta);
                    Console.WriteLine("Planta agregada!!!");
                }
                else
                {
                    Console.WriteLine("Registro Duplicado!!!");
                }
            }
            else
            {
                Console.WriteLine("Error: El servicio de plantas es nulo.");
            }
            Thread.Sleep(2000);

        }

        //TODO: Utilizar un DTO!!! que es más fácil
        private static void ListarPlantasAnonima()
        {
            Console.Clear();
            Console.WriteLine("Listado de Plantas");

            var servicio = servicioProvider?.GetService<IPlantasService>();
            var lista = servicio?.GetListaAnonima();
            var tabla = new ConsoleTable("ID", "Planta", "Tipo", "Envase", "Precio");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    // Obtener las propiedades del objeto anónimo
                    var properties = item.GetType().GetProperties();
                    var row = new MiRow();
                    // Iterar sobre las propiedades y mostrar sus nombres y valores
                    foreach (var property in properties)
                    {
                        var propertyName = property.Name;
                        var propertyValue = property.GetValue(item);
                        // Asignar el valor de la propiedad a la instancia de MiRow
                        switch (propertyName)
                        {
                            case "Id":
                                row.ID = propertyValue != null ? (int)propertyValue : 0;
                                break;
                            case "Planta":
                                row.Planta = propertyValue != null ? (string)propertyValue : string.Empty;
                                break;
                            case "TipoPlanta":
                                row.Tipo = propertyValue != null ? (string)propertyValue : string.Empty; ;
                                break;
                            case "TipoEnvase":
                                row.Envase = propertyValue != null ? (string)propertyValue : string.Empty;
                                break;
                            case "PrecioVenta":
                                row.PrecioVenta = propertyValue != null ? (decimal)propertyValue : 0;
                                break;
                        }
                    }
                    tabla.AddRow(row.ID, row.Planta, row.Tipo, row.Envase, row.PrecioVenta);
                }

            }
            tabla.Options.EnableCount = false;
            tabla.Write();


        }

        private static void EditarEnvase()
        {
            Console.Clear();
            var servicio = servicioProvider?
                .GetService<ITiposDeEnvasesService>();
            Console.WriteLine("Editar Envase");
            ListadoDeEnvases();
            var idEditar = ConsoleExtensions.ReadInt("Ingrese el ID a editar:");
            var envaseEnDb = servicio?.GetEnvasePorId(idEditar);
            if (envaseEnDb != null)
            {
                Console.WriteLine($"Descripción anterior: {envaseEnDb.Descripcion}");
                var nuevaDesc = ConsoleExtensions.ReadString("Ingrese la nueva descripción:");
                envaseEnDb.Descripcion = nuevaDesc;
                servicio?.Guardar(envaseEnDb);
                Console.WriteLine("Envase editado!!!");
            }
            else
            {
                Console.WriteLine("Envase inexistente!!!");
            }
            Thread.Sleep(2000);
        }

        private static void EliminarEnvase()
        {
            Console.Clear();
            Console.WriteLine("Eliminar Tipo de Envase");
            ListadoDeEnvases();
            var envaseId = ConsoleExtensions.ReadInt("Ingrese ID del tipo de Envase:");
            try
            {
                var servicio = servicioProvider?
                    .GetService<ITiposDeEnvasesService>();
                var tipoDeEnvase = servicio?.GetEnvasePorId(envaseId);
                if (tipoDeEnvase != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(tipoDeEnvase))
                        {
                            servicio.Borrar(tipoDeEnvase);
                            Console.WriteLine("Registro borrado!!!");

                        }
                        else
                        {
                            Console.WriteLine("Tipo de Envase relacionado!!!\n Baja denegada");
                        }

                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Registro inexistente!!!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            Thread.Sleep(5000);

        }

        private static void IngresoDeEnvases()
        {
            var servicio = servicioProvider?
                .GetService<ITiposDeEnvasesService>();
            Console.Clear();
            Console.WriteLine("Tipos de Envases");
            var tipoEnvaseDescripcion = ConsoleExtensions
                .ReadString("Ingrese un nuevo tipo de envase:");
            var tipoEnvase = new TipoDeEnvase
            {
                Descripcion = tipoEnvaseDescripcion
            };
            if (servicio != null)
            {
                if (!servicio.Existe(tipoEnvase))
                {
                    servicio.Guardar(tipoEnvase);
                    Console.WriteLine("Envase agregado!!!");
                }
                else
                {
                    Console.WriteLine("Envase existente!!!");
                }

            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }
            Thread.Sleep(2000);
        }

        private static void ListadoDeEnvases()
        {
            Console.WriteLine("Listado de Tipos de Envases");
            var servicio = servicioProvider?
                .GetService<ITiposDeEnvasesService>();
            var lista = servicio?.GetLista();
            var tabla = new ConsoleTable("ID", "Descripción");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    tabla.AddRow(item.TipoDeEnvaseId, item.Descripcion);
                }

            }
            tabla.Options.EnableCount = false;
            tabla.Write();
        }

        private static void EditarTipoDePlanta()
        {
            Console.Clear();
            Console.WriteLine("Ingreso de tipo de Planta a editar");
            var tipoDescripcion = ConsoleExtensions.ReadString("Ingrese descripción del tipo de Planta:");
            try
            {
                var servicio = servicioProvider?.GetService<ITiposDePlantasService>();
                var tipoDePlanta = servicio?.GetTipoDePlantaPorNombre(tipoDescripcion);
                if (tipoDePlanta != null)
                {
                    Console.WriteLine($"Tipo de Planta:{tipoDePlanta.Descripcion}");
                    var nuevoTipoDescripcion = ConsoleExtensions.ReadString("Ingrese la nueva descripción del tipo de Planta:");
                    tipoDePlanta.Descripcion = nuevoTipoDescripcion;
                    if (servicio != null)
                    {
                        if (!servicio.Existe(tipoDePlanta))
                        {
                            servicio.Guardar(tipoDePlanta);
                            Console.WriteLine("Registro editado!!!");

                        }
                        else
                        {
                            Console.WriteLine("Registro duplicado!!!");
                        }

                    }
                    else
                    {
                        throw new Exception("Servicio no disponible!!");
                    }
                }
                else
                {
                    Console.WriteLine("Registro inexistente!!!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            Thread.Sleep(5000);
        }

        private static void BorrarTipoDePlanta()
        {
            Console.Clear();
            Console.WriteLine("Ingreso de tipo de Planta a borrar");
            var tipoDescripcion = ConsoleExtensions.ReadString("Ingrese descripción del tipo de Planta:");
            try
            {
                var servicio = servicioProvider?.GetService<ITiposDePlantasService>();
                var tipoDePlanta = servicio?
                    .GetTipoDePlantaPorNombre(tipoDescripcion);
                if (tipoDePlanta != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(tipoDePlanta))
                        {
                            servicio.Borrar(tipoDePlanta);
                            Console.WriteLine("Registro borrado!!!");

                        }
                        else
                        {
                            Console.WriteLine("Tipo de planta relacionado!!! Baja denegada");
                        }

                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Registro inexistente!!!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            Thread.Sleep(5000);
        }

        private static void InsertarTipoDePlanta()
        {
            Console.Clear();
            Console.WriteLine("Ingreso de nuevo tipo de Planta");
            var tipoDescripcion = ConsoleExtensions.ReadString("Ingrese descripción de tipo de Planta:");

            TipoDePlanta tipoDePlanta = new TipoDePlanta()
            {
                Descripcion = tipoDescripcion
            };

            try
            {
                var servicio = servicioProvider?.GetService<ITiposDePlantasService>();
                if (servicio != null)
                {
                    if (!servicio.Existe(tipoDePlanta))
                    {
                        servicio.Guardar(tipoDePlanta);
                        Console.WriteLine("Registro agregado!!!");

                    }
                    else
                    {
                        Console.WriteLine("Registro existente!!!");
                    }

                }
                else { Console.WriteLine("Servicio no disponible"); }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            Thread.Sleep(5000);
        }

        private static void ListaDeTiposDePlantas()
        {
            var servicio = servicioProvider?
                .GetService<ITiposDePlantasService>();
            var lista = servicio?.GetLista();

            // Imprimir los títulos
            Console.WriteLine("Listado de Tipos de Plantas");

            // Crear la tabla con los títulos de las columnas
            var tabla = new ConsoleTable("ID", "Descripción");

            if (lista != null)
            {
                foreach (var item in lista)
                {

                    // Agregar la fila a la tabla
                    tabla.AddRow(item.TipoDePlantaId, item.Descripcion);
                }

            }
            // Mostrar la tabla
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }
        private static void ListarPlantas()
        {
            Console.Clear();
            Console.WriteLine("Listado de Plantas");

            var servicio = servicioProvider?.GetService<IPlantasService>();
            var recordCount = servicio?.GetCantidad()??0;
            var pageCount = CalcularCantidadPaginas(recordCount, pageSize);
            for (int page = 0; page < pageCount; page++)
            {
                Console.Clear();
                Console.WriteLine("Listado de Plantas");
                Console.WriteLine($"Página: {page + 1}");
                var listaPaginada = servicio?
                    .GetListaPaginadaOrdenadaFiltrada(page, pageSize);
                MostrarListaPlantas(listaPaginada);
                

            }
        }

        private static void ListarPlantasPaginado()
        {
            Console.Clear();
            var servicio = servicioProvider?.GetService<IPlantasService>();
            pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 10, 20);
            var recordCount = servicio?.GetCantidad() ?? 0;
            var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

            for (int page = 0; page < pageCount; page++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Página: {page + 1}");
                var listaPaginada = servicio?
                    .GetListaPaginadaOrdenadaFiltrada(page, pageSize);
                MostrarListaPlantas(listaPaginada);
                
            }
            Console.WriteLine("Fin del Listado");
        }

        private static void ListadoDePlantasOrdenado()
        {
            Console.Clear();
            Console.WriteLine("Listado de Plantas Ordenada Por Precio");
            var orden = ConsoleExtensions.GetValidOptions("(A)Z (Z)A (1)2 (2)1:", new List<string> { "A", "Z", "1", "2" });
            var servicio = servicioProvider?.GetService<IPlantasService>();
            pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 10, 20);
            var recordCount = servicio?.GetCantidad() ?? 0;
            var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

            for (int page = 0; page < pageCount; page++)
            {
                switch (orden)
                {
                    case "A":
                        MostrarListaPlantas(servicio?.GetListaPaginadaOrdenadaFiltrada(page, pageSize, Orden.AZ));
                        break;
                    case "Z":
                        MostrarListaPlantas(servicio?.GetListaPaginadaOrdenadaFiltrada(page, pageSize, Orden.ZA));
                        break;
                    case "1":
                        MostrarListaPlantas(servicio?.GetListaPaginadaOrdenadaFiltrada(page, pageSize, Orden.MenorPrecio));
                        break;
                    default:
                        MostrarListaPlantas(servicio?.GetListaPaginadaOrdenadaFiltrada(page, pageSize, Orden.MayorPrecio));
                        break;
                }
                
            }  
        }

        private static void ListaPlantasFiltrado()
        {
            Console.Clear();
            Console.WriteLine("Listado de Plantas Filtrada por Tipo de Planta");
            var servicioTipoPlanta = servicioProvider?.GetService<ITiposDePlantasService>();
            var listaTipos = servicioTipoPlanta?.GetLista();
            ListaDeTiposDePlantas();
            var listaCharac = listaTipos?.Select(x => x.TipoDePlantaId.ToString()).ToList();

            var tipoFiltroID = ConsoleExtensions.GetValidOptions("Seleccione Tipo: ", listaCharac);

            TipoDePlanta? tipoFiltro = servicioTipoPlanta?.GetTipoDePlantaPorId(Convert.ToInt32(tipoFiltroID));
            var servicio = servicioProvider?.GetService<IPlantasService>();
            MostrarListaPlantas(servicio?.GetListaPaginadaOrdenadaFiltrada(0, int.MaxValue, null, tipoFiltro));
        }

        private static void MostrarListaPlantas(List<PlantaListDto>? lista)
        {
            var tabla = new ConsoleTable("ID", "Planta", "Tipo", "Envase", "Precio");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    tabla.AddRow(item.PlantaId, item.Nombre, item.Tipo, item.Envase, item.Precio);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
        }

    }
}
