// See https://aka.ms/new-console-template for more information
using NLog;

/*
Console.WriteLine("Hello, World!");


try
{
    Logger.Info("Info");
    Logger.Debug("Debug");
    //System.Console.ReadKey();
}
catch (Exception ex)
{
    Logger.Error(ex, "Goodbye cruel world");
}
*/

NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
Console.WriteLine("Ingrese la cantidad de alumnos: ");
int cant_alumnos = Convert.ToInt32(Console.ReadLine());

List<Alumno> alumnos = new List<Alumno>();
string[] tipo_cursos = {"atletismo", "voley", "futbol"};
string ruta = @"C:\DIANA\Facultad\3er ANIO\2do Cuatrimestre\Taller de lenguajes II\TP2\tl2-tp2-2022-dianapark411\LogTest";

foreach (var item in tipo_cursos)
{
    HelperDeArchivos.crearCSV(ruta, item);
}

for (int i = 0; i < cant_alumnos; i++)
{
    Console.WriteLine($"\nCARGUE LOS DATOS DEL ALUMNO {i+1}:\n");
    int id = i; //sera autonumerico
    Console.WriteLine("Ingrese el nombre: ");
    string nombre = Funciones.ingresar_string();
    Console.WriteLine("Ingrese el apellido: ");
    string apellido = Funciones.ingresar_string();
    Console.WriteLine("Ingrese el DNI: ");
    int dni = Funciones.ingresar_positivo();
    Console.WriteLine("Ingrese el deporte que realiza: 0--> atletismo, 1--> voley, 2--> futbol");
    int curso = Funciones.ingresar_positivo();

    alumnos.Insert(i, new Alumno(id, nombre, apellido, dni, curso));
    Logger.Info("Alumno guardado");

    HelperDeArchivos.escribir_contenido(ruta, tipo_cursos[curso], alumnos[i]);
    Logger.Debug("CSV escrito");
    
}