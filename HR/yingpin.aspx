<%@ Page Language="C#" AutoEventWireup="true" CodeFile="yingpin.aspx.cs" Inherits="yingpin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>应聘</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="性别"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="男">男</asp:ListItem>
            <asp:ListItem Value="女">女</asp:ListItem>  
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="学历"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem >---请选择---</asp:ListItem>
            <asp:ListItem Value="高中">高中</asp:ListItem>
            <asp:ListItem Value="本科">本科</asp:ListItem>
            <asp:ListItem Value="硕士">硕士</asp:ListItem>
            <asp:ListItem Value="博士">博士</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" Text="手机号码"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="应聘岗位"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Label ID="Label6" runat="server" Text="上传简历"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"  />
    </div>
    </form>
</body>
</html>
