<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="staffList.aspx.cs" Inherits="staffList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/zhaopin.css" />
    <div class="content">
        <div class="title"><a href="index.aspx">工作台</a>-->员工花名册</div>
        <div class="zhaopin-href">
            <span class="zhaopin-href-title"><a href="zhaopinDaishai.aspx" target="iFrame1" >全部（人）</a></span>
            <span class="zhaopin-href-title"><a href="zhaopinKu.aspx" target="iFrame1" >在职（人）</a></span>
            <span class="zhaopin-href-title"><a href="zhaopinAnpai.aspx" target="iFrame1">实习（人）</a></span>
            <span class="zhaopin-href-title"><a href="zhaopinLuyong.aspx" target="iFrame1">离职（人）</a></span>
            如何点击链接在框架中操作不同的表
        </div>
        <div>
        <asp:TextBox ID="TextBox1" runat="server" Text="员工姓名、部门、职位"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="确定" />
        </div>
        
        <div>
            <iframe name= "iFrame1" frameborder="0" src= "index.html" style="width:100%;height:495px"; > </iframe> 
        </div>
    </div>

</asp:Content>
