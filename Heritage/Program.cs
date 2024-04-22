using System.Net.Http.Headers;

namespace Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5];
            Bipedes humain = new Bipedes(" humain ");
            Bipedes singe = new Bipedes(" singe ");
            Quadrupedes elephan = new Quadrupedes(" élephant ");
            Quadrupedes tortue = new Quadrupedes(" tortue ");
            Quadrupedes lezard = new Quadrupedes(" lézard ");

            animals[0] = humain;
            animals[1] = singe;
            animals[2] = elephan;
            animals[3] = tortue;
            animals[4] = lezard;

            foreach (var anim in animals)
            {
                Console.WriteLine($"{anim.Eat()} {anim.Move()}");
            }

        }
    }
}
