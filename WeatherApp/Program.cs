using System;
using System.Linq;
using WeatherApp.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Common;

namespace WeatherApp
{
    public class Program
    {
        private static readonly int exitValue = 2;
        
        static void Main(string[] args)
        {
            var serviceProvider = Setup.InitDiContainers();
            while (true)
            {
                var initialQuestion = QuestionListFactory.CreateInitialQuestion();
                var initialAnswer = GetAnswer(initialQuestion);
                if (initialAnswer == exitValue)
                    break;

                var weatherQuestion = QuestionListFactory.CreateWeatherQuestion();
                var cityAnswer = GetAnswer(weatherQuestion);
                if (cityAnswer == exitValue)
                    break;
                
                var formatAnswer = GetAnswer(QuestionListFactory.CreateFormatQuestion());
                var formatFactory = serviceProvider.GetService<IFormatFactory>();
                var format = SetFormat(formatAnswer, formatFactory);

                var weatherQueryService = serviceProvider.GetService<IWeatherQueryService>();
                var result = weatherQueryService.Execute(Constant.City.CapeTown, format); // Since Cape Town is the only option needed now
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }


        private static int GetAnswer(Question question)
        {
            DisplayText(question);
            return question.GetAnswer();
        }

        private static void DisplayText(Question question)
        {
            Console.WriteLine(question.QuestionText);
            question.Options.ToList().ForEach(option => Console.WriteLine(option.Text));
        }

        private static IFormat SetFormat(int answer, IFormatFactory formatFactory)
        { 
            switch (answer)
            {
                case 1:
                    return formatFactory.CreateRawJsonFormat();
                case 2:
                    return formatFactory.CreateFormattedJsonFormat();
                case 3:
                    return formatFactory.CreatePublicFormat();
                default:
                    return formatFactory.CreateRawJsonFormat();
            }
        }
    }
}
