using DinamicCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamicCV.Data
{/// <summary>
/// Insere dados para teste na fase de desenvolvimento
/// </summary>
    public class SeedData
    {
        /// <summary>
        /// Insere dados para teste na fase de desenvolvimento na tabela workdata, contexto ApplicationDbContext
        /// </summary>
        /// <param name="dbContext">Contexto da Tabela para insercao de dados</param>
        internal static void InsereDadosFicaoCientifica(ApplicationDbContext db)
        {
            if (db.WorkData.Any()) return;


            db.WorkData.AddRange(new WorkData[] {
                new WorkData
                {
                    Employer = "Delita",
                    InitialDate = new DateTime(2020, 7, 1),
                    FinalDate = new DateTime(2020, 8, 31),
                    JobTitle = "Java Developer",
                    JobDescription = "Java development for android devices"
                },
                new WorkData
                {
                    Employer = "ModeloContinente",
                    InitialDate = new DateTime(2018, 9, 1),
                    FinalDate = new DateTime(2019, 8, 31),
                    JobTitle = "Retail Store Sales and Attendant",
                    JobDescription = "Prepare and examine financial records"
                },
                new WorkData
                {
                    Employer = "Pautaconta",
                    InitialDate = new DateTime(2016, 4, 1),
                    FinalDate = new DateTime(2017, 6, 30),
                    JobTitle = "Portuguese Certified Accoutant",
                    JobDescription = "Prepare and examine financial records"
                },

            });

            db.SaveChanges();

        }
    }
}