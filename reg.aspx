<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 72px;
            height: 26px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPage" Runat="Server">

        <div class="registrion">
                        <div class="reg-header">
                            <h1>REGISTRION</h1>
                            <table border="1"  cellspacing="0" align="center">
                                <tr>
                                    <td colspan="2" style="height: 20px; text-align: center;width: 700px;"></td>
                                </tr>
                                <tr>


                                    <td style="height: 26px; width: 72px; margin-right: 5px; text-align: center;">Name
                                    </td>


                                    <td>
                                        <asp:TextBox ID="regname" runat="server" Width="400px"></asp:TextBox></td>
                                </tr>
                                <tr>


                                    <td style="height: 26px; width: 72px; margin-right: 5px; text-align: center;">Email
                                    </td>

                                    
                                    <td>
                                        <asp:TextBox ID="regemail" runat="server" Width="400px"></asp:TextBox></td>

                                  


                                </tr>
                                <tr>
                                         <td style="height: 26px; width: 120px; margin-right: 5px; text-align: center;">MobilesNo
                                    </td>

                                    <td>
                                        <asp:TextBox ID="regmob" MaxLength="10"  runat="server"  Width="400px"></asp:TextBox></td>
                                </tr>
                                <tr>


                                    <td style="margin-right: 5px; text-align: center;" class="auto-style1">
                                        Pasword</td>



                                    
                                    <td class="auto-style2">
                                        <asp:TextBox ID="regpas" runat="server" Width="400px" TextMode="Password"></asp:TextBox></td>


                                </tr>
                                <tr>


                                    <td style="height: 26px; width: 150px; margin-right: 5px; text-align: center;">
                                        Confirm Pasword</td>



                                    <td>
                                        <asp:TextBox ID="regcomps" runat="server" Width="400px"></asp:TextBox></td>


                                </tr>
                                <tr>


                                    <td style="height: 26px; width: 150px; margin-right: 5px; text-align: center;">Date
                                        of Birth</td>



                                    <td>

                                        <%-- date --%>


                                        <asp:DropDownList ID="regdate" runat="server">
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem></asp:ListItem>

                                        </asp:DropDownList>


                                        <%-- month --%>
                                        
                                        <asp:DropDownList ID="regmonth" runat="server">
                                            <asp:ListItem>Janyuary</asp:ListItem>
                                            <asp:ListItem>February</asp:ListItem>
                                            <asp:ListItem>March</asp:ListItem>
                                            <asp:ListItem>April</asp:ListItem>
                                            <asp:ListItem>May</asp:ListItem>
                                            <asp:ListItem>Jun</asp:ListItem>
                                            <asp:ListItem>July</asp:ListItem>
                                            <asp:ListItem>Augest</asp:ListItem>
                                            <asp:ListItem>September</asp:ListItem>
                                            <asp:ListItem>Octomber</asp:ListItem>
                                            <asp:ListItem>Navomber</asp:ListItem>
                                            <asp:ListItem>Dcember</asp:ListItem>
                                        </asp:DropDownList>
                                        
                                        <%-- year --%>
                                        <asp:DropDownList ID="regyear" runat="server">
                                            <asp:ListItem>2000</asp:ListItem>
                                            <asp:ListItem>2001</asp:ListItem>
                                            <asp:ListItem>2002</asp:ListItem>
                                            <asp:ListItem>2003</asp:ListItem>
                                            <asp:ListItem>2004</asp:ListItem>
                                            <asp:ListItem>2005</asp:ListItem>
                                            <asp:ListItem>2006</asp:ListItem>
                                            <asp:ListItem>2007</asp:ListItem>
                                            <asp:ListItem>2008</asp:ListItem>
                                            <asp:ListItem>2009</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>


                                </tr>

                                <%-- image --%>

                                <tr>


                                    <td style="height: 26px; width: 150px; margin-right: 5px; text-align: center;">image</td>
                                    <td>
                                        <asp:FileUpload ID="FileUpload1" runat="server" /></td>

                                </tr>
                                <%-- gender --%>
                                <tr>


                                    <td style="height: 26px; width: 150px; margin-right: 5px; text-align: center;">Gender</td>
                                     <td>
                                         <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                                             <asp:ListItem>male</asp:ListItem>
                                             <asp:ListItem>female</asp:ListItem>
                                         </asp:RadioButtonList></td>


                                </tr>
                                <%-- security qus --%>

                                 <tr>


                                    <td style="height: 26px; width: 150px; margin-right: 5px; text-align: center;">Security QUS</td>
                                 <td>
                                  <asp:DropDownList ID="regq" runat="server" DataTextField="">
                                      <asp:ListItem>what is your pet name</asp:ListItem>
                                      <asp:ListItem>Yes</asp:ListItem>
                                         <asp:ListItem>No</asp:ListItem>
                                         </asp:DropDownList></td>


                                </tr>
                                <%-- security ans --%>
                                        <tr>


                                    <td style="height: 26px; width: 150px; margin-right: 5px; text-align: center;">Security Ans</td>
                                     <td>
            

                                          <asp:TextBox ID="regsec" runat="server" Width="400px"></asp:TextBox></td>

                                </tr>
                                <tr>
                                    <td colspan="2" style="height: 20px; text-align: center;width: 700px;"></td>
                                </tr>
                                 <tr>
                                
                                                                        <td colspan="2" style="height: 20px; text-align: center;width: 700px;">
                                                                            <asp:Button ID="reg1" runat="server" Text="Registrion" OnClick="reg1_Click"/>
                                    </td>
                                </tr>
                                   
                            </table>
                        </div>
                    </div>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentJavaScript" Runat="Server">
</asp:Content>

