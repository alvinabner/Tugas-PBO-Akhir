<%@ Page Title="Add Todo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Tugas_PBO_Akhir.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="mt-5">
        <section class="input_section  mt-3">
            <h2>Input Data</h2>
            <div id="inputList" class="text-white">
                <div class="input mt-2">
                    <asp:Label for="todo" runat="server" Text="Todo" />
                    <asp:TextBox ID="todo" class="form-control full-width" runat="server" />
                </div>
                <div class="input mt-2">
                    <asp:Label for="deadline" runat="server" Text="Deadline">
                        <asp:TextBox ID="deadline" class="form-control full-width" TextMode="DateTimeLocal" runat="server" />
                    </asp:Label>
                </div>
                <div class="input input-dropdown mt-2">
                    <asp:Label for="status" runat="server" Text="Action" /><br />
                        <asp:DropDownList class="custom-select w-100" ID="status" runat="server">
                            <asp:ListItem Value="False" Selected="True">  
                                Undone  
                            </asp:ListItem>
                            <asp:ListItem Value="True" Selected="False">  
                                Completed  
                            </asp:ListItem>
                        </asp:DropDownList>
                    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                <div class="text-center button mt-2">
                    <a class="btn btn-danger m-2" text="Cancel" runat="server" href="~/">Cancel</a>
                    <asp:Button class="btn btn-success m-2" Text="Done" runat="server" OnClick="insertData" />
                </div>

            </div>
        </section>
    </main>
</asp:Content>
