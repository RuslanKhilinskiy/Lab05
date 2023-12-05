
using System;                // Console
using System.IO;             // FileStream, FileReader

class FileDetails 
{
    static void Main(string[] args)
	{
        char[] contents = null;
        try
        {
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            contents = new char[size];

            //Console.WriteLine(args.Length);
            //foreach (string arg in args)
            //{
            //    Console.WriteLine(arg);
            //}

            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            reader.Close();

            //foreach (char ch in contents)
            //{
            //    Console.Write(ch);
            //}
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            contents = new char[0];
        }
        Summarize(contents);
    }
    static void Summarize(char[] contents)
    {
        int vowels = 0, consonants = 0, lines = 0;
        foreach (char current in contents)
        {
            if (Char.IsLetter(current)) 
            {
                if ("AEIOUaeiou".IndexOf(current) != -1)
                {
                    vowels++;
                } else
                {
                    consonants++;
                }

            } else if (current == '\n')
            {
                lines++;
            }
        }
        Console.WriteLine("Total no of characters: {0}", contents.Length);
        Console.WriteLine("Total no of vowels : {0}", vowels);
        Console.WriteLine("Total no of consonants: {0}", consonants);
        Console.WriteLine("Total no of lines : {0}", lines);
    }
}
