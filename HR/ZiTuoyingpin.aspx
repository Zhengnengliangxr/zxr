<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ZiTuoyingpin.aspx.cs" Inherits="ZiTuoyingpin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>自拓客应邀</h1>
        <asp:Label ID="Label1" runat="server" Text="姓名："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="手机号："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="面试岗位："></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
         <asp:Label ID="Label8" runat="server" Text="证件类型"></asp:Label>
             <asp:DropDownList ID="DropDownList1" runat="server">
                  <asp:ListItem Value="身份证">身份证</asp:ListItem>
                  <asp:ListItem Value="军官证">军官证</asp:ListItem>
                  <asp:ListItem Value="护照">军官证</asp:ListItem>
                  <asp:ListItem Value="港澳通行证">港澳通行证</asp:ListItem>
             </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" Text="证件号码："></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="预约时间："></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="申请" />
        <asp:Button ID="Button2" runat="server" Text="取消" />
    </div>
    </form>
</body>
</html>
