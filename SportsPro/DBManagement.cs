using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SportsPro
{
    public class DBManagement
    {
        public static DataSet getAllCustomers()
        {
            string tsConnStr = System.Configuration.ConfigurationManager.
                ConnectionStrings["TechSupportConnectionString"].ConnectionString;

            string query = "SELECT * FROM Customers ORDER BY Name";

            //Open MySQL Connection by this connection string.
            SqlConnection con = new SqlConnection(tsConnStr);

            //Create a empty dataset.
            DataSet ds = new DataSet();

            //Avoid the unwanted crash use try/catch.
            try
            {
                //Craete adapter object by connecttion and query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

                //Create command builder object by adapter.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                //Open connection.
                con.Open();

                //Fill dataset by database data.
                dataAdapter.Fill(ds);

                //Return dataset.
                return ds;
            }
            catch (Exception ex)
            {
                //If any exception occured then empty dataset return.
                return ds;
            }
            finally
            {
                //If all done then close the database connection for secure use.
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public static Customer getCustomerByID(int CID)
        {
            string tsConnStr = System.Configuration.ConfigurationManager.
                ConnectionStrings["TechSupportConnectionString"].ConnectionString;

            string query = "SELECT * FROM Customers WHERE CustomerID = " + CID;

            Customer objCust = null;

            SqlConnection mySqlConn = new SqlConnection(tsConnStr);
            try
            {
                SqlCommand mySqlComm = new SqlCommand();
                mySqlComm = mySqlConn.CreateCommand();
                mySqlComm.CommandText = query;
                mySqlConn.Open();

                SqlDataReader reader = mySqlComm.ExecuteReader(CommandBehavior.SingleRow);

                while (reader.Read())
                {
                    objCust = new Customer();
                    //Load all column into customer object.
                    objCust.CustomerID = Convert.ToInt32(reader.GetValue(0).ToString());
                    objCust.Name = reader.GetString(1);
                    objCust.Address = reader.GetString(2);
                    objCust.City = reader.GetString(3);
                    objCust.State = reader.GetString(4);
                    objCust.ZipCode = reader.GetString(5);
                    objCust.Phone = reader.GetString(6);
                    objCust.Email = reader.GetString(7);
                }
                return objCust;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (mySqlConn.State == System.Data.ConnectionState.Open)
                    mySqlConn.Close();
            }
        }

        public static List<Incident> getIncidentByCustID(int CID)
        {
            string tsConnStr = System.Configuration.ConfigurationManager.
                ConnectionStrings["TechSupportConnectionString"].ConnectionString;

            string query = "SELECT * FROM Incidents WHERE ISDATE(DateClosed) = 1 AND CustomerID = " + CID + " ORDER BY DateClosed";
            //string query = "SELECT * FROM Incidents WHERE ISDATE(DateClosed) = 1 ORDER BY DateClosed";

            List<Incident> objIncidentList = new List<Incident>();

            SqlConnection mySqlConn = new SqlConnection(tsConnStr);
            try
            {
                SqlCommand mySqlComm = new SqlCommand();
                mySqlComm = mySqlConn.CreateCommand();
                mySqlComm.CommandText = query;
                mySqlConn.Open();

                SqlDataReader reader = mySqlComm.ExecuteReader();

                while (reader.Read())
                {
                    Incident objIncident = new Incident();
                    //Load all column into incident object.
                    objIncident.IncidentID = Convert.ToInt32(reader.GetValue(0).ToString());
                    objIncident.CustomerID = Convert.ToInt32(reader.GetValue(1).ToString());
                    objIncident.ProductCode = reader.GetString(2);
                    objIncident.TechID = Convert.ToInt32(reader.GetValue(3).ToString());
                    objIncident.DateOpened = Convert.ToDateTime(reader.GetValue(4).ToString());
                    objIncident.DateClosed = Convert.ToDateTime(reader.GetValue(5).ToString());
                    objIncident.Title = reader.GetString(6);
                    objIncident.Description = reader.GetString(7);
                    objIncident.ResolutionNotes = reader.GetValue(8).ToString();

                    objIncidentList.Add(objIncident);
                }
                return objIncidentList;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (mySqlConn.State == System.Data.ConnectionState.Open)
                    mySqlConn.Close();
            }
        }
    }
}