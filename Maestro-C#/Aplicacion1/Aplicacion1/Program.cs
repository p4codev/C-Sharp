using System;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------- Tipo de Datos --------------
            Console.WriteLine("Tipo de Datos en C#");            
            
            //Tipo de Dato Short (Para Numeros Pequeños)
            short a = 20;
            Console.WriteLine("La variable Short es:"+ a);

            //Tipo de Dato Int (El mas usado)
            int b = 1523655;
            Console.WriteLine("La Variable Int es:" + b);

            //Tipo de Dato Long (Para Cantidades Enteras Grandes)
            long c = 1526;
            Console.WriteLine("La Variable Long es:" + c);

            //Tipo de Dato Double (numeros y decimales - 7 digitos)
            double d = 5.268d;
            Console.WriteLine("La variable Double es:" + d);

            //Tipo de Dato Float (numeros y decimas - 15 /16 digitos)
            float e = 5.32659854f;
            Console.WriteLine("La variable Float es:"+ e);

            //Tipo de Dato Decimal (Nos permite almacenar varios decimales)
            decimal f = 8.2365985m;
            Console.WriteLine("La variables Decimal es:" + f);

            //Tipo de Dato Char (Almacena un Caracter)
            char g = 'a';
            Console.WriteLine("El Caracter es:" + g);

            //Tipo de Dato String (Cadena de Caracteres)
            string h = "Bienvenido PacoDev Sigue Asi";
            Console.WriteLine("La cadena de caracteres es:" + h);

            //Tipo de dato Booleano (Verdadero o Falso)
            bool i = true;
            Console.WriteLine("El Valor Booleano es:" + i);

            Console.ReadLine();


            //--------------- Operadores en C# --------------
            Console.WriteLine("Operadores en C#");
            int j = 10;
            int k = 56;
            double l = 38.95;

            int suma = j + k;
            double sumaDouble = j + l;
            int resta = k - j;
            int multiplicacion = j * k;
            double division = k / l;
            double divisionEnteros = (k * 1.0) / j; //La division entre enteros va a dar un numero entero para solucionar usamos (x * 1.0)
            double residuo = k % j;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La Suma Double es: " + sumaDouble);
            Console.WriteLine("La Resta es: " + resta);
            Console.WriteLine("La Multiplicacion es: " + multiplicacion);
            Console.WriteLine("La division es: " + division );
            Console.WriteLine("La division Enteros es: " + divisionEnteros);
            Console.WriteLine("El Residuo es: " + residuo);

            Console.ReadLine();

            //--------------- Concatenacion con Cadenas en C# --------------
            Console.WriteLine("Concatenación con en C#");
            string cad1 = "Hola este Archivo fue elaborado por: ";
            string cad2 = "Alexander Coral (Pacodev)";
            string resultado = cad1 + cad2;
            Console.WriteLine("La Cadena 1 es: " + cad1);
            Console.WriteLine("La Cadena 2 es: " + cad2);
            Console.WriteLine("Resultante es: " + resultado);

            Console.ReadLine();

        }
    }
}
