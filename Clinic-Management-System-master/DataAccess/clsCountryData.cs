using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsCountryData
    {
        public static bool GetCountryByID(byte? CountryID, ref string CountryName)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetCountryByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                CountryName = (string)reader["CountryName"];
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
        public static bool GetCountryByName(ref byte? CountryID, string CountryName)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetCountryByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryName", CountryName);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                CountryID = (byte?)reader["CountryID"];
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
        public static int AddNewCountry(string CountryName)
        {
            int CountryID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewCountry", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryName", CountryName);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            CountryID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return CountryID;
        }
        public static bool UpdateCountry(byte? CountryID, string CountryName)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdateCountry", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        command.Parameters.AddWithValue("@CountryName", CountryName);

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
        public static bool DeleteCountry(byte? CountryID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeleteCountry", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

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
        public static bool DoesCountryExist(byte? CountryID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesCountryExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

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
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllCountries", connection))
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
    }
}
