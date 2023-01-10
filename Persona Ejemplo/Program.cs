using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedios
{
    class Persona
    {
        private int promedio;
        private int promedio2;
        private int promedio3;

        private int sedades, sedades2;
        private int sedades3, sedades4;
        private int sedades5, sedades6;
        private int f;


        public void pedir()
        {
            sedades = 0;
            sedades3 = 0;
            sedades5 = 0;

            for (f = 1; f <= 10; f++)
            {
                Console.WriteLine("=======TRABAJO DEL ALUMNO JEDIDIEL TOTO GARCIA============");
                Console.WriteLine("Por favor ingresa las edades de los alumnos de la mañana: ");
                sedades2 = int.Parse(Console.ReadLine());
                sedades = sedades + sedades2;
                Console.WriteLine("///////////////////////////////////////////////////////////");
            }
            for (f = 1; f <= 10; f++)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////");
                Console.WriteLine("Por favor ingresa las edades de los alumnos de la tarde: ");
                sedades4 = int.Parse(Console.ReadLine());
                sedades3 = sedades3 + sedades4;
                Console.WriteLine("///////////////////////////////////////////////////////////");
            }
            for (f = 1; f <= 10; f++)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////");
                Console.WriteLine("Por favor ingresa las edades de los alumnos de la noche: ");
                sedades6 = int.Parse(Console.ReadLine());
                sedades5 = sedades5 + sedades6;
                Console.WriteLine("///////////////////////////////////////////////////////////");
            }
        }

        public void promedios()
        {
            promedio = sedades / 3;
            promedio2 = sedades3 / 3;
            promedio3 = sedades5 / 3;

            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Promedio del turno MATUTINO");
            Console.WriteLine(promedio);

            Console.WriteLine("Promedio del turno VESPERTINO");
            Console.WriteLine(promedio2);

            Console.WriteLine("Promedio del turno NOCTURNO");
            Console.WriteLine(promedio3);
            Console.WriteLine("++++++++++++++++++++++++++++");
        }

        public void menor()
        {
            if (promedio < promedio2)
            {
                //sabemos quepromedio 1(matutino)<
                if (promedio < promedio3)
                {
                    Console.WriteLine("El turno matutino es el de menor edad");
                }
            }
            else if (promedio2 < promedio3)
            {

                Console.WriteLine("El turno vespertino es menor ");
            }
            else
            {
                Console.WriteLine("El turno Nocturno es menor");
            }

        }

        static void Main(string[] args)
        {
            Persona per1 = new Persona();

            per1.pedir();
            per1.promedios();
            per1.menor();

            Console.ReadKey();
        }
    }
}

