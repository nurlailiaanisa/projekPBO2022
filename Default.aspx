<%@ Page Title="Default" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="projek._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Jember-Kost</h1>
        <p class="lead">Merupakan platform sistem publikasi informasi mengenai data kos yang tersebar di kabupaten Jember, baik Putra, Putri, maupun Campuran</p>
        <p><a href="About.aspx" class="btn btn-primary btn-lg">Detail &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Menu Dashboard</h2>
            <p>
                Dimenu Dashboard pemilik bisa menambahkan data kos, mengubah, melihat, 
                serta menghapus data kos.
            
            </p>
        </div>
        <div class="col-md-4">
            <h2>Menu Pemilik</h2>
            <p>
                Jika Anda Pemilik kos Anda bisa mengubah data kos Anda dan menghapus data pemilik di menu ini.
            </p>
        </div>
        <div class="col-md-4">
            <h2>Menu Penyewaan</h2>
            <p>
                Anda bisa melihat data kos dan pemiliknya serta menambah data penyewaan di menu ini.
            </p>
        </div>
    </div>

<table>  
    <tr>  
        <td colspan="2" style="height: 59px">  
            <h1>Menambah Data Kos</h1>  
        </td>  
    </tr>  
    <tr>  
        <td style="height: 24px">Nama Kos</td>  
        <td style="height: 24px">:</td>  
        <td style="height: 24px">  
            <asp:TextBox ID="NamaKos" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Jenis</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="Jenis" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>ID Pemilik</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="ID_pemilik" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Fasilitas</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="Fasilitas" runat="server"></asp:TextBox>  
        </td>  
    </tr>
    <tr>  
        <td>Lokasi</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="Lokasi" runat="server"></asp:TextBox>  
        </td>  
    </tr>
    <tr>  
        <td>Harga</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="Harga" runat="server"></asp:TextBox>  
        </td>  
    </tr>
    <tr>  
        <td>Stok kamar</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="Stok" runat="server"></asp:TextBox>  
        </td>  
    </tr>
    <tr>  
        <td colspan="2">  
            <asp:Button ID="btnInsertion" runat="server" Text="Insert" OnClick="tambahDataKos" Style="width: 65px" />  
            <asp:Button ID="btnUpdation" runat="server" Text="Update" OnClick="ubahDataKos" />
            <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>
    <tr>  
        <td>ID KOS</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
        </td>  
    </tr>
</table>
    
    <%--selection--%>
    <table>  
    <tr>  
        <td>  
            <h1>Lihat Data Kos</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>  
            <asp:Button ID="btnSelect" runat="server" Text="Select All Data" OnClick="lihatDataKos" />  
        </td>  
    </tr>  
    <tr>  
        <td>  
            <asp:GridView ID="GridView1" runat="server" Width="920px" HorizontalAlign="Center" AllowCustomPaging="True">
                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:GridView>  
        </td>  
    </tr>  
</table>
    
<table>  
    <tr>  
        <td colspan="3">  
            <h1>Hapus Data Kos </h1>
        </td>  
    </tr>  
    <tr>  
        <td>ID Kos</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="ID_kos" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td colspan="3">  
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="hapusDataKos" />  
            <asp:Label ID="lblmessage" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>  
</table>

</asp:Content>
