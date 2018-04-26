using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QuanLyQuanCafe.Entity;
using QuanLyQuanCafe.BUS;
namespace QuanLyQuanCafe.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceStaff" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceStaff.svc or ServiceStaff.svc.cs at the Solution Explorer and start debugging.
    public class ServiceStaff : IServiceStaff
    {
        StaffBUS staffbus = new StaffBUS();
        public int AddStaff(Staff nv)
        {
            return staffbus.AddStaff(nv);
        }

        public int DeleteStaff(Staff nv)
        {
            return staffbus.DeleteStaff(nv);
        }

        public DataSet GetStaff()
        {
            return staffbus.GetStaff();
        }

        public int UpdateStaff(Staff nv)
        {
            return staffbus.UpdateStaff(nv);
        }
    }
}
