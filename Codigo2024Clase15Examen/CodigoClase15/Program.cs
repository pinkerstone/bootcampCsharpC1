

using CodigoClase15.Clases;
using CodigoClase15.Interfaces;

void Parte1()
{
    List<EmpleadoBase> empleados = new List<EmpleadoBase>();
    Gerente gerente = new Gerente
    {
        IdEmpleado = "1",
        Nombre = "Hugo Torrico",
        Puesto = "Gerente Desarrollo"
    };

    Desarollador desarollador = new Desarollador
    {
        IdEmpleado = "2",
        Nombre = "José Cárdenas",
        Puesto = "Desarrollador Senior"   
    };
    GerenteRRHH gerenteRRHH = new GerenteRRHH
    {
        IdEmpleado = "3",
        Nombre = "Luis Ulloa",
        Puesto = "Gerente Recursos Humanos"
    };
    ConsultorExterno consultor = new ConsultorExterno
    {
        IdEmpleado = "4",
        Nombre = "Fernando Perez",
        Puesto = "Consultor"
    };
    
    empleados.Add(gerente);
    empleados.Add(desarollador);
    empleados.Add(gerenteRRHH);
    empleados.Add(consultor);

    foreach (var empleado in empleados)
    {
        empleado.MostrarDetalle();
        Console.WriteLine(empleado.CalcularSueldo());

        if (empleado is ISueldoBonificable empleadoBonificable)
        {
            Console.WriteLine(empleadoBonificable.CalcularBonificacion());
        }
        if (empleado is IDescuentoImpuesto empleadoDescuento)
        {
            Console.WriteLine(empleadoDescuento.DescontarSueldo());
        }

    }
}

void Parte2()
{
    string opcion;
    List<EmpleadoBase> empleados = new List<EmpleadoBase>();
    do
    {

        Console.Clear();
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("--------------");
        Console.WriteLine("1. Ingresar empleado");
        Console.WriteLine("2. Mostrar listado de Empleados");
        Console.WriteLine("3. Salir");
        opcion = Console.ReadLine();
        Console.Clear();

        switch (opcion)
        {
            case "1":
                {
                    IngresarEmpleado();
                    break;
                }
            case "2":
                {
                    MostrarListado();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
    while (opcion == "1" || opcion == "2");

    void IngresarEmpleado()
    {
        string opcion2;
        string idEmpleado;
        string nombre;
        string puesto;
        int sueldoBase;

            Console.WriteLine("Ingresa el Id del empleado: ");
            idEmpleado = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el puesto: ");
            puesto = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("SELECCIONA EL TIPO DE EMPLEADO");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Gerente");
            Console.WriteLine("2. Gerente RRHH");
            Console.WriteLine("3. Desarrollador");
            Console.WriteLine("4. Consultor Externo");
            opcion2 = Console.ReadLine();
            Console.Clear();

            switch (opcion2)
            {
                case "1":
                    {
                        Gerente empleado = new Gerente
                        {
                            IdEmpleado = idEmpleado,
                            Nombre = nombre,
                            Puesto = puesto,
                        };
                        AgregarEmpleado(empleado);
                        break;
                    }
                case "2":
                    {
                        GerenteRRHH empleado = new GerenteRRHH
                        {
                            IdEmpleado = idEmpleado,
                            Nombre = nombre,
                            Puesto = puesto,
                        };
                        AgregarEmpleado(empleado);
                        break;
                    }
                case "3":
                    {
                        Desarollador empleado = new Desarollador
                        {
                            IdEmpleado = idEmpleado,
                            Nombre = nombre,
                            Puesto = puesto,
                        };
                        AgregarEmpleado(empleado);
                        break;
                    }
                case "4":
                    {
                        ConsultorExterno empleado = new ConsultorExterno
                        {
                            IdEmpleado = idEmpleado,
                            Nombre = nombre,
                            Puesto = puesto,
                        };
                        AgregarEmpleado(empleado);
                        break;
                    }
                default:
                {
                    break;
                }
            }
    }
    
    void AgregarEmpleado(EmpleadoBase ArgEmpleado)
    {
        empleados.Add(ArgEmpleado);
    }

    void MostrarListado()
    {
        int cantidadEmpleados = 0;
        decimal planillaTotal = 0m;

        foreach (var empleado in empleados)
        {
            empleado.MostrarDetalle();
            Console.WriteLine($"El sueldo neto es: {empleado.CalcularSueldo()}");

            if (empleado is ISueldoBonificable empleadoBonificable)
            {
                Console.WriteLine($"La bonificación es de: {empleadoBonificable.CalcularBonificacion()}");
            }
            if (empleado is IDescuentoImpuesto empleadoDescuento)
            {
                Console.WriteLine($"El descuento es de: {empleadoDescuento.DescontarSueldo()}");
            }
            cantidadEmpleados++;
            planillaTotal = planillaTotal + empleado.CalcularSueldo();
            Console.WriteLine("------------------");
        }
        Console.WriteLine("-------------------");
        Console.WriteLine($"El total de empleados es: {cantidadEmpleados}");
        Console.WriteLine($"La planilla total es de: {planillaTotal}");
        Console.ReadKey();
    }
}

Parte2();





Console.Read();