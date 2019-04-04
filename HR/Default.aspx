<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
              <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
              <asp:Label ID="Time1" runat="server" Text="Timel"></asp:Label>
              <asp:Button runat="server" Text="按钮1" OnClick="OnClick" />
              <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                      <asp:Label ID="Time2" runat="server" Text="Time2"></asp:Label>
                      <asp:Button runat="server" Text="按钮2" OnClick="OnClick" />
                    </ContentTemplate>
              </asp:UpdatePanel>           

              

  </form>


</body>
</html>
