using BusinessObject;
using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Email, CompanyName, City, Country, Password from Member";
            var members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        Email = dataReader.GetString(dataReader.GetOrdinal("Email")),
                        CompanyName = dataReader.GetString(dataReader.GetOrdinal("CompanyName")),
                        City = dataReader.GetString(dataReader.GetOrdinal("City")),
                        Country = dataReader.GetString(dataReader.GetOrdinal("Country")),
                        Password = dataReader.GetString(dataReader.GetOrdinal("Password"))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
        public MemberObject GetMemberByID(int MemberId)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Email, CompanyName, City, Country, Password from Member where MemberId = @MemberId";
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, MemberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        Email = dataReader.GetString(dataReader.GetOrdinal("Email")),
                        CompanyName = dataReader.GetString(dataReader.GetOrdinal("CompanyName")),
                        City = dataReader.GetString(dataReader.GetOrdinal("City")),
                        Country = dataReader.GetString(dataReader.GetOrdinal("Country")),
                        Password = dataReader.GetString(dataReader.GetOrdinal("Password"))
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
        public void AddNew(MemberObject member)
        {
            try
            {
                MemberObject pro = GetMemberByID(member.MemberId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Member values(@MemberId, @Email, @CompanyName, @City, @Country, @Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 15, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 15, member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(MemberObject member)
        {
            try
            {
                MemberObject c = GetMemberByID(member.MemberId);
                if (c != null)
                {
                    string SQLUpdate = "Update Member set Email = @Email, CompanyName = @CompanyName, " +
                        "City = @City, Country = @Country, Password = @Password  where MemberId = @MemberId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 15, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 15, member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int MemberId)
        {
            try
            {
                MemberObject member = GetMemberByID(MemberId);
                if (member != null)
                {
                    string SQLDelete = "Delete Member where MemberId = @MemberId";
                    var param = dataProvider.CreateParameter("@MemberId", 4, MemberId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<MemberObject> GetMemberBySearch(string search, string keyword)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Member WHERE " + search + " LIKE @keyword";
            var members = new List<MemberObject>();
            try
            {
                var param = dataProvider.CreateParameter("@keyword", 20, "%" + keyword + "%", DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        Email = dataReader.GetString(dataReader.GetOrdinal("Email")),
                        CompanyName = dataReader.GetString(dataReader.GetOrdinal("CompanyName")),
                        City = dataReader.GetString(dataReader.GetOrdinal("City")),
                        Country = dataReader.GetString(dataReader.GetOrdinal("Country")),
                        Password = dataReader.GetString(dataReader.GetOrdinal("Password"))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }

        public List<MemberObject> GetMemberByFilter(string filter, string location)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Member WHERE " + filter + " LIKE @location";
            var members = new List<MemberObject>();
            try
            {
                var param = dataProvider.CreateParameter("@location", 20, "%" + location + "%", DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        Email = dataReader.GetString(dataReader.GetOrdinal("Email")),
                        CompanyName = dataReader.GetString(dataReader.GetOrdinal("CompanyName")),
                        City = dataReader.GetString(dataReader.GetOrdinal("City")),
                        Country = dataReader.GetString(dataReader.GetOrdinal("Country")),
                        Password = dataReader.GetString(dataReader.GetOrdinal("Password"))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }

        public List<MemberObject> GetMemberByDescending()
        {
            List<MemberObject> list = GetMemberList().OrderByDescending(x => x.MemberId).ToList();
            return list;
        }

        public List<MemberObject> GetMemberByAscending()
        {
            List<MemberObject> list = GetMemberList().OrderBy(x => x.MemberId).ToList();
            return list;
        }

        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        {
            MemberObject member = GetMemberList().Where(x => x.Email.Equals(email) && x.Password.Equals(password)).FirstOrDefault();
            return member;
        }
    }
}
