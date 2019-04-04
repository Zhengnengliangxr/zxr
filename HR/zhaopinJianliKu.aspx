<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zhaopinJianliKu.aspx.cs" Inherits="zhaopinJianliKu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  ShowHeaderWhenEmpty="True"
                        EmptyDataText="对不起，没有相关记录！"
                        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        Font-Size="20px" onpageindexchanging="GridView1_PageIndexChanging" 
                        onrowdatabound="GridView1_RowDataBound" onrowdeleting="GridView1_RowDeleting" 
                        onrowediting="GridView1_RowEditing"   
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        onselectedindexchanging="GridView1_SelectedIndexChanging" PageSize="18" 
                        Width="1080px">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <Columns>        
                                        <asp:BoundField DataField="ID" HeaderText="编号" />
                                        <asp:BoundField DataField="JL_name" HeaderText="姓名" 
                                            SortExpression="JL_name" />
                                        
                                        <asp:BoundField DataField="JL_sex" HeaderText="性别" 
                                            SortExpression="JL_sex" />
                                        <asp:BoundField DataField="JL_xueli" HeaderText="学历" 
                                            SortExpression="JL_xueli" />
                                        <asp:BoundField DataField="JL_phone" HeaderText="联系方式" 
                                            SortExpression="JL_phone" />
                                   <asp:TemplateField>   
                                   <ItemTemplate>   
                                    <asp:Button  ID="Button1" runat="server"  OnClick="Button1_Click"   Text='<%# Eval("JL_zhuangtai")%>'  />   
                                   </ItemTemplate>   
                                  </asp:TemplateField>   


                       

                            <asp:BoundField DataField="JL_date" HeaderText="日期" 
                                            SortExpression="JL_date" />
                            <asp:CommandField HeaderText="详细信息"  ShowDeleteButton="True"
                                DeleteText="放入回收站">
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
