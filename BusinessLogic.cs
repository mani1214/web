using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication9
{
    public class BusinessLogic
    {
        SqlConnection con; //Non Static Members (declaring globally)
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public BusinessLogic()// Basic Configuration
        {
            string vani = @"Data Source=OJAS-DD64\SQLEXPRESS;Initial Catalog=AppDB;Persist Security Info=True;User ID=sa;Password=Ojas@15251525";
            con = new SqlConnection(vani); 
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        }
        public bool AddEmployee(int eid, string ename, int esal) // Inserting the details
        {
            cmd.CommandText = String.Format($"insert into emptable values({eid},'{ename}',{esal})");  // Works with Query
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val==1;
        }
        public bool DelEmployee(int eid) // Deleting the details
        {
            cmd.CommandText = string.Format($"delete from emptable where eid = {eid}");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }
        public bool UpdateEmployee(int eid, string ename, int esal) //Updating the details
        {

            cmd.CommandText = string.Format($"update emptable set ename = {ename},esal={esal} where eid = {eid}");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }

        public DataTable ShowEmployees() // Showing the details
        {
            cmd.CommandText = "select * from emptable";
            con.Open();
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;

        }
        public string[] GetEmplyeeById(int id)
        {
            string[] res = new string[3];
            cmd.CommandText = string.Format($"select * from emptable where eid = {id}");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                res[0] = dr[0].ToString();
                res[1] = dr[1].ToString();
                res[2] = dr[2].ToString();
            }
            con.Close();
            return res;

        }
    }
}