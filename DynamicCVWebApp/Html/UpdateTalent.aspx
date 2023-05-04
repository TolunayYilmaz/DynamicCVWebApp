<%@ Page Title="" Language="C#" MasterPageFile="~/Html/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateTalent.aspx.cs" Inherits="DynamicCVWebApp.Html.UpdateTalent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4>
        Yetenek Güncelleme Sayfası
    </h4>
    
    <br /> 
      <asp:TextBox ID="txtTalent" runat="server" CssClass="form-control" placeholder="Yeteneğinizi Boş Alana Yazınız." TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Güncelle" CssClass="btn btn-group" OnClick="btnUpdate_Click"  />
</asp:Content>
