<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        default page 1</div>
        <asp:Label ID="LabelApplicationClicks" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelSessionClicks" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLinkPage2" runat="server" NavigateUrl="~/default2.aspx">HyperLink</asp:HyperLink>
        </p>
    </form>
</body>
</html>
