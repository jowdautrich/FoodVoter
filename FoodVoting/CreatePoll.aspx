<%@ Page Language="C#" MasterPageFile="~/GroupVoter.Master" AutoEventWireup="true" CodeBehind="CreatePoll.aspx.cs" Inherits="FoodVoting.CreatePoll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="/Assets/CSS/CreatePoll.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="row my-5 text-center">
        <div class="col text-center">
            <asp:Label ID="createPollInstructions" CssClass="text-white body-width" runat="server" Text="Add up to five options for your poll"></asp:Label>
        </div>
    </div>
    <div class="row my-3">
        <div class="col text-center">
            <asp:TextBox ID="tbOption1" CssClass="tb-voter form-control" placeholder="Enter Option" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row my-3">
        <div class="col text-center">
            <asp:TextBox ID="tbOption2" CssClass="tb-voter form-control" placeholder="Enter Option" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row my-3">
        <div class="col text-center">
            <asp:TextBox ID="tbOption3" CssClass="tb-voter form-control" placeholder="Enter Option" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row my-3">
        <div class="col text-center">
            <asp:TextBox ID="tbOption4" CssClass="tb-voter form-control" placeholder="Enter Option" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row my-3">
        <div class="col text-center">
            <asp:TextBox ID="tbOption5" CssClass="tb-voter form-control" placeholder="Enter Option" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="row my-5">
        <div class="col text-center">
            <asp:Button ID="btnCreatePoll" runat="server" Text="Create Poll" CssClass="btn btn-success btn-xl body-width" OnClick="btnCreatePoll_Click" />
        </div>
    </div>





</asp:Content>
