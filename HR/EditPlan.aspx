<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditPlan.aspx.cs" Inherits="EditPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  
      <title>填写备忘录信息</title>  
      <script type="text/javascript">
          function watermark(id, value) { 
              var obj = document.getElementById(id);
              obj.value = value;
              obj.style.cssText = "color:Gray";
              //获取焦点事件
              obj.onfocus = function () { 
                  this.style.cssText = "color:Blue"; 
                  if (this.value == value) {  
                      this.value = ''; 
                  }      
              };   
              //失去焦点事件 
              obj.onblur = function () {
                  if (this.value == "") {
                      this.value = value;
                      this.style.cssText = "color:Gray";
                  }
                  else {
                      this.style.cssText = "color:Blue";
                  }
              };
          }
          window.onload = function () {
              var arr = [{ 'id': 'tb_title', 'desc': '请输入您的备忘录标题...' }, { 'id': 'tb_content', 'desc': '请输入备忘录内容...' }];
              for (var i = 0; i < arr.length; i++) {
                  watermark(arr[i].id, arr[i].desc);
              }
          };

      </script>  
      <style type="text/css"> 
                 .css1{  
                       width:500px;         
                       height:26px; 

                 }        
                 .css2{
                       width:500px;
                       height:270px; 

                 }  

      </style>

</head>
    <body> 
           <form id="form1" runat="server">
                   <div>
                 <table style="width:500px;height:400px" align="center">
                   <tr>       
                     <td style="width:500px;height:35px; font-weight: bold;" align="center">
                     填写备忘录信息
                     </td>
                   </tr>                     
                   <tr> 
                     <td style="width:500px;height:30px;">
                       <asp:TextBox ID="tb_title" runat="server" CssClass="css1"></asp:TextBox>
                     </td>
                   </tr>           
                   <tr>                                 
                     <td style="width:500px;height:270px">
                       <asp:TextBox ID="tb_content" runat="server" CssClass="css2" TextMode="MultiLine"></asp:TextBox>
                     </td>
                   </tr>                
                   <tr>
                      <td style="width:500px;height:30px" align="left"> 
                      <asp:CheckBox ID="CheckBox_Remind" runat="server" Text="邮件提醒" />
                      <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                      </td>
                   </tr>                    
                   <tr>
                      <td style="width:500px;height:35px" align="center">
                      <asp:Button ID="Button1" runat="server" Height="22px" Text="保存" Width="50px" onclick="Button1_Click" />  
                      </td>
                   </tr>            
                  </table>
              </div>           
        </form>
   </body>              
</html>
                   

           

    



版权声明：本文为博主原创文章，转载请附上博文链接！