using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class XZgonggaoEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Button1.Attributes.Add("onclick", "return confirm('您确认要修改该数据信息吗？');");//怎样给一个按钮添加对话框


        if (!IsPostBack)
        {
            if (Session["mids"] != null)
            {
                // 连接数据库
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                sqlcon.Open();
                string strselect = "select * from GongGao where ID='" + Session["mids"].ToString() + "'";
                SqlCommand sqlcmd = new SqlCommand(strselect, sqlcon);
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {

                    TextBox1.Text = dr["GG_title"].ToString();
                    TextBox2.Text = dr["GG_person"].ToString();
                    TextBox3.Text = dr["GG_content"].ToString();
                    

                }
                dr.Close();
                sqlcon.Close();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            //连接数据库
            SqlConnection sqlcon1 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            sqlcon1.Open();

            //修改数据信息
            string StrSqls = "";

            StrSqls = "update GongGao set GG_title='" + TextBox1.Text + "',GG_person='" + TextBox2.Text + "',GG_content='" + TextBox3.Text + "' where ID=" + Session["mids"].ToString() + "";

            SqlCommand cmd = new SqlCommand(StrSqls, sqlcon1);
            //添加参数并且设置参数值
            cmd.ExecuteNonQuery();
            sqlcon1.Close();
            this.Page.RegisterStartupScript("ss", "<script>alert('信息已经成功修改!')</script>");

        }
        catch (Exception ex) { }
    }

}
