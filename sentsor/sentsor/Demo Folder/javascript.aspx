<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="javascript.aspx.cs" Inherits="sentsor.Demo_Folder.javascript" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Using JavaScript</title>
</head>
<body onload="javascript:document.forms[0]['TextBox1'].value=Date();">
<form id="form1" runat="server">
<div>
<asp:TextBox ID="TextBox1" Runat="server" Width="500"  ></asp:TextBox>
</div>
    <p>
        &nbsp;</p>
    <p style="height: 171px">
        <asp:TextBox ID="FirstNameTextBox2" runat="server"></asp:TextBox>
    </p>
    <p style="height: 171px">
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
    </p>
    <p style="height: 171px">










        





       
    </p>


 <asp:AdRotator ID="AdRotator1" runat="server" />

<asp:Xml ID="Xml1" runat="server"></asp:Xml>

    <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
        <asp:View ID="View1" runat="server">
        </asp:View>
    </asp:MultiView>

</form>
</body>
</html>
