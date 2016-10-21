using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks
{
    public class Neuron
    {
        public double Threshold { get; private set; }
        public double BiasWeight { get; private set; }
        public List<double> InputWeights { get; }
        public int InputCount => InputWeights.Count;
        public NeuronType NeuronType { get; set; }
        public double MaxError { get; set; }
        public double MeanTotalError => totalNeuronError/numOfRecords;
        public string Log { get; set; }

        private double totalNeuronError;
        private int numOfRecords;

        public Neuron(int numberOfInputs)
        {
            var rand = new Random();
            BiasWeight = rand.NextDouble();
            Threshold = rand.NextDouble();
            InputWeights = new List<double>();
            for (var i = 0; i < numberOfInputs; i++)
            {
                InputWeights.Add(rand.NextDouble());
            }
            this.NeuronType = NeuronType.Perceptron;

        }
        
        public Neuron(double threshold, double biasWeight, List<double> inputWeights)
        {
            this.BiasWeight = biasWeight;
            this.InputWeights = inputWeights;
            this.Threshold = threshold;
            this.NeuronType = NeuronType.Perceptron;
        }

        public Neuron(double threshold, double biasWeight, params double[] inputWeights)
        {
            this.BiasWeight = biasWeight;
            this.InputWeights = inputWeights.ToList();
            this.Threshold = threshold;
            this.NeuronType = NeuronType.Perceptron;
        }

        public int GetOutput(List<double> inputs)
        {
            return SumInputs(inputs) > Threshold ? 1 : 0;
        }

        public int GetOutput(params double[] inputValues)
        {
            return GetOutput(inputValues.ToList());
        }

        public void Learn(List<DataSetRecord> learningSet, double gain = 0.2, int numOfEpoch = 10000)
        {
            // Log = "Input1\tInput2\tExpected\tCorrect\r\n";
            numOfRecords = learningSet.Count;
            if (numOfRecords == 0)
            {
                return;
            }

            do
            {
                totalNeuronError = 0;
                foreach (var record in learningSet)
                {
                    LearnFromRecord(record, gain);
                    UpdateThreshold(gain);
                }
                // LogEpoch(ref learningSet);
                MixRecords(ref learningSet);
            } while (!SolutionFound() & --numOfEpoch > 0);

            // DataIO.WriteResults("results.txt", Log);
        }

        private void LogEpoch(ref List<DataSetRecord> learningSet)
        {
            foreach (var record in learningSet)
            {
                Log += record.WriteFormat();
            }
            Log += "\r\n\r\n\r\n";
        }

        private void MixRecords(ref List<DataSetRecord> learningSet)
        {
            var rand = new Random();
            for (int i = 0; i < learningSet.Count/3; i++)
            {
                var index = rand.Next(learningSet.Count);
                var relocatedElement = learningSet[index];
                learningSet.RemoveAt(index);
                learningSet.Insert(rand.Next(learningSet.Count), relocatedElement);
            }
        }

        private void UpdateThreshold(double gain)
        {
            switch (NeuronType)
            {
                case NeuronType.Perceptron:
                    Threshold = Threshold + gain * MeanTotalError;
                    break;
                case NeuronType.Adaline:
                    Threshold = 0.25;
                    break;
            }
        }

        private void LearnFromRecord(DataSetRecord record, double gain)
        {
            var error = this.GetError(record.ExpectedOutput, record.Inputs);
            UpdateTotalNeuronError(error);
            UpdateWeights(record.Inputs, error, gain);
            record.ActualOutput = GetOutput(record.Inputs);
        }

        private double GetError(int recordOutput, List<double> recordInputs)
        {
            switch (NeuronType)
            {
                case NeuronType.Perceptron:
                    return recordOutput - GetOutput(recordInputs);
                case NeuronType.Adaline:
                    return recordOutput - SumInputs(recordInputs);
                default:
                    throw new Exception("Neuron type not found");
            }
        }

        private void UpdateTotalNeuronError(double error)
        {
            this.totalNeuronError += Math.Pow(error, 2);
        }

        private void UpdateWeights(List<double> inputs, double error, double gain)
        {
            for (var i = 0; i < InputWeights.Count; i++)
            {
                InputWeights[i] = InputWeights[i] + inputs[i] * gain * error;
            }
            BiasWeight = BiasWeight + gain * error;
        }


        private bool SolutionFound()
        {
            switch (NeuronType)
            {
                case NeuronType.Perceptron:
                    return totalNeuronError == 0;
                case NeuronType.Adaline:
                    return MeanTotalError < MaxError;
                default:
                    throw new Exception("Neuron type not found");
            }
        }

        private double SumInputs(List<double> inputValues)
        {
            return BiasWeight + Enumerable.Range(0, Math.Max(inputValues.Count, InputWeights.Count))
                       .Sum(i => inputValues.ElementAtOrDefault(i)*InputWeights.ElementAtOrDefault(i));
        }
    }
}