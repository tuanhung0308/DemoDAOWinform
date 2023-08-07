using DemoWinformDAO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWinformDAO.DAO
{
    internal class EmployeeDAO
    {

        public static List<Employee> getListEmployee()
        {
            string sql = "select * from Employees";
            DataTable dt = DAO.GetDataBySQl(sql);
            List<Employee> employees= new List<Employee>();

            foreach (DataRow dr in dt.Rows)
            {
                Employee emp = new Employee();
                emp.EmployeeId = int.Parse(dr["EmployeeID"].ToString());
                emp.LastName = dr["LastName"].ToString();
                emp.FirstName = dr["FirstName"].ToString();
                emp.Title = dr["Title"].ToString();
                emp.TitleOfCourtesy = dr["TitleOfCourtesy"].ToString();
                emp.BirthDate =  DateTime.Parse(dr["BirthDate"].ToString());

                employees.Add(emp);

                
            }
            return employees;
        }

            //tra ve so dong dươc insert vao
            public static int insertEmployee(Employee e)
            {
                string sql = @"INSERT INTO [Employees]
               (
		        [LastName]
               ,[FirstName]
               ,[Title]
               ,[TitleOfCourtesy]
               ,[BirthDate])
           
                VALUES 
                 (@lastname ,@firstname,@title,@courtesy, @date)";

                SqlParameter para2 = new SqlParameter("@lastname", DbType.String);
                para2.Value = e.LastName;
                SqlParameter para3 = new SqlParameter("@firstname", DbType.String);
                para3.Value = e.FirstName;
                SqlParameter para4 = new SqlParameter("@title", DbType.String);
                para4.Value = e.Title;
                SqlParameter para5 = new SqlParameter("@courtesy", DbType.String);
                para5.Value = e.TitleOfCourtesy;
                SqlParameter para6 = new SqlParameter("@date", DbType.DateTime);
                para6.Value = e.BirthDate;
                return DAO.ExecuteSql(sql, para2, para3, para4,para5,para6);
            }


    }
}
