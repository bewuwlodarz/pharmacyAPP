using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyCore.Models
{
    abstract class ActiveRecord
    {
        public int ID { get; protected set; }

        public abstract void Save();
        public abstract void Reload();
        public abstract void Open();
        public abstract void Close();
        public abstract void Remove();

    }
}
