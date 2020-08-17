using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoQuizApp.Data
{
    public class GeoQuizItem
    {
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public int AnswerIndex { get; set; }
        public int Score { get; set; }

        public GeoQuizItem()
        {
            Choices = new List<string>();
        }
    }
}
