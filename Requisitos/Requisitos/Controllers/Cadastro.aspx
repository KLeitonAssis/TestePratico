<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Requisitos.Controllers.Cadastro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

    <ajaxToolkit:MaskedEditExtender ID="meeCPF" runat="server"
    TargetControlID="txtCpf"
    Mask="999.999.999-99"
    MaskType="Number"
    InputDirection="RightToLeft"
    AcceptNegative="None"
    ErrorTooltipEnabled="True"
    ClearMaskOnLostFocus="false" />



    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h7>Faça o Cadastro de um novo Devedor.</h7>

        <div class="m-md-2">
            <asp:Label ID="Label1" runat="server" Text="Label" >CPF: </asp:Label>
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        
            <asp:Label ID="Label2" runat="server" Text="Label" CssClass="m-3">Contrato: </asp:Label>
            <asp:TextBox ID="txtContrato" runat="server" TextMode="Number" ></asp:TextBox>
        
            <asp:Label ID="Label3" runat="server" Text="Label" CssClass="m-3">Data de Pagamento: </asp:Label>
            <asp:TextBox ID="txtData" runat="server" TextMode="Date" ></asp:TextBox>
        </div>
        
            <asp:Label ID="Label4" runat="server" Text="Label">	Valor Principal: </asp:Label>
            <asp:TextBox ID="txtValorP" runat="server" ></asp:TextBox>
       
            <asp:Label ID="Label5" runat="server" Text="Label" CssClass="m-3">Valor Atualizado: </asp:Label>
            <asp:TextBox ID="txtValorA" runat="server" ></asp:TextBox>
        
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastro" OnClick="btnCadastrar_Click"></asp:Button>
        
    </main>
</asp:Content>