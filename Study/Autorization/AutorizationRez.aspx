<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutorizationRez.aspx.cs" Inherits="Study.Autorization.AutorizationRez" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Logining:
            <asp:Label ID="Rezultat" runat="server" Text="NOK"></asp:Label>
            <br />
            <asp:Button ID="LoOutButton" runat="server" OnClick="LoOutButton_Click" Text="Button" />
            <br />
        </div>
    </form>
</body>
</html>
