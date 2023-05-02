<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="Communications.aspx.cs" Inherits="DynamicCVWebApp.Html.Communications" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table table-bordered" style="margin-left:20px;margin-right:20px">
        <tr>
            <th>ID</th>
            <th>AD SOYAD</th>
            <th>MAİL</th>
            <th>KONU</th>
            <th>MESAJI GÖR</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID")%></td>
                    <td><%#Eval("NameSurname")%></td>
                    <td><%#Eval("Mail")%></td>
                    <td><%#Eval("Subject")%></td>
                    
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"DetailMessage.aspx?ID=" 
                            + Eval("ID")%>'    CssClass="btn btn-warning" BackColor="#CC6699">Mesajı Gör</asp:HyperLink></td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
</asp:Content>
