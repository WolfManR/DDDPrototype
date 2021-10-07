using DDDClient.Abstractions;
using DDDClient.DataModels;

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DDDClient
{
    internal class Program
    {
        private static void Main()
        {
            IReadOnlyList<Patient> patients = new List<Patient>()
            {
                new Dog(1, "Dog1"),
                new Kitten(3, "Kitten1")
            };

            Clinic clinic = new(1, "Clinic1");

            IReadOnlyList<ILabor> labors = new List<ILabor>()
            {
                new InspectionAnalysis(1) { Price = 10.34M, Description = "Rebum lorem gubergren nonummy elitr dolor"},
                new BloodAnalysis(2) { Price = 2.2M, Description = "Décor non divines loisirs beauté pontife long"}
            };

            var patient1 = patients[0];
            var patient2 = patients[^1];

            clinic.Patients.Add(patient1);
            clinic.Patients.Add(patient2);

            var inspectionAnalysis = GetCopy<InspectionAnalysis>(labors[0]);
            var bloodAnalysis = GetCopy<BloodAnalysis>(labors[1]);

            patient1.Analizes.Add(inspectionAnalysis);

            patient2.Analizes.Add(bloodAnalysis);
            patient2.Analizes.Add(GetCopy<InspectionAnalysis>(inspectionAnalysis));

            inspectionAnalysis.IsPaid = true;

            Console.WriteLine("State of Clinic1");
            foreach (var clinicPatient in clinic.Patients)
            {
                Console.WriteLine($"    Patient: {clinicPatient.Id} {clinicPatient.Name}");
                Console.WriteLine("     Labors:");
                foreach (ILabor labor in clinicPatient.Analizes)
                {
                    Console.WriteLine(
                        $@"         Id: {labor.Id}
         Description: {labor.Description}
         Is Paid: {labor.IsPaid}
         Expected Price: {labor.Price}
"
                        );
                }
            }
        }

        private static T GetCopy<T>(object original) => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(original));
    }
}
