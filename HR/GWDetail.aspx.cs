using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GWDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

        //显示商品详细信息
        string id = Request["t_id"].ToString();
        SqlDataAdapter adsa = new SqlDataAdapter("select * from GangWei where ID='" + id + "'", sqlcon);
        DataSet adds = new DataSet();
        adsa.Fill(adds);
        this.DataList1.DataSource = adds;
        this.DataList1.DataBind();

        sqlcon.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("yingpin.aspx");
    }

}