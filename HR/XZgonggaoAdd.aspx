﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XZgonggaoAdd.aspx.cs" Inherits="XZgonggaoAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
        <asp:Label ID="Label1" runat="server" Text="标题:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="发布人:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        
        <asp:Label ID="Label3" runat="server" Text="内容:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" style="resize:none"  Width="500px" Height="100px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="提交"  OnClick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
