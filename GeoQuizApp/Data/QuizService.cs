using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoQuizApp.Data
{
    public class QuizService
    {
        private static readonly List<GeoQuizItem> Quiz;

        static QuizService()
        {
            Quiz = new List<GeoQuizItem> {
                new GeoQuizItem
                {
                    Question = "Test question where answer is answer 2",
                    Choices = new List<string> {"Answer 1", "Answer 2", "Answer 3" },
                    AnswerIndex = 1,
                    Score = 3
                },
                new GeoQuizItem
                {
                    Question = "Test question where answer is answer 1",
                    Choices = new List<string> {"Answer 1", "Answer 2", "Answer 3" },
                    AnswerIndex = 0,
                    Score = 5
                },
            };
        }

        public Task<List<GeoQuizItem>> GetQuizAsync()
        {
            return Task.FromResult(Quiz);
        }
    }
}
