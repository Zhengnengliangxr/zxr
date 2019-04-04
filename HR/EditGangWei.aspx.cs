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

public partial class EditGangWei : System.Web.UI.Page
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
                string strselect = "select * from GangWei where ID='" + Session["mids"].ToString() + "'";
                SqlCommand sqlcmd = new SqlCommand(strselect, sqlcon);
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {

                    TextBox1.Text = dr["GW_name"].ToString();
                    TextBox2.Text = dr["GW_bumen"].ToString();
                    TextBox3.Text = dr["GW_xinzi"].ToString();
                    TextBox4.Text = dr["GW_content"].ToString();
                   
                    DropDownList1.SelectedValue = dr["GW_xueli"].ToString();
                    DropDownList2.SelectedValue = dr["GW_jingyan"].ToString();
                    DropDownList3.SelectedValue = dr["GW_leixing"].ToString();
                   
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

            StrSqls = "update GangWei set GW_name='" + TextBox1.Text + "',GW_bumen='" + TextBox2.Text + "',GW_xinzi='" + TextBox3.Text + "',GW_content='" + TextBox4.Text + "',GW_xueli='" + DropDownList1.SelectedValue + "',GW_jingyan='" + DropDownList2.SelectedValue + "' ,GW_leixing='" + DropDownList3.SelectedValue + "' where ID=" + Session["mids"].ToString() + "";

            SqlCommand cmd = new SqlCommand(StrSqls, sqlcon1);
            //添加参数并且设置参数值
            cmd.ExecuteNonQuery();
            sqlcon1.Close();
            this.Page.RegisterStartupScript("ss", "<script>alert('信息已经成功修改!')</script>");

        }
        catch (Exception ex) { }
    }

}
