# DatabaseSimulation
Database Isolation Levels Simulation Program

This project is the first term project of the SE 308 – Advanced Topics in Database Systems course. The goal of the project is to simulate user transactions on the AdventureWorks2022 database and measure the performance under different transaction isolation levels.
There are two types of users in the simulation:
•	Type A users make update queries.
•	Type B users make select queries.
The simulation program is built with multi-threading by using C# and Windows Forms. Each user runs the same query structure 100 times. During the simulation, the program measures the time for each thread and counts the number of deadlocks.
