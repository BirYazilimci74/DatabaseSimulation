using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Advanced_Database_Topics
{
    public class DatabaseOperations
    {
        private readonly Simulation _simulation;
        private readonly string _connectionString;

        public DatabaseOperations(Simulation simulation)
        {
            _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=120;Max Pool Size=100000;";
            _simulation = simulation;
        }

        public async Task GetDataAsync(string isolationLevel)
        {
            //User B
            List<Task> sqlCommadTasks = new List<Task>();

            for (int i = 0; i < 100; i++)
            {
                int j = i;
                sqlCommadTasks.Add(Task.Run(() => SelectOperation(isolationLevel, j)));
            }
            try
            {
                await Task.WhenAll(sqlCommadTasks);
            }
            catch (Exception)
            {

                throw;
            }
            sqlCommadTasks.Clear();
        }

        private void SelectOperation(string isolationLevel, int i)
        {
            Random random = new Random();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SetIsolationLevel(connection, transaction, isolationLevel);

                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(SelectQuery("20110101", "20111231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User B: " + i);
                        }
                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(SelectQuery("20120101", "20121231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User B: " + i);
                        }
                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(SelectQuery("20130101", "20131231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User B: " + i);
                        }
                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(SelectQuery("20140101", "20141231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User B: " + i);
                        }
                        //if (random.NextDouble() < 0.5)
                        //{
                        //    SqlCommand cmd = new SqlCommand(SelectQuery("20150101", "20151231"), connection, transaction);
                        //    await cmd.ExecuteScalarAsync();
                        //}
                        // there is no record for 20150101 to 20151231 in the database
                        transaction.Commit();
                    }
                    catch (SqlException ex) when (ex.Number == 1205) // deadlock error number
                    {
                        transaction.Rollback();
                        _simulation.NumberOfDeadlocksUserB++;
                        Console.WriteLine("Deadlock occurred for User B: " + i);
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null)
                        {
                            transaction.Rollback();
                        }
                        Console.WriteLine("Error: " + ex.Message);
                        return;
                    }
                }
                connection.Close();
            }
        }

        public async Task UpdateDataAsync(string isolationLevel)
        {
            //User A
            List<Task> sqlCommadTasks = new List<Task>();

            for (int i = 0; i < 100; i++)
            {
                int j = i;
                sqlCommadTasks.Add(Task.Run(() => UpdateOperation(isolationLevel, j)));
            }
            try
            {
                await Task.WhenAll(sqlCommadTasks);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpdateOperation(string isolationLevel, int i)
        {
            Random random = new Random();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        SetIsolationLevel(connection, transaction, isolationLevel);

                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(UpdateQuery("20110101", "20111231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User A: " + i);
                        }
                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(UpdateQuery("20120101", "20121231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User A: " + i);
                        }
                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(UpdateQuery("20130101", "20131231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User A: " + i);
                        }
                        if (random.NextDouble() < 0.5)
                        {
                            SqlCommand cmd = new SqlCommand(UpdateQuery("20140101", "20141231"), connection, transaction);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("User A: " + i);
                        }
                        //if (random.NextDouble() < 0.5)
                        //{
                        //    SqlCommand cmd = new SqlCommand(UpdateQuery("20150101", "20151231"), connection, transaction);
                        //    await cmd.ExecuteNonQueryAsync();
                        //}
                        // there is no record for 20150101 to 20151231 in the database
                        transaction.Commit();
                    }
                    catch (SqlException ex) when (ex.Number == 1205) // deadlock error number
                    {
                        transaction.Rollback();
                        _simulation.NumberOfDeadlocksUserA++;
                        Console.WriteLine("Deadlock occurred for User A: " + i);
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null)
                        {
                            transaction.Rollback();
                        }
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                connection.Close();
            }
        }

        private string SelectQuery(string begin, string end)
        {
            return $"SELECT SUM(Sales.SalesOrderDetail.OrderQty) " +
                   $"FROM Sales.SalesOrderDetail " +
                   $"WHERE UnitPrice > 100 " +
                   $"AND EXISTS (SELECT * FROM Sales.SalesOrderHeader " +
                                $"WHERE Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                                $"AND Sales.SalesOrderHeader.OrderDate BETWEEN '{begin}' AND '{end}' " +
                                $"AND Sales.SalesOrderHeader.OnlineOrderFlag = 1)";
        }

        private string UpdateQuery(string begin, string end)
        {
            return $"UPDATE Sales.SalesOrderDetail " +
                   $"SET UnitPrice = UnitPrice * 10.0 / 10.0 " +
                   $"WHERE UnitPrice > 100 " +
                   $"AND EXISTS (SELECT * FROM Sales.SalesOrderHeader " +
                                $"WHERE Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                                $"AND Sales.SalesOrderHeader.OrderDate BETWEEN '{begin}' AND '{end}' " +
                                $"AND Sales.SalesOrderHeader.OnlineOrderFlag = 1)";
        }

        private void SetIsolationLevel(SqlConnection connection, SqlTransaction transaction, string level)
        {
            SqlCommand cmd = new SqlCommand($"SET TRANSACTION ISOLATION LEVEL {level};", connection, transaction);
            cmd.ExecuteNonQuery();
        }
    }
}
