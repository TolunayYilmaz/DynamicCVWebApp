<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateExperience.aspx.cs" Inherits="DynamicCVWebApp.Html.UpdateExperience" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <h4>
        Deneyim Güncelleme Sayfası
    </h4> 
    <br /> 
    <asp:TextBox ID="txtExperience" runat="server" CssClass="form-control" placeholder="Deneyiminizi Boş Alana Yazınız." TextMode="MultiLine" Height="300px" MaxLength="3000" Width="700px"></asp:TextBox>
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Güncelle" CssClass="btn btn-info" OnClick="btnUpdate_Click"  />
</asp:Content>
