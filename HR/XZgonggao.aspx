<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="XZgonggao.aspx.cs" Inherits="XZgongga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/zhaopin.css" />
    <div class="content">
        <div class="title"><a href="index.aspx">工作台</a>-->通知管理</div>
        <div class="zhaopin-href">
            <span class="zhaopin-href-title"><a href="XZgonggaoManage.aspx" target="iFrame1" >公告管理</a></span>
            <span class="zhaopin-href-title"><a href="XZgonggaoAdd.aspx" target="iFrame1" >新增公告</a></span>
           
            
        </div>
        <div>
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate> 
                                              
                    	     <iframe name= "iFrame1" frameborder="0" src= "XZgonggaoAdd.aspx" style="width:100%;height:495px"; > </iframe> 

                            </ContentTemplate>   

            </asp:UpdatePanel>





            
        </div>
    </div>

</asp:Content>