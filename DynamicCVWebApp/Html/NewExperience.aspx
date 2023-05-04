<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="NewExperience.aspx.cs" Inherits="DynamicCVWebApp.Html.NewExperience" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4>
        Yeni Deneyim Ekleme Sayfası
    </h4>
    
    <br /> 
      <asp:TextBox ID="txtExperience" runat="server" CssClass="form-control" placeholder="Deneyiminizi Boş Alana Yazınız." Height="400px" Width="500px"></asp:TextBox>
    <br />
    <asp:Button ID="btnInsert" runat="server" Text="Ekle" CssClass="btn btn-info" OnClick="btnInsert_Click" />
</asp:Content>
