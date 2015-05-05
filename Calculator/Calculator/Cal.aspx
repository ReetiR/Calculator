<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cal.aspx.cs" Inherits="Calculator.Cal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Calculatore</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="3" style="height:300px; width:200px; margin-left:550px;">
      <tr>
      <td colspan="4"><asp:TextBox BorderWidth="2" BackColor="Black" ID="text_result" Width="215" Height="60" runat="server" ForeColor="White" Font-Size="20"></asp:TextBox></td>
      </tr>
      <tr>
      <td><asp:Button ID="bttn1" Width="50" Height="60" runat="server" Text="1" Font-Size="16" onclick="bttn1_Click" /></td>
      <td><asp:Button ID="bttn2" Width="50" Height="60" runat="server" Text="2" Font-Size="16" onclick="bttn2_Click" /></td>
      <td><asp:Button ID="bttn3" Width="50" Height="60" runat="server" Text="3" Font-Size="16" onclick="bttn3_Click" /></td>
      <td><asp:Button ID="bttn_add" Width="50" Height="60" runat="server" Text="+" Font-Size="16" onclick="bttn_add_Click" /></td>
      </tr>
      <tr>
      <td><asp:Button ID="bttn4" Width="50" Height="60" runat="server" Text="4" Font-Size="16" onclick="bttn4_Click" /></td>
      <td><asp:Button ID="bttn5" Width="50" Height="60" runat="server" Text="5" Font-Size="16" onclick="bttn5_Click" /></td>
      <td><asp:Button ID="bttn6" Width="50" Height="60" runat="server" Text="6" Font-Size="16" onclick="bttn6_Click" /></td>
      <td><asp:Button ID="bttn_sub" Width="50" Height="60" runat="server" Text="-" Font-Size="16" onclick="bttn_sub_Click" /></td>
      </tr>
      <tr>
      <td><asp:Button ID="bttn7" Width="50" Height="60" runat="server" Text="7" Font-Size="16" onclick="bttn7_Click" /></td>
      <td><asp:Button ID="bttn8" Width="50" Height="60" runat="server" Text="8" Font-Size="16" onclick="bttn8_Click" /></td>
      <td><asp:Button ID="bttn9" Width="50" Height="60" runat="server" Text="9" Font-Size="16" onclick="bttn9_Click" /></td>
      <td><asp:Button ID="bttn_prod" Width="50" Height="60" runat="server" Text="*" Font-Size="16" onclick="bttn_prod_Click" /></td>
      </tr>
      <tr>
      <td><asp:Button ID="bttn0" Width="50" Height="60" runat="server" Text="0" Font-Size="16" onclick="bttn0_Click" /></td>
      <td><asp:Button ID="bttn_clr" Width="50" Height="60" runat="server" Text="C" Font-Size="16" onclick="bttn_clr_Click" /></td>
      <td><asp:Button ID="bttn_eq" Width="50" Height="60" runat="server" Text="=" Font-Size="16" onclick="bttn_eq_Click" /></td>
      <td><asp:Button ID="bttn_div" Width="50" Height="60" runat="server" Text="/" Font-Size="16" onclick="bttn_div_Click" /></td>
      </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
