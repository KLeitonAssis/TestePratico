<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Requisitos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Devedores</h1>
            <p>
                <asp:GridView ID="GridDevedor" runat="server" AutoGenerateColumns="False"
    DataKeyNames="id"
    onrowcancelingedit="EmployeeGridView_RowCancelingEdit"
    onrowediting="EmployeeGridView_RowEditing"            
    onrowdeleting="EmployeeGridView_RowDeleting"
    onrowupdating="EmployeeGridView_RowUpdating">
      
        <Columns>
        <asp:TemplateField HeaderText="Cod.">
        <ItemTemplate>    <%#Container.DataItemIndex+1 %>    </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nome">
        <ItemTemplate>    <%#Eval("nome") %>    </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="txtnome" runat="server" Text='<%#Eval("nome") %>'></asp:TextBox>
        </EditItemTemplate>
        </asp:TemplateField>   
         <asp:TemplateField HeaderText="Endereco">
        <ItemTemplate>    <%#Eval("endereco") %>    </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="txtendereco" runat="server" Text='<%#Eval("endereco") %>'></asp:TextBox>
        </EditItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Email">
        <ItemTemplate>    <%#Eval("email") %>    </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="txtemail" runat="server" Text='<%#Eval("email") %>'></asp:TextBox>
        </EditItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="true" ButtonType ="Image"
            EditImageUrl="Imagem/editar.jpg"
            UpdateImageUrl="Imagem/aceitar.jpg"
            CancelImageUrl="Imagem/erro.jpg" HeaderText="Editar" />
        <asp:CommandField ShowDeleteButton="true" ButtonType="Image" DeleteImageUrl="Imagem/erro.jpg" HeaderText="Deletar" /> 
    </Columns>
    </asp:GridView>
            </p>
        </section>
    </main>

</asp:Content>
