using System;
using System.Collections.Generic;

namespace EjercicioCajeroPin
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 3867;
            double saldo = 4000;
            int intentos = 3;
            bool bandera = false;
            List<string> movimientos = new List<string>();
            int control = 1;

            while (intentos>0) {

                Console.WriteLine("Ingrese el Pin");
                int valuePin = Int32.Parse(Console.ReadLine());

                if (valuePin == pin)
                {
                    bandera = true;
                    break;
                }
                else {
                    Console.WriteLine("Pin incorrecto");
   
                }
                intentos--;
            }

            while (control!=0) {
                if (bandera == true)
                {
                    Console.WriteLine("Consulta que deseas realizar \n 1)Consultar saldo \n 2)Retirar saldo \n 3) Consultar Movimiento \n 4) Salir");
                    int consulta = Int32.Parse(Console.ReadLine());

                    switch (consulta)
                    {
                        case 1:
                            {
                                Console.WriteLine("Su saldo es: ${0}", saldo);
                                Console.WriteLine("");

                            }
                            
                            break;
                        case 2:
                            {
                                bandera = false;
                                while (bandera != true) {
                                    Console.WriteLine("Cuanto desea retirar");
                                    double retiro = double.Parse(Console.ReadLine());
                                    if (retiro > saldo)
                                    {
                                        Console.WriteLine("Su saldo es iferior al moto ingresado su salldo actual es de: ${0}", saldo);
                                    }
                                    else {
                                        saldo = saldo - retiro;
                                        movimientos.Add(retiro.ToString()+ "fecha: "+ DateTime.Now);
                                        Console.WriteLine("Se retiro el monto de ${0} su saldo queda con ${1}", retiro, saldo);
                                        Console.WriteLine("Desea realizar otro retiro presione:\n -Cualquier tecla para continuar \n -N para salir");
                                        string continuar = Console.ReadLine();
                                        if (continuar == "n")
                                        {
                                            bandera = true;
                                        }
                                    }
                                    
                                 

                                }
                            }
                            break;
                        case 3:
                            {
                                if (movimientos.Count > 0)
                                {
                                    foreach (string mov in movimientos)
                                    {
                                        Console.WriteLine("Movimientos realizados: {0} ", mov);
                                    }
                                }
                                else {
                                    Console.WriteLine("la cuenta no tiene movimientos");
                                    Console.WriteLine();
                                }
                                
                            }
                            break;
                        case 4:
                            Console.WriteLine("Hasta luego");
                            control = 0;
                            break;
                        default:
                            {
                                Console.WriteLine("Ingreso una opcion no valida, si desea salir precione 4");
                                
                               
                            }
                           
                            break;
                    }


                }

            }
            if(bandera==false)
            {
                Console.WriteLine("Realizaste tres intentos, tu clave fue bloqueada");
            }

            

        }
    }


}
