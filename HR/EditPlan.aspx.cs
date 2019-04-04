using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class EditPlan : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["SelectDateTime"] != null)
            {
                Label1.Text = Session["SelectDateTime"].ToString();
                Session.Remove("SelectDateTime");
            }
            else
            {
                Response.Write("<script>alert('你没有选中日期');window.close();</script>");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e) {
      /*  SqlHelp sql = new SqlHelp();
        string remind = string.Empty;
        if (CheckBox_Remind.Checked)
        {
            remind = "true";
        }
        else
        {
            remind = "false";
        }
        string strfac = "insert into Rex_Test2(MemorandumTitle,MemorandumContent,Owner,DueTime,Remind,CreateTime) values('" + tb_title.Text.ToString() + "','" + tb_content.Text.ToString() + "','" + Session["LoginID"] + "','" + Label1.Text.ToString() + "','" + remind + "','" + DateTime.Now.ToString() + "')";
        bool flag = sql.ExecuteNonQuery(strfac); sql.SqlClose();
        if (flag)
        {
            Response.Write("<script>alert('该备忘录新建成功！');window.close();</script>");
        }
        else
        {
            Response.Write("<script>alert('该备忘录新建失败！');window.close();</script>");
        }*/
    }
}
