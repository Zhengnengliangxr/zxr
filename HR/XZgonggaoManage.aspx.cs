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

public partial class XZgonggaoManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadDatas();
        }
    }

    private void LoadDatas()
    {
        SqlConnection sqlcon3 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon3.Open();
        SqlDataAdapter adsa3 = new SqlDataAdapter("select * from GongGao order by ID desc", sqlcon3);
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
        LoadDatas();
        Session["mids"] = GridView1.Rows[e.NewSelectedIndex].Cells[0].Text;//第一个单元格里的内容
        Response.Redirect("XZgonggaoEdit.aspx");  //会考的这一类
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
                ((LinkButton)e.Row.Cells[4].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除吗?')");
            }
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon.Open();
        SqlCommand sqlcom;
        string sqlstr = "delete from GongGao where ID='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        sqlcom = new SqlCommand(sqlstr, sqlcon);
        sqlcom.ExecuteNonQuery();
        sqlcon.Close();
        LoadDatas();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}
