using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3 , 7);
        Scripture scripture = new Scripture( reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
    
    
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();// Leer la entrada del usuario
            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("All words are hidden. The program will now exit.");
                    break;
                }

            }

        }

    }


}