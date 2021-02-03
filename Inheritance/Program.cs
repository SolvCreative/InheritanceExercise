using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var robin = new Bird(2, 2, false, true, true, 12, "gray-brown", "sticks");
            var ostrich = new Bird(62, 2, false, true, false, 77, "brown", "dirt") ;

            var snake = new Reptile(9, 0, false, false, false, true, "varies", true);
            var turtle = new Reptile(40, 4, false, true, true, true, "green and brown", true);


            Console.WriteLine($"The other day I saw a {robin.AvgLifeSpan} year old robin. It is {robin.Flies} she could fly \n" +
                $"and she did so magnificently with a {robin.InchesWingSpan} inches wingspan. She was {robin.FeatherColor} and \n" +
                $"blended in with her nest of {robin.NestMadeOf}. She eats mostly berries and worms, so it's {robin.IsOmnivore} \n" +
                $"she is an omnivore.");

            Console.WriteLine($"Down by the stream, there was a {turtle.ColorScales} turtle. He looked to be about {turtle.AvgLifeSpan} \n" +
                $"years old and it's {turtle.HasShell} his shell was thick from years of growth. He was large and slow on those {turtle.Legs} \n" +
                $"short legs.");
        }
    }
}
