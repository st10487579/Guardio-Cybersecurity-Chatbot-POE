using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardioChatbot.Models
{
    public class QuizQuestion
    {
        public string QuestionText { get; set; }

        public string[] Options { get; set; }

        public int CorrectAnswer { get; set; }

        public string Explanation { get; set; }
    }
}