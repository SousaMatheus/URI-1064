using System;
using System.Globalization;

namespace URI_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valor3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valor4 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valor5 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valor6 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            int seForPositivo = 0;
            double media = 0.0;
            

            if (valor1 > 0.0){
                seForPositivo += 1;
                media += valor1;
            }
            if (valor2 > 0.0){
                seForPositivo += 1;
                media += valor2;
            }
            if (valor3 > 0.0){
                seForPositivo += 1;
                media += valor3;
            }
            if (valor4 > 0.0){
                seForPositivo += 1;
                media += valor4;
            }
            if (valor5 > 0.0){
                seForPositivo += 1;
                media += valor5;
            }
            if (valor6 > 0.0){
                seForPositivo += 1;
                media += valor6;
            }

            double resultadoMedia = media/seForPositivo;
            Console.WriteLine(seForPositivo +" valores positivos");
            Console.WriteLine(resultadoMedia.ToString("F1",CultureInfo.InvariantCulture));


        }
    }
}
