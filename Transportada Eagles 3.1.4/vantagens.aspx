<%@ Page Title="Transportadora Eagles - Unidades" Language="VB" MasterPageFile="~/layout.master" AutoEventWireup="false" CodeFile="vantagens.aspx.vb" Inherits="unidades" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="App_Themes/Theme1/StyleSheet3.css" rel="stylesheet" />
  <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate>
            <table class="TABELA">
            <tr>
                <td class="semitabela">

                    <asp:Image Height="200" Width="250"  ImageUrl ='<%# Container.DataItem("ProductImage")%>' runat ="server" />


                </td>
                <td class="semitabela2">
                    <%# Container.DataItem("ProductName")%> <br />
                   
                </td>

            </tr>

        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

