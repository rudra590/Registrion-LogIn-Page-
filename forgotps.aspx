<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forgotps.aspx.cs" Inherits="forgotps" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPage" Runat="Server">
     <div class="right">
                    <div class="registrion">
                        <div class="reg-header-ps">
                            <h1> New pasword</h1>
                            <table border="1"  cellspacing="0" align="center">
                             
                                     <tr>
                                    <td style="height: 26px; width: 100px; margin-right: 5px; text-align: center;"> new pasword
                                        
                                    </td>
                                    <td colspan="2" style="height: 20px; text-align: center;width: 700px;">
                                        <asp:TextBox ID="fognewps" runat="server"></asp:TextBox>
                                    </td>


                                </tr>
                            
                                 <tr>
                                    <td style="height: 26px; width: 100px; margin-right: 5px; text-align: center;"> confirm pasword
                                        
                                    </td>
                                    <td colspan="2" style="height: 20px; text-align: center;width: 700px;">
                                        <asp:TextBox ID="fognewcon" runat="server"></asp:TextBox>
                                    </td>


                                </tr>
                                <tr>
                                    <td style="height: 26px; width: 120px; margin-right: 5px; text-align: center;">
                                    </td>

                                    <td>
                                        <asp:Button ID="senps2" runat="server" Text="Send Pasword" ViewStateMode="Inherit" OnClick="senps2_Click" />
                                    </td>



                                </tr>
                            </table>
                            </div>
                        </div>
                      </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentJavaScript" Runat="Server">
</asp:Content>

