<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Otp.aspx.cs" Inherits="Otp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPage" Runat="Server">
        <div class="right">
                    <div class="registrion">
                        <div class="reg-header-ps">
                            <h1>Send Otp</h1>
                            <table border="1" alcellpadding="0" cellspacing="0" align="center">
                                <tr>
                                    <td  colspan="2" style="height: 26px; width: 400px; margin-right: 5px; text-align: center;">
                                        <p>please enter 4 digit otp</p>
                                        
                                    </td>
                                  
                            


                                </tr>
                                <tr>
                                      <td  colspan="2" style="height: 26px; width: 400px; margin-right: 5px; margin-top:10px; padding-top:10px; padding-bottom:10px;">
                                        <asp:TextBox ID="TextBox1" Width="50px" Height="50px" runat="server"></asp:TextBox>
                                        <asp:TextBox ID="TextBox2" Width="50px" Height="50px" runat="server"></asp:TextBox>
                                        <asp:TextBox ID="TextBox3" Width="50px" Height="50px" runat="server"></asp:TextBox>
                                        <asp:TextBox ID="TextBox4" Width="50px" Height="50px" runat="server"></asp:TextBox>

                                        
                                    </td>
                                </tr>
                               
                         
                         
                                <tr>
                                    </td>

                                    <td colspan="2" style="height: 26px; width: 100px; margin-right: 5px; text-align: center;">
                                        <asp:Button ID="btn" runat="server" Text="Verify Account" ViewStateMode="Inherit" OnClick="btn_Click" />
                                    </td>



                                </tr>
                            </table>
                            </div>
                        </div>
                      </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentJavaScript" Runat="Server">

</asp:Content>

