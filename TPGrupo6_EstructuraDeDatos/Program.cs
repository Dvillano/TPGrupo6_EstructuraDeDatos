using System;
using System.Collections.Generic;

namespace TPGrupo6_EstructuraDeDatos
{
    class Program
    {
        //Funcion para preguntar y guardar candidato
        public static string[] GuardarCandidatos()
        {
            string[] candidatos = new string[3];

            for (int i = 0; i < candidatos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre  del candidato: ");
                candidatos[i] = Console.ReadLine();
            }

            return candidatos;
        }

        //Funcion para mostrar candidatos
        public static void MostrarCandidatos(string[] candidatos)
        {
            Console.WriteLine("========Lista de candidatos========");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Candidato #{0}" +
                                   "\nNombre: " + candidatos[i], i+1);
            }
        }

        public static string[] ingresarVotantes(string[] candidatos)
        {
            string[] votantes = new string[6];
            int edad, voto;
            Console.WriteLine("\n\nArranca la votacion\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\nIngrese su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                while (edad < 18)
                {
                    Console.Write("Usted no puede votar\n\nIngrese su edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n¿Por quien votara?\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine((j + 1) + "_ " + candidatos[j]);
                }
                Console.Write("\nElija a su candidato: ");
                voto = Convert.ToInt32(Console.ReadLine());
                while (voto < 1 || voto > 3)
                {
                    Console.Write("Ese candidato no existe. Vuelva a elegir su candidato: ");
                    voto = Convert.ToInt32(Console.ReadLine());
                }
                votantes[i] = candidatos[voto - 1];
            }
            return votantes;
        }

        static void Main(string[] args)
        {
            Queue<string> cola = new Queue<string>();
            //Parte 1 - Guardar candidatos
            string[] candidatos = GuardarCandidatos();
            MostrarCandidatos(candidatos);

            //Parte 2 - Ingresar votos
            string[] votantes = ingresarVotantes(candidatos);

            //Parte 3 - Guardar votos en una cola
            for (int i = 0; i < 6; i++)
            {
                cola.Enqueue(votantes[i]);
            }

            //Parte 4 - Contar votos y guardar ganador

            //Parte 5 - Mostrar resultados con cantidad de votos y porcentaje, solo puede acceder "Jefe de Mesa"

            //Parte 6 - Menu


        }
    }

    
}
