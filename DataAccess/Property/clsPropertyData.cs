using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property
{
    public static class clsPropertyData
    {
        //___________________________
        //Table Attributes are:
        //Table Name Properties_Dictionary
        //1.PropertyID int PK
        //2.PropertyName nvarchar(150)
        //2.Property Unit nvarchar(50)
        //3.Target Entity nvarchar(50)
        //___________________________

        //Table Related to this Properties Table:
        //Mold Property, Machine Property, Mixture Actual Properties
        //Foam Grade SPEC, TDS Master, COA Results

        public static int AddNewProperty(string PropertyName, string PropertyUnit,
            string TargetEntity)
        {
            return -1;
        }
        public static bool GetPropertyByPeropertyID(int PerpertyID,
            ref string PropertyName,ref string PropertyUnit,ref string TargetEntity)
        {
            return false;
        }

        public static bool GetPropertyByPropertyName(string PropertyName,
            ref int PropertyID, ref string PropertyUnit, ref string TargetEntity)
        {
            return false;
        }

        public static DataTable GetAllProperties()
        {
            DataTable _dt= new DataTable();
            return _dt;
        }

        public static bool UpdateProperty()
        {
            return false;
        }

        public static bool DeleteProperty(int PropertID)
        {
            //Here we don't delete if other entities related with this property
            return false;
        }

    }
}
