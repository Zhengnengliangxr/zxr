<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="zhaopinManage.aspx.cs" Inherits="zhaopinManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/zhaopin.css" />
    <div class="content">
        <div class="title"><a href="index.aspx">工作台</a>-->招聘管理</div>
        <div class="zhaopin-href">
           
            <span class="zhaopin-href-title"><a href="zhaopinJianliKu.aspx" target="iFrame1" >简历库</a></span>
            <span class="zhaopin-href-title"><a href="zhaopinAnpai.aspx" target="iFrame1">面试安排</a></span>
            <span class="zhaopin-href-title"><a href="zhaopinLuyong.aspx" target="iFrame1">录用员工</a></span>
            <span class="zhaopin-href-title"><a href="zhaopinHushou.aspx" target="iFrame1">回收站</a></span>
        </div>
        <div>
            <iframe name= "iFrame1" frameborder="0" src= "zhaopinJianLiKu.aspx" style="width:100%;height:495px"; > </iframe> 
        </div>
    </div>

</asp:Content>