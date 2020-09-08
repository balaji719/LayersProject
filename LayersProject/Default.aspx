<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LayersProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
    <tr>
    <td colspan="2">
    3-tier</td>
    </tr>
    <tr>
    <td>
           Name of the Company :</td>
    <td>
    <asp:TextBox ID="txtcomanyname" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
   Incorporation(Year):
    </td>
    <td>
    <asp:TextBox ID="IYear" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    Location :
    </td>
    <td>
    <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    State :
    </td>
    <td>
    <asp:TextBox ID="state" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
        &nbsp;</td>
    <td>
    <asp:Button ID="btnsave" runat="server" Text="SAVE" />
    </td>
    </tr>
     </table>
    
        </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="+"></asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
