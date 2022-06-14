<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tugas_PBO_Akhir._Default" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <table  class="table table-striped table-dark mt-5">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Task</th>
                <th scope="col">Deadline</th>
                <th scope="col">Status</th>
            </tr>
        </thead>
        <tbody ID="body"  runat="server">
            
        </tbody>
    </table>
    <asp:Label ID="warning" runat="server" ForeColor="Red"></asp:Label>

</asp:Content>
