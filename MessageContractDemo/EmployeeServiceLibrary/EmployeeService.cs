﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["EmployeeSampleDatabaseDB"].ConnectionString;
        public EmployeeInfo GetEmployee(EmployeeRequest employeeRequest)
        {
            Console.WriteLine("LicenseKey "+employeeRequest.LicenseKey);
            Employee employee = new Employee();
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM TBLEMPLOYEE WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", employeeRequest.EmployeeId);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employee.Id = Convert.ToInt32(reader["ID"]);
                        employee.Name = reader["NAME"].ToString();
                        employee.Gender = reader["GENDER"].ToString();
                        employee.DateOfBirth = Convert.ToDateTime(reader["DATEOFBIRTH"]);
                    }
                }
            }

            return new EmployeeInfo(employee);
        }

        public void SaveEmployee(EmployeeInfo employee)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO TBLEMPLOYEE VALUES (@EID,@ENAME,@EGENDER,@EDATEOFBIRTH)";
                cmd.Parameters.AddWithValue("@EID", employee.ID);
                cmd.Parameters.AddWithValue("@ENAME", employee.Name);
                cmd.Parameters.AddWithValue("@EGENDER", employee.Gender);
                cmd.Parameters.AddWithValue("@EDATEOFBIRTH", employee.DOB);

                con.Open();
                int rowsAffected = (int)cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected in tblEmployee = " + rowsAffected.ToString());
            }
        }
    }
}
