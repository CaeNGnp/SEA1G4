using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class GiftCard {
        public double value { get; set; }
        public string cardId { get; set; }
        public double price { get; set; }

        public GiftCard(double v, string id, double p) {
            value = v;
            cardId = id;
            price = p;
        }
    }
}
