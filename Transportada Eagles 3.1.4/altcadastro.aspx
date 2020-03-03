<%@ Page Title="" Language="VB" MasterPageFile="~/layout.master" AutoEventWireup="false" CodeFile="altcadastro.aspx.vb" Inherits="altcadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#A8DEFF" BorderColor="#0099FF" 
            BorderStyle="Outset" Height="268px" style="margin-left: 165px" Width="700px" 
            Font-Bold="False" HorizontalAlign="Left">
            &nbsp;&nbsp;&nbsp;<asp:Label ID="Label19" runat="server" Font-Bold="True" Text="Dados da Empresa:"></asp:Label>
        <br />
        <br />
            &nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Razão Social"></asp:Label>
            <asp:TextBox ID="razaosocial" runat="server" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="razaosocial" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
        <asp:Label ID="Label12" runat="server" Text="Nome Fantasia"></asp:Label>
        <asp:TextBox ID="nomefantasia" runat="server" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nomefantasia" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:Label ID="Label13" runat="server" Text="CNPJ"></asp:Label>
            <asp:TextBox ID="cnpj" runat="server" Height="25px" Width="114px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="cnpj" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="cnpj" ErrorMessage="CNPJ inválido" ValidationExpression="^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="CEP"></asp:Label>
            <asp:TextBox ID="cep" runat="server" Height="25px" style="width: 128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="cep" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="cep" ErrorMessage="CNPJ inválido" ValidationExpression="\d{5}\d{3}">*</asp:RegularExpressionValidator>
            <asp:LinkButton ID="LinkButton20" runat="server" CausesValidation="false">Buscar CEP</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" Text="Endereço"></asp:Label>
            <asp:TextBox ID="endereco" runat="server" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="endereco" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <br />
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="Nº"></asp:Label>
            &nbsp;<asp:TextBox ID="n" runat="server" Height="25px" Width="66px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="n" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:Label ID="Label14" runat="server" Text="Complemento"></asp:Label>
            &nbsp;<asp:TextBox ID="complemento" runat="server" Height="25px"></asp:TextBox>
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label15" runat="server" Text="Bairro"></asp:Label>
            &nbsp;<asp:TextBox ID="bairro" runat="server" Height="25px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="bairro" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:Label ID="Cidade" runat="server" Text="Cidade"></asp:Label>
            &nbsp;<asp:TextBox ID="cid" runat="server" Height="25px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="cid" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;<asp:Label ID="Label16" runat="server" Text="UF"></asp:Label>
            <asp:TextBox ID="uf" runat="server" Width="40px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="uf" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            &nbsp;<br />
    </asp:Panel>
    <br />
        <asp:Panel ID="Panel2" runat="server" BackColor="#A8DEFF" BorderColor="#0099FF" 
            BorderStyle="Outset" Height="90px" style="margin-left: 165px; margin-top: 26px" 
            Width="700px" HorizontalAlign="Left">
            &nbsp;&nbsp;
            <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Usuário:"></asp:Label>
            <br />
            <br />
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="email" runat="server" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="email" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                ControlToValidate="email" ErrorMessage="Email inválido" 
                ValidationExpression="(\w+?@\w+?\x2E.+)">*</asp:RegularExpressionValidator>
            &nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Senha: "></asp:Label>
            <asp:TextBox ID="senha" runat="server" TextMode="Password" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                ControlToValidate="senha" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="senha" ErrorMessage="Senha incorreta!">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;<br /> &nbsp;
            <asp:Label ID="Label20" runat="server"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;<br />&nbsp;
            <br />
            &nbsp;&nbsp;
            <br />
        </asp:Panel>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Concluir Alteração" 
            style="margin-left: 355px" CausesValidation="false" />
&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Cancelar" CausesValidation="false" />
        </asp:Content>

