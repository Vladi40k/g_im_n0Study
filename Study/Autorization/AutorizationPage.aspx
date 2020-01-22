<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutorizationPage.aspx.cs" Inherits="Study.Autorization.AutorizationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            emai
            <asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>
            <br />
            pass<asp:TextBox ID="PassBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="SingButton" runat="server" OnClick="SingButton_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
