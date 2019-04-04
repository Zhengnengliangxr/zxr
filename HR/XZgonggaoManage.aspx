<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XZgonggaoManage.aspx.cs" Inherits="XZgonggaoManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                        BorderColor="#cccccc" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        Font-Size="20px" onpageindexchanging="GridView1_PageIndexChanging" 
                        onrowdatabound="GridView1_RowDataBound" onrowdeleting="GridView1_RowDeleting" 
                        onrowediting="GridView1_RowEditing"   
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        onselectedindexchanging="GridView1_SelectedIndexChanging" PageSize="18" 
                        Width="1080px">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <Columns>        
                                        <asp:BoundField DataField="ID" HeaderText="编号" />
                                        <asp:BoundField DataField="GG_title" HeaderText="标题" 
                                            SortExpression="GG_title" />
                                        
                                        <asp:BoundField DataField="GG_person" HeaderText="发布人" 
                                            SortExpression="GG_person" />

                     

                       

                            <asp:BoundField DataField="GG_date" HeaderText="日期" 
                                            SortExpression="GG_date" />
                            <asp:CommandField HeaderText="详细信息" SelectText="修改" ShowCancelButton="False" ShowDeleteButton="True"
                                ShowHeader="True" ShowSelectButton="True">
                                <ControlStyle ForeColor="Blue" />
                            </asp:CommandField>

                       
                        </Columns>
                        <RowStyle HorizontalAlign ="Center" />  
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Right" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>

    </div>
    </form>
</body>
</html>
