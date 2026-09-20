using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Security.Policy;

namespace DataAccess.Property.Materials
{
    public static class clsMaterialData
    {
        //Materials
        //MaterialID int PK
        //Trade Material Name nvarchar(255)
        //MaterialCategoryID int
        //IsActive bool
        //ChemicalName nvarchar(255)

        //MaterialView here we use it as Read properties
        public static int? AddNewMaterial(string TradeMaterialName, int MaterialCategoryID,
             bool? IsActive, string ChemicalName)
        {
            int? MaterialID = null;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO MATERIALS 
                            (TradeMaterialName,MaterialCategoryID,IsActive,ChemicalName) VALUES 
                            (@TradeMaterialName,@MaterialCategoryID,@IsActive,@ChemicalName);
                            Select SCOPE_Identity();";

            SqlCommand command=new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TradeMaterialName", TradeMaterialName);
            command.Parameters.AddWithValue("@MaterialCategoryID", MaterialCategoryID);
            
            if (IsActive.HasValue)
            {
                command.Parameters.AddWithValue("@IsActive", IsActive);
            }
            else
                command.Parameters.AddWithValue("@IsActive",DBNull.Value);

            command.Parameters.AddWithValue("@ChemicalName", ChemicalName);

            try
            {
                connection.Open();
                object result= command.ExecuteScalar();
                if(result!=null&&int.TryParse(result.ToString(),out int InsertedMaterialID))
                {
                    MaterialID = InsertedMaterialID;
                }
                connection.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return MaterialID;
        }

        public static bool ActiveMaterial(int MaterialID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"update Materials set IsActive=1
                            where MaterialID=@MaterialID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaterialID", MaterialID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;
        }
        public static bool DeActivateMaterial(int MaterialID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"update Materials set IsActive=0
                            where MaterialID=@MaterialID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaterialID", MaterialID);

            try
            {
                connection.Open();

                rowsAffected= command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;
        }
        public static bool GetMaterialByChemicalName(string ChemicalName,
            ref int MaterialID, ref string TradeMaterialName,
            ref int MaterialCategoryID, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Select top 1 * from Materials where ChemicalName LIKE '%' +@ChemicalName +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ChemicalName", ChemicalName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    MaterialID = (int)reader["MaterialID"];
                    TradeMaterialName = (string)reader["TradeMaterialName"];
                    MaterialCategoryID = (int)reader["MaterialCategoryID"];
                   
                        IsActive = (bool)reader["IsActive"];

                   

                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
        public static bool GetMaterialByMaterialID(int MaterialID, ref string TradeMaterialName,
            ref int MaterialCategoryID, ref bool IsActive, ref string ChemicalName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Select * from Materials where MaterialID=@MaterialID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaterialID", MaterialID);

            try
            {
                connection.Open();

                SqlDataReader reader=command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TradeMaterialName = (string)reader["TradeMaterialName"];
                    MaterialCategoryID = (int)reader["MaterialCategoryID"];
                    
                        IsActive = (bool)reader["IsActive"];

                    ChemicalName = (string)reader["ChemicalName"];
                    
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAllMaterials()
        {
            DataTable _dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query = @"   select MATERIALS.MaterialID,MATERIALS.TradeMaterialName,
                                Material_Categories.MaterialCategoryName,MATERIALS.ChemicalName,
                                MATERIALS.IsActive
                                from Materials left join Material_Categories
                                on MATERIALS.MaterialCategoryID=Material_Categories.MaterialCategoryID;
                                ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader= command.ExecuteReader();
                if (reader.HasRows)
                {
                    _dt.Load(reader);
                }

                reader.Close();
            } catch (Exception ex) { }
            finally { connection.Close(); }
            return _dt;
        }

        public static bool UpdateMaterial(int MaterialID, string TradeMaterialName,
            int MaterialCategoryID, bool? IsActive, string ChemicalName)
        {
            int rowsAffected= 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Materials Set
                             TradeMaterialName=@TradeMaterialName,
                             MaterialCategoryID=@MaterialCategoryID,
                             IsActive=@IsActive,
                             ChemicalName=@ChemicalName
                            Where MaterialID=@MaterialID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TradeMaterialName", TradeMaterialName);
            command.Parameters.AddWithValue("@MaterialCategoryID", MaterialCategoryID);
            
            
                command.Parameters.AddWithValue("@IsActive", IsActive);
            
            
            command.Parameters.AddWithValue("@ChemicalName", ChemicalName);
            command.Parameters.AddWithValue("@MaterialID", MaterialID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }catch (Exception ex) { }
            finally { connection.Close(); }

            return rowsAffected > 0;
        }

        public static bool DeleteMaterial(int MaterialID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete From Materials Where MaterialID=@MaterialID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaterialID", MaterialID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }catch(Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;
        }


        public static bool IsMaterialExist(int MaterialID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select 1 from Materials where 
                            MaterialID=@MaterialID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaterialID", MaterialID);

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

        public static bool IsMaterialExistsByChemicalName(string ChemicalName)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select 1 from Materials where 
                            ChemicalName=@ChemicalName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ChemicalName", ChemicalName);

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
