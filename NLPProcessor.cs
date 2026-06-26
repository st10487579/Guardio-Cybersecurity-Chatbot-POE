using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardioChatbot.Services
{
    public class NLPProcessor
    {
        public string DetectIntent(string input)
        {
            input = input.ToLower();

            if (input.Contains("task") ||
                input.Contains("add task") ||
                input.Contains("create task"))
            {
                ActivityLogger.Log("NLP detected task creation");

                return "ADD_TASK";
            }

            if (input.Contains("remind") ||
                input.Contains("reminder"))
            {
                ActivityLogger.Log("NLP detected reminder");

                return "SET_REMINDER";
            }

            if (input.Contains("quiz") ||
                input.Contains("game"))
            {
                ActivityLogger.Log("NLP detected quiz");

                return "START_QUIZ";
            }

            if (input.Contains("activity") ||
                input.Contains("what have you done"))
            {
                ActivityLogger.Log("NLP detected activity request");

                return "SHOW_LOG";
            }

            if (input.Contains("password"))
            {
                return "PASSWORD_HELP";
            }

            if (input.Contains("phishing"))
            {
                return "PHISHING_HELP";
            }

            return "UNKNOWN";
        }
    }
}
