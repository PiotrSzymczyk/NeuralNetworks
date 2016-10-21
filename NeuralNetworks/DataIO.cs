using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetworks
{
    public class DataIO
    {
        public static List<DataSetRecord> LoadRecords(string fileName)
        {
            try
            {
                var data = File.ReadAllText(fileName);
                return ParseData(data);
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        private static List<DataSetRecord> ParseData(string data)
        {
            var result = new List<DataSetRecord>();
            foreach (var line in data.Split('\n'))
            {
                var values = line.Split('\t');
                result.Add(new DataSetRecord
                {
                    Inputs = values.Take(values.Length -1).Select(input => double.Parse(input)).ToList(),
                    ExpectedOutput = int.Parse(values.Last())
                });
            }

            return result;
        }
    }
}

