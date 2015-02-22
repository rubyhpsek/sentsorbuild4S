<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adrotator.aspx.cs" Inherits="sentsor.Demo_Folder.adrotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:Timer ID="Timer1" Interval="2000" runat="server" />
        <asp:UpdatePanel ID="up1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
        <ContentTemplate>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/App_Data/adXMLFile.xml" KeywordFilter="small" />
        </ContentTemplate>
             </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
