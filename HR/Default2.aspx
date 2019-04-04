<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
        <title></title>
    <script type="text/javascript" src="bootstrap-3.3.7-dist/js/jquery-3.2.1.min.js"></script>
    <script type="text/javascript">     
        var Test = {       
            times: 0, 
            timer: null, 
            logs: [],    
            first: null, 
            last: null,  
            do_dblclick: function () {    
                var self = Test;   
                clearTimeout(self.timer);
                self.logs.push('dblclick');  
                self.echo();
            },
            start: function () {   
                if (this.first == null) {     
                    this.first = new Date().getTime();   
                }
            },
            end: function () {    
                if (this.last == null) { 
                    this.last = new Date().getTime();      
                }
            },
            get_time: function () {         
                return (this.last - this.first) || 0;     
            },
            echo: function () {
                var self = Test;        
                self.end();        
                var iWidth = 550; //模态窗口宽度  
                var iHeight = 450; //模态窗口高度 
                var iTop = (window.screen.height - iHeight) / 2;   
                var iLeft = (window.screen.width - iWidth) / 2;     
                window.open('EditPlan.aspx', "Detail", "Scrollbars=yes,Toolbar=no,Location=no,Direction=no,Resizeable=no,   Width=" + iWidth + " ,Height=" + iHeight + ",top=" + iTop + ",left=" + iLeft)
                self.first = null;
                self.last = null;
                self.logs = [];
            },
            init: function () {
                $(document).ready(function () {
                    $('#Calendar1').click(Test.do_click).dblclick(Test.do_dblclick);
                });
            }
        };
        Test.init();


    </script>

</head>
    <body>
        <form runat="server">
                <div>      
                      <asp:Calendar ID="Calendar1" runat="server"  
                                    onselectionchanged="Calendar1_SelectionChanged">

                      </asp:Calendar>

                </div> 

        </form></body></html>

  
