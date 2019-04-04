<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gaihuoshanGw.aspx.cs" Inherits="gaihuoshanGw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        Font-Size="20px" onpageindexchanging="GridView1_PageIndexChanging" 
                        onrowdatabound="GridView1_RowDataBound" onrowdeleting="GridView1_RowDeleting" 
                        onrowediting="GridView1_RowEditing"   
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        onselectedindexchanging="GridView1_SelectedIndexChanging" PageSize="2" 
                        Width="1080px">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <Columns>       
                            
                            <asp:TemplateField>
                               <ItemTemplate>
                                  <asp:CheckBox ID="CheckBox1" runat="server" /> 
                               </ItemTemplate>
                            </asp:TemplateField>
                            





                            
                             
                                        <asp:BoundField DataField="ID" HeaderText="编号" />
                                        <asp:BoundField DataField="GW_name" HeaderText="岗位名称" 
                                            SortExpression="GW_name" />
                                        
                                        <asp:BoundField DataField="GW_bumen" HeaderText="部门" 
                                            SortExpression="GW_bumen" />

                     

                            <asp:BoundField DataField="GW_xinzi" HeaderText="薪资" 
                                            SortExpression="GW_xinzi" />

                            <asp:BoundField DataField="GW_date" HeaderText="日期" 
                                            SortExpression="GW_date" />
                                        
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
            
             <PagerTemplate>
                                    当前第:
                                     <%--//((GridView)Container.NamingContainer)就是为了得到当前的控件--%>
                                    <asp:Label ID="LabelCurrentPage" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageIndex + 1 %>"></asp:Label>
                                    页/共:
                                    <%--//得到分页页面的总数--%>
                                    <asp:Label ID="LabelPageCount" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageCount %>"></asp:Label>
                                    页
                                    <%--//如果该分页是首分页，那么该连接就不会显示了.同时对应了自带识别的命令参数CommandArgument--%>
                                    <asp:LinkButton ID="LinkButtonFirstPage" runat="server" CommandArgument="First" CommandName="Page"
                                        Visible='<%#((GridView)Container.NamingContainer).PageIndex != 0 %>'>首页</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButtonPreviousPage" runat="server" CommandArgument="Prev"
                                        CommandName="Page" Visible='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>'>上一页</asp:LinkButton>
                                    <%--//如果该分页是尾页，那么该连接就不会显示了--%>
                                    <asp:LinkButton ID="LinkButtonNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                        Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'>下一页</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButtonLastPage" runat="server" CommandArgument="Last" CommandName="Page"
                                        Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'>尾页</asp:LinkButton>
                                    转到第
                                    <asp:TextBox ID="txtNewPageIndex" runat="server" Width="20px" Text='<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>' />页
                                    <%--//这里将CommandArgument即使点击该按钮e.newIndex 值为3 --%>
                                    <asp:LinkButton ID="btnGo" runat="server" CausesValidation="False" CommandArgument="-2"
                                        CommandName="Page" Text="GO" />
                                </PagerTemplate>
                          
</asp:GridView>


         <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" Font-Size="9pt" OnCheckedChanged="CheckBox2_CheckedChanged"  Text="全选" />                    
        <asp:Button ID="Button1" runat="server" Font-Size="9pt" Text="取消" OnClick="Button1_Click" />                    
        <asp:Button ID="Button2" runat="server" Font-Size="9pt" Text="删除" OnClick="Button2_Click" />


                       
                    

    </div>
    </form>
</body>
</html>
