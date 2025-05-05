using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Advanced_Database_Topics
{
    public class Simulation
    {
        public string DurationUserA { get; set; }
        public string DurationUserB { get; set; }
        public int NumberOfDeadlocksUserA { get; set; } = 0;
        public int NumberOfDeadlocksUserB { get; set; } = 0;

        private int _userA;
        private int _userB;
        private string _isolationLevel;
        private DatabaseOperations dbOps;

        public Simulation(int userA, int userB, string isolationLevel)
        {
            _userA = userA;
            _userB = userB;
            dbOps = new DatabaseOperations(this);
            _isolationLevel = isolationLevel;
        }

        public async Task Simulate()
        {
            await Task.WhenAll(UserA(), UserB());
        }

        private async Task UserA()
        {
            Stopwatch stopwatchUserA = new Stopwatch();
            List<Task> tasksA = new List<Task>();

            stopwatchUserA.Start();

            //Creating UserA 
            for (int i = 0; i < _userA; i++)
            {
                tasksA.Add(Task.Run(async () =>
                {
                    try
                    {
                        await dbOps.UpdateDataAsync(_isolationLevel);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }));
            }
            await Task.WhenAll(tasksA);
            stopwatchUserA.Stop();
            DurationUserA = stopwatchUserA.Elapsed.TotalSeconds.ToString("F2");
        }

        private async Task UserB()
        {
            Stopwatch stopwatchUserB = new Stopwatch();
            List<Task> tasksB = new List<Task>();

            //Creating UserB
            stopwatchUserB.Start();
            for (int i = 0; i < _userB; i++)
            {
                tasksB.Add(Task.Run(async () =>
                {
                    try
                    {
                        await dbOps.GetDataAsync(_isolationLevel);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }));

            }
            await Task.WhenAll(tasksB);
            stopwatchUserB.Stop();
            DurationUserB = stopwatchUserB.Elapsed.TotalSeconds.ToString("F2");
        }
    }
}
