<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wanshanInfor.aspx.cs" Inherits="wanshanInfor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>完善个人信息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
        <asp:Label ID="Label14" runat="server" Text="上传照片"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
           
        <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
        <asp:Label ID="Label2" runat="server" Text="性别"></asp:Label>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="男" Checked="false" GroupName="sex" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="女" Checked="true"  GroupName="sex"/>

        </div>

        <div>
        <asp:Label ID="Label3" runat="server" Text="出生日期"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
        <asp:Label ID="Label4" runat="server" Text="婚姻状况"></asp:Label>
        <asp:RadioButton ID="RadioButton3" runat="server" Text="未婚" Checked="false" GroupName="hun" />
        <asp:RadioButton ID="RadioButton4" runat="server" Text="已婚" Checked="true"  GroupName="hun"/>

        </div>
         <div>
        <asp:Label ID="Label5" runat="server" Text="民族"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="政治面貌"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </div>
         <div>
        <asp:Label ID="Label7" runat="server" Text="国籍"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="证件类型"></asp:Label>
             <asp:DropDownList ID="DropDownList1" runat="server">
                  <asp:ListItem Value="身份证">身份证</asp:ListItem>
                  <asp:ListItem Value="军官证">军官证</asp:ListItem>
                  <asp:ListItem Value="护照">军官证</asp:ListItem>
                  <asp:ListItem Value="港澳通行证">港澳通行证</asp:ListItem>
             </asp:DropDownList>
        </div>
         <div>
        <asp:Label ID="Label9" runat="server" Text="证件号码"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" Text="联系电话"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </div>
         <div>
        <asp:Label ID="Label11" runat="server" Text="家庭住址"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" Text="紧急联系人"></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </div>
         <div>
        <asp:Label ID="Label13" runat="server" Text="手机号码"></asp:Label>
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
             <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click"/>
        
        </div>
    </div>
    </form>
</body>
</html>
