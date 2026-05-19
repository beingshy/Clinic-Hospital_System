using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsLoginHistoryData
    {
        public static bool GetLoginHistoryByID(int? LoginHistoryID, ref short UserID, ref DateTime LoginTime, ref DateTime? LogoutTime)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetLoginHistoryByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LoginHistoryID", (object)LoginHistoryID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                UserID = (short)reader["UserID"];
                                LoginTime = (DateTime)reader["LoginTime"];
                                LogoutTime = (reader["LogoutTime"] != DBNull.Value) ? (DateTime?)reader["LogoutTime"] : null;
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
        public static int AddNewLoginHistory(short UserID, DateTime LoginTime, DateTime? LogoutTime)
        {
            int LoginHistoryID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewLoginHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@LoginTime", LoginTime);
                        command.Parameters.AddWithValue("@LogoutTime", (object)LogoutTime ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            LoginHistoryID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);

            }

            return LoginHistoryID;
        }
        public static bool UpdateLoginHistory(int? LoginHistoryID, short UserID, DateTime LoginTime, DateTime? LogoutTime)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdateLoginHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@LoginHistoryID", LoginHistoryID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@LoginTime", LoginTime);
                        command.Parameters.AddWithValue("@LogoutTime", (object)LogoutTime ?? DBNull.Value);

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
        public static bool DeleteLoginHistory(int? LoginHistoryID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeleteLoginHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@LoginHistoryID", (object)LoginHistoryID ?? DBNull.Value);

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
        public static bool DoesLoginHistoryExist(int? LoginHistoryID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesLoginHistoryExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@LoginHistoryID", (object)LoginHistoryID ?? DBNull.Value);

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
        public static DataTable GetUserLoginHistory(short UserID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetUserLoginHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", UserID);

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
        public static DataTable GetAllLoginHistory()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllLoginHistory", connection))
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
