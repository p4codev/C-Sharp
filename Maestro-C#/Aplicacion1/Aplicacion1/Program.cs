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

            //--------------- Conversion de tipo de datos en C# --------------
            Console.WriteLine("Conversion de tipo de Datos en C# \n");
            short v0 = 56;
            int v1 = 25;
            double v2 = 35.26;
            float v3 = 26.35564f;

            //Convertimos de Short, Int, double, float a tipo de dato String
            string v0T = v0.ToString();
            string v1T = v1.ToString();
            string v2T = v2.ToString();
            string v3T = v3.ToString();
            Console.WriteLine("Convertimos de datos numericos a tipo String");
            Console.WriteLine("El valor " +v0T+" es de Tipo de dato: " + v0T.GetType());
            Console.WriteLine("El valor "+v1T+" es de Tipo de dato: "+ v1T.GetType());
            Console.WriteLine("El valor "+v2T+" es de Tipo de dato: " + v2T.GetType());
            Console.WriteLine("El valor "+v3T+" es de Tipo de dato: " + v3T.GetType());

            //Convertimos de dato String a datos Short, int, double, float
            short v0N = short.Parse(v0T);
            int v1N = int.Parse(v1T);
            double v2N = double.Parse(v2T);
            float v3N = float.Parse(v3T);
            Console.WriteLine("\nConvertimos de datos String a valores numericos");
            Console.WriteLine("El valor " + v0N + " es de tipo de dato: " + v0N.GetType());
            Console.WriteLine("El valor " + v1N + " es de tipo de dato: " + v1N.GetType());
            Console.WriteLine("El valor " + v2N + " es de tipo de dato: " + v2N.GetType());
            Console.WriteLine("El valor " + v3N + " es de tipo de dato: " + v3N.GetType());

            //------------------------------- Start Formato de Secuencia de Cadenas -------------------------------            
            //Secuencia de Caracteres de Escape
            Console.WriteLine("\nSecuencia de Caracteres de Escape");
            Console.WriteLine("Hello\nWorld");//Salto de Linea
            Console.WriteLine("Hello\tWorld");//Tabulación
            Console.WriteLine("Hello \"World\"");
            Console.WriteLine("C:\\\\User\\Pacodev");
            Console.WriteLine("\nEjemplos\n");
            Console.WriteLine("Generating invoices for costumers \"BUUUQ S. T.\"...\n");
            Console.WriteLine("Invoice: 1021\tComplete!");
            Console.WriteLine("Invoice: 1022\tComplete!\n");
            Console.WriteLine("Output Directory:");

            //Literal de Cadena Textual 
            Console.WriteLine(@"C\\User\Pacodev\
            This is where your code goes
                Hello World!"); //Conserva todos los espacios en blanco y los caracteres sin la nececidad de usar una secuencia de escape
            Console.WriteLine(@"C:\Invoices");

            //Carcateres de Escape Unicode
            Console.WriteLine("\nCaracteres de Escape Unicode");
            Console.Write("\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");
            //------------------------------- End Formato de Secuencia de Cadenas -------------------------------

            //Interpolación de Cadenas
            Console.WriteLine("\nInterpolacion de Cadenas");
            string firstName = "Alexander";
            string lastName = "Coral";
            string message = $"{firstName} {lastName}";
            Console.WriteLine(message);
            Console.WriteLine($"{lastName} - {firstName}");








        }
    }
}
