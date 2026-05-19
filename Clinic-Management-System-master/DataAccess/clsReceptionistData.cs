using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsReceptionistData
    {
        public static bool GetReceptionistByID(short? ReceptionistID, ref int PersonID, ref DateTime HireDate, ref DateTime? EndDate, ref byte ReceptionistStatus, ref short ReceptionistUserID, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("GetReceptionistByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID ?? DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                PersonID = (int)reader["PersonID"];
                                HireDate = (DateTime)reader["HireDate"];
                                EndDate = (reader["EndDate"] != DBNull.Value) ? (DateTime?)reader["EndDate"] : null;
                                ReceptionistStatus = (byte)reader["ReceptionistStatus"];
                                ReceptionistUserID = (short)reader["ReceptionistUserID"];
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
            catch (Exception ex)
            {
                isFound = false;
                clsLogger.LogError(ex);
            }

            return isFound;
        }
        public static int AddNewReceptionist(int PersonID, DateTime HireDate, DateTime? EndDate, byte ReceptionistStatus, short ReceptionistUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int ReceptionistID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewReceptionist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReceptionistStatus", ReceptionistStatus);
                        command.Parameters.AddWithValue("@ReceptionistUserID", ReceptionistUserID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            ReceptionistID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return ReceptionistID;
        }
        public static bool UpdateReceptionist(short? ReceptionistID, int PersonID, DateTime HireDate, DateTime? EndDate, byte ReceptionistStatus, short ReceptionistUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdateReceptionist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReceptionistID", ReceptionistID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReceptionistStatus", ReceptionistStatus);
                        command.Parameters.AddWithValue("@ReceptionistUserID", ReceptionistUserID);
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
        public static bool DeleteReceptionist(short? ReceptionistID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeleteReceptionist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID ?? DBNull.Value);

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
        public static bool DoesReceptionistExist(short? ReceptionistID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("DoesReceptionistExist", connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID  ?? DBNull.Value);

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
        public static int? GetPersonID(short? ReceptionistID)
        {
            int? PersonID = null;
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetReceptionistPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID ?? DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if(reader.Read())
                        {
                            PersonID = (int?)reader["PersonID"];
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);
            }

            return PersonID;
        }
        public static bool DoesReceptionistExistByPersonID(int? PersonID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesReceptionistExistByPersonID", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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
        public static DataTable GetAllReceptionists()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllReceptionists", connection))
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
