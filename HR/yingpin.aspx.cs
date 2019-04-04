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

public partial class yingpin : System.Web.UI.Page
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
            Page.RegisterStartupScript("ss", "<script>alert('上传附件不能为空!')");
        }
        else
        {
            if (FileUpload1.PostedFile.ContentLength <= 0)
            {
                Page.RegisterStartupScript("ss", "<script>alert('上传附件为空文件，请重新选择!')</script>");
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
                    FilePath = Server.MapPath("~/resume");//  MapPath获取括号里文件夹的物理路径
                    Session["FilePaths1"] = "resume\\" + FileUpload1.FileName;
                }
                UpLoad(FilePath, this.FileUpload1);

                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
                {
                    this.Page.RegisterStartupScript("ss", "<script>alert('必填内容不能为空!')</script>");
                    return;
                }
                else
                {
                    SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                    sqlcon.Open();

                    string strselect = "select * from JianLI  where JL_name=@JL_name and JL_gangwei=@JL_gangwei ";
                    SqlCommand sqlcmd = new SqlCommand(strselect, sqlcon);
                    string StrInsert = "";
                    // 添加参数并且设置参数的值
                    sqlcmd.Parameters.Add("@JL_name", SqlDbType.VarChar);
                    sqlcmd.Parameters["@JL_name"].Value = this.TextBox1.Text.ToString();

                    sqlcmd.Parameters.Add("@JL_gangwei", SqlDbType.VarChar);
                    sqlcmd.Parameters["@JL_gangwei"].Value = this.TextBox3.Text.ToString();

                   

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
                    String StrInsert1 = "insert into JianLi(JL_name,JL_sex,JL_xueli,JL_phone,JL_gangwei,JL_fujian,JL_date,JL_zhuangtai) values(@JL_name,@JL_sex,@JL_xueli,@JL_phone,@JL_gangwei,@JL_fujian,@JL_date,@JL_zhuangtai)";
                    SqlCommand cmd = new SqlCommand(StrInsert1, sqlcon);
                    // 添加参数并且设置参数值
                    cmd.Parameters.Add("@JL_name", SqlDbType.VarChar, 50);
                    cmd.Parameters["@JL_name"].Value = this.TextBox1.Text.ToString();

                    cmd.Parameters.Add("@JL_phone", SqlDbType.VarChar, 50);
                    cmd.Parameters["@JL_phone"].Value = this.TextBox2.Text.ToString();

                    
                    cmd.Parameters.Add("@JL_gangwei", SqlDbType.VarChar, 50);
                    cmd.Parameters["@JL_gangwei"].Value = this.TextBox3.Text.ToString();

                    cmd.Parameters.Add("@JL_sex", SqlDbType.VarChar);
                    cmd.Parameters["@JL_sex"].Value = this.DropDownList1.SelectedValue.ToString();

                    cmd.Parameters.Add("@JL_xueli", SqlDbType.VarChar);
                    cmd.Parameters["@JL_xueli"].Value = this.DropDownList2.SelectedValue.ToString();

                    cmd.Parameters.Add("@JL_fujian", SqlDbType.VarChar, 50);
                    cmd.Parameters["@JL_fujian"].Value = Session["FilePaths1"].ToString();

                    cmd.Parameters.Add("@JL_date", SqlDbType.VarChar,50);
                    cmd.Parameters["@JL_date"].Value = DateTime.Now.ToString();

                    cmd.Parameters.Add("@JL_zhuangtai", SqlDbType.VarChar, 50);
                    cmd.Parameters["@JL_zhuangtai"].Value ="待邀约";
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
            string[] allowedException = { ".xls", ".doc", ".mpp", ".rar", ".zip", ".vsd", ".txt", ".jpg", ".gif", ".bmp", ".png", ".swf", ".avi", ".mp3", ".rm", ".wma", ".wmv",".docx",".pdf" };
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






}