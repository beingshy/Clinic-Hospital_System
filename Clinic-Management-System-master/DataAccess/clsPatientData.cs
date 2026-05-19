using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace ClinicManagementDB_DataAccess
{
    public class clsPatientData
    {
        public static bool GetPatientByID(int? PatientID, ref int PersonID, ref string BloodType, ref string Allergies, ref string MedicalHistory, ref string EmergencyContactName, ref string EmergencyContactPhone, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("GetPatientByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PatientID", (object)PatientID ?? DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                PersonID = (int)reader["PersonID"];
                                BloodType = (reader["BloodType"] != DBNull.Value) ? (string)reader["BloodType"] : null;
                                Allergies = (reader["Allergies"] != DBNull.Value) ? (string)reader["Allergies"] : null;
                                MedicalHistory = (reader["MedicalHistory"] != DBNull.Value) ? (string)reader["MedicalHistory"] : null;
                                EmergencyContactName = (reader["EmergencyContactName"] != DBNull.Value) ? (string)reader["EmergencyContactName"] : null;
                                EmergencyContactPhone = (reader["EmergencyContactPhone"] != DBNull.Value) ? (string)reader["EmergencyContactPhone"] : null;
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
        public static int AddNewPatient(int PersonID, string BloodType, string Allergies, string MedicalHistory, string EmergencyContactName, string EmergencyContactPhone, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int PatientID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewPatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@BloodType", (object)BloodType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Allergies", (object)Allergies ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MedicalHistory", (object)MedicalHistory ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactName", (object)EmergencyContactName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactPhone", (object)EmergencyContactPhone ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            PatientID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return PatientID;
        }
        public static bool UpdatePatient(int? PatientID, int PersonID, string BloodType, string Allergies, string MedicalHistory, string EmergencyContactName, string EmergencyContactPhone, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdatePatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@BloodType", (object)BloodType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Allergies", (object)Allergies ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MedicalHistory", (object)MedicalHistory ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactName", (object)EmergencyContactName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactPhone", (object)EmergencyContactPhone ?? DBNull.Value);
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
        public static bool DeletePatient(int? PatientID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeletePatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PatientID", (object)PatientID ?? DBNull.Value);

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
        public static bool DoesPatientExist(int? PatientID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesPatientExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PatientID", (object)PatientID  ?? DBNull.Value);

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
        public static bool DoesPatientExistByPersonID(int PersonID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesPatientExistByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

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
        public static DataTable GetAllPatients(short PageNumber, int PageSize, ref int Records)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllPatients", connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@PageSize", PageSize);

                        command.CommandType = CommandType.StoredProcedure;

                        var recordsParam = command.Parameters.Add("@Records", SqlDbType.Int);
                        recordsParam.Direction = ParameterDirection.Output;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                        else
                            return dt;

                        Records = recordsParam.Value != DBNull.Value ? (int)recordsParam.Value : 0;

                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return dt;
        }
        public static DataTable GetPatientWithPatientID(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPatientWithPatientID", connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                        else
                            return dt;

                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return dt;
        }
        public static DataTable GetPatientWithPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPatientWithPersonID", connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                        else
                            return dt;

                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return dt;
        }
        public static DataTable GetPatientWithNationalID(string NationalID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPatientWithNationalID", connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", NationalID);

                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                        else
                            return dt;

                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return dt;
        }
        public static DataTable GetPatientWithName(short PageNumber, int PageSize, ref int Records, string Name)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPatientWithName", connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@PageSize", PageSize);
                        command.Parameters.AddWithValue("@Name", Name);

                        command.CommandType = CommandType.StoredProcedure;

                        var recordsParam = command.Parameters.Add("@Records", SqlDbType.Int);
                        recordsParam.Direction = ParameterDirection.Output;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                        else
                            return dt;

                        Records = recordsParam.Value != DBNull.Value ? (int)recordsParam.Value : 0;

                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return dt;
        }
        public static async Task<int> GetTotalPatientsAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetTotalPatients", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        await connection.OpenAsync();
                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {
                                int totalPatients = (int)reader["TotalPatients"];
                                return totalPatients;
                            }
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
        public static async Task<int> GetNewPatientsThisWeekAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetNewPatientsThisWeek", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        await connection.OpenAsync();
                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {
                                int newPatientsThisWeek = (int)reader["NewPatientsThisWeek"];
                                return newPatientsThisWeek;
                            }
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
        public static async Task<int> GetAveragePatientAgeAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetAveragePatientAge", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        await connection.OpenAsync();
                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {
                                int averagePatientAge = (int)reader["AveragePatientAge"];
                                return averagePatientAge;
                            }
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
