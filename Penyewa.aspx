<%@ Page Title="Penyewa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Penyewa.aspx.cs" Inherits="projek.Penyewa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
            <table>  
                <tr>  
                    <td>  
                        <h1>Melihat Data Kos</h1>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="btnSelect" runat="server" Text="Select All Data" OnClick="selectDataKos" />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:GridView ID="GridView1" runat="server" Width="603px"></asp:GridView>  
                    </td>  
                </tr>


                <tr>  
                    <td>  
                        <h1>Melihat Data Pemilik Kos</h1>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="btnSelectPemilik" runat="server" Text="Select All Data" OnClick="selectDataPemilik" />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:GridView ID="GridView2" runat="server" Width="606px"></asp:GridView>  
                    </td>  
                </tr>
            </table>
            <table>
                <tr>  
                    <td colspan="3">
                        <h1>Menambah Data Penyewaan</h1>  
                    </td>  
                </tr>  
                <tr>  
                    <td style="height: 24px;">Tanggal</td>  
                    <td style="height: 24px">:</td>  
                    <td style="height: 24px">  
                        <asp:TextBox ID="TanggalSewa" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td style="height: 24px;">Penyewa</td>  
                    <td style="height: 24px">:</td>  
                    <td style="height: 24px">  
                        <asp:TextBox ID="NamaPenyewa" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td style="height: 24px">No HP</td>  
                    <td style="height: 24px">:</td>  
                    <td style="height: 24px">  
                        <asp:TextBox ID="NoHp" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>ID Kos</td>  
                    <td>:</td>  
                    <td>  
                        <asp:TextBox ID="IDKos" runat="server"></asp:TextBox>  
                    </td>  
                </tr>
                <tr>  
                    <td colspan="2">  
                        <asp:Button ID="btnSewa" runat="server" Text="Ajukan Penyewaan" OnClick="ajukan_sewa" Width="161px" />  
                        <asp:Label ID="lblmsgSewa" runat="server" ForeColor="Red"></asp:Label>  
                    </td>  
                </tr>
            </table>
        </div>

</asp:Content>