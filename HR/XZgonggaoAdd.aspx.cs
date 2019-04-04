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


public partial class XZgonggaoAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon.Open();

        string strselect = "select * from GongGao where GG_title=@GG_title  and GG_person=@GG_person  and GG_content=@GG_content";
        SqlCommand sqlcmd = new SqlCommand(strselect, sqlcon);
        string StrInsert = "";
        // 添加参数并且设置参数的值
        sqlcmd.Parameters.Add("@GG_title", SqlDbType.VarChar);
        sqlcmd.Parameters["@GG_title"].Value = this.TextBox1.Text.ToString();

        sqlcmd.Parameters.Add("@GG_person", SqlDbType.VarChar);
        sqlcmd.Parameters["@GG_person"].Value = this.TextBox2.Text.ToString();

        sqlcmd.Parameters.Add("@GG_content", SqlDbType.VarChar);
        sqlcmd.Parameters["@GG_content"].Value = this.TextBox3.Text.ToString();

       

        //  执行查询，判断保存的数据记录是否存在
        SqlDataReader dr = sqlcmd.ExecuteReader();
        if (dr.Read())
        {
            this.Page.RegisterStartupScript("ss", "<script>alert('信息已经提交,请不要重复提交信息!')</script>");
            return;
        }
        // 关闭读操作
        dr.Close();
        // 插入数据信息
        String StrInsert1 = "insert into GongGao(GG_title,GG_person,GG_content,GG_date) values(@GG_title,@GG_person,@GG_content,@GG_date)";
        SqlCommand cmd = new SqlCommand(StrInsert1, sqlcon);
        // 添加参数并且设置参数值
        cmd.Parameters.Add("@GG_title", SqlDbType.VarChar);
        cmd.Parameters["@GG_title"].Value = this.TextBox1.Text.ToString();

        cmd.Parameters.Add("@GG_person", SqlDbType.VarChar);
        cmd.Parameters["@GG_person"].Value = this.TextBox2.Text.ToString();

        cmd.Parameters.Add("@GG_content", SqlDbType.VarChar);
        cmd.Parameters["@GG_content"].Value = this.TextBox3.Text.ToString();

     

        cmd.Parameters.Add("@GG_date", SqlDbType.VarChar, 50);
        cmd.Parameters["@GG_date"].Value = DateTime.Now.ToString();
        // 执行插入数据的操作
        cmd.ExecuteNonQuery();
        sqlcon.Close();
        this.Page.RegisterStartupScript("ss", "<script>alert('发布成功!')</script>");

        //重置数据



    }





}
