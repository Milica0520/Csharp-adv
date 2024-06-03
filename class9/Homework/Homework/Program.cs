using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Homework
{
    public class Program
    {
        static void Main(string[] args)
        {

            string currDirectory = Directory.GetCurrentDirectory();

            string folderPath = currDirectory + "\\Files";
            string filePath = folderPath + "\\names.txt";
            //task1.create folder
            if (Directory.Exists(folderPath) == false)
            {
                Directory.CreateDirectory(folderPath);
            }
            //task1. create file
            if (File.Exists(filePath) == false)
            {
                File.Create(filePath).Close();

            };
            //task2. ask user to input names
            bool keepEntering = true;
            do
            {
                Console.WriteLine("Enter name (To stop entering press N. ):");
                string nameInp = Console.ReadLine();

                if (nameInp.ToLower() == "n")
                {
                    keepEntering = false;
                    continue;
                }
                StreamWriter nameToWrite = new StreamWriter(filePath, true);
                using (nameToWrite)
                {
                    nameToWrite.WriteLine(nameInp);
                }


            } while (keepEntering == true);

            //task3. read the file
            StreamReader fileToRead = new StreamReader(filePath);

            using (fileToRead)
            {
                string restOfTheContent = fileToRead.ReadToEnd();
               Console.WriteLine(restOfTheContent);
            }
            //task3. filter names from file start with A
            string[] alphabet = new string[]
                 {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
            "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
                 };

            string fileForNameWith;
            foreach (string line in File.ReadLines(filePath))
            {
                if (line == null)
                {
                    Console.WriteLine("The file is empty.");
                    continue;
                }

                foreach (string letter in alphabet)
                {
                    if (line.StartsWith(letter))
                    {
                        fileForNameWith = folderPath + $"\\namesStartingWith_{letter}.txt";
                        if (!File.Exists(fileForNameWith))
                        {
                            File.Create(fileForNameWith).Close();
                            StreamWriter streamWriter = new StreamWriter(fileForNameWith, true);
                            using (streamWriter)
                            {
                                streamWriter.WriteLine(line);
                            }
                        }
                    }
                }
            }
        }
    }
}
