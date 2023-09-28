//1.Realice un programa que permita verificar si el dado el siguiente arreglo de años
//evalúe cada dato contenido y diga si es un año bisiesto o no
//int[] years = new int[10] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

public class Ejercicio1
{
    public static void Main()
    {
        //arreglo de años
        int[] years = new int[10] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021 };

        foreach (int Evaluar_año in years)
        {
            //Evaluacion si es año bisiesto o no usando IsLeapYear()
            if (DateTime.IsLeapYear(Evaluar_año))
            {
                Console.WriteLine("El siguiente año si es un año bisiesto: " + Evaluar_año);
            }
            else
            {
                Console.WriteLine("El siguiente año no es un año bisiesto: " + Evaluar_año);
            }
        }

    }
}

//Hecho por Josue Bryan Hernandez Zelaya
