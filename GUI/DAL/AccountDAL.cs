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
    public class AccountDAL
    {

        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { AccountDAL.instance = value; }
        }

        private AccountDAL() { }

        public List<AccountDTO> GetAccount()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();

            string query = "SELECT * FROM ACCOUNT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accounts.Add(account);
            }

            return accounts;
        }

        public bool LoginAdmin(string userName, string passWord)
        {
            //passWord = Encryptor.Instance.Encrypt(passWord);

            string query = "SELECT * FROM ACCOUNT WHERE MANV = '" + userName + "' AND MATKHAU = '" + passWord + "' AND Type = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool LoginStaff(string userName, string passWord)
        {
            //passWord = Encryptor.Instance.Encrypt(passWord);

            string query = "SELECT * FROM ACCOUNT WHERE MANV = '" + userName + "' AND MATKHAU = '" + passWord + "' AND Type = 2";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool Login(string username, string password)
        {
            ///password = Encryptor.Instance.Encrypt(password);

            string query = "SELECT * FROM ACCOUNT WHERE MANV = '" + username + "' AND MATKHAU = '" + password + "'" ;

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public void changePassword(string username, string password)
        {
            //password = Encryptor.Instance.Encrypt(password);
            DataProvider.Instance.ExecuteQuery(string.Format("UPDATE ACCOUNT SET MATKHAU = '{0}' WHERE MANV = '{1}' ", password, username));
        }

        public void deleteAccount(string username)
        {
            string query = string.Format("delete from ACCOUNT where MANV = '{0}'", username);

            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool addAccount (string username, string password, int type)
        {
            //password = Encryptor.Instance.Encrypt(password);

            try
            {
                string query= string.Format("insert into ACCOUNT (MANV,MATKHAU,Type) values ('{0}','{1}','{2}')", username, password, type);
                return DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
