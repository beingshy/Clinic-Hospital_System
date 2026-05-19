using Microsoft.SqlServer.Server;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsUserData
    {
        public static bool GetUserByID(short? UserID, ref int PersonID, ref string Username, ref string Password, ref byte Role, ref bool IsActive, ref DateTime? LastLoginAt, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetUserByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                PersonID = (int)reader["PersonID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                Role = (byte)reader["Role"];
                                IsActive = (bool)reader["IsActive"];
                                LastLoginAt = (reader["LastLoginAt"] != DBNull.Value) ? (DateTime?)reader["LastLoginAt"] : null;
                                CreatedByUserID = (short)reader["CreatedByUserID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedByUserID = (reader["UpdatedByUserID"] != DBNull.Value) ? (short?)reader["UpdatedByUserID"] : null;
                                UpdatedAt = (reader["UpdatedAt"] != DBNull.Value) ? (DateTime?)reader["UpdatedAt"] : null;
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
        public static bool GetUserByPersonID(ref short? UserID, int PersonID, ref string Username, ref string Password, ref byte Role, ref bool IsActive, ref DateTime? LastLoginAt, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetUserByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                UserID = (short)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                Role = (byte)reader["Role"];
                                IsActive = (bool)reader["IsActive"];
                                LastLoginAt = (reader["LastLoginAt"] != DBNull.Value) ? (DateTime?)reader["LastLoginAt"] : null;
                                CreatedByUserID = (short)reader["CreatedByUserID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedByUserID = (reader["UpdatedByUserID"] != DBNull.Value) ? (short?)reader["UpdatedByUserID"] : null;
                                UpdatedAt = (reader["UpdatedAt"] != DBNull.Value) ? (DateTime?)reader["UpdatedAt"] : null;
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
        public static bool GetUserByUsername(ref short? UserID, ref int PersonID, string Username, ref string Password, ref byte Role, ref bool IsActive, ref DateTime? LastLoginAt, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetUserByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", (object)Username ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                UserID = (short?)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                Password = (string)reader["Password"];
                                Role = (byte)reader["Role"];
                                IsActive = (bool)reader["IsActive"];
                                LastLoginAt = (reader["LastLoginAt"] != DBNull.Value) ? (DateTime?)reader["LastLoginAt"] : null;
                                CreatedByUserID = (short)reader["CreatedByUserID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedByUserID = (reader["UpdatedByUserID"] != DBNull.Value) ? (short?)reader["UpdatedByUserID"] : null;
                                UpdatedAt = (reader["UpdatedAt"] != DBNull.Value) ? (DateTime?)reader["UpdatedAt"] : null;
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
        public static bool GetUserByUsernameAndPassword(ref short? UserID, ref int PersonID, string Username, string Password, ref byte Role, ref bool IsActive, ref DateTime? LastLoginAt, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetUserByUsernameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                UserID = (short?)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                Role = (byte)reader["Role"];
                                IsActive = (bool)reader["IsActive"];
                                LastLoginAt = (reader["LastLoginAt"] != DBNull.Value) ? (DateTime?)reader["LastLoginAt"] : null;
                                CreatedByUserID = (short)reader["CreatedByUserID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedByUserID = (reader["UpdatedByUserID"] != DBNull.Value) ? (short?)reader["UpdatedByUserID"] : null;
                                UpdatedAt = (reader["UpdatedAt"] != DBNull.Value) ? (DateTime?)reader["UpdatedAt"] : null;
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
        public static int AddNewUser(int PersonID, string Username, string Password, byte Role, bool IsActive, DateTime? LastLoginAt, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int UserID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Role", Role);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@LastLoginAt", (object)LastLoginAt ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            UserID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);

            }

            return UserID;
        }
        public static string GetUsernameByID(short? UserID)
        {
            string Username = string.Empty;
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetUsernameByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                Username = (string)reader["Username"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);
            }

            return Username;
        }
        public static bool UpdateUser(short? UserID, int PersonID, string Username, string Password, byte Role, bool IsActive, DateTime? LastLoginAt, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Role", Role);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@LastLoginAt", (object)LastLoginAt ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

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
        public static bool ActivateUser(short? UserID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("ActivateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

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
        public static bool ChangeRole(short? UserID, byte Role)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("ChangeRole", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Role", Role);

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
        public static bool DeactivateUser(short? UserID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeactivateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

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
        public static bool DoesUserExistByUserID(short? UserID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("DoesUserExistByUserID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);
                isFound = false;
            }

            return isFound;
        }
        public static bool DoesUserExistByUsername(string Username)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesUserExistByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", (object)Username ?? DBNull.Value);

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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllUsers", connection))
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
