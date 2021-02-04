using DinamicCV.Models;
using Microsoft.AspNetCore.Identity;
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
        /// 


        private const string NOME_UTILIZADOR_ADMIN_PADRAO = "antoniocaldeira@yahoo,com";
        private const string PASSWORD_UTILIZADOR_ADMIN_PADRAO = "Secret123$";

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
                    FinalDate = new DateTime(2019, 5, 2),
                    JobTitle = "Store Sales Assistant",
                    JobDescription = "Store Sales Assistant"
                },                
                new WorkData
                {
                    Employer = "Pautaconta",
                    InitialDate = new DateTime(2016, 4, 1),
                    FinalDate = new DateTime(2017, 6, 30),
                    JobTitle = "Portuguese Certified Accountant",
                    JobDescription = "Prepare and examine financial records and statements"
                },

            });

            db.SaveChanges();

        }
        internal static async Task InsereAdministradorPadraoAsync(UserManager<IdentityUser> gestorUtilizadores)
        {
            IdentityUser utilizador = await gestorUtilizadores.FindByNameAsync(NOME_UTILIZADOR_ADMIN_PADRAO);

            if (utilizador == null)
            {
                utilizador = new IdentityUser(NOME_UTILIZADOR_ADMIN_PADRAO);
                await gestorUtilizadores.CreateAsync(utilizador, PASSWORD_UTILIZADOR_ADMIN_PADRAO);
            }
        }
    }
}