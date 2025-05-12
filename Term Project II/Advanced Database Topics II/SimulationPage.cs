using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Database_Topics_II
{
    public partial class SimulationPage : Form
    {
        private readonly Simulation _simulation;
        public SimulationPage()
        {
            _simulation = new Simulation();
            InitializeComponent();
        }

        private async void btnSimulateQ1_Click(object sender, EventArgs e)
        {
            var query1Top10 = await _simulation.GenerateQuery1();
            dgwTop10.DataSource = query1Top10.Item1;
            lblEffectedRow.Text = query1Top10.Item2.ToString();
            lblDuration.Text = $"{query1Top10.Item3} ms";
        }

        private async void btnSimulateQ2_Click(object sender, EventArgs e)
        {
            var query2Top10 = await _simulation.GenerateQuery2();
            dgwTop10.DataSource = query2Top10.Item1; 
            lblEffectedRow.Text = query2Top10.Item2.ToString();
            lblDuration.Text = $"{query2Top10.Item3} ms";
        }

        private async void btnSimulateQ3_Click(object sender, EventArgs e)
        {
            var query3Top10 = await _simulation.GenerateQuery3();
            dgwTop10.DataSource = query3Top10.Item1;
            lblEffectedRow.Text = query3Top10.Item2.ToString();
            lblDuration.Text = $"{query3Top10.Item3} ms";
        }
    }
}
