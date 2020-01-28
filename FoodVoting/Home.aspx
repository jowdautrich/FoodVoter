<%@ Page Language="C#" MasterPageFile="~/GroupVoter.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FoodVoting.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="/Assets/CSS/Home.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="row my-5 text-center">
        <div class="col text-center">
            <asp:Button ID="btnCreatePoll" runat="server" Text="Create New Poll" CssClass="btn btn-primary btn-xl button-home" OnClick="btnCreatePoll_Click" />
        </div>
    </div>
    <div class="row mt-5">
        <div class="col text-center">
            <asp:TextBox ID="tbVoteId" CssClass="tb-home form-control" placeholder="Enter Poll ID" runat="server"></asp:TextBox>
        </div>
        
    </div>
    <div class="row mt-2 mb-5">
        <div class="col text-center">
            <asp:Button ID="btnVote" runat="server" Text="Vote" CssClass="btn btn-success btn-xl button-home" OnClick="btnVote_Click" />
        </div>
    </div>
    <div class="row mt-5">
        <div class="col text-center">
            <asp:TextBox ID="tbResultsId" CssClass="tb-home form-control" placeholder="Enter Poll ID" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row mt-2">
        <div class="col text-center">
            <asp:Button ID="btnViewResults" runat="server" Text="View Poll Results" CssClass="btn btn-info btn-xl button-home" OnClick="btnViewResults_Click" />
        </div>
    </div>
</asp:Content>
