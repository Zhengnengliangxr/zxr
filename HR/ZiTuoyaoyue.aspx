<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ZiTuoyaoyue.aspx.cs" Inherits="ZiTuoyaoyue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>自拓邀约</h1>
        <div>
        <asp:Label ID="Label1" runat="server" Text="姓名："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="Label2" runat="server" Text="手机号："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="面试时间："></asp:Label>
            <asp:TextBox ID="test1" runat="server" ></asp:TextBox> 
<script src="JavaScript/layDate-v5.0.9/laydate/laydate.js"  charset="utf-8"></script> <!-- 改成你的路径 -->
<script>
//执行一个laydate实例
laydate.render({
  elem: '#test1' //指定元素
});
</script>
        
        </div>
        <div>
        <asp:Button ID="Button1" runat="server" Text="发送邀约短信" />
        </div>
    </div>
    </form>
</body>
</html>
