// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n\r============================================");
Console.WriteLine("\n\rSistema para registro de alumnos y promedios");
Console.WriteLine("\n\r============================================");
lectura();

 static void lectura()
{
    Console.Write("\nIngrese la cantidad de alumnos a registrar: ");

    int alumnos;
    bool flag= Int32.TryParse(Console.ReadLine(), out alumnos);
    if (flag && alumnos > 0)
    {
        evaluar(alumnos);
    }
    else
    {
        Console.WriteLine("Por favor, ingrese una cantidad valida");
        lectura();
    }
}

static void evaluar(int n)
{
    string[] alumnos = new string[n];
    double[] notas = new double[n];
    double mejorAvg = 0, peorAvg = 20, aux = 0;
    string erudito = "", pobresito = "";

    List<Alumno> prueba = new List<Alumno>();

    for (int i = 0; i < alumnos.Length; i++)
    {
        Console.WriteLine("\n\r============================================");
        Console.WriteLine("\n\rPor favor, ingrese los datos del alumno #"+(i+1));
        Console.WriteLine("\n\rDatos del alumno #" + (i + 1)+":");

        Console.Write("\n\r Nombre: ");
        alumnos[i] = Console.ReadLine();

        Console.Write("\n\r Promedio: ");
        bool flag = Double.TryParse(Console.ReadLine(), out notas[i]);

        Console.WriteLine("\n\r============================================");

        prueba.Add(new Alumno { ID = (i+1), Nombre = alumnos[i], Promedio = notas[i] }) ;
    }
    //prueba.ForEach(e => Console.WriteLine(e));
    prueba.ForEach(e =>
    {
        aux = e.Promedio;

        if (e.Promedio > mejorAvg)
        {
            mejorAvg = e.Promedio;
            erudito = e.Nombre;
        }
        if (aux <= peorAvg)
        {
            peorAvg = e.Promedio;
            pobresito = e.Nombre;
        }
    });
    Console.WriteLine("El alumno con mejor promedio es "+ erudito +" con un promedio de " + mejorAvg);
    Console.WriteLine("El alumno con peor promedio es " + pobresito + " con un promedio de " + peorAvg);

}
public class Alumno
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public double Promedio { get; set; }

    public override string ToString()
    {
        return  "\n"+
                $"ID: {ID}\n" +
                $"Nombre: {Nombre} \n" +
                $"Promedio: {Promedio}";
    }
}