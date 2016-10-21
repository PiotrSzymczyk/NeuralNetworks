using System.Collections.Generic;

namespace NeuralNetworks
{
    public class DataSetRecord
    {
        public List<double> Inputs { get; set; }

        public int ExpectedOutput { get; set; }

        public int? ActualOutput { get; set; }
    }
}
