using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamicCV.Models
{
    public class ListaWorkDataViewModel
    {

        public List<WorkData> WorkDatas { get; set; }
        public Pagination Paginacao { get; set; }

        public string NomePesquisar { get; set; }

    }
}
