//Create a model with following properties DateOnly Date, int TemperatureC, int TemperatureF, string Summary
using System;
namespace API.Models
{
    public class Clima
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public required string Comments { get; set; }
    }
}