using System;
using System.IO; 


namespace Dog_Document
{
    class MainClass
    {
        private static object e;

        public static bool Content { get; private set; }

        private static void Main(string[] args)
        {
            
            Console.WriteLine("Document\n");
            Console.Write("Enter the name of the document: ");
            string name = Console.ReadLine();
            Console.Write("Enter the content of the document: ");

            try
            {
                StreamWriter streamWriter = new StreamWriter(name + ".txt");
                streamWriter.WriteLine(Content);
                streamWriter.Close();
              Console.WriteLine("{0} was successfully saved.", name, Content.Length);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
