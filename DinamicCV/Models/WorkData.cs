using System;
using System.ComponentModel.DataAnnotations;

namespace DinamicCV.Models
{
    public class WorkData
    {
        public int WorkDataId { get; set; }
        //[Required(ErrorMessage = "O nome do Empregador é obrigatório")]
        [Display(Name = "Empregador")]
        public String Employer { get; set; }
        //[Required(ErrorMessage = "A data Inicial é para preencher")]
        //[DataType(DataType.Date)]

        [Display(Name = "Data Inicial")]
        public DateTime InitialDate { get; set; }
        //[Required(ErrorMessage = "A data Final também")]
        //[DataType(DataType.Date)]

        [Display(Name = "Data Final")]
        public DateTime FinalDate { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [Display(Name = "Profissão")]
        public String JobTitle { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [Display(Name = "Descrição da Profissão")]
        public String JobDescription { get; set; }
    }
}
