using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Properties_Ortiz_Victor
{
    internal class Car
    {
        // A field that protects the Model property
        private string model;
        // A property that sets and returns a new value that is set when called and changed
        public string Model { get { return model; } set { model = value; } }
        // A automatic property that sets the return and set values automatically 
        public string Make { get; set; }
    }
}
