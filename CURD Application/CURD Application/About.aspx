<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CURD_Application.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="font-size:x-large" align="center">STUDENT INFORMATION CURD OPERATION</div>
  <br />
    <table class="nav-justified">
        <tr>
            <td style="width: 203px; height: 22px"></td>
            <td class="text-left" style="width: 255px; height: 22px">student ID</td>
            <td style="height: 22px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#6666FF" ForeColor="White" OnClick="Button5_Click" Text="GET" />
            </td>
        </tr>
        <tr>
            <td style="width: 203px">&nbsp;</td>
            <td class="text-left" style="width: 255px">student Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 203px; height: 20px"></td>
            <td class="text-left" style="width: 255px; height: 20px">Address</td>
            <td style="height: 20px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 203px">&nbsp;</td>
            <td class="text-left" style="width: 255px">Age</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 203px; height: 20px"></td>
            <td class="text-left" style="width: 255px; height: 20px">Contact</td>
            <td style="height: 20px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 203px">&nbsp;</td>
            <td style="width: 255px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 203px">&nbsp;</td>
            <td style="width: 255px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#6666FF" ForeColor="White" OnClick="Button1_Click" Text="INSERT" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#6666FF" ForeColor="White" OnClick="Button2_Click" Text="UPDATE" />
&nbsp;
                <asp:Button ID="Button3" runat="server" BackColor="#6666FF" ForeColor="White" OnClick="Button3_Click" Text="DELETE" />
&nbsp;
                <asp:Button ID="Button4" runat="server" BackColor="#6666FF" ForeColor="White" OnClick="Button4_Click" Text="SEARCH" />
            </td>
        </tr>
        <tr>
            <td style="width: 203px">&nbsp;</td>
            <td style="width: 255px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 203px">&nbsp;</td>
            <td style="width: 255px">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Width="457px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 203px">&nbsp;</td>
            <td style="width: 255px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
