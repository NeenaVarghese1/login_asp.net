<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Web2.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
    <div class="col">
        <asp:TextBox ID="TextBoxDefaultPageText" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
</div>
    <div class="row">
    <div class="col">
        <asp:Button ID="ButtonSave" class="btn btn-success" runat="server" Text="Save" OnClick="ButtonSave_Click" />
    </div>
</div>
</asp:Content>
