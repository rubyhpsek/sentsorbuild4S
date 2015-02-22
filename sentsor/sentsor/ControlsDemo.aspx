<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlsDemo.aspx.cs" Inherits="sentsor.ControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Your Name
        <asp:TextBox ID="YourName" runat="server">YourName</asp:TextBox>
        <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit Information" />
        <br />
    
    </div>
        <p>
            <asp:Label ID="Result" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>




   
