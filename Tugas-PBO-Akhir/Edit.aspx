<%@ Page Title="Edit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Tugas_PBO_Akhir.Edit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="mt-5">
        <section class="input_section  mt-3">
            <h2>Edit Data</h2>
            <div id="inputList" class="text-white">
                <div class="input mt-2">
                    <asp:Label for="taskInput" ID="taskLabel" runat="server" Text="Task" />
                    <asp:TextBox ID="taskInput" class="form-control full-width" runat="server" />
                </div>
                <div class="input mt-2">
                    <asp:Label for="dlInput" ID="dlLabel" runat="server" Text="Deadline" />
                    <asp:TextBox ID="dlInput" class="form-control full-width" textmode="DateTimeLocal" runat="server"/>
                </div>
                <div class="input input-dropdown mt-2">
                        <asp:Label for="statusInput" ID="statusLabel" runat="server" Text="Action" /><br />
                        <asp:DropDownList class="custom-select"  ID="statusInput" runat="server">
                            <asp:ListItem Value="False" Selected="False">  
                                Unfinished  
                            </asp:ListItem>
                            <asp:ListItem Value="True" Selected="False">  
                                Finished  
                            </asp:ListItem>
                        </asp:DropDownList>
                </div>
                <div class="text-center button mt-2">
                    <a class="btn btn-danger m-2" Text="Cancel" runat="server" href="~/">Cancel</a>
                    <asp:Button class="btn btn-primary m-2" Text="Edit" OnClick="updateData" runat="server" />
                </div>
           
            </div>
            <asp:Label ID="warning" runat="server" ForeColor="Red"></asp:Label>
        </section>
    </main>
</asp:Content>
