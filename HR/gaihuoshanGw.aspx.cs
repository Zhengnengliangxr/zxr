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


public partial class gaihuoshanGw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadDatas();
            Button2.Attributes.Add("onclick", "JavaScript:return confirm('确定要批量删除？')");
        }
    }

    private void LoadDatas()
    {
        SqlConnection sqlcon3 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon3.Open();
        SqlDataAdapter adsa3 = new SqlDataAdapter("select * from GangWei order by ID desc", sqlcon3);
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
        Response.Redirect("EditGangWei.aspx");  //会考的这一类
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
     //   GridView1.PageIndex = e.NewPageIndex;
     //   LoadDatas();

        GridView theGrid = sender as GridView;
        int newPageIndex = 0;
        if (e.NewPageIndex == -3)
        {
            //点击了Go按钮
            TextBox txtNewPageIndex = null;

            //GridView较DataGrid提供了更多的API，获取分页块可以使用BottomPagerRow 或者TopPagerRow，当然还增加了HeaderRow和FooterRow
            GridViewRow pagerRow = theGrid.BottomPagerRow;

            if (pagerRow != null)
            {
                //得到text控件
                txtNewPageIndex = pagerRow.FindControl("txtNewPageIndex") as TextBox;
            }
            if (txtNewPageIndex != null)
            {
                //得到索引
                newPageIndex = int.Parse(txtNewPageIndex.Text) - 1;
            }
        }
        else
        {
            //点击了其他的按钮
            newPageIndex = e.NewPageIndex;
        }
        //防止新索引溢出
        newPageIndex = newPageIndex < 0 ? 0 : newPageIndex;
        newPageIndex = newPageIndex >= theGrid.PageCount ? theGrid.PageCount - 1 : newPageIndex;

        //得到新的值
        theGrid.PageIndex = newPageIndex;

        //重新绑定
        //    InitGridView();
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
                ((LinkButton)e.Row.Cells[6].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除吗?')");
            }
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        sqlcon.Open();
        SqlCommand sqlcom;
        string sqlstr = "delete from GangWei where ID='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        sqlcom = new SqlCommand(sqlstr, sqlcon);
        sqlcom.ExecuteNonQuery();
        sqlcon.Close();
        LoadDatas();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }



    protected void CheckBox2_CheckedChanged(object sender, EventArgs e) {
        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (CheckBox2.Checked == true) {
                cbox.Checked = true;
            } else
            {
                cbox.Checked = false;
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e) {
        CheckBox2.Checked = false;
        for (int i = 0; i <= GridView1.Rows.Count - 1; i++) {
            CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            cbox.Checked = false;
        }
    }

    protected void Button2_Click(object sender, EventArgs e) {
        /*   sqlcon = new SqlConnection(strCon);
           SqlCommand sqlcom;
           for (int i = 0; i <= GridView1.Rows.Count - 1; i++) {
               CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
               if (cbox.Checked == true) {
                   string sqlstr = "delete from 飞狐工作室 where 身份证号码='" + GridView1.DataKeys[i].Value + "'";
                   sqlcom = new SqlCommand(sqlstr, sqlcon);
                   sqlcon.Open();
                   sqlcom.ExecuteNonQuery();
                   sqlcon.Close();
               }
           }
           bind();*/


        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
       
        SqlCommand sqlcom;

        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (cbox.Checked == true)
            {
                string sqlstr = "delete from GangWei where ID='" + GridView1.DataKeys[i].Value.ToString() + "'";
                sqlcom = new SqlCommand(sqlstr, sqlcon);
                sqlcon.Open();
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        LoadDatas();







    }


    }

