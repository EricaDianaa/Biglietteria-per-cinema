<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cinema.aspx.cs" Inherits="w13_2.Cinema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2"   ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Nome cognome --%>
    <div id="body" class="w-100 bg-dark p-5 ">
    <div id="Form" class="d-flex justify-content-center text-white text-center flex-column m-5 border border-white bg-danger bg-opacity-10 p-3 rounded-3">
    <h4>Inserisci il tuo nome</h4>
    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
    <h4>Inserisci il tuo cognome</h4>
    <asp:TextBox ID="cognome" runat="server"></asp:TextBox>
    <%-- Sala --%>
    <h4>Scegli una sala</h4>
 <asp:DropDownList ID="DropDownList1" runat="server">
     <asp:ListItem Value="Nord" Text="Sala Nord" />
     <asp:ListItem Value="Sud" Text="Sala Sud" />
     <asp:ListItem  Value="Est" Text="Sala Est" />
 </asp:DropDownList>
    <%-- biglietto ridotto --%>
    <asp:CheckBox ID="ridotto" Text="Biglietto ridotto" runat="server" />
    <br />
 <asp:Button ID="Button1"  runat="server" CssClass="btn btn-danger mt-2" Text="Prenota" OnClick="Button1_Click" />
    <asp:Label ID="alertext" CssClass="text-danger fw-bold" runat="server" Text=""></asp:Label>
</div>
   
      <%-- Dettagli --%>
        <div id="dettagli" class="m-5 border border-white">
    <div class="d-flex justify-content-center text-white flex-column m-5   p-3 rounded-3 
        text-center" ID="Dettagli" runat="server"></div></div>
        </div>

</asp:Content>
