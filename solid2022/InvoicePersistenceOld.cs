using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace solid2022
{
    /* This class was refactored to an interface to be under the open_colsed princble.
     * to give us the chance to extension and modification
     * extension :- mean that we can add any new fucntionality to out class without edit any thing in hte code
     * and avoid modifing any thing in our code
     */
    //internal class InvoicePersistence
    //{
    //    public Invoice Invoice { get; set; }

    //    public InvoicePersistence(Invoice invoice)
    //    {
    //        this.Invoice = invoice; 
    //    }


    //    public void SaveToFile()
    //    {
    //        string filename = "book";
    //        string BookJsonString = JsonSerializer.Serialize(this);
    //        File.WriteAllText(filename, BookJsonString);
    //    }
    //}
}
