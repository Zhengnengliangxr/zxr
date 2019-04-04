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

public partial class wanshanInfor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string FilePath = "";                         //上传图片
        //是否有上传文件
        if (this.FileUpload1.FileName == null && this.FileUpload1.FileName == "")
        {
            Page.RegisterStartupScript("ss", "<script>alert('上传照片不能为空!')");
        }
        else
        {
            if (FileUpload1.PostedFile.ContentLength <= 0)
            {
                Page.RegisterStartupScript("ss", "<script>alert('上传图片为空文件，请重新选择!')</script>");
                return;
            }
            else
            { }
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentLength > 4196304)//单位字节，大于4MB
                {
                    Page.RegisterStartupScript("ss", "<script>alert('上传文件过大!')</script>");
                    return;
                }
                else
                {
                    FilePath = Server.MapPath("~/img");//  MapPath获取括号里文件夹的物理路径
                    Session["FilePaths"] = "img\\" + FileUpload1.FileName;
                }
                UpLoad(FilePath, this.FileUpload1);

                if (TextBox1.Text == "" || TextBox3.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox9.Text == "" || TextBox10.Text == "" || TextBox11.Text == "" || TextBox12.Text == "" || TextBox13.Text == "")
                {
                    this.Page.RegisterStartupScript("ss", "<script>alert('必填内容不能为空!')</script>");
                    return;
                }
                else
                {
                    SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                    sqlcon.Open();

                    string strselect = "select * from staff  where emp_name=@emp_name and emp_zjnum=@emp_zjnum  and emp_img=@emp_img";
                    SqlCommand sqlcmd = new SqlCommand(strselect, sqlcon);
                    string StrInsert = "";
                    // 添加参数并且设置参数的值
                    sqlcmd.Parameters.Add("@emp_name", SqlDbType.VarChar);
                    sqlcmd.Parameters["@emp_name"].Value = this.TextBox1.Text.ToString();

                    sqlcmd.Parameters.Add("@emp_zjnum", SqlDbType.VarChar);
                    sqlcmd.Parameters["@emp_zjnum"].Value = this.TextBox9.Text.ToString();

                    sqlcmd.Parameters.Add("@emp_img", SqlDbType.VarChar);
                    sqlcmd.Parameters["@emp_img"].Value = Session["FilePaths"].ToString();

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
                    String StrInsert1 = "insert into staff(emp_name,emp_sex,emp_birth,emp_marry,emp_minzu,emp_zhengzhi,emp_country,emp_zhengjian,emp_zjnum,emp_phone,emp_address,emp_jinji,emp_jjnum,emp_img) values(@emp_name,@emp_sex,@emp_birth,@emp_marry,@emp_minzu,@emp_zhengzhi,@emp_country,@emp_zhengjian,@emp_zjnum,@emp_phone,@emp_address,@emp_jinji,@emp_jjnum,@emp_img)";
                    SqlCommand cmd = new SqlCommand(StrInsert1, sqlcon);
                    // 添加参数并且设置参数值
                    cmd.Parameters.Add("@emp_name", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_name"].Value = this.TextBox1.Text.ToString();

                    cmd.Parameters.Add("@emp_birth", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_birth"].Value = this.TextBox3.Text.ToString();

                    string sex = "";
                    if (RadioButton1.Checked)
                    {
                        sex = "男";
                    }
                    else if (RadioButton2.Checked)
                    {
                        sex = "女";
                    }
                    cmd.Parameters.Add("@emp_sex", SqlDbType.VarChar);
                    cmd.Parameters["@emp_sex"].Value = sex;

                    string hun = "";
                    if (RadioButton1.Checked)
                    {
                        hun = "未婚";
                    }
                    else if (RadioButton2.Checked)
                    {
                        hun = "已婚";
                    }
                    cmd.Parameters.Add("@emp_marry", SqlDbType.VarChar);
                    cmd.Parameters["@emp_marry"].Value = hun;

                    cmd.Parameters.Add("@emp_minzu", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_minzu"].Value = this.TextBox5.Text.ToString();

                    cmd.Parameters.Add("@emp_zhengzhi", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_zhengzhi"].Value = this.TextBox6.Text.ToString();

                    cmd.Parameters.Add("@emp_country", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_country"].Value = this.TextBox7.Text.ToString();

                    cmd.Parameters.Add("@emp_zhengjian", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_zhengjian"].Value = this.DropDownList1.SelectedValue.ToString();

                    cmd.Parameters.Add("@emp_zjnum", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_zjnum"].Value = this.TextBox9.Text.ToString();

                    cmd.Parameters.Add("@emp_phone", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_phone"].Value = this.TextBox10.Text.ToString();

                    cmd.Parameters.Add("@emp_address", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_address"].Value = this.TextBox11.Text.ToString();

                    cmd.Parameters.Add("@emp_jinji", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_jinji"].Value = this.TextBox12.Text.ToString();

                    cmd.Parameters.Add("@emp_jjnum", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_jjnum"].Value = this.TextBox13.Text.ToString();

                    cmd.Parameters.Add("@emp_img", SqlDbType.VarChar, 50);
                    cmd.Parameters["@emp_img"].Value = Session["FilePaths"].ToString();

                    
                    // 执行插入数据的操作
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    this.Page.RegisterStartupScript("ss", "<script>alert('发布成功!')</script>");

                    //重置数据
                    


                }

            }

            else
            {
                Page.RegisterStartupScript("ss", "<script>alert('文件上传错误!')</script>");
                return;
            }
        }
    }













    public void UpLoad(string path, System.Web.UI.WebControls.FileUpload fileupload)
    {
        bool fileOK = false;

        if (fileupload.HasFile)
        {
            string fileException = System.IO.Path.GetExtension(fileupload.FileName).ToLower();
            string[] allowedException = { ".xls", ".doc", ".mpp", ".rar", ".zip", ".vsd", ".txt", ".jpg", ".gif", ".bmp", ".png", ".swf", ".avi", ".mp3", ".rm", ".wma", ".wmv" };
            for (int i = 0; i < allowedException.Length; i++)
            {
                if (fileException == allowedException[i])
                    fileOK = true;
            }
        }
        if (fileOK)
        {

            //判断文件夹是否存在,不存在则创建路径
            if (System.IO.Directory.Exists(path))
            {
                //该目录存在，则将上传的文件保存在该目录当中;     
            }
            else
            {
                System.IO.Directory.CreateDirectory(path);//创建文件夹
            }

            fileupload.SaveAs(path + "\\" + fileupload.FileName);
        }
        else
        {
            Page.RegisterStartupScript("ss", "<script>alert('不支持此格式文件上传!')</script>");
            return;
        }
    }





    protected void Button3_Click(object sender, EventArgs e)
    {

        Response.Redirect("index.aspx");
    }

}