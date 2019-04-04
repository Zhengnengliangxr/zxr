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

public partial class addGangwei : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon.Open();

        string strselect = "select * from GangWei where GW_name=@GW_name  and GW_bumen=@GW_bumen  and GW_xinzi=@GW_xinzi and GW_xueli=@GW_xueli and GW_jingyan=@GW_jingyan and GW_leixing=@GW_leixing and GW_content=@GW_content ";
        SqlCommand sqlcmd = new SqlCommand(strselect, sqlcon);
        string StrInsert = "";
        // 添加参数并且设置参数的值
         sqlcmd.Parameters.Add("@GW_name", SqlDbType.VarChar);
         sqlcmd.Parameters["@GW_name"].Value = this.TextBox1.Text.ToString();

        sqlcmd.Parameters.Add("@GW_bumen", SqlDbType.VarChar);
        sqlcmd.Parameters["@GW_bumen"].Value = this.TextBox2.Text.ToString();

        sqlcmd.Parameters.Add("@GW_xinzi", SqlDbType.VarChar);
        sqlcmd.Parameters["@GW_xinzi"].Value = this.TextBox3.Text.ToString();

        sqlcmd.Parameters.Add("@GW_xueli", SqlDbType.VarChar);
        sqlcmd.Parameters["@GW_xueli"].Value = this.DropDownList1.SelectedValue.ToString();

        sqlcmd.Parameters.Add("@GW_jingyan", SqlDbType.VarChar);
        sqlcmd.Parameters["@GW_jingyan"].Value = this.DropDownList2.SelectedValue.ToString();

        sqlcmd.Parameters.Add("@GW_leixing", SqlDbType.VarChar);
        sqlcmd.Parameters["@GW_leixing"].Value = this.DropDownList3.SelectedValue.ToString();

        sqlcmd.Parameters.Add("@GW_content", SqlDbType.VarChar);
        sqlcmd.Parameters["@GW_content"].Value = this.TextBox4.Text.ToString();

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
        String StrInsert1 = "insert into GangWei(GW_name,GW_bumen,GW_xinzi,GW_xueli,GW_jingyan,GW_leixing,GW_content,GW_date) values(@GW_name,@GW_bumen,@GW_xinzi,@GW_xueli,@GW_jingyan,@GW_leixing,@GW_content,@GW_date)";
        SqlCommand cmd = new SqlCommand(StrInsert1, sqlcon);
        // 添加参数并且设置参数值
        cmd.Parameters.Add("@GW_name", SqlDbType.VarChar);
        cmd.Parameters["@GW_name"].Value = this.TextBox1.Text.ToString();

        cmd.Parameters.Add("@GW_bumen", SqlDbType.VarChar);
        cmd.Parameters["@GW_bumen"].Value = this.TextBox2.Text.ToString();

        cmd.Parameters.Add("@GW_xinzi", SqlDbType.VarChar);
        cmd.Parameters["@GW_xinzi"].Value = this.TextBox3.Text.ToString();

        cmd.Parameters.Add("@GW_xueli", SqlDbType.VarChar);
        cmd.Parameters["@GW_xueli"].Value = this.DropDownList1.SelectedValue.ToString();

        cmd.Parameters.Add("@GW_jingyan", SqlDbType.VarChar);
        cmd.Parameters["@GW_jingyan"].Value = this.DropDownList2.SelectedValue.ToString();

        cmd.Parameters.Add("@GW_leixing", SqlDbType.VarChar);
        cmd.Parameters["@GW_leixing"].Value = this.DropDownList3.SelectedValue.ToString();

        cmd.Parameters.Add("@GW_content", SqlDbType.VarChar);
        cmd.Parameters["@GW_content"].Value = this.TextBox4.Text.ToString();

        cmd.Parameters.Add("@GW_date", SqlDbType.VarChar, 50);
        cmd.Parameters["@GW_date"].Value = DateTime.Now.ToShortDateString().ToString();
        // 执行插入数据的操作
        cmd.ExecuteNonQuery();
        sqlcon.Close();
        this.Page.RegisterStartupScript("ss", "<script>alert('发布成功!')</script>");

        //重置数据



    }





}
