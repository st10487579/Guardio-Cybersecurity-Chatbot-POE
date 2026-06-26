using System;
using System.Collections.Generic;
using GuardioChatbot.Models;

namespace GuardioChatbot.Services
{
    public class QuizManager
    {
        public List<QuizQuestion> Questions { get; set; }

        public int CurrentQuestionIndex { get; set; }

        public int Score { get; set; }

        public QuizManager()
        {
            Questions = new List<QuizQuestion>();
            CurrentQuestionIndex = 0;
            Score = 0;

            LoadQuestions();
        }

        private void LoadQuestions()
        {
            Questions.Add(new QuizQuestion
            {
                QuestionText = "What is phishing?",
                Options = new string[]
                {
                    "A type of fishing",
                    "A cyber scam",
                    "Antivirus software",
                    "A password manager"
                },
                CorrectAnswer = 1,
                Explanation = "Phishing is a scam used to steal personal information."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "Strong passwords should contain:",
                Options = new string[]
                {
                    "Only letters",
                    "Only numbers",
                    "Letters, numbers and symbols",
                    "Your birthday"
                },
                CorrectAnswer = 2,
                Explanation = "Strong passwords are harder to crack."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "True or False: Using the same password everywhere is safe.",
                Options = new string[]
                {
                    "True",
                    "False"
                },
                CorrectAnswer = 1,
                Explanation = "Always use different passwords for different accounts."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "What does VPN stand for?",
                Options = new string[]
                {
                    "Virtual Private Network",
                    "Verified Personal Network",
                    "Virtual Public Network",
                    "Very Private Node"
                },
                CorrectAnswer = 0,
                Explanation = "VPN stands for Virtual Private Network."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "Which is an example of malware?",
                Options = new string[]
                {
                    "Virus",
                    "Firewall",
                    "VPN",
                    "Router"
                },
                CorrectAnswer = 0,
                Explanation = "Viruses are a type of malware."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "What should you do before clicking a suspicious link?",
                Options = new string[]
                {
                    "Click it anyway",
                    "Ignore it",
                    "Verify the sender",
                    "Reply with your password"
                },
                CorrectAnswer = 2,
                Explanation = "Always verify suspicious links first."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "True or False: Antivirus software should be updated regularly.",
                Options = new string[]
                {
                    "True",
                    "False"
                },
                CorrectAnswer = 0,
                Explanation = "Updates protect against new threats."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "What is Two-Factor Authentication (2FA)?",
                Options = new string[]
                {
                    "Two passwords",
                    "Extra security verification",
                    "Firewall",
                    "Virus scanner"
                },
                CorrectAnswer = 1,
                Explanation = "2FA adds another layer of security."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "Public Wi-Fi should be used carefully because:",
                Options = new string[]
                {
                    "It is always secure",
                    "Hackers may intercept data",
                    "It is faster",
                    "It blocks malware"
                },
                CorrectAnswer = 1,
                Explanation = "Public Wi-Fi can expose your personal data."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "What is ransomware?",
                Options = new string[]
                {
                    "Software that locks your files",
                    "Password manager",
                    "Firewall",
                    "VPN"
                },
                CorrectAnswer = 0,
                Explanation = "Ransomware encrypts files and demands payment."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "True or False: Backing up your files protects against ransomware.",
                Options = new string[]
                {
                    "True",
                    "False"
                },
                CorrectAnswer = 0,
                Explanation = "Backups help recover files without paying criminals."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "What is social engineering?",
                Options = new string[]
                {
                    "Building websites",
                    "Tricking people into giving information",
                    "Programming",
                    "Installing software"
                },
                CorrectAnswer = 1,
                Explanation = "Social engineering targets people instead of computers."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "Software updates are important because:",
                Options = new string[]
                {
                    "They waste storage",
                    "They fix security vulnerabilities",
                    "They delete viruses",
                    "They slow the computer"
                },
                CorrectAnswer = 1,
                Explanation = "Updates patch security weaknesses."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "Identity theft happens when someone:",
                Options = new string[]
                {
                    "Steals your personal information",
                    "Deletes your files",
                    "Installs Windows",
                    "Creates a backup"
                },
                CorrectAnswer = 0,
                Explanation = "Identity theft involves using someone else's personal information."
            });

            Questions.Add(new QuizQuestion
            {
                QuestionText = "Which email is most likely a phishing email?",
                Options = new string[]
                {
                    "An email asking you to verify your password immediately",
                    "A school newsletter",
                    "A message from your lecturer",
                    "A calendar reminder"
                },
                CorrectAnswer = 0,
                Explanation = "Urgent password requests are a common phishing tactic."
            });
        }

        public QuizQuestion GetCurrentQuestion()
        {
            if (CurrentQuestionIndex >= Questions.Count)
                return null;

            return Questions[CurrentQuestionIndex];
        }

        public bool CheckAnswer(int selectedAnswer)
        {
            bool correct = selectedAnswer ==
                           Questions[CurrentQuestionIndex].CorrectAnswer;

            if (correct)
                Score++;

            CurrentQuestionIndex++;

            return correct;
        }

        public bool IsFinished()
        {
            return CurrentQuestionIndex >= Questions.Count;
        }

        public string GetFinalMessage()
        {
            double percentage = (double)Score / Questions.Count * 100;

            if (percentage >= 90)
                return "🏆 Excellent! You're a Cybersecurity Pro!";

            if (percentage >= 70)
                return "👏 Great Job! Your cybersecurity knowledge is strong.";

            if (percentage >= 50)
                return "🙂 Good effort! Keep learning cybersecurity.";

            return "📚 Keep practicing. Cybersecurity awareness keeps you safe.";
        }

        public void RestartQuiz()
        {
            CurrentQuestionIndex = 0;
            Score = 0;
        }
    }
}