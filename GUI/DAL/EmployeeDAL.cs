﻿    using System;
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

        public void AddEmployee(string MaNV,string TenNV,string SoDT,DateTime NgVL,string ChucVu,string DiaChi,string email, string gioitinh)
        {
            string query = string.Format("insert into NHANVIEN (MANV,TENNV,SODT,NGVL,CHUCVU,DIACHI,EMAIL,GIOITINH) " +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", MaNV,TenNV,SoDT,NgVL,ChucVu,DiaChi,email,gioitinh);

            DataProvider.Instance.ExecuteQuery(query);
        }

        public void EditEmployee(string MaNV, string TenNV, string SoDT, DateTime NgVL, string ChucVu, string DiaChi, string email, string gioitinh)
        {
            string query = string.Format("update NHANVIEN set TENNV = '{0}', SODT = '{1}', NGVL = '{2}', CHUCVU = '{3}', DIACHI = '{4}', " +
                "EMAIL = '{5}', GIOITINH = '{6}' where MANV = '{7}'", TenNV, SoDT, NgVL, ChucVu, DiaChi, email, gioitinh, MaNV);
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
