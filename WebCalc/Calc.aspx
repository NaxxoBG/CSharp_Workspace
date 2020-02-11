<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calc.aspx.cs" Inherits="Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    .textfield {
        margin:10px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" CssClass="textfield" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" CssClass="textfield" runat="server" Text="+" OnClick="Button1_Click" Width="20px" />
        <asp:TextBox ID="TextBox5" CssClass="textfield" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="="></asp:Label>
        <asp:TextBox ID="TextBox9" CssClass="textfield" runat="server"></asp:TextBox>
    
    </div>
        <asp:TextBox ID="TextBox2" CssClass="textfield" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" CssClass="textfield" runat="server" Text="-" OnClick="Button2_Click" />
        <asp:TextBox ID="TextBox6" CssClass="textfield" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="="></asp:Label>
        <asp:TextBox ID="TextBox10" CssClass="textfield" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" CssClass="textfield" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" CssClass="textfield" runat="server" Text="*" OnClick="Button3_Click" Width="20px" />
        <asp:TextBox ID="TextBox7" CssClass="textfield" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="="></asp:Label>
        <asp:TextBox ID="TextBox11" CssClass="textfield" runat="server"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox4" CssClass="textfield" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" CssClass="textfield" runat="server" Text="/" OnClick="Button4_Click" Width="20px" />
            <asp:TextBox ID="TextBox8" CssClass="textfield" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="TextBox12" CssClass="textfield" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server"></asp:Label>
    </form>
</body>
</html>
