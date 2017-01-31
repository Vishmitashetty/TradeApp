using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeData
{
    public class Classes
    {
        public class Security
        {
            public Security()
            {
                Trades = new List<Trade>();
            }
            public int SecurityId { get; set; }

            [Required]
            public string Ticker { get; set; }
            [StringLength(9)]
            public string CUSIP { get; set; }

            [StringLength(12)]
            public string ISIN { get; set; }
            [StringLength(7)]
            public string SEDOL { get; set; }

            public List<Trade> Trades { get; set; }
        }
        public class Trade
        {
            public int TradeId { get; set; }
            public int SecurityId { get; set; }
            [Required]
            public string TransactionType { get; set; }
            [Required]
            [Range(0, int.MaxValue)]
            public int Quantity { get; set; }
            [Required]
            [Range(0.0, Double.MaxValue)]
            public decimal Price { get; set; }

            [Required]
            public System.DateTime TradeDate { get; set; }

            public Security Security { get; set; }
        }



        public class Position
        {
            public int PositionId { get; set; }
            [Required]
            public string Ticker { get; set; }
            [StringLength(9)]
            public string CUSIP { get; set; }

            [StringLength(12)]
            public string ISIN { get; set; }
            [StringLength(7)]
            public string SEDOL { get; set; }

            public int position { get; set; }


        }
    }
}
