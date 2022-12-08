<%@ Page Title="Pemilik" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pemilik.aspx.cs" Inherits="projek._Pemilik" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
            <table>
                <tr>  
                    <td colspan="2">  
                        <h1>Menambah Data Pemilik</h1>  
                    </td>  
                </tr>
                <tr>  
                    <td>ID Pemilik</td>  
                    <td>:</td>  
                    <td>  
                        <asp:TextBox ID="idPemilik" runat="server"></asp:TextBox>  
                    </td>  
                </tr>
                <tr>  
                    <td>Nama Pemilik</td>  
                    <td>:</td>  
                    <td>  
                        <asp:TextBox ID="NamaPemilik" runat="server"></asp:TextBox>  
                    </td>  
                </tr>
                <tr>  
                    <td>No Hp</td>  
                    <td>:</td>  
                    <td>  
                        <asp:TextBox ID="NoHp" runat="server"></asp:TextBox>  
                    </td>  
                </tr>
                <tr>  
                    <td>Email</td>  
                    <td>:</td>  
                    <td>  
                        <asp:TextBox ID="Email" runat="server"></asp:TextBox>  
                    </td>  
                </tr>
                <tr>  
                    <td colspan="2">  
                        <asp:Button ID="btnInsertionPemilik" runat="server" Text="Insert" OnClick="tambahDataPemilik" Style="width: 65px" />  
                        <asp:Button ID="btnUpdationPemilik" runat="server" Text="Update" OnClick="ubahDataPemilik" />
                        <asp:Label ID="lblmsgPemilik" runat="server" ForeColor="Red"></asp:Label>  
                    </td>  
                </tr> 
            </table>
            <table>  
                <tr>  
                    <td>  
                        <h1>Melihat data Pemilik</h1>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="btnSelectPemilik" runat="server" Text="Select All Data" OnClick="lihatDataPemilik" />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:GridView ID="GridView2" runat="server" Width="410px"></asp:GridView>  
                    </td>  
                </tr>
            </table>
            <table>
                <tr>  
                    <td colspan="3">  
                        <h1>Hapus Data Pemilik</h1>  
                    </td>  
                </tr>  
                <tr>  
                    <td>ID Pemilik</td>  
                    <td>:</td>  
                    <td>  
                        <asp:TextBox ID="Pemilik" runat="server"></asp:TextBox>  
                    </td>  
                </tr>
                <tr>  
                    <td colspan="3">  
                        <asp:Button ID="btnDeletePemilik" runat="server" Text="Delete" OnClick="hapusDataPemilik" />  
                        <asp:Label ID="lblmessagePemilik" runat="server" ForeColor="Red"></asp:Label>  
                    </td>  
                </tr>
            </table>
            <table>  
                <tr>  
                    <td>  
                        <h1>Melihat data Penyewaan</h1>  
                    </td>  
                </tr>
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Select All Data" OnClick="lihatDataPenyewaan" />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:GridView ID="GridView3" runat="server" Width="410px"></asp:GridView>  
                    </td>  
                </tr>
            </table>
        </div>
<%--</html>--%>
</asp:Content>