using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyCore.Models
{
    class Medicine
    {
        public int MedicineID { get; set; }
        public string NameMedicine { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public bool WIthPrescription { get; set; }

    }
}
