<%@ Page Title="Demo Seite 1" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="DemoSeite1.aspx.vb" Inherits="DemoSeite1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

    <style type="text/css">
        .auto-style1 {
            font-size: 5em;
        }
    </style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Demo 1 - Hallo Welt - Einfache Demo</h1>
    <div class="demo-content">

        <p>Hallo, <asp:Label ID="GivenNamenLabel" runat="server" Text="Label"></asp:Label></p>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="WhatIsYourNameTextBox" ErrorMessage="Du musst entweder deinen Namen oder irgend was einfeben."></asp:RequiredFieldValidator>

        <asp:TextBox ID="WhatIsYourNameTextBox" runat="server"></asp:TextBox><asp:Button ID="DemoStartenButton" runat="server" Text="Button" />
        <h2>Demo 2 - Rechnen</h2>
        <asp:TextBox ID="Wert1" runat="server" Width="142px"></asp:TextBox>
        <span class="auto-style1"><strong>+
        </strong></span><asp:TextBox ID="Wert2" runat="server" Width="142px"></asp:TextBox><strong class="auto-style1">=</strong><asp:Button ID="Resultat" runat="server" Text="?" />
        <br />

    </div>
</asp:Content>

