using class9.Utils;
using System.Security.Cryptography.X509Certificates;

namespace class9
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Reading and writing on file system//bekend aplikacije se obicno izvrsavaju na serveru

            string absolutPath = "C:\\Users\\micad\\OneDrive\\Desktop\\C#-advanced\\Csharp-adv\\class9\\class9";
            string currDirectory = Directory.GetCurrentDirectory();
            string newFolderPath = Directory.GetCurrentDirectory() + "\\NoviFolder";
            
            if(Directory.Exists(newFolderPath) == false)
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(newFolderPath);
            }


            string newFilePath = newFolderPath + "\\test.txt" ;
            if(File.Exists(newFilePath) == false)
            {
                FileStream newFile = File.Create(newFilePath);
                newFile.Close();//moras zatvoriti a ako mu pristupas samim tim ga i otvaras
            }
            /*
            if (File.Exists(newFilePath))
                {
                File.Delete(newFilePath);
            };
            */

            if (File.Exists(newFilePath))
            {
                string fileContent = File.ReadAllText(newFilePath);
                Console.WriteLine(fileContent);

                Console.WriteLine("Type additional content for this txt:");
                string inputContent = Console.ReadLine();   
                
                File.AppendAllText(newFilePath, "\n" + inputContent);  //isprobaj ovo bez predhodnih koraka
               // File.Copy(newFilePath, newFolderPath + "\\noviTextFileCopy.txt");
            }


            Console.WriteLine(currDirectory);

            //stream
            Console.WriteLine("Workig with streams....");
            string streamFilesFolder = Directory.GetCurrentDirectory() + "\\streams";

            string longTextFile = streamFilesFolder + "\\longText.txt";

            if(Directory.Exists (streamFilesFolder) == false)
            {
                Directory.CreateDirectory(streamFilesFolder);
                Console.WriteLine("The folder created");
            }
            if(File.Exists (longTextFile) == false)
            {
                File.Create(longTextFile).Close();
            }

            StreamWriter streamWriter = new StreamWriter(longTextFile);

            using (streamWriter)
            {
                streamWriter.WriteLine("1. Milica");
                streamWriter.WriteLine("2. Djordje");
                streamWriter.WriteLine("3. Goran");
                streamWriter.WriteLine("4. Sava");
                streamWriter.WriteLine("5. Almir");

            }
            StreamWriter streamWriterAppend = new StreamWriter(longTextFile, true);

            using (streamWriterAppend)
            {

                streamWriterAppend.WriteLine("6. Tamara");
                streamWriterAppend.WriteLine("7. Tamara");
            }

            Console.WriteLine("reading - Start");
            StreamReader streamReader = new StreamReader(longTextFile);

            using (streamReader)
            {
                string firstLine = streamReader.ReadLine();
                string secondLine = streamReader.ReadLine();
                string thirdLine = streamReader.ReadLine();
                string restOfTheContent = streamReader.ReadToEnd();
            }
            Console.WriteLine("reading - Start");


            //exercise

            string exercisePath = Directory.GetCurrentDirectory() + "\\Exercise";
            if (Directory.Exists(exercisePath) == false)
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(exercisePath);
            }

            string calculationPath = exercisePath + "\\calculation.txt";
            if (File.Exists(calculationPath) == false)
            {
                FileStream newFile = File.Create(calculationPath);
                newFile.Close();
            }


            Console.WriteLine("Eter two numbers you want tu calculate: ");
            Console.WriteLine("Enter first num.");
            int num1Inp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num.");
            int num2Inp = int.Parse(Console.ReadLine());

            
            Console.WriteLine(calculateSum(num1Inp, num2Inp));

            StreamWriter streamExercise = new StreamWriter(calculationPath);

            using (streamExercise)
            {
                streamExercise.WriteLine(calculateSum(num1Inp, num2Inp));
                streamExercise.WriteLine(calculateSum(num1Inp, num2Inp));
                streamExercise.WriteLine(calculateSum(num1Inp, num2Inp));
            }

            //uradi ovako sa append
            /*
            if (File.Exists(newFilePath))
            {
                string fileContent = File.ReadAllText(newFilePath);
                Console.WriteLine(fileContent);

                Console.WriteLine("Type additional content for this txt:");
                string inputContent = Console.ReadLine();

                File.AppendAllText(newFilePath, "\n" + inputContent);  //isprobaj ovo bez predhodnih koraka
                                                                       // File.Copy(newFilePath, newFolderPath + "\\noviTextFileCopy.txt");
            }
            */
            /////////////////class11
            string path = "newFile.txt";


            if (File.Exists(path) == false)
            {
                File.Create(path)
                    .Close();  

            }

            OurTextWriter ourTextWriter = new OurTextWriter(path);

            ourTextWriter.Write("We are learning C#.");





        }

        public static string calculateSum(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            return $"{DateTime.Today}:{num1} + {num2} = {sum} ";
        }

       




    }
}
