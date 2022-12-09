﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblemAssignment
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        {

        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (message.Contains("Sad") || message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "mood should not be null ");
                }
            }
        }
    }
}
