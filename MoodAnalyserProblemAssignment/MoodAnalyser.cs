﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblemAssignment
{
    public class MoodAnalyser
    {
        public static string AnalyseMood(string message)
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
    }
}
