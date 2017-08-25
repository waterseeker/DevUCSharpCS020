<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevUCSharpCS_ASP_020.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Type a balue to add it to the string.
        </p>
        <p>
            Server Control:</p>
        <p>
            <asp:TextBox ID="valueTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Plain &#39;ol HTML input field:</p>
        <p>
            <input id="Text1" type="text" /></p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="Button1_Click" Text="Add" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
