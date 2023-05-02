<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="Talents.aspx.cs" Inherits="DynamicCVWebApp.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered" style="margin-left:20px;margin-right:20px">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID")%></td>
                    <td><%#Eval("TALENT")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"DeleteTalent.aspx?ID=" 
                            + Eval("ID")%>'    CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                   
                     <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"UpdateTalent.aspx?ID=" 
                            + Eval("ID")%>'    CssClass="btn btn-success">GÜNCELLE</asp:HyperLink></td>
             

                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="NewTalent.aspx" class="btn btn-primary" style="margin-left:20px">Yeni Yetenek Ekle</a>
</asp:Content>
