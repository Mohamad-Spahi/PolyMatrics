using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Materials
{
    public static class clsMaterialCategoryData
    {
        //Material_Categories
        //MaterialCategoryID int PK
        //Material Category Name nvarchar(100) not null
        //MaterialCategoryDescryption nvarchar(255) null
        public static int? AddNewMaterialCategory(string MaterialCategoryName,
            string MaterialCategoryDescryption)
        {
            int? MaterialCategoryID = null;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Material_Categories 
                            (MaterialCategoryName,MaterialCategoryDescryption) VALUES 
                            (@MaterialCategoryName,@MaterialCategoryDescryption);
                            Select SCOPE_Identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaterialCategoryName", MaterialCategoryName);
            if (!string.IsNullOrEmpty(MaterialCategoryDescryption))
            {
                command.Parameters.AddWithValue("@MaterialCategoryDescryption", MaterialCategoryDescryption);
            }
            else
                command.Parameters.AddWithValue("@MaterialCategoryDescryption", DBNull.Value);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedMaterialCategoryID))
                {
                    MaterialCategoryID = InsertedMaterialCategoryID;
                }
                connection.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return MaterialCategoryID;

        }
        public static bool GetMaterialCategoryByCategoryName(string MaterialCategoryName,
            ref int MaterialCategoryID,ref string MaterialCategoryDescryption)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Select * from Material_Categories where MaterialCategoryName=@MaterialCategoryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaterialCategoryName", MaterialCategoryName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    MaterialCategoryID = (int)reader["MaterialCategoryID"];
                    if (reader["MaterialCategoryDescryption"] != null)
                        MaterialCategoryDescryption = (string)reader["MaterialCategoryDescryption"];
                    else
                        MaterialCategoryDescryption = null;
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
        public static bool GetMaterialCategoryByMaterialCategoryID(int MaterialCategoryID,
            ref string MaterialCategoryName,ref string MaterialCategoryDescryption)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Select * from Material_Categories where MaterialCategoryID=@MaterialCategoryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaterialCategoryID", MaterialCategoryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    MaterialCategoryName = (string)reader["MaterialCategoryName"];
                    if (reader["MaterialCategoryDescryption"] != null)
                        MaterialCategoryDescryption = (string)reader["MaterialCategoryDescryption"];
                    else
                        MaterialCategoryDescryption = null;
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAllMaterialCategories()
        {
            DataTable _dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Select * from Material_Categories";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    _dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return _dt;
        }

        public static bool UpdateMaterialCategory(int MaterialCategoryID,
            string MaterialCategoryName, string MaterialCategoryDescription)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Material_Categories Set
                             MaterialCategoryName=@MaterialCategoryName,
                             MaterialCategoryDescription=@MaterialCategoryDescription
                            Where MaterialCategoryID=@MaterialCategoryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaterialCategoryName", MaterialCategoryName);
            if (string.IsNullOrEmpty(MaterialCategoryDescription))
            {
                command.Parameters.AddWithValue("@MaterialCategoryDescription", MaterialCategoryDescription);
            }
            else
                command.Parameters.AddWithValue("@MaterialCategoryDescription", DBNull.Value);
            command.Parameters.AddWithValue("@MaterialCategoryID", MaterialCategoryID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return rowsAffected > 0;
        }
        public static bool DeleteMaterialCategory(int MaterialCategoryID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete From Material_Categories Where MaterialCategoryID=@MaterialCategoryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaterialCategoryID", MaterialCategoryID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;
        }

        public static bool IsMaterialCategoryExit(int MaterialCategoryID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select 1 from Material_Categories where 
                            MaterialCategoryID=@MaterialCategoryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaterialCategoryID", MaterialCategoryID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                IsExist = result != null;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsExist;
        }

        public static bool IsMaterialCategoryNameExist(string MaterialCategoryName)
        {

            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select 1 from Material_Categories where 
                            MaterialCategoryName=@MaterialCategoryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaterialCategoryName", MaterialCategoryName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                IsExist = result != null;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsExist;
        }
    }
}
