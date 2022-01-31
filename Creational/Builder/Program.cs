using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builderJoe = new Builder().SetExperience(3).SetSex("male").SetSpecialization("Potter");
            builderJoe.SetExperience(3).SetSex("male").SetSpecialization("Potter");

            Console.WriteLine($"Builder Joe: experience {builderJoe.Experience}, sex {builderJoe.Sex}, specialization {builderJoe.Specialization}.");
        }
    }
}
