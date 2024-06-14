namespace HttpExamples
{
    public class Program
    {
        static void  Main(string[] args)
        {
            PostService postService = new PostService();

            Task getAllPsts = postService.GetPosts();

            Console.WriteLine("Before geting posts");
            getAllPsts.Wait();
            Console.WriteLine("After ");
        }
    }
}
