//Ejercicio 3 Clase de Lógica de Programación
public class ProgramaSalario
{
    static void Main(string[] args)
    {

        //Declaración de variables
        decimal sueldoBase, venta1, venta2, venta3, totalComision, totalSalario;
        
        //Declaración de constantes
        const decimal PORCENTAJE_COMISION = 10;

        //Datos de entrada
        Console.Write("Ingrese su sueldo base: ");
        sueldoBase = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el valor de su venta #1: ");
        venta1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el valor de su venta #2: ");
        venta2 = decimal.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de su venta #3: ");
        venta3 = Convert.ToDecimal(Console.ReadLine());

        //Proceso (Cálculos)

        totalComision = (venta1 + venta2 + venta3) * (PORCENTAJE_COMISION/100);
        totalSalario = sueldoBase + totalComision;

        //Datos de salida
        Console.WriteLine("El total de comisiones se calcula teniendo en cuenta que su ganancia equivale al 10% del valor de la venta.");
        Console.WriteLine($"El total de comisiones por sus ventas es: ${totalComision}.");
        Console.WriteLine($"Su salario total es: ${totalSalario}.");
    }
}
