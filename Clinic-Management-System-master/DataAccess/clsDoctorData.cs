using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace ClinicManagementDB_DataAccess
{
    public class clsDoctorData
    {
        public static bool GetDoctorByID(short? DoctorID, ref int PersonID, ref byte DepartmentID, ref string LicenseNumber, ref string Specialization, ref byte YearsOfExperience, ref DateTime HireDate, ref DateTime? EndDate, ref byte DoctorStatus, ref decimal? ConsultationFee, ref short DoctorUserID, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetDoctorByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                PersonID = (int)reader["PersonID"];
                                DepartmentID = (byte)reader["DepartmentID"];
                                LicenseNumber = (string)reader["LicenseNumber"];
                                Specialization = (string)reader["Specialization"];
                                YearsOfExperience = (byte)reader["YearsOfExperience"];
                                HireDate = (DateTime)reader["HireDate"];
                                EndDate = (reader["EndDate"] != DBNull.Value) ? (DateTime?)reader["EndDate"] : null;
                                DoctorStatus = (byte)reader["DoctorStatus"];
                                ConsultationFee = (reader["ConsultationFee"] != DBNull.Value) ? (decimal?)reader["ConsultationFee"] : null;
                                DoctorUserID = (short)reader["DoctorUserID"];
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
        public static int AddNewDoctor(int PersonID, byte DepartmentID, string LicenseNumber, string Specialization, byte YearsOfExperience, DateTime HireDate, DateTime? EndDate, byte DoctorStatus, decimal? ConsultationFee, short DoctorUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int DoctorID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("AddNewDoctor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@YearsOfExperience", YearsOfExperience);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorStatus", DoctorStatus);
                        command.Parameters.AddWithValue("@ConsultationFee", (object)ConsultationFee ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorUserID", DoctorUserID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            DoctorID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex);

            }

            return DoctorID;
        }
        public static bool UpdateDoctor(short? DoctorID, int PersonID, byte DepartmentID, string LicenseNumber, string Specialization, byte YearsOfExperience, DateTime HireDate, DateTime? EndDate, byte DoctorStatus, decimal? ConsultationFee, short DoctorUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdateDoctor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@YearsOfExperience", YearsOfExperience);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorStatus", DoctorStatus);
                        command.Parameters.AddWithValue("@ConsultationFee", (object)ConsultationFee ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorUserID", DoctorUserID);
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
        public static bool DeleteDoctor(short? DoctorID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeleteDoctor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);

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
        public static bool DoesDoctorExistByDoctorID(short? DoctorID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesDoctorExistByDoctorID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);

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
        public static bool DoesDoctorExistByPersonID(int? PersonID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesDoctorExistByPersonID", connection))
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
        public static bool IsDoctorAvailable(short? DoctorID, DateTime AppointmentDate)
        {
            bool IsAvailable = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("IsDoctorAvailable", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        IsAvailable = !reader.HasRows;
                    }
                }
            }
            catch(Exception ex)
            {
                IsAvailable = false;
                clsLogger.LogError(ex);
            }

            return IsAvailable;
        }
        public static int? GetDoctorPersonID(short? DoctorID)
        {
            int? PersonID = null;
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetDoctorPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);

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
        public static bool DoesUsernameUsedByAnotherDoctor(short? DoctorID, string Username)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("DoesUsernameUsedByAnotherDoctor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Username", Username);

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
        public static DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllDoctors", connection))
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
        public static async Task<decimal> GetAverageConsultationFeeAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetAverageConsultationFee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        await connection.OpenAsync();
                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {
                                decimal averageConsultationFee = (decimal)reader["AverageConsultationFee"];
                                return averageConsultationFee;
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
        public static async Task<int> GetTotalAvailableDoctorsAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetTotalAvailableDoctors", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        await connection.OpenAsync();
                        using(SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {
                                int totalAvailableDoctors = (int)reader["TotalAvailableDoctors"];
                                return totalAvailableDoctors;
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
