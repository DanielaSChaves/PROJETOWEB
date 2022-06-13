<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PROJETOWEB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 331px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="319px">
            CADASTRO&nbsp; DE DOCUMENTOS<br />
            <br />
            &nbsp;Código
            <asp:TextBox ID="txtCodigo" runat="server" OnTextChanged="txtCodigo_TextChanged"></asp:TextBox>
            <br />
            <br />
            &nbsp;Titulo<asp:TextBox ID="txtTitulo" runat="server" OnTextChanged="txtTitulo_TextChanged" style="margin-left: 10px"></asp:TextBox>
            <br />
            <br />
            &nbsp;Processo<asp:ListBox ID="listProcesso" runat="server" Height="21px" OnSelectedIndexChanged="listProcesso_SelectedIndexChanged" style="margin-left: 4px" Width="145px">
                <asp:ListItem>ADMINISTRATIVO</asp:ListItem>
                <asp:ListItem>COMERCIAL</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            &nbsp;Categoria<asp:TextBox ID="txtCategoria" runat="server" style="margin-left: 4px"></asp:TextBox>
            <br />
            <br />
            &nbsp;Arquivo<asp:FileUpload ID="FupArquivo" runat="server" />
            <br />
            <br />
            <asp:Button ID="ButInserirDoc" runat="server" Height="25px" style="margin-left: 15px" Text="INSERIR DOCUMENTO" Width="242px" OnClick="ButInserirDoc_Click" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="138px">
            CONSULTA DE DOCUMENTOS<br />
            <br />
            Insira o titulo do documento:<br />
            <br />
            <asp:TextBox ID="txtBusca" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="BUSCAR" OnClick="Button1_Click" />
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="185px">
            LISTAGEM DE DOCUMENTOS
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="98px" style="margin-left: 43px" Width="361px">
                <Columns>
                    <asp:BoundField HeaderText="Código" />
                    <asp:BoundField HeaderText="Título" />
                    <asp:BoundField HeaderText="Processo" />
                    <asp:BoundField HeaderText="Categoria" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
