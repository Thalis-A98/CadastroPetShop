<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="CadastroPetShop.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Css/style_cadastro.css" rel="stylesheet" />
    <title>Cadastro Pet Shop</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="containerCadastro">
            <img src="Imagens/pet-shop.png" alt="Logo PetShop" />
            <asp:TextBox ID="txtNome" placeholder="Nome" class="form-control" runat="server" />
            <asp:TextBox ID="txtPeso" placeholder="Peso" class="form-control" runat="server" />
            <asp:TextBox ID="txtRaca" placeholder="Raça" class="form-control" runat="server" />
            <asp:RadioButton ID="rbMacho" Text="Macho" GroupName="sexo"  runat="server" />
            <asp:RadioButton ID="rbFemea" Text="Fêmea" GroupName="sexo"  runat="server" /><br />
            <asp:Label ID="lblData" Text="Data de Nascimento" runat="server" />
            <asp:TextBox ID="txtDataNascimento" TextMode="Date" class="form-control" runat="server" />
            <asp:CheckBox ID="ckCastrado" Text="Pet castrado" runat="server" /><br />
            <asp:DropDownList ID="ddlPorte" class="form-control" runat="server">
                <asp:ListItem Text="-- Selecione o porte do Pet --" />
                <asp:ListItem Text="Porte Pequeno" Value="1" />
                <asp:ListItem Text="Porte Médio" Value="2" />
                <asp:ListItem Text="Porte Grande" Value="3" />
            </asp:DropDownList>
            <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" OnClick="btnCadastrar_Click" />
        </div>
    </form>
</body>
</html>
