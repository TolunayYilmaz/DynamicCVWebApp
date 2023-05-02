<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="NewTalent.aspx.cs" Inherits="DynamicCVWebApp.Html.NewTalent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>
        Yeni Yetenek Ekleme Sayfası
    </h4>
    
    <br /> 
      <asp:TextBox ID="txtTalent" runat="server" CssClass="form-control" placeholder="Yeteneğinizi Boş Alana Yazınız."></asp:TextBox>
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Güncelle" CssClass="btn btn-info" OnClick="btnİnsert_Click" />
</asp:Content>
