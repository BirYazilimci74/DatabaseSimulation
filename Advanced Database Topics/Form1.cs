using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Database_Topics
{
    internal partial class Form1 : Form
    {
        private BindingList<SimulationModel> _simulationModels;
        public Form1()
        {
            InitializeComponent();
            _simulationModels = new BindingList<SimulationModel>();
            dataGridView1.DataSource = _simulationModels;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadIsolationLevelData();
        }

        private void LoadIsolationLevelData()
        {
            string[] isolationLevels = new string[] { "READ UNCOMMITTED", "READ COMMITTED", "REPEATABLE READ", "SERIALIZABLE"};
            cbxIsolationLvl.DataSource = isolationLevels;
        }

        private async void btnSimulate_ClickAsync(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Simulating...\n\n";
            await SimulateAsync();
        }

        private async Task SimulateAsync()
        {
            var numOfUserA = Convert.ToInt32(numUserA.Value);
            var numOfUserB = Convert.ToInt32(numUserB.Value);
            string isolationLevel = cbxIsolationLvl.SelectedItem.ToString();
            
            Simulation simulation = new Simulation(numOfUserA, numOfUserB, isolationLevel);
            await simulation.Simulate();

            var newSimulation = new SimulationModel
            {
                NumberOfAUser = numOfUserA,
                NumberOfBUser = numOfUserB,
                DurationUserA = simulation.DurationUserA,
                DeadlockUserA = simulation.NumberOfDeadlocksUserA,
                DurationUserB = simulation.DurationUserB,
                DeadlockUserB = simulation.NumberOfDeadlocksUserB,
                IsolationLevel = isolationLevel
            };

            _simulationModels.Add(newSimulation);

            Console.WriteLine("************The simulation is over.*************");
            richTextBox1.Text = $"Number of Deadlocks for UserA: {simulation.NumberOfDeadlocksUserA}\nNumber of Deadlocks for UserB: {simulation.NumberOfDeadlocksUserB}";
            richTextBox1.Text += $"\n\nDuration for UserA: {simulation.DurationUserA} s\nDuration for UserB: {simulation.DurationUserB} s";
            richTextBox1.Text += $"\n\nNumber of UserA: {numOfUserA}\nNumber of UserB: {numOfUserB}";
            richTextBox1.Text += $"\n\nIsolation Level: {isolationLevel}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _simulationModels.Clear();
        }
    }
}
