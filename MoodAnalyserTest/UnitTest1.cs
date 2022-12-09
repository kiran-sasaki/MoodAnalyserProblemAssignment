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
            MoodAnalyser mood = new MoodAnalyser("i am sad");
            try
            {
                string message = mood.AnalyseMood();
                Assert.AreEqual("Sad", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC1.2
        [TestMethod]
        public void WhenGivenHappyMessage_shouldReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("i am in any Mood");
            try
            {
                string message = mood.AnalyseMood();
                Assert.AreEqual("Happy", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC2.1
        [TestMethod]
        public void WhenGivenHappyMessage_shouldReturnEmpty()
        {
            MoodAnalyser mood = new MoodAnalyser("");
            try
            {
                string message = mood.AnalyseMood();
                Assert.AreEqual("Happy", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}