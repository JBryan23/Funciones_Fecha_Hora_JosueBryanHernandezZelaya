//3.Crea un programa en C# que le indique al usuario cuantos días faltan a partir de hoy,
//para su próximo cumpleaños, puede pedir la fecha que la ingrese el usuario o dejar
//su propia fecha, en cualquier caso que decida, debe de mostrar la fecha ingresada o
//establecida y los días restantes a partir de la evaluación

public class Ejercicio3
{
    public static void Main()
    {
        //Mi fecha de cumpleaños establecida
        var Usuario = "Bryan";
        DateTime Fecha_Cumpleaños_Bryan = new DateTime(2023, 08, 23);
        DateTime Fecha_Actual = DateTime.Now;
        //Cuantos días faltan a partir de hoy
        if (Fecha_Cumpleaños_Bryan < Fecha_Actual)
        {
            Console.WriteLine("Fecha establecida " + Fecha_Cumpleaños_Bryan.ToString("d"));
            //Si ya paso este año se va calcular el proximo
            Fecha_Cumpleaños_Bryan = Fecha_Cumpleaños_Bryan.AddYears(1);
        }

        var Dias_Restantes = Fecha_Cumpleaños_Bryan - Fecha_Actual;
        // Mostrar la fecha de cumpleaños y los días restantes
        Console.WriteLine("El próximo cumpleaños de "+Usuario+" es el " + Fecha_Cumpleaños_Bryan.ToString("d"));
        Console.WriteLine("Para su proximo cumpleaños faltan " + Dias_Restantes.Days);

        Console.ReadLine();
    }
}//Hecho por Josue Bryan Hernandez Zelaya 