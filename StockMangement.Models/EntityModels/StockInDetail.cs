using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMangement.Models.EntityModels
{
    public class StockInDetail
    {
        public int Id { get; set; }

        public int StockInId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }

        public StockIn StockIn { get; set; }

        public Product Product { get; set; }
    }
}
