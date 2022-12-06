using MoodAnalyserProblemAssignment;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC1.1
        [TestMethod]
        public void WhenGivenSadMessage_shouldReturnSad()
        {
            try
            {
                string message = MoodAnalyser.AnalyseMood("i am sad");
                Assert.AreEqual("Sad", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}