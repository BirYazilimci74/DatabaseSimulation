using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Database_Topics
{
    public class SimulationModel
    {
        public int NumberOfAUser { get; set; }
        public int NumberOfBUser { get; set; }
        public string DurationUserA { get; set; }
        public int DeadlockUserA { get; set; }
        public string DurationUserB { get; set; }
        public int DeadlockUserB { get; set; }
        public string IsolationLevel { get; set; }
    }
}
