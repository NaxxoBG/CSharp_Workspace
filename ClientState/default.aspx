<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default2.aspx">HyperLink</asp:HyperLink>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
        <asp:HiddenField ID="HiddenField1" runat="server" />
    </form>
</body>
</html>
