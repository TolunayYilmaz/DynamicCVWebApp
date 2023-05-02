<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="DetailMessage.aspx.cs" Inherits="DynamicCVWebApp.Html.DetailMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Mesaj Detayları</h4>
    <asp:TextBox ID="TxtNameSurname" runat="server" CssClass="form form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtMail" runat="server" CssClass="form form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtSubject" runat="server" CssClass="form form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtMessage" TextMode="MultiLine" runat="server" CssClass="form form-control" Height="100" Enabled="false"></asp:TextBox>
</asp:Content>
