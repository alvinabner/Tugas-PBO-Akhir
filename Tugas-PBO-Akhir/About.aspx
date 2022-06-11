<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Tugas_PBO_Akhir.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="mt-5">
        <section class="input_section  mt-3">
            <h2>Input New Book</h2>
            <div id="inputList" class="text-white">
                <div class="input">
                    <asp:Label for="inputListName" runat="server" Text="Nama" >
                    <asp:TextBox ID="inputListName" class="form-control" runat="server" />
                    </asp:Label>
                </div>
                <div class="input">
                    <asp:Label for="inputBookAuthor" runat="server" Text="Deadline" >
                    <asp:TextBox ID="inputBookAuthor" class="form-control" textmode="DateTimeLocal" runat="server"/>
                    </asp:Label>
                </div>
                <div class="input m-auto">
                    <label  for="inputBookYear">Year</label>
                    <input id="inputBookYear" class="form-control">
                </div>
            </div>
        </section>
    </main>
</asp:Content>
