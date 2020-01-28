<%@ Page Language="C#" MasterPageFile="~/GroupVoter.Master" AutoEventWireup="true" CodeBehind="ViewResults.aspx.cs" Inherits="FoodVoting.ViewResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:Panel ID="pnlResults" runat="server">


    </asp:Panel>
    <asp:Label ID="lblShareDescription" runat="server" Text="Share this link to invite more participants"></asp:Label>
    <asp:Label ID="lblShareLink" runat="server" Text=""></asp:Label>
</asp:Content>
