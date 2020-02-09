using System.Collections.Generic;

namespace WeatherApp
{
    public static class QuestionListFactory
    {
        public static Question CreateInitialQuestion()
        {
            return new Question(GetInitialOptions(), "Welcome to the Weather Service console app.Please select an option from the menu:");
        }

        private static IEnumerable<OptionDto> GetInitialOptions()
        {
            return new List<OptionDto>
            {
                new OptionDto
                {
                    Text = "1. Choose City",
                    Value = 1
                },
                 new OptionDto
                {
                    Text = "2. Exit",
                    Value = 2
                }
            };
        }

        public static Question CreateWeatherQuestion()
        {
            return new Question(GetCityOptions(), "We currently only support Cape Town's weather");
        }

        private static IEnumerable<OptionDto> GetCityOptions()
        {
            return new List<OptionDto>
            {
                new OptionDto
                {
                    Text = "1. Get Cape Town's current weather",
                    Value = 1
                },
                 new OptionDto
                {
                    Text = "2. Exit",
                    Value = 2
                }
            };
        }

        public static Question CreateFormatQuestion()
        {
            return new Question(GetFormatOptions(), "How would you like to view the data?");
        }

        private static IEnumerable<OptionDto> GetFormatOptions()
        {
            return new List<OptionDto>
            {
                new OptionDto
                {
                    Text = "1. Raw JSON",
                    Value = 1
                },
                new OptionDto
                {
                    Text = "2. Formatted",
                    Value = 2
                },
                 new OptionDto
                {
                    Text = "3. Nicely formatted and only displaying data interesting to the public",
                    Value = 3
                }
            };
        }
    }
}
