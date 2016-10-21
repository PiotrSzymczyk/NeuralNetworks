using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NeuralNetworks
{
    public partial class Form1 : Form
    {
        private static Neuron neuron;
        public Form1()
        {
            InitializeComponent();
        }

        private void eval_Click(object sender, EventArgs e)
        {
            var inputsVal = inputs.Text.Split(' ').Select(input => ReadDouble(input)).ToList();
            resultBox.Text = neuron.GetOutput(inputsVal).ToString();
        }

        private void learn_Click(object sender, EventArgs e)
        {
            var datasetVal = DataIO.LoadRecords(dataset.Text);
            neuron = new Neuron(datasetVal.First().Inputs.Count);
            neuron.NeuronType = isAdaline.Checked ? NeuronType.Adaline : NeuronType.Perceptron;
            neuron.MaxError = ReadDouble(maxError);
            neuron.Learn(datasetVal, ReadDouble(gain), (int)ReadDouble(epochCount));
            ShowPercepton();
        }

        private void ShowPercepton()
        {
            biasVal.Text = Math.Round(neuron.BiasWeight, 2).ToString();
            weightsVal.Text = string.Concat(neuron.InputWeights.Select(weight => Math.Round(weight, 2) + ", "));
            theresholdVal.Text = Math.Round(neuron.Threshold, 2).ToString();
        }

        private void isAdaline_CheckedChanged(object sender, EventArgs e)
        {
            maxError.Enabled = isAdaline.Checked;
        }

        private double ReadDouble(string val)
        {
            val = Regex.Replace(val, "\\.", ",");
            double result;
            double.TryParse(val, out result);
            return result;
        }

        private double ReadDouble(TextBox val)
        {
            return ReadDouble(val.Text);
        }
    }
}
