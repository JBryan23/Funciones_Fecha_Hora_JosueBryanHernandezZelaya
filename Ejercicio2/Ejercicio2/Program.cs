//2. Se adquiere un préstamo de $3,000 para cubrir los gastos de colegiatura del ciclo
//2-2023 del estudiante Juan Perez de la UNAB Chalatenango, el préstamo es a un
//plazo de 6 meses, la fecha de pago de la primera cuota es el dia de hoy, hacer un
//programa que muestre las fechas de pago futuras y la cuota a pagar del préstamo.

public class Ejercicio2
{
    public static void Main()
    {
        //Datos y prestamo que realizo Juan Perez
        var Usuario = "Juan Perez";
        double Prestamo_JP = 3000;
        int Plazo_De_Meses = 6;
        //Se ocupa la funcion DateTime.Now para fecha actual (Funcion vista en clase)
        DateTime Fecha_Pago_Actual = DateTime.Now;
        //Este monto se divide para tener la couta mensal que es con el prestamo entre el plazo de meses
        double Cuotas_Mensualmente = Prestamo_JP / Plazo_De_Meses;

        Console.WriteLine("Usuario " + Usuario +" sus detalles de su prestamo son los siguientes:");
        Console.WriteLine("Prestamo total: $" + Prestamo_JP);
        Console.WriteLine("Plazo en meses: " + Plazo_De_Meses+" meses");
        Console.WriteLine("=======================================================");
        Console.WriteLine("Usuario "+Usuario+" las fechas de pago futuras y la cuota a pagar del préstamo son:");

        // Se muestra del usuario (Juan Perez) las fechas de pago futuras y la cuota a pagar
        for (int JP = 0; JP < Plazo_De_Meses; JP++)
        {
            Fecha_Pago_Actual = Fecha_Pago_Actual.AddMonths(1);
            Console.WriteLine("Fecha de pago: " + Fecha_Pago_Actual.ToString("dd MMMM yyyy") + " y su cuota a pagar: $" + Cuotas_Mensualmente);
        }

        Console.ReadLine();
    }
}

//Hecho por Josue Bryan Hernandez Zelaya