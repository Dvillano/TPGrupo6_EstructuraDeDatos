using System;
using System.Collections;


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

        public static void MostrarCandidatos(string[] candidatos)
        {
            Console.WriteLine("========Lista de candidatos========");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Candidato #{0}" +
                                   "\nNombre: " + candidatos[i], i+1);
            }
        }

        static void Main(string[] args)
        {
            //Parte 1 - Guardar candidatos
            string[] candidatos = GuardarCandidatos();
            MostrarCandidatos(candidatos);

            //Parte 2 - Ingresar votos

            //Parte 3 - Guardarlos en una cola

            //Parte 4 - Contar votos y guardar ganador

            //Parte 5 - Mostrar resultados con cantidad de votos y porcentaje, solo puede acceder "Jefe de Mesa"

            //Parte 6 - Menu


        }
    }

    
}
