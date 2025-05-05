using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Database_Topics_II
{
    public class Simulation
    {
        private readonly DatabaseOperations _databaseOperations;
        public Simulation()
        {
            _databaseOperations = new DatabaseOperations();
        }

        private async Task GenerateQuery1()
        {
            List<Task> queries = new List<Task>();
            
            for (int i = 0; i < 100; i++)
            {
                queries.Add(Task.Run(async () =>
                {
                    try
                    {
                        await _databaseOperations.ExecuteQuery1Async();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }));
            }

            await Task.WhenAll(queries);
        }

        private async Task GenerateQuery2()
        {
            List<Task> queries = new List<Task>();
            
            for (int i = 0; i < 100; i++)
            {
                queries.Add(Task.Run(async () =>
                {
                    try
                    {
                        await _databaseOperations.ExecuteQuery2Async();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }));
            }

            await Task.WhenAll(queries);
        }

        private async Task GenerateQuery3()
        {
            List<Task> queries = new List<Task>();
            
            for (int i = 0; i < 100; i++)
            {
                queries.Add(Task.Run(async () =>
                {
                    try
                    {
                        await _databaseOperations.ExecuteQuery3Async();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }));
            }

            await Task.WhenAll(queries);
        }

        public async Task Simulate()
        {
            await Task.WhenAll(GenerateQuery1(),GenerateQuery2(), GenerateQuery3());
        }
    }
}
