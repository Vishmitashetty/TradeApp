using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCST
{
    public class CounterParty
    {
        //public CounterParty()
        //{
        //    Trades = new List<Trade>();
        //}
        public int CounterPartyId { get; set; }
        [Required, StringLength(20)]
        public string CounterPartyName { get; set; }
        public List<Trade> Trades { get; set; }
    }

    public class Security
    {
        public Security()
        {
            Trades = new List<Trade>();
        }
        public int SecurityId { get; set; }
        [StringLength(9)]
        public string CUSIP { get; set; }
        [StringLength(7)]
        public string SEDOL { get; set; }
        [StringLength(12)]
        public string ISIN { get; set; }
        [StringLength(50)]
        public string SecName { get; set; }

        public List<Trade> Trades { get; set; }
    }
    public class Trade
    {
        public int TradeId { get; set; }
        public int CounterPartyId { get; set; }
        public int SecurityId { get; set; }
        [ Required]
        public char TransactionType { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal NetAmount { get; set; }

        [Required]
        public System.DateTime TradeDate { get; set; }
        public System.DateTime? Maturity { get; set; }

        public CounterParty CounterParty { get; set; }
        public Security Security { get; set; }
    }
}
