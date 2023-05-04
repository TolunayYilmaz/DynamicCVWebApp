<%@ Page Title="" Language="C#"MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="Experiences.aspx.cs" Inherits="DynamicCVWebApp.Deneyimler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered" style="margin-left:20px;margin-right:20px">
        <tr>
            <th>ID</th>
            <th>DENEYİM</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID")%></td>
                    <td><%#Eval("EXPERIENCE")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"DeleteExperience.aspx?ID=" 
                            + Eval("ID")%>'    CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                   
                     <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"UpdateExperience.aspx?ID=" 
                            + Eval("ID")%>'    CssClass="btn btn-success">GÜNCELLE</asp:HyperLink></td>
             

                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="NewExperience.aspx" class="btn btn-primary" style="margin-left:20px">Yeni Deneyim Ekle</a>
</asp:Content>
