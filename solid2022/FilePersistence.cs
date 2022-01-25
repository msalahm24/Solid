using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace solid2022
{
    internal class FilePersistence : InvoicePersistence
    {
        public void Save(Invoice invoice)
        {
            string filename = "book";
            string BookJsonString = JsonSerializer.Serialize(invoice);
            File.WriteAllText(filename, BookJsonString);
        }
    }
}
