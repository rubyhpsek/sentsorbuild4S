<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageGalleryTest.aspx.cs" Inherits="sentsor.Demo_Folder.ImageGalleryTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" Width="228px"  />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
    <asp:Panel ID="Panel1" runat="server" BorderColor="#FF0066" BorderStyle="Dashed" Width="480px" AccessKey="0">
        </asp:Panel>
    </div>
        
    </form>
</body>
</html>
