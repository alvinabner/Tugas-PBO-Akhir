<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tugas_PBO_Akhir._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <table class="table table-striped table-dark mt-5">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Task</th>
                <th scope="col">Deadline</th>
                <th scope="col">Status</th>
            </tr>
        </thead>
        <tbody>
            <% for (int i = 0; i < 5; i++)
                {  %>
            <tr>
                <th scope="row">1</th>
                <td>Mark</td>
                <td><%= i+1 %> Januari 2022</td>
                <td><a class="btn btn-primary mr-2" href="Edit.aspx">Edit</a>
                    <a class="btn btn-danger mr-2">Delete</a></td>
            </tr>

            <%} %>
        </tbody>
    </table>

</asp:Content>
