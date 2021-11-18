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
        static string guardarGanador(string[] candidatos)
        {
            string ganador = string.Empty;
            int candidato1 = 0;
            int candidato2 = 0;
            int candidato3 = 0;

            if (candidato1 > candidato2)
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
            return ganador;

        }


        //Mostrar resultados por cantidad de votos y porcentaje general para cada candidato

        static int Resultado(Queue<string> votos, string[] candidatos)
        {

            int mostrarResul;
            int candidato1 = 0, candidato2 = 0, candidato3 = 0;
            int cantidadVotantes = votos.Count;
            double oc1, oc2, oc3;

            Console.WriteLine(votos.Peek());
            for (int i = 0; i < cantidadVotantes; i++)
            {
                if (votos.Peek() == candidatos[0])
                {
                    candidato1 += 1;
                    votos.Dequeue();
                }

                else if (votos.Peek() == (candidatos[1]))
                {
                    candidato2 += 1;
                    votos.Dequeue();
                }

                else if (votos.Peek() == (candidatos[2]))
                {
                    candidato3 += 1;
                    votos.Dequeue();
                }
            }

            Console.WriteLine("\nEl candidato {0} recibio {1} votos", candidatos[0], candidato1);
            Console.WriteLine("\nEl candidato {0} recibio {1} votos", candidatos[1], candidato2);
            Console.WriteLine("\nEl candidato {0} recibio {1} votos", candidatos[2], candidato3);

            mostrarResul = candidato1 + candidato2 + candidato3;
            oc1 = candidato1 * 100 / mostrarResul;
            oc2 = candidato2 * 100 / mostrarResul;
            oc3 = candidato3 * 100 / mostrarResul;
            Console.WriteLine("\nEl porcentaje de votos para el candidato {0} es de {1}%", candidatos[0], oc1);
            Console.WriteLine("\nEl porcentaje de votos para el candidato {0} es de {1}%", candidatos[1], oc2);
            Console.WriteLine("\nEl porcentaje de votos para el candidato {0} es de {1}%\n", candidatos[2], oc3);

            return mostrarResul;

        }

        static void Main(string[] args)
        {
            Queue<string> votos = new Queue<string>();
            //Parte 1 - Guardar candidatos
            string[] candidatos = GuardarCandidatos();
            MostrarCandidatos(candidatos);

            //Parte 2 - Ingresar votos
            string[] votantes = ingresarVotantes(candidatos);

            //Parte 3 - Guardar votos en una cola
            for (int i = 0; i < votantes.Length; i++)
            {
                votos.Enqueue(votantes[i]);
            }

            //Parte 4 - Contar votos y guardar ganador 
            Console.Write("El ganador es: {0}", guardarGanador(candidatos));

            //Parte 5 - Mostrar resultados con cantidad de votos y porcentaje
            Console.Write("La cantidad de votos totales es de: {0}\n", Resultado(votos, candidatos));
        }
    }

    
}
