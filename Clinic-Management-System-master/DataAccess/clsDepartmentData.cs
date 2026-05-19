using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace ClinicManagementDB_DataAccess
{
    public class clsDepartmentData
    {
        public static bool GetDepartmentByID(byte? DepartmentID, ref string DepartmentName, ref string DepartmentDescription, ref string DepartmentLocation)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetDepartmentByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                DepartmentName = (string)reader["DepartmentName"];
                                DepartmentDescription = (reader["DepartmentDescription"] != DBNull.Value) ? (string)reader["DepartmentDescription"] : null;
                                DepartmentLocation = (reader["DepartmentLocation"] != DBNull.Value) ? (string)reader["DepartmentLocation"] : null;
                            }
                            else
                                isFound = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                isFound = false;
                clsLogger.LogError(ex);
            }

            return isFound;
        }
        public static bool GetDepartmentByDepartmentName(ref byte? DepartmentID, string DepartmentName, ref string DepartmentDescription, ref string DepartmentLocation)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetDepartmentByDepartmentName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DepartmentName", (object)DepartmentName ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                DepartmentID = (byte?)reader["DepartmentID"];
                                DepartmentDescription = (reader["DepartmentDescription"] != DBNull.Value) ? (string)reader["DepartmentDescription"] : null;
                                DepartmentLocation = (reader["DepartmentLocation"] != DBNull.Value) ? (string)reader["DepartmentLocation"] : null;
                            }
                            else
                                isFound = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                isFound = false;
                clsLogger.LogError(ex);
            }

            return isFound;
        }
        public static int AddNewDepartment(string DepartmentName, string DepartmentDescription, string DepartmentLocation)
        {
            int DepartmentID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewDepartment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                        command.Parameters.AddWithValue("@DepartmentDescription", (object)DepartmentDescription ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DepartmentLocation", (object)DepartmentLocation ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            DepartmentID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);

            }

            return DepartmentID;
        }
        public static bool UpdateDepartment(byte? DepartmentID, string DepartmentName, string DepartmentDescription, string DepartmentLocation)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdateDepartment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        command.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                        command.Parameters.AddWithValue("@DepartmentDescription", (object)DepartmentDescription ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DepartmentLocation", (object)DepartmentLocation ?? DBNull.Value);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);
                return false;
            }

            return (rowsAffected > 0);
        }
        public static bool DeleteDepartment(byte? DepartmentID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeleteDepartment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }

            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return (rowsAffected > 0);
        }
        public static bool DoesDepartmentExist(byte? DepartmentID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesDepartmentExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;
                    }
                }
            }
            catch(Exception ex)
            {
                isFound = false;
                clsLogger.LogError(ex);
            }

            return isFound;
        }
        public static DataTable GetAllDepartments()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllDepartments", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return dt;
        }
        public async static Task<short> TotalDoctorsByDepartmentIDAsync(byte? DepartmentID)
        {
            short TotalDoctors = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("TotalDoctorsByDepartmentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        await connection.OpenAsync();

                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {


                                TotalDoctors = (short)reader["TotalDoctors"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);
            }

            return TotalDoctors;
        }
        public async static Task<int> TotalVisitsByDepartmentIDAsync(byte? DepartmentID)
        {
            int TotalVisits = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("TotalVisitsByDepartmentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        await connection.OpenAsync();

                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {


                                TotalVisits = (int)reader["TotalVisits"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);
            }

            return TotalVisits;
        }
        public async static Task<decimal> TotalRevenueByDepartmentIDAsync(byte? DepartmentID)
        {
            decimal TotalRevenue = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("TotalRevenueByDepartmentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        await connection.OpenAsync();

                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {


                                TotalRevenue = (decimal)reader["TotalRevenue"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);
            }

            return TotalRevenue;
        }
        public async static Task<int> GetTotalDepartmentsAsync()
        {

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetTotalDepartments", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        await connection.OpenAsync();
                        SqlDataReader reader = await command.ExecuteReaderAsync();

                        if(await reader.ReadAsync())
                        {
                            int TotalDepartments = (int)reader["TotalDepartments"];
                            return TotalDepartments;
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);

            }

            return -1;
        }
    }
}
