<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forgot.aspx.cs" Inherits="forgot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPage" Runat="Server">
                  <div class="right">
                    <div class="registrion">
                        <div class="reg-header-ps">
                            <h1>Forgot pasword</h1>
                            <table border="1" alcellpadding="0" cellspacing="0" align="center">
                                <tr>
                                    <td style="height: 26px; width: 100px; margin-right: 5px; text-align: center;">Email
                                        
                                    </td>
                                    <td colspan="2" style="height: 20px; text-align: center;width: 700px;">
                                        <asp:TextBox ID="fogem" runat="server"></asp:TextBox>
                                    </td>


                                </tr>
                               <tr>


                                    <td style="height: 26px; width: 200px; margin-right: 5px; text-align: center;">Security QUS</td>
                                    <td>
                                        <asp:DropDownList ID="fogsec1" runat="server">
                                            <asp:ListItem>what is pet name</asp:ListItem>
                                            <asp:ListItem>Yes</asp:ListItem>
                                            <asp:ListItem>No</asp:ListItem>
                                        </asp:DropDownList></td>


                                </tr>
                              <tr>


                                    <td style="height: 26px; width: 150px; margin-right: 5px; text-align: center;">Security Ans</td>
                                     <td>
                                         <asp:TextBox ID="fogsecans1" runat="server"></asp:TextBox></td>


                                </tr>
                                <tr>
                                    <td style="height: 26px; width: 120px; margin-right: 5px; text-align: center;">
                                    </td>

                                    <td>
                                        <asp:Button ID="sendps1" runat="server" Text="Send Pasword" ViewStateMode="Inherit" OnClick="sendps1_Click" />
                                    </td>



                                </tr>
                            </table>
                            </div>
                        </div>
                      </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentJavaScript" Runat="Server">
</asp:Content>

