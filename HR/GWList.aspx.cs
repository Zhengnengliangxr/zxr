using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class GWList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //最新
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon.Open();
        SqlDataAdapter adsa = new SqlDataAdapter("select top 5 ID, GW_name,GW_xinzi,GW_content,GW_date from GangWei   order by ID desc", sqlcon);
        DataSet adds = new DataSet();
        adsa.Fill(adds);
        this.DataList1.DataSource = adds;
        this.DataList1.DataBind();
        sqlcon.Close();
    }
}