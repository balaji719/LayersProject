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
                <td class="auto-style1">Name of the Company</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                    </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>Incorporation(year)</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                   </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Location</td>
                <td style="margin-left: 80px">
                    <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
                  </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>State</td>
                <td style="margin-left: 80px">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                  </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="margin-left: 80px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="margin-left: 80px">
                    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            
        </table>
        </div>
        <asp:GridView ID="GridView1" ShowHeaderWhenEmpty="true" EmptyDataText="true" runat="server" AutoGenerateColumns="false"  CellPadding="4" ForeColor="#333333" GridLines="None" Width="456px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                
                <asp:TemplateField  HeaderText="Name Of The Company">
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Incorporation(Year)">
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Location">
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="State">
                </asp:TemplateField>
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
