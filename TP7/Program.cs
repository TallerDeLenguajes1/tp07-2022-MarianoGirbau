using System;
using TP7;


int CantidadDeTareas = 5;
int variable = 0;
var rnd = new Random();
string[] descripciones = { "limpiar", "trabajar", "descansar", "fabricar" };

List<tarea> tareasPendientes = new List<tarea>();
List<tarea> tareasRealizadas = new List<tarea>();

for (int i = 0; i < CantidadDeTareas; i++)
{
    tarea tar = new tarea();
    tar.tareaID = i + 1;
    tar.descripcion = descripciones[rnd.Next(0, 3)];
    tar.duracion = rnd.Next(10, 100);
    tareasPendientes.Add(tar);
}

Console.WriteLine("--TAREAS PENDIENTES--");
foreach (tarea tar in tareasPendientes)
{
    tar.mostrarTareas();
}

for (int i = 0; i < CantidadDeTareas; i++)
{
    Console.WriteLine("\n=======Tarea ID [" + tareasPendientes[i].tareaID+ "]=======");
    Console.WriteLine("\nDescricpion: " + tareasPendientes[i].descripcion);
    Console.WriteLine("\nDesea pasar esta tarea a realizadas? 1:SI / 0:NO\n");
    variable = Int32.Parse(Console.ReadLine());

    if (variable == 1)
    {
        tareasRealizadas.Add(tareasPendientes[(int)i]);
    }

}

tareasPendientes = tareasPendientes.Except(tareasRealizadas).ToList();//pone en pendientes todas menos las realizadas(borra las que son iguales)

Console.WriteLine("\n=======TAREAS REALIZADAS=======");

foreach (tarea tar in tareasRealizadas)
{
    tar.mostrarTareas();
}

Console.WriteLine("\nBusqueda por palabra:");
