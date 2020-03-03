<%@ Page Title="Transportadora Eagles - Cadastro" Language="VB" MasterPageFile="~/layout.master" AutoEventWireup="false" CodeFile="cadastro.aspx.vb" Inherits="cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script src="Paranaues.js"></script>
      <br />
        <br /><div style="text-align:center">
        <asp:Panel ID="Panel1" runat="server" BackColor="#A8DEFF" BorderColor="#0099FF" 
            BorderStyle="Outset" Height="277px" style="margin-left: 165px" Width="650px" 
            Font-Bold="False" HorizontalAlign="Left">
            &nbsp;&nbsp;<asp:Label ID="Label19" runat="server" Font-Bold="True" Text="Dados da Empresa:"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Razão Social"></asp:Label>
            &nbsp;<asp:TextBox ID="razaosocial" runat="server" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="razaosocial" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            &nbsp;<asp:Label ID="Label12" runat="server" Text="Nome Fantasia"></asp:Label>
            <asp:TextBox ID="nomefantasia" runat="server" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="nomefantasia" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            &nbsp;<br />
            &nbsp;&nbsp;<asp:Label ID="Label13" runat="server" Text="CNPJ"></asp:Label>
&nbsp;<asp:TextBox ID="cnpj" runat="server" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="cnpj" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="cnpj" ErrorMessage="CNPJ inválido" ValidationExpression="^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$">*</asp:RegularExpressionValidator>
            &nbsp;<asp:Label ID="Label21" runat="server" Text="Telefone: "></asp:Label>
            <asp:TextBox ID="dd" runat="server" Height="25px" MaxLength="4" Width="43px" onkeyup="mascara(this, ddtel)"></asp:TextBox>
            &nbsp;<asp:TextBox ID="tel" runat="server" Height="25px" MaxLength="8" onkeyup="mascara(this, mtel)"></asp:TextBox>
            <br />
            &nbsp;&nbsp;<br />&nbsp;&nbsp;<asp:Label ID="Label20" runat="server" Text="CEP"></asp:Label>
            &nbsp;<asp:TextBox ID="cep" runat="server" CausesValidation="true" Height="25px" style="width: 128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="cep" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                ControlToValidate="cep" ErrorMessage="CNPJ inválido" 
                ValidationExpression="\d{5}\d{3}">*</asp:RegularExpressionValidator>
            &nbsp;<asp:LinkButton ID="LinkButton20" runat="server" CausesValidation="false" >Buscar CEP</asp:LinkButton>
            &nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Endereço"></asp:Label>
            <asp:TextBox ID="endereco" runat="server" Height="25px" Width="284px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="endereco" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="Nº"></asp:Label>
            &nbsp;<asp:TextBox ID="n" runat="server" Height="25px" Width="66px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="n" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;<asp:Label ID="Label15" runat="server" Text="Bairro"></asp:Label>
            &nbsp;<asp:TextBox ID="bairro" runat="server" Height="25px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="bairro" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            &nbsp;<asp:Label ID="Label14" runat="server" Text="Complemento"></asp:Label>
            <asp:TextBox ID="complemento" runat="server" Height="25px"></asp:TextBox>
            <br />
            &nbsp;&nbsp;<asp:Label ID="Cidade" runat="server" Text="Cidade"></asp:Label>
            &nbsp;<asp:TextBox ID="cid" runat="server" Height="25px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                ControlToValidate="cid" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;<asp:Label ID="Label16" runat="server" Text="UF"></asp:Label>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="uf" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="uf" runat="server" Width="40px"></asp:TextBox>
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#A8DEFF" BorderColor="#0099FF" 
            BorderStyle="Outset" Height="305px" style="margin-left: 165px; margin-top: 26px" 
            Width="650px" HorizontalAlign="Left">
            &nbsp;&nbsp;
            <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Cadastro Usuário:"></asp:Label>
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
            <asp:Label ID="Label7" runat="server" Text="Digite novamente o Email: "></asp:Label>
            <asp:TextBox ID="email2" runat="server" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                ControlToValidate="email2" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="email" ControlToValidate="email2" 
                ErrorMessage="Emails não conferem">*</asp:CompareValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                ControlToValidate="email2" ErrorMessage="Email inválido" 
                ValidationExpression="(\w+?@\w+?\x2E.+)">*</asp:RegularExpressionValidator>
            <br />
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Usuário: "></asp:Label>
            <asp:TextBox ID="usuario" runat="server" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                ControlToValidate="usuario" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <br />
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Senha: "></asp:Label>
            <asp:TextBox ID="senha" runat="server" TextMode="Password" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                ControlToValidate="senha" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:Label ID="Label5" runat="server" Text="Digite a senha novamente: "></asp:Label>
            <asp:TextBox ID="senha2" runat="server" TextMode="Password" Height="25px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                ControlToValidate="senha2" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                ControlToCompare="senha" ControlToValidate="senha2" 
                ErrorMessage="Senhas não conferem">*</asp:CompareValidator>
            <br />
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Pergunta secreta: "></asp:Label>
            <asp:ListBox ID="psecreta" runat="server" Height="25px" Rows="1" Width="351px">
                <asp:ListItem Selected="True"></asp:ListItem>
                <asp:ListItem Value="amg">Qual o nome do seu melhor amigo?</asp:ListItem>
                <asp:ListItem Value="mae">Nome da cidade onde sua mãe nasceu?</asp:ListItem>
                <asp:ListItem Value="escola">Nome da primeira escola que você estudou?</asp:ListItem>
                <asp:ListItem Value="cachorro">Quantas patas tem um cachorro de 4 patas?</asp:ListItem>
            </asp:ListBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                ControlToValidate="psecreta" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <br />
            <br />
&nbsp;
            <asp:Label ID="Label17" runat="server" Text="Resposta secreta: "></asp:Label>
            <asp:TextBox ID="rsecreta" runat="server" Height="25px" Width="348px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                ControlToValidate="rsecreta" ErrorMessage="Preencha os campos em branco">*</asp:RequiredFieldValidator>
            <br />
        </asp:Panel>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Concluir" 
            style="margin-left: 0px" />
&nbsp;&nbsp;
&nbsp;<asp:Button ID="Button2" runat="server" Text="Cancelar" CausesValidation="false" />

    </div>
    
</asp:Content>
