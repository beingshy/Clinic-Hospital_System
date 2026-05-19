using System;
using System.Data;
using Microsoft.Data.SqlClient;

using System.Threading.Tasks;

namespace ClinicManagementDB_DataAccess
{
    public class clsAppointmentData
    {
        public static bool GetAppointmentByID(int? AppointmentID, ref int PatientID, ref short DoctorID, ref DateTime AppointmentDate, ref byte AppointmentStatus, ref bool IsPaid, ref int? PaymentID, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAppointmentByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AppointmentID", (object)AppointmentID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                PatientID = (int)reader["PatientID"];
                                DoctorID = (short)reader["DoctorID"];
                                AppointmentDate = (DateTime)reader["AppointmentDate"];
                                AppointmentStatus = (byte)reader["AppointmentStatus"];
                                IsPaid = (bool)reader["IsPaid"];
                                PaymentID = (reader["PaymentID"] != DBNull.Value) ? (int?)reader["PaymentID"] : null;
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
        public static int AddNewAppointment(int PatientID, short DoctorID, DateTime AppointmentDate, byte AppointmentStatus, bool IsPaid, int? PaymentID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int AppointmentID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewAppointment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        command.Parameters.AddWithValue("@IsPaid", IsPaid);
                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            AppointmentID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return AppointmentID;
        }
        public static bool UpdateAppointment(int? AppointmentID, int PatientID, short DoctorID, DateTime AppointmentDate, byte AppointmentStatus, bool IsPaid, int? PaymentID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdateAppointment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        command.Parameters.AddWithValue("@IsPaid", IsPaid);
                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);
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
        public static bool DeleteAppointment(int? AppointmentID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeleteAppointment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AppointmentID", (object)AppointmentID ?? DBNull.Value);

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
        public static bool DoesAppointmentExist(int? AppointmentID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesAppointmentExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AppointmentID", (object)AppointmentID ?? DBNull.Value);

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
        public static DataTable GetAllAppointments(short PageNumber, int PageSize, ref int Records)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllAppointments", connection))
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
        public static DataTable GetAppointmentWithAppointmentID(int AppointmentID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAppointmentWithAppointmentID", connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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
        public static DataTable GetAppointmentsWithPatientID(short PageNumber, int PageSize, ref int Records, int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAppointmentsWithPatientID", connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@PageSize", PageSize);
                        command.Parameters.AddWithValue("@PatientID", PatientID);

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
        public static DataTable GetAppointmentsWithDoctorID(short PageNumber, int PageSize, ref int Records, int DoctorID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAppointmentsWithDoctorID", connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@PageSize", PageSize);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

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
        public static DataTable GetAppointmentWithName(short PageNumber, int PageSize, ref int Records, string Name)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAppointmentWithPatientName", connection))
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
        public static bool HasMedicalRecord(int? AppointmentID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("HasMedicalRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AppointmentID", (object)AppointmentID ?? DBNull.Value);

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
        public static int? GetMedicalRecordID(int? AppointmentID)
        {

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetMedicalRecordID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AppointmentID", (object)AppointmentID ?? DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.Read())
                        {
                            int? MedicalRecordID = (int?)reader["MedicalRecordID"];
                            return MedicalRecordID;
                        }

                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return null;
        }
        public static async Task<int> GetTodayAppointmentsCountAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetTodayAppointmentsCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        await connection.OpenAsync();
                        SqlDataReader reader = await command.ExecuteReaderAsync();
                        if(await reader.ReadAsync())
                        {
                            int todayAppointmentsCount = (int)reader["TodayAppointmentsCount"];
                            return todayAppointmentsCount;
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
        public static async Task<int> GetWeeklyAppointmentsCountAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetWeeklyAppointmentsCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        await connection.OpenAsync();
                        SqlDataReader reader = await command.ExecuteReaderAsync();
                        if(await reader.ReadAsync())
                        {
                            int weeklyAppointmentsCount = (int)reader["WeeklyAppointmentsCount"];
                            return weeklyAppointmentsCount;
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
        public static async Task<int> GetCreatedAppointmentsThisWeekCountAsync()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetCreatedAppointmentsThisWeekCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        await connection.OpenAsync();
                        SqlDataReader reader = await command.ExecuteReaderAsync();
                        if(await reader.ReadAsync())
                        {
                            int createdAppointmentsThisWeekCount = (int)reader["CreatedAppointmentsThisWeekCount"];
                            return createdAppointmentsThisWeekCount;
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
