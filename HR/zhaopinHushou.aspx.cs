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

public partial class zhaopinHushou : System.Web.UI.Page
{
  
 protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadDatas();
            Button1.Attributes.Add("onclick", "JavaScript:return confirm('确定要清空回收站？')");
        }
    }

    private void LoadDatas()
    {
        SqlConnection sqlcon3 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon3.Open();
        SqlDataAdapter adsa3 = new SqlDataAdapter("select * from huishouJianLi order by ID desc", sqlcon3);
        DataSet adds3 = new DataSet();
        adsa3.Fill(adds3);
        GridView1.DataSource = adds3;
        GridView1.DataKeyNames = new string[] { "ID" };
        GridView1.DataBind();
        sqlcon3.Close();         //绑定数据
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        // 跳转到详细信息描述页面当中
        //  LoadDatas();
        // Session["mids"] = GridView1.Rows[e.NewSelectedIndex].Cells[0].Text;//第一个单元格里的内容
        //  Response.Redirect("XZgonggaoEdit.aspx");  //会考的这一类
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        LoadDatas();
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //如果是绑定数据行 
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[7].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除吗?')");
            }
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon.Open();
        SqlCommand sqlcom;
        
        string sqlstr = "delete from huishouJianLi where ID='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        sqlcom = new SqlCommand(sqlstr, sqlcon);
        sqlcom.ExecuteNonQuery();    
        sqlcon.Close();
        LoadDatas();

        //删除服务器文件
        SqlConnection sqlcon2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon2.Open();
        SqlCommand sqlcom2;
        string wenjianName = "select JL_fujian from  huishouJianLi where ID='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        sqlcom2 = new SqlCommand(wenjianName, sqlcon2);
        SqlDataReader dr = sqlcom2.ExecuteReader();
        if (dr.Read())
        {
            string fileName = (string)dr.GetValue(5);
            Response.Write(fileName);     // 获取路径并且删除
            string FilePath = Server.MapPath("resume/" + fileName);// 必须转化以下文件路径，不能直接delete("image/4jpg"); 
            System.IO.File.Delete(FilePath);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon.Open();
        SqlCommand sqlcom;
        string sqlstr = "truncate table huishouJianLi";
        sqlcom = new SqlCommand(sqlstr, sqlcon);
        sqlcom.ExecuteNonQuery();
        sqlcon.Close();
        LoadDatas();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}