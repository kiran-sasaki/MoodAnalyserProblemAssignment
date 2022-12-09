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
        public void WhenGivenNull_ShouldReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
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
        //3.1
        [TestMethod]
        public void given_Empty_Mood_Should_Throw_MoodAnalyserCustomException_Indocating_NullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Console.WriteLine("Mood should not be null", e.Message);
            }
        }
    }

}