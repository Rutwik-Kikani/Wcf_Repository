﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlDataAdapterDemo
{
    public partial class Sql_QueryWithParamDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                //Create instance of dataAdapter 
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT NAME,QTYAVAILABLE FROM TBLPRODUCTINVENTORY" +
                                                            " WHERE PRODUCTID LIKE @PID", con);
                // Specify the command type is an SP
                adapter.SelectCommand.Parameters.AddWithValue("@PID", 2);

                //Create instance of DataSet for storing result in memory
                DataSet dataSet = new DataSet();
                //call fill() which automatically open connection and execute query and close connection
                adapter.Fill(dataSet);

                ProductsGridView.DataSource = dataSet;
                ProductsGridView.DataBind();

            }
        }
    }
}