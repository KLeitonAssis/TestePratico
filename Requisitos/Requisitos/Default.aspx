<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Requisitos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <header>

    </header>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle" dir="auto">Devedores</h1>
           

                <asp:GridView ID="GridDevedor" runat="server" AutoGenerateColumns="false" HorizontalAlign="Center" OnRowCommand="GridDevedor_RowCommand"
                    Width="100%" CssClass="table table-striped-columns table-bordered border-dark">
                    <Columns >
                        <asp:BoundField DataField="DEV_COD" HeaderText="Código" />
                        <asp:BoundField DataField="DEV_CPF" HeaderText="CPF" />
                        <asp:BoundField DataField="DEV_CONTRATO_NUM" HeaderText="Contrato" />
                        <asp:BoundField DataField="DEV_DATAPAG" HeaderText="Data de Pagamento" />
                        <asp:BoundField DataField="DEV_VLPRINCIPAL" HeaderText="Valor Principal " />
                        <asp:BoundField DataField="DEV_VLATUALIZADO" HeaderText="Valor Atualizado " />
                        <asp:ButtonField ButtonType="link"  CommandName="Editar" Text="Editar" HeaderText="Editar"/> 
                        <asp:ButtonField ButtonType="Button" CommandName="Deletar" Text="Deletar" HeaderText="Deletar"  />

                    </Columns>
                </asp:GridView>
               
    
        </section>
    </main>

</asp:Content>
