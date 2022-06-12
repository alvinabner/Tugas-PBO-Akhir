<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Tugas_PBO_Akhir.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="mt-5">
        <section class="input_section  mt-3">
            <h2>Input Data</h2>
            <div id="inputList" class="text-white">
                <div class="input mt-2">
                    <asp:Label for="inputListName" runat="server" Text="Nama" />
                    <asp:TextBox ID="inputListName" class="form-control full-width" runat="server" />
                </div>
                <div class="input mt-2">
                    <asp:Label for="inputBookAuthor" runat="server" Text="Deadline" >
                    <asp:TextBox ID="inputBookAuthor" class="form-control full-width" textmode="DateTimeLocal" runat="server"/>
                    </asp:Label>
                </div>
                <div class="input input-dropdown mt-4">
                        <asp:Label for="inputComplete" runat="server" Text="Action" /><br />
                        <div class="select-wrapper">
                            <select class="select-box">
                                <option>Finished</option>
                                <option>Undone</option>
                            </select>
                        </div>
                </div>
           
            </div>
        </section>
    </main>
</asp:Content>
