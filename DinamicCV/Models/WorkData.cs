using System;
using System.ComponentModel.DataAnnotations;

namespace DinamicCV.Models
{
    public class WorkData
    {
        public int WorkDataId { get; set; }
        //[Required(ErrorMessage = "O nome do Empregador é obrigatório")]
        public String Employer { get; set; }
        //[Required(ErrorMessage = "A data Inicial é para preencher")]
        //[DataType(DataType.Date)]


        public DateTime InitialDate { get; set; }
        //[Required(ErrorMessage = "A data Final também")]
        //[DataType(DataType.Date)]


        public DateTime FinalDate { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório")]

        public String JobTitle { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório")]

        public String JobDescription { get; set; }
    }
}
