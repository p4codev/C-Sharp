using System;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //Tipo de Datos
        }
    }
}
