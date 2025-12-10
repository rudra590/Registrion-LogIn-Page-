<%@ Page Language="C#" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="main">
        <div class="container">
            <div class="header">
                <h1>My Site</h1>
            </div>
            <div class="navbar">
                <a href="#">Home</a>
                <a href="#">About</a>
                <a href="#">Product</a>
                <a href="#">Contect</a>

            </div>
            <div class="content">
                <div class="left">
                    <div class="login">
                        <div class="login-heder">
                            <h3>WELCOME</h3>
                        </div>
                        <div class="login-content">

                            <table border="1"  cellspacing="0" align="center">
                                <tr>
                                    <td colspan="2" style="height: 26px; width:400px; text-align: center;">
                                        <asp:Image ID="Image1" Height="100" Width="100px" runat="server"/>
                                    </td>

                                </tr>
                                       <tr>


                                    <td style="height: 26px; width: 72px; margin-right: 5px; text-align: center;">Name
                                    </td>


                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </td>
                                </tr>
                                  <tr>


                                    <td colspan="2" style="height: 26px; width:400px; text-align: center;">
                                          <asp:Button ID="logoutbtn1" runat="server" Text="logout" OnClick="logoutbtn1_Click" /> 
                                    </td>


                                </tr>
                                  <tr>


                                    <td colspan="2" style="height: 26px; width:400px; text-align: center;">
                                          <asp:Button ID="Button1" runat="server" Text="logout" /> 
                                    </td>


                                </tr>
                            </table>
                              
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        
    </div>
    </form>
</body>
</html>
