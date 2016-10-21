using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks
{
    public class DataSetRecord
    {
        public List<double> Inputs { get; set; }

        public int ExpectedOutput { get; set; }

        public int? ActualOutput { get; set; }

        public string WriteFormat()
        {
            return Inputs.Aggregate(string.Empty, (current, input) => current + (input + "\t")) 
                + ExpectedOutput + "\t"
                + (ExpectedOutput == ActualOutput ? "1" : "0") + "\r\n";
        }
    }
}
