using System;

namespace gradescores.Contracts
{
    public class DataEntry
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Grade { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            DataEntry entry = (DataEntry)obj;

            return entry.FirstName.Equals(FirstName) &&
                entry.LastName.Equals(LastName) &&
                entry.Grade.Equals(Grade);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
