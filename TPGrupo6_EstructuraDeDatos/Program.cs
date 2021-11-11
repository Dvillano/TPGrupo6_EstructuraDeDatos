using System;
using System.Collections;


namespace TPGrupo6_EstructuraDeDatos
{

    //Clase candidato
    class Candidato
    {
        public Candidato(string nombre1, string apellido1, string partido_politico1)
        {
            nombre = nombre1;
            apellido = apellido1;
            partido_politico = partido_politico1;
        }

        public string nombre;
        public string apellido;
        public string partido_politico;
    }

    class Program
    {
        //Funcion para preguntar y guardar candidato
        public static Candidato GuardarCandidato()
        {
            Console.WriteLine("Ingrese el nombre  del candidato: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del candidato: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el partido politico del candidato: ");
            string partidoPolitico = Console.ReadLine();

            Candidato candidato = new Candidato(nombre, apellido, partidoPolitico);

            return candidato;
        }

        public static void MostrarCandidatos(Candidato[] candidatos)
        {
            Console.WriteLine("========Lista de candidatos========");
            for (int i = 0; i < candidatos.Length; i++)
            {
                Console.WriteLine("Candidato #" + i +
                                   "\nNombre: " + candidatos[i].nombre +
                                   " Apellido: " + candidatos[i].apellido +
                                   " Partido politico: " + candidatos[i].partido_politico);
            }
        }

        static void Main(string[] args)
        {
            //Parte 1 - Guardar candidatos
            Candidato[] candidatos = new Candidato[3];
            for (int i = 0; i < 3; i++)
            {
                candidatos[i] = GuardarCandidato();
            }

            MostrarCandidatos(candidatos);

            //Parte 2 - Ingresar votos

            //Parte 3 - Guardarlos en una cola

            //Parte 4 - Contar votos y guardar ganador

            //Parte 5 - Mostrar resultados con cantidad de votos y porcentaje, solo puede acceder "Jefe de Mesa"

            //Parte 6 - Menu


        }
    }

    
}
