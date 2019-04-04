<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addGangwei.aspx.cs" Inherits="addGangwei" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="岗位名称:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Label ID="Label6" runat="server" Text="薪资:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="所属部门:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        
        <asp:Label ID="Label3" runat="server" Text="最低学历:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem >---请选择---</asp:ListItem>
            <asp:ListItem Value="高中">高中</asp:ListItem>
            <asp:ListItem Value="本科">本科</asp:ListItem>
            <asp:ListItem Value="硕士">硕士</asp:ListItem>
            <asp:ListItem Value="博士">博士</asp:ListItem>
        </asp:DropDownList>
       
        <asp:Label ID="Label4" runat="server" Text="经验要求:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem >---请选择---</asp:ListItem>
            <asp:ListItem Value="无经验">无经验</asp:ListItem>
            <asp:ListItem Value="1-2年">1-2年</asp:ListItem>
            <asp:ListItem Value="2年以上">2年以上</asp:ListItem>
           
        </asp:DropDownList>
        <asp:Label ID="Label5" runat="server" Text="职位类型:"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server">
        <asp:ListItem >---请选择---</asp:ListItem>
            <asp:ListItem Value="全职">全职</asp:ListItem>
            <asp:ListItem Value="兼职">兼职</asp:ListItem>
            <asp:ListItem Value="实习">实习</asp:ListItem>

        </asp:DropDownList>
        <div>
        <asp:Label ID="Label7" runat="server" Text="详细要求:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" style="resize:none"  Width="500px" Height="100px"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="提交"  OnClick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
