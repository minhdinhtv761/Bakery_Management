    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DTO;
using GUI.DAL;


namespace GUI.DAL
{
    public class EmployeeDAL
    {
        private static EmployeeDAL instance;

        public static EmployeeDAL Instance
        {
            get { if (instance == null) instance = new EmployeeDAL(); return instance; }
            private set { EmployeeDAL.instance = value; }
        }

        private EmployeeDAL() { }

        public List<EmployeeDTO> GetFood()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            string query = "SELECT * FROM NHANVIEN";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                EmployeeDTO employee = new EmployeeDTO(item);
                employees.Add(employee);
            }

            return employees;
        }

        public void DeleteEmployee(string id)
        {
            string query = string.Format("delete from NHANVIEN where MANV = '{0}'", id);

            DataProvider.Instance.ExecuteQuery(query);
        }

        public void AddEmployee(string MaNV,string TenNV,string SoDT,DateTime NgVL,string ChucVu,string DiaChi,string email, string gioitinh, byte[] Image)
        {
            /*string query = string.Format("insert into NHANVIEN (MANV,TENNV,SODT,NGVL,CHUCVU,DIACHI,EMAIL,GIOITINH,LinkImage ) " +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", MaNV,TenNV,SoDT,NgVL,ChucVu,DiaChi,email,gioitinh,Image);

            DataProvider.Instance.ExecuteQuery(query);*/
            DataProvider.Instance.ExecuteQuery("USP_AddEmployee @MANV , @TENNV , @SODT , @NgVL , @ChucVu , @DiaChi , @Email , @GioiTinh , @LinkImage ",
                new object[] { MaNV, TenNV, SoDT, NgVL, ChucVu, DiaChi, email, gioitinh, Image });
        }

        public void EditEmployee(string MaNV, string TenNV, string SoDT, DateTime NgVL, string ChucVu, string DiaChi, string email, string gioitinh, byte[] Image)
        {
            /*string query = string.Format("update NHANVIEN set TENNV = '{0}', SODT = '{1}', NGVL = '{2}', CHUCVU = '{3}', DIACHI = '{4}', " +
                "EMAIL = '{5}', GIOITINH = '{6}', LinkImage = '{7}' where MANV = '{8}'", TenNV, SoDT, NgVL, ChucVu, DiaChi, email, gioitinh, Image, MaNV);
            DataProvider.Instance.ExecuteQuery(query);*/
            DataProvider.Instance.ExecuteQuery("USP_EditEmployee @MANV , @TENNV , @SODT , @NgVL , @ChucVu , @DiaChi , @Email , @GioiTinh , @LinkImage ",
                new object[] { MaNV, TenNV, SoDT, NgVL, ChucVu, DiaChi, email, gioitinh, Image });
        }

        public int GetStaffIDbyUsername(string username)
        {
            string query = string.Format("SELECT * FROM NHANVIEN WHERE MANV = '{0}'", username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                EmployeeDTO staff = new EmployeeDTO(data.Rows[0]);

                return int.Parse(staff.MaNV1);
            }

            return -1;
        }
    }
}
