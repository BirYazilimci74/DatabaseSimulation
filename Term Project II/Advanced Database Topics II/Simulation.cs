using Advanced_Database_Topics_II.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public async Task<(List<Query1Model>, int numOfReturnedRow, long duration)> GenerateQuery1()
        {
            Stopwatch stopwatch = new Stopwatch();
            List<Task> queries = new List<Task>();

            stopwatch.Start();
            var query1Top10 = await _databaseOperations.ExecuteQuery1Async();
            int numOfReturnedRow = query1Top10.Item2;

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
            stopwatch.Stop();
            var duration = stopwatch.ElapsedMilliseconds;
            return (query1Top10.Item1, numOfReturnedRow, duration);
        }

        public async Task<(List<Query2Model>, int numOfReturnedRow, long duration)> GenerateQuery2()
        {
            List<Task> queries = new List<Task>();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var query2Top10 = await _databaseOperations.ExecuteQuery2Async();
            int numOfReturnedRow = query2Top10.Item2;

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
            stopwatch.Stop();
            var duration = stopwatch.ElapsedMilliseconds;
            return (query2Top10.Item1, numOfReturnedRow, duration);
        }

        public async Task<(List<Query3Model>, int numOfReturnedRow, long duration)> GenerateQuery3()
        {
            List<Task> queries = new List<Task>();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var query3Top10 = await _databaseOperations.ExecuteQuery3Async();
            int numOfReturnedRow = query3Top10.Item2;

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
            stopwatch.Stop();
            var duration = stopwatch.ElapsedMilliseconds;
            return (query3Top10.Item1, numOfReturnedRow, duration);
        }
    }
}
