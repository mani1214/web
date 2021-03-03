<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="5">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">Employee ID</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">Employee Name </td>
                <td colspan="3">
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">Employee Salary</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtSal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnInsert" runat="server" OnClick="BtnInsert_Click" Text="Insert" />
                </td>
                <td>
                    <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
                </td>
                <td>
                    <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
                </td>
                <td>
                    <asp:Button ID="BtnShow" runat="server" OnClick="BtnShow_Click" Text="Show" />
                </td>
                <td>
                    <asp:Button ID="BntFind" runat="server" OnClick="BntFind_Click" Text="Find" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
