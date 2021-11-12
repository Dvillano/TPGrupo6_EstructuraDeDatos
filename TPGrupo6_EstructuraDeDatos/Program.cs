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

        //Funcion para ingresar los votos
        public static string[] ingresarVotantes(string[] candidatos)
        {
            Console.WriteLine("Ingrese cantidad de votantes");
            int cantVotantes = int.Parse(Console.ReadLine());

            string[] votantes = new string[cantVotantes];
            int edad, voto;
            Console.WriteLine("\n\nArranca la votacion\n");
            for (int i = 0; i < votantes.Length; i++)
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

        //Contar votos y guardar ganador
        static string guardarGanador(Queue<string> votos, string[] candidatos)
        {
            string ganador = string.Empty;
            int candidato1 = 0;
            int candidato2 = 0;
            int candidato3 = 0;

            for (int i = 0; i < votos.Count; i++)
            {
                if (votos.Contains(candidatos[0]))
                {
                    candidato1 += 1;
                }

                if (votos.Contains(candidatos[1]))
                {
                    candidato2 += 1;
                }

                if (votos.Contains(candidatos[2]))
                {
                    candidato3 += 1;
                }
            }

            if(candidato1 > candidato2)
            {
                if (candidato1 > candidato3)
                {
                    ganador = candidatos[0];
                }
                else
                {
                    ganador = candidatos[2];
                }
            }
            else if (candidato2 > candidato3)
            {
                ganador = candidatos[1];
            }
            else
            {
                ganador = candidatos[2];
            }

            return ganador;
        }

        static void Main(string[] args)
        {
            Queue<string> votos = new Queue<string>();
            //Parte 1 - Guardar candidatos
            string[] candidatos = GuardarCandidatos();
            MostrarCandidatos(candidatos);

            //Parte 2 - Ingresar votos - Pendiente cambiar el numero de votantes
            string[] votantes = ingresarVotantes(candidatos);

            //Parte 3 - Guardar votos en una cola
            for (int i = 0; i < votantes.Length; i++)
            {
                votos.Enqueue(votantes[i]);
            }

            //Parte 4 - Contar votos y guardar ganador - Pendiente que hacer en caso de empate
            Console.WriteLine("El ganador es: {0}", guardarGanador(votos, candidatos));

            //Parte 5 - Mostrar resultados con cantidad de votos y porcentaje, solo puede acceder "Jefe de Mesa"

            //Parte 6 - Validaciones

            //Mandar funciones a libreria
        }
    }

    
}
