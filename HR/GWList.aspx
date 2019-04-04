<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GWList.aspx.cs" Inherits="GWList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h1>岗位列表</h1>
                   
          <asp:DataList ID="DataList1" runat="server" CellPadding="4" 
                 ForeColor="#333333" Width="100%" Height="50px ">
                 <AlternatingItemStyle BackColor="White" />
                 <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                 <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <ItemStyle BackColor="#EFF3FB"  Font-Size="24px" />
                
            <ItemTemplate>
                <!--RepeatDirection="Horizontal" RepeatColumns="5" datalist 数据横向展示-->
                <!--         <div class="col-2 item"> -->
                
                    
                    
                <div>
                    <a href='GWDetail.aspx?t_id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'target="_blank" class="protitle">
                       
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("GW_name") %>'></asp:Label>
                    </a>
                    
                        <span>￥
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("GW_xinzi") %>'></asp:Label></span>
                        <span class="protime">发布于
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("GW_date") %>'></asp:Label></span>
                </div>   
                <div style="border:1px solid #ccc; width:auto;height:30px; overflow:hidden">
        <!--      <asp:TextBox ID="TextBox1" TextMode="MultiLine" Rows="3" style="resize:none"  Width="500px" Height="50px" runat="server" Text='<%# Eval("GW_content") %>'></asp:TextBox>  -->
                     <%# Eval("GW_content") %>
                    </div>
            </ItemTemplate>
        </asp:DataList>    





    </div>
    </form>
</body>
</html>
