using System.Collections.Generic;

namespace INHERITANCE

// Classes inherit properties of another class. 
{
    public class Smartphone : CellPhone
    {
        public List<string> Apps { get; set; }

        public void ConnectInterner()
        {

        }
    } // Smartphone inherit properties of Cellphone class, and Cellphone inherits properties of Phone Class.
}
