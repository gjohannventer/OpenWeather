using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherApp
{
    public class Question
    {
        public IEnumerable<OptionDto> Options { get; }
        public string QuestionText { get; }

        public Question(IEnumerable<OptionDto> validValues, string questionText)
        {
            Options = validValues;
            QuestionText = questionText;
        }

        public int GetAnswer()
        {
            int intToReturn = 0;
            while (true)
            {
                var answer = Console.ReadLine();
                var isValidSelection = int.TryParse(answer, out intToReturn) && Options.Any(option => option.Value == intToReturn);
                if (isValidSelection)
                    break;

                Console.WriteLine($"Only {string.Join(',', Options.Select(option => option.Value))} Allowed!");
            }

            return intToReturn;
        }
    }
}
