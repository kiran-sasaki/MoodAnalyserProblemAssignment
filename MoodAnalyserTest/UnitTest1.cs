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
        //3.2
        [TestMethod]
        public void given_Empty_Mood_Should_Throw_MoodAnalyserCustomException_Indocating_Empty_Mood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Console.WriteLine("Mood should not be Empty", e.Message);
            }
        }
        ////UC4.1
        //[TestMethod]
        //public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
        //{
        //    object expected = new MoodAnalyser();
        //    object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyserProblemAssignment.MoodAnalyser", "MoodAnalyser");
        //    expected.Equals(obj);
        //}
        ////UC4.2
        //[TestMethod]
        //public void Given_MoodAnalyser_ClassName_ImproperShould_Throw_MoodAnalyserException()
        //{
        //    try
        //    {
        //        object expected = new MoodAnalyser();
        //        object obj = MoodAnalayserFactory.CreateMoodAnalyse("erMoodAnalyserProblemAssignment.MoodAnalys", "MoodAnalyser");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        ////UC4.3
        //[TestMethod]
        //public void Given_MoodAnalyser_Constructor_Name_Improper_Should_Throw_MoodAnalyserException()
        //{
        //    try
        //    {
        //        object expected = new MoodAnalyser();
        //        object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzer.MoodAr", "Mood");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        //UC5.1
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parameeterized_ConstrctrutorImproper()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyserProblemAssignment.MoodAnalyser", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC5.2
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyserProblemAssignment.MoodAnalyr", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC5.3
        [TestMethod]
        public void Given_MoodAnalyser_Method_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblemAssignment.MoodAnalyzer", "MoodAnal", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC6.1
        //[TestMethod]
        //public void GivenHappyShouldReturnHappy()
        //{
        //    string expected = "Happy";
        //    string mood = MoodAnalayserFactory.InvokedAnalyseMood("Happy", "AnalyseMood");
        //    Assert.AreEqual(expected, mood);
        //}
        //UC6.2
        [TestMethod]
        public void GivenHappyMessage_WhenImproperMethod_ShouldThrowMoodAnalysisException()
        {
            string expected = "Method is not found";
            string mood = MoodAnalayserFactory.InvokedAnalyseMood("Happy", "Analyse");
            Assert.AreEqual(expected, mood);
        }
    }
}