using System;

namespace ExercicioFVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qrooms = 10; 

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Rooms[] vect = new Rooms[qrooms];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + (i + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Email: ");
                string email = Console.ReadLine();
                
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room - 1] = new Rooms(name, email, room);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            
            for(int i = 0; i < qrooms; i++)
            {
                if(vect[i] != null)
                {
                    Console.Write((i + 1) + ": ");
                    Console.Write(vect[i].Nome + ", ");
                    Console.WriteLine(vect[i].Email);
                }
            }
        }
    }
}
