<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BoozeSoothe.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>BoozeSoothe Contact Page</h3>
    <address>
        145 Pilser Way<br />
        Greenville, NC 27858<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@BoozeSoothe.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@BoozeSoothe.com</a>
    </address>
</asp:Content>
