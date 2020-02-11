<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default2.aspx.cs" Inherits="default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        default page 2</div>
        <asp:Label ID="LabelApplicationClicks" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelSessionClicks" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLinkPage1" runat="server" NavigateUrl="~/default.aspx">HyperLink</asp:HyperLink>
        </p>
    </form>
    
</body>
</html>
