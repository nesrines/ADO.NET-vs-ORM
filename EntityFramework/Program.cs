using EntityFramework.DataAccess;
using EntityFramework.Entities;

Console.WriteLine("Employee list:");
appdbcontext db = new();
List<Employee> employees = db.Employees.ToList();
foreach (Employee employee in employees)
    Console.WriteLine(employee);

#region Ado.NET
//using Microsoft.Data.SqlClient;
//string conn = "Data Source=TITAN06\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=true";
//SqlConnection sqlConnection = new SqlConnection(conn);
//string query = "SELECT * FROM Employees";
//SqlCommand cmd = new SqlCommand(query, sqlConnection);
//sqlConnection.Open();
//SqlDataReader reader = cmd.ExecuteReader();
//Console.WriteLine("Employee list:");
//while (reader.Read())
//    Console.WriteLine($"Id: {reader[0]} Name: {reader[1]} {reader[2]}");
//reader.Close();
#endregion