using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    public class Valyuta
    {
        public string Title { get; set; }

        public string Code { get; set; }

        [JsonProperty("cb_price")]
        public double? CbPrice { get; set; }

        [JsonProperty("nbu_buy_price")]
        public double? NbuBuyPrice { get; set; }

        [JsonProperty("nbu_cell_price")]
        public double? NbuCellPrice { get; set; }

        public string Date { get; set; }
    }
}
