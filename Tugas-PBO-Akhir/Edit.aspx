<%@ Page Title="Edit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Tugas_PBO_Akhir.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main class="mt-5">
        <section class="input_section  mt-3">
            <h2>Edit Data</h2>
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
                <div class="input input-dropdown mt-2">
                        <asp:Label for="inputComplete" runat="server" Text="Action" /><br />
                        <div class="select-wrapper">
                            <select class="select-box">
                                <option>Finished</option>
                                <option>Undone</option>
                            </select>
                        </div>
                </div>
                <div class="text-center button mt-2">
                    <a class="btn btn-danger m-2" Text="Cancel" runat="server" href="~/">Cancel</a>
                    <asp:Button class="btn btn-primary m-2" Text="Edit" runat="server" />
                </div>
           
            </div>
        </section>
    </main>

</asp:Content>