<%@ Page Title="Transportadora Eagles - Login" Language="VB" MasterPageFile="~/layout.master" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="login" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
&nbsp;<div align="center" class="Login" 
    
        
        style="border: medium outset #C0C0C0; background-position: center; width: 290px; margin-top: 0px; margin-left: 3px; height: 152px; position: relative; top: -29px; left: 363px;">
    <asp:Label ID="Label1" runat="server" Text="Login in:"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
    &nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="25px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Senha"></asp:Label>
    &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="25px" 
        style="margin-top: 10px" TextMode="Password"></asp:TextBox>
    <br />
    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" 
        Font-Size="Medium" ForeColor="#0033CC">Entrar</asp:LinkButton>
    &nbsp; /&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
        Font-Size="Medium" ForeColor="#0033CC">Voltar</asp:LinkButton>
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
</div>
</asp:Content>

