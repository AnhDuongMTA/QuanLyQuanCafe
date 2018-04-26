using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuanLyQuanCafe.Entity;
using QuanLyQuanCafe.DAL;
using System.Data;

namespace QuanLyQuanCafe.BUS
{
    public class StaffBUS
    {
        StaffDAL staffdal = new StaffDAL();
        public DataSet GetStaff()
        {
            return staffdal.GetStaff();
        }
        public int AddStaff(Staff nv)
        {
            return staffdal.AddStaff(nv);
        }
        public int UpdateStaff(Staff nv)
        {
            return staffdal.UpdateStaff(nv);
        }
        public int DeleteStaff(Staff nv)
        {
            return staffdal.DeleteStaff(nv);
        }

    }
}