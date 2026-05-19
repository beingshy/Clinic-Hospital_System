using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonByID(int? PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string NationalID, ref DateTime BirthDate, ref bool Gender, ref string Address, ref string Phone, ref string Email, ref byte CountryID, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetPersonByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : null;
                                LastName = (string)reader["LastName"];
                                NationalID = (string)reader["NationalID"];
                                BirthDate = (DateTime)reader["BirthDate"];
                                Gender = (bool)reader["Gender"];
                                Address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
                                CountryID = (byte)reader["CountryID"];
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
        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalID, DateTime BirthDate, bool Gender, string Address, string Phone, string Email, byte CountryID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int PersonID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewPerson", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@NationalID", NationalID);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", (object)CreatedAt ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            PersonID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

                clsLogger.LogError(ex);
            }

            return PersonID;
        }
        public static bool UpdatePerson(int? PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalID, DateTime BirthDate, bool Gender, string Address, string Phone, string Email, byte CountryID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("UpdatePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@NationalID", NationalID);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@CountryID", CountryID);
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
        public static bool DeletePerson(int? PersonID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DeletePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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
        public static bool DoesPersonExist(int? PersonID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesPersonExist", connection))
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
        public static bool DoesPersonHasUser(int? PersonID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("DoesPersonHasUser", connection))
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
        public static DataTable GetAllPeople(short PageNumber, int PageSize, ref int Records)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllPeople", connection))
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
        public static DataTable GetPersonWithPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPersonWithPersonID", connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static DataTable GetPersonWithNationalID(string NationalID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPersonWithNationalID", connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", NationalID);
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
        public static DataTable GetPeopleWithName(short PageNumber, int PageSize, ref int Records, string Name)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPeopleWithName", connection))
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


    }
}
