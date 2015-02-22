<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sentsor._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1><%: Title %>.</h1>
    <p>
      <strong>The time now is :</strong><%= DateTime.Now.ToLongTimeString() %>   
    </p>
        <h2>Sentsor Cart Books and DVD&#39;s</h2>
        <p class="lead">We sell the most unique books Sets and Classic DVD&#39;s</p>

    <asp:Button ID="Button1" runat="server" Text="Products Catalogue" PostBackUrl="~/ProductList.aspx" />

</asp:Content>
            

