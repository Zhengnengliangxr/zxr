<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GangWeiManage.aspx.cs" Inherits="GangWeiManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/zhaopin.css" />
    <div class="content">
        <div class="title"><a href="index.aspx">工作台</a>-->岗位管理</div>
        <div class="zhaopin-href">
            <span class="zhaopin-href-title"><a href="GWList.aspx" target="iFrame1" >所有岗位</a></span>
            <span class="zhaopin-href-title"><a href="addGangwei.aspx" target="iFrame1" >新增岗位</a></span>
            <span class="zhaopin-href-title"><a href="gaihuoshanGw.aspx" target="iFrame1">岗位管理</a></span>
            
        </div>
        <div>
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate> 
                                              
                    	     <iframe name= "iFrame1" frameborder="0" src= "GWList.aspx" style="width:100%;height:495px"; > </iframe> 

                            </ContentTemplate>   

            </asp:UpdatePanel>





            
        </div>
    </div>

</asp:Content>