<%@ Page Title="" Language="VB" MasterPageFile="~/layout.master" AutoEventWireup="false" CodeFile="orçamento.aspx.vb" Inherits="contratar_orçamento" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:Label ID="Label14" runat="server" Text="Razão Social: "></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Label ID="Label7" runat="server" Text="Nome Fantasia:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Endereço de retirada:"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Label ID="Label9" runat="server" Text="Destino:"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label16" runat="server" Text="Peso: "></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    <asp:Label ID="Label17" runat="server" Text="Tipo: "></asp:Label>
    <asp:ListBox ID="ListBox3" runat="server" Rows="1">
        <asp:ListItem Selected="True">Selecione:</asp:ListItem>
        <asp:ListItem>Sólido</asp:ListItem>
        <asp:ListItem>Liquído</asp:ListItem>
    </asp:ListBox>
    <asp:Label ID="Label18" runat="server" Text="Valor: "></asp:Label>
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label19" runat="server" Text="Quantidade de volumes: "></asp:Label>
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    <br />
&nbsp;
    <asp:Panel ID="Panel3" runat="server" BorderColor="Silver" BorderStyle="Groove" 
        HorizontalAlign="Left" style="margin-left: 0px" Width="258px">
        <asp:Label ID="Label20" runat="server" Text="Medidas:"></asp:Label>
        <br />
        <asp:Label ID="Label21" runat="server" Text="Altura: "></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server" Width="61px"></asp:TextBox>
        <asp:Label ID="Label22" runat="server" Text="M"></asp:Label>
        <br />
        <asp:Label ID="Label23" runat="server" Text="Comprimento: "></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server" Width="59px"></asp:TextBox>
        <asp:Label ID="Label24" runat="server" Text="M"></asp:Label>
        <br />
        <asp:Label ID="Label25" runat="server" Text="Largura: "></asp:Label>
        <asp:TextBox ID="TextBox13" runat="server" Width="58px"></asp:TextBox>
        <asp:Label ID="Label26" runat="server" Text="M"></asp:Label>
        <br />
    </asp:Panel>
    <br />
    <asp:Label ID="Label27" runat="server" Text="Cubagem: " Visible="False"></asp:Label>
    <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
    <br />
&nbsp;
    <br />
    <asp:Label ID="Label15" runat="server" Text="Email para contato: "></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server" Width="186px"></asp:TextBox>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Valor Estimado: " Visible="False"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server" Enabled="False" Width="125px" 
        ReadOnly="True" Visible="False"></asp:TextBox>
    <br />
    <asp:LinkButton ID="LinkButton19" runat="server">OK</asp:LinkButton>
&nbsp;
    <asp:LinkButton ID="LinkButton20" runat="server">Limpar</asp:LinkButton>
    <br />
</asp:Content>

