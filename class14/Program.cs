namespace class14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task myFirstTast = new Task(()=>
            {
                Console.WriteLine("The task started.");
                Thread.Sleep(2000);

                Console.WriteLine("2 seconds passed");
            });
            Task<string> calculationTast = new Task<string>(() =>
            {
                Console.WriteLine("The task started.");
                Thread.Sleep(000);

                Console.WriteLine("5 seconds passed");
                return "Result was 100";
            });

            Console.WriteLine("First line code executed.");

            myFirstTast.Start();
            calculationTast.Start();

            Console.WriteLine("Second line code executed.");
            Console.WriteLine(calculationTast.Result);
        }
        static void SynchronousCodeExecutio()
        {
            Console.WriteLine("Non: sinc :The task started.");
            Thread.Sleep(5000);

            Console.WriteLine("Non sinc : 5 seconds passed");
        }
    }
}
