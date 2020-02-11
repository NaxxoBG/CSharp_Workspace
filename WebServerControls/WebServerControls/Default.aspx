<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServerControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelInformation" runat="server"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxUserName" runat="server" MaxLength="12"></asp:TextBox>
        <br />
        <p>
            <asp:CheckBox ID="CheckBoxAdmin" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBoxAdmin_CheckedChanged" Text="System Administrator" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Application role:"></asp:Label>
        </p>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="ApplicationRole" Text="User" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="ApplicationRole" Text="Manager" />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="ApplicationRole" Text="Director" />
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
    </form>
</body>
</html>
