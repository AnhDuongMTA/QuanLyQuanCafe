using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuanLyQuanCafe.Entity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanCafe.DAL
{
    public class StaffDAL
    {
        KetNoi conn = new KetNoi();

        public DataSet GetStaff()
        {
            return conn.GetData("GetStaff", null);
        }
        public int AddStaff(Staff nv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("birthday",nv.birthday),
                new SqlParameter("name",nv.name),
                new SqlParameter("phone",nv.phone),
                new SqlParameter("address",nv.address),
                new SqlParameter("sex",nv.sex)
            };
            return conn.ExcuteSQL("AddStaff", para);
        }
        public int UpdateStaff(Staff nv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("id",nv.id),
                new SqlParameter("birthday",nv.birthday),
                new SqlParameter("name",nv.name),
                new SqlParameter("phone",nv.phone),
                new SqlParameter("address",nv.address),
                new SqlParameter("sex",nv.sex)
            };
            return conn.ExcuteSQL("UpdateStaff", para);
        }
        public int DeleteStaff(Staff nv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("id",nv.id)
            };
            return conn.ExcuteSQL("DeleteStaff", para);
        }

    }
}