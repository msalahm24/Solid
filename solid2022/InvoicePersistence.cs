using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2022
{
    internal interface InvoicePersistence
    {
        public void Save(Invoice invoice);
    }
}
