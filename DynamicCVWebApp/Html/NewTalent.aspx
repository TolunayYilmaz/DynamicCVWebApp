<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="NewTalent.aspx.cs" Inherits="DynamicCVWebApp.Html.NewTalent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>
        Yeni Yetenek Ekleme Sayfası
    </h4>
    
    <br /> 
      <asp:TextBox ID="txtTalent" runat="server" CssClass="form-control" placeholder="Yeteneğinizi Boş Alana Yazınız." Height="80px" Width="500px"></asp:TextBox>
    <br />
    <asp:Button ID="btnInsert" runat="server" Text="Ekle" CssClass="btn btn-info" OnClick="btnInsert_Click" />
</asp:Content>
