namespace MoodAnalyserProblemAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            MoodAnalyser mood = new MoodAnalyser();
            Console.WriteLine("Enter The Mood");
            string message = Console.ReadLine();
            MoodAnalyser.AnalyseMood(message);
        }
    }
}
