using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINALPROGRA_JOSEG1124522_CAMILAG1188422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un usuario y contraseña
            int cantidad = 0;
            int contador = 0;
            string usuario;
            string contraseña;
            bool res = false;


            while (cantidad < 3)
            {
                Console.WriteLine("Ingrese el usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Coloque contraseña");
                contraseña = Console.ReadLine();

                res = login(usuario, contraseña);
                if (res == true)
                {
                    cantidad = 3;
                    Console.WriteLine("Ingreso accedido");
                    Console.ReadKey();
                    Console.Clear();
                menu:
                    Console.Clear();
                    int opcion = 0;
                    Console.WriteLine("       Bienvenido al sistema " + usuario);
                    Console.WriteLine("       Ingrese entre las opciones");
                    Console.WriteLine("       1. Ventilacion");
                    Console.WriteLine("       2. Calefaccion");
                    Console.WriteLine("       3. Iluminacion");
                    Console.WriteLine("       4. Panel de Control");
                    Console.WriteLine("       5. Salir ");
                    opcion = int.Parse(Console.ReadLine());


                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Esta opcion esta desabilitada, Precione enter para regresar");
                            Console.ReadKey();
                            goto menu;
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Esta opcion esta desabilitada, Precione enter para regresar");
                            Console.ReadKey();
                            goto menu;
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Esta opcion esta desabilitada, Precione enter para regresar");
                            Console.ReadKey();
                            goto menu;
                            break;


                        case 4:
                            int control = 0;
                        menus:
                            Console.Clear();
                            Console.WriteLine("       Panel de control");
                            Console.WriteLine("       1. Ventilacion");
                            Console.WriteLine("       2. Calefaccion");
                            Console.WriteLine("       3. Regresar al inicio");



                            control = int.Parse(Console.ReadLine());

                            switch (control)
                            {
                                case 1:
                                    int on, off, temperatura, hora;
                                    Console.Clear();
                                    Console.WriteLine("Ingresar horas de encendido");
                                    on = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingresar horas de apagado");
                                    off = Int32.Parse(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Ingrese la hora");
                                    hora = Int32.Parse(Console.ReadLine());
                                    Random random = new Random();
                                    temperatura = random.Next(1, 100);


                                    Console.ReadKey();
                                    if (hora <= off)
                                    {
                                        if (temperatura == 70)
                                        {
                                            Console.ReadKey();
                                            Console.WriteLine("la temperatura es: " + temperatura);
                                            Console.WriteLine("la temperatura esta en su nivel optimo");

                                        }
                                        else
                                        {
                                            if (temperatura > 70)
                                            {
                                                Console.ReadKey();
                                                Console.WriteLine("la temperatura es: " + temperatura);
                                                Console.WriteLine("la temperatura exterior esta alta");
                                                Console.WriteLine("la temperatura se bajara al 70%");
                                            }
                                            else
                                            {
                                                if (temperatura < 70)
                                                {
                                                    Console.ReadKey();
                                                    Console.WriteLine("la temperatura es: " + temperatura);
                                                    Console.WriteLine("la temperatura exterior esta baja");
                                                    Console.WriteLine("la temperatura se subira al 70%");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {

                                        if (hora >= off)
                                        {
                                            Console.WriteLine("A esta hora la ventilacion esta apagada ");
                                            Console.ReadKey();

                                        }
                                    }
                                    Console.ReadKey();
                                    goto menus;
                                    break;
                                case 2:
                                    int n, f, maxima, minima, grados, menu, mapromedio, mipromedio;
                                    int masuma = 0;
                                    int misuma = 0;
                                    string cuarto;

                                    Console.Clear();
                                    Console.WriteLine("Temperatura maxima es 22");
                                    Console.WriteLine("Temperatura minima es 18");
                                    Console.WriteLine("Cuantas habitaciones configurara: ");
                                    n = Int32.Parse(Console.ReadLine());
                                    for (f = 1; f <= n; f++)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Se configuraran las temperaturas aleatoriamente");
                                        Console.WriteLine("Ingrese la habitacion que desea configurar");
                                        cuarto = Console.ReadLine();
                                        Console.WriteLine("Temperaturas maximas");
                                        Random random1 = new Random();
                                        maxima = random1.Next(19, 22);
                                        Console.WriteLine("La temperatura es: " + maxima);
                                        Console.WriteLine("Temperaturas minimas");
                                        Random random2 = new Random();
                                        minima = random1.Next(1, 18);
                                        Console.WriteLine("La temperatura es: " + minima);
                                        Console.ReadKey();
                                        Console.Clear();
                                        Random random3 = new Random();
                                        grados = random3.Next(1, 40);
                                        masuma = masuma + maxima;
                                        misuma = misuma + minima;
                                        Console.Clear();
                                        Console.WriteLine("       Entrara a la " + cuarto);
                                        Console.WriteLine("       1. Si");
                                        Console.WriteLine("       2. No");


                                        menu = int.Parse(Console.ReadLine());

                                        switch (menu)
                                        {
                                            case 1:
                                                if (grados >= 22)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("La habitacion esta encendida");
                                                    Console.WriteLine("Los grados son: " + grados);
                                                    Console.WriteLine("la temperatura esta alta");
                                                    Console.WriteLine("La temperatura maxima deseada es 22, se reducira");
                                                    Console.ReadKey();
                                                }
                                                if (grados <= 18)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("La habitacion esta encendida");
                                                    Console.WriteLine("Los grados son: " + grados);
                                                    Console.WriteLine("la temperatura esta muy baja");
                                                    Console.WriteLine("La temperatura minima deseada es 18, se aumentara");
                                                    Console.ReadKey();
                                                }
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("La habitacion seguira apagada");
                                                Console.ReadKey();
                                                break;

                                        }
                                    }
                                    Console.Clear();
                                    mapromedio = masuma / n;
                                    mipromedio = misuma / n;
                                    Console.WriteLine("El promedio de las temperaturas maximas es : " + mapromedio);
                                    Console.WriteLine("El promedio de las temperaturas minima es : " + mipromedio);
                                    Console.ReadKey();
                                    goto menus;

                                    break;
                                case 3:
                                    goto menus;
                                    break;
                            }
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Ingrese una opción entre 1 a 5");
                            break;
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Error al ingresar ingrese de nuevo, su cantidad de intentos es: " + contador);
                    contador++;
                    cantidad++;
                }
                if (contador == 3)
                {
                    Console.WriteLine("Se han agotado las oportunidades");
                }
            }
            Console.ReadKey();
        }
        public static bool login(string usuario, string contra)
        {
            //USUARIO = JOCA Y CONTRASEÑA  = hola
            if (usuario == "JOCA" && contra == "hola")
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
