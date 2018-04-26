using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.Entity;
namespace QuanLyQuanCafe.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceStaff" in both code and config file together.
    [ServiceContract]
    public interface IServiceStaff
    {
        [OperationContract]
        DataSet GetStaff();
        [OperationContract]
        int AddStaff(Staff nv);
        [OperationContract]
        int UpdateStaff(Staff nv);
        [OperationContract]
        int DeleteStaff(Staff nv);
    }
}
