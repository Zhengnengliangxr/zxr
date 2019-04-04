<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GWDetail.aspx.cs" Inherits="GWDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>岗位详细信息</h1>
        <asp:DataList ID="DataList1" runat="server" Width="100%" >
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("GW_name") %>'></asp:Label>
                    </a>
                    
                        <span>￥
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("GW_xinzi") %>'></asp:Label></span>
                        <span class="protime">发布于
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("GW_date") %>'></asp:Label></span>
              <div>      
            <asp:TextBox ID="TextBox1" TextMode="MultiLine" Rows="3" style="resize:none"  Width="500px" Height="50px" runat="server" Text='<%# Eval("GW_content") %>'></asp:TextBox>
                </div>
    
            </ItemTemplate>
            </asp:DataList>
        <asp:Button ID="Button1" runat="server" Text="投递简历"  OnClick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
