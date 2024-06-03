namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your text here: ");
            string textInput = Console.ReadLine();

            string myFolderPath = Directory.GetCurrentDirectory() + "\\exerciseFolder";
            string myFilePath = myFolderPath + "\\userInputtext.txt";

            if (Directory.Exists(myFolderPath) == false)
            {
                Directory.CreateDirectory(myFolderPath);
            }
            ////
            if (File.Exists(myFilePath) == false)
            {
                File.Create(myFilePath).Close();
            }

            StreamWriter textToWrite = new StreamWriter(myFilePath, true);

            using (textToWrite)
            {
                textToWrite.WriteLine(textInput);
            }

            StreamReader textToRead = new StreamReader(myFilePath);

            using (textToRead)
            {
                //textToRead.ReadLine();
               string text = textToRead.ReadToEnd(); 
                Console.WriteLine(text);
            }


               


          

        }
    }
}
