using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblemAssignment
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (!string.IsNullOrEmpty(message))
            {
                if (message.Contains("Sad") || message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            else
            {
                throw new MoodAnalyserException("Getting null or empty value");
            }
        }
    }
}
