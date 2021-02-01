using DinamicCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamicCV.Data
{
/// <summary>
/// Insere dados para teste na fase de desenvolvimento
/// </summary>
    public class SeedData
    {
        /// <summary>
        /// Insere dados para teste na fase de desenvolvimento na tabela workdata
        /// </summary>
        /// <param name="db">Argumento do Contexto da Tabela para insercao de dados</param>
        internal static void InsereDadosFicaoCientifica(ApplicationDbContext db)
        {
            if (db.WorkData.Any()) return;


            db.WorkData.AddRange(new WorkData[] {
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

            db.SaveChanges();

        }
    }
}