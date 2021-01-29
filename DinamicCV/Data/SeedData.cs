using DinamicCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamicCV.Data
{
    public class SeedData
    {

        internal static void InsereDadosFicaoCientifica(ApplicationDbContext dbContext)
        {
            if (dbContext.WorkData.Any()) return;


            dbContext.WorkData.AddRange(new WorkData[] {
                new WorkData
                {
                    Employer = "Delita",
                    InitialDate = new DateTime(2006, 5, 2),
                    FinalDate = new DateTime(2006, 5, 2),
                    JobTitle = "Java Developer",
                    JobDescription = "Java development for android devices"
                },                
                new WorkData
                {
                    Employer = "Delita",
                    InitialDate = new DateTime(2006, 5, 2),
                    FinalDate = new DateTime(2006, 5, 2),
                    JobTitle = "Java Developer",
                    JobDescription = "Java development for android devices"
                },                
                new WorkData
                {
                    Employer = "Delita",
                    InitialDate = new DateTime(2006, 5, 2),
                    FinalDate = new DateTime(2006, 5, 2),
                    JobTitle = "Java Developer",
                    JobDescription = "Java development for android devices"
                },

            });

            dbContext.SaveChanges();

        }
    }
}