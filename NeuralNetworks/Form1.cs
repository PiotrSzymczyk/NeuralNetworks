using System;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetworks
{
    public partial class Form1 : Form
    {
        private static Perceptron perceptron;
        public Form1()
        {
            InitializeComponent();
        }

        private void eval_Click(object sender, EventArgs e)
        {
            var inputsVal = inputs.Text.Split(' ').Select(input => double.Parse(input)).ToList();
            resultBox.Text = perceptron.GetOutput(inputsVal).ToString();
        }

        private void learn_Click(object sender, EventArgs e)
        {
            var datasetVal = DataIO.LoadRecords(dataset.Text);
            var gainVal = double.Parse(gain.Text);
            perceptron = new Perceptron(datasetVal.First().Inputs.Count);
            perceptron.NeuronType = isAdaline.Checked ? NeuronType.Adaline : NeuronType.Perceptron;
            perceptron.MaxError = 0.08;
            perceptron.Learn(datasetVal, gainVal);
            ShowPercepton();
        }

        private void ShowPercepton()
        {
            biasVal.Text = Math.Round(perceptron.BiasWeight, 2).ToString();
            weightsVal.Text = string.Concat(perceptron.InputWeights.Select(weight => Math.Round(weight, 2) + ", "));
            theresholdVal.Text = Math.Round(perceptron.Threshold, 2).ToString();
        }
    }
}
