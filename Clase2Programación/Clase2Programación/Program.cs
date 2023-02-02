using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Programación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("LLuvia");
            Humano miHumano = new Humano("Mayerli");
            Gorila miGorila = new Gorila("Rochi");
            Ballena miBallena = new Ballena("Vally");
            Cocodrilo miCocodrilo = new Cocodrilo("Modelon");

            Mamiferos[] almacenAnimales = new Mamiferos[4];
            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = miHumano;
            almacenAnimales[2] = miGorila;
            almacenAnimales[3] = miBallena;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }
            Mamiferos miMamifero = new Mamiferos("");
            miMamifero.pensar();

            miCaballo.cuidarCrias();
            miHumano.getNombre();
            miGorila.trepar();
        }



    }
    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public abstract void getNombre();
    }

    interface IMamiferosTerrestres
    {
        int numeroPiernas();
    }
     class Reptil : Animales
     {
        public Reptil(String nombre)
        {
            String nombreSerVivo = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es:" + nombreSerVivo);

        }
        private string nombreSerVivo;


     }
    class Mamiferos: Animales
    {
        public Mamiferos(String nombre)
        {
            String nombreSerVivo = nombre;

        }
       
        public void pensar()
        {
            Console.WriteLine("Pensamientos basicos e instintivos ");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuidar de las crias hasta que crezcan");
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es:" + nombreSerVivo);
        }
        private string nombreSerVivo;

    }
    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

    }
    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");

        }
        public int numeroPiernas()
        {
            return 4;
        }

    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public  void Razonar()
        {
            Console.WriteLine("Soy capaz de razonar");
        }
        
    }
    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int numeroPiernas()
        {
            return 2;
        }
    }
    class Cocodrilo : Reptil,IMamiferosTerrestres
    {
        public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
        {

        }
        public void morder()
        {
            Console.WriteLine("Soy capaz de morder");

        }
        public int numeroPiernas()
        {
            return 4;
        }
    }
}

