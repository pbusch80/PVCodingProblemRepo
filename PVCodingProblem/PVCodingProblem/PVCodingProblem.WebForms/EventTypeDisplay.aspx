<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventTypeDisplay.aspx.cs" Inherits="PVCodingProblem.WebForms.EventTypeDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Which Event Type you would like to see the contents of:&nbsp;
        <asp:DropDownList ID="eventTypesDdl" runat="server">
            <asp:ListItem>Register</asp:ListItem>
            <asp:ListItem>Diagnose</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="generateContentBtn" runat="server" OnClick="generateContentBtn_Click" Text="Generate" />
        <br />
        <asp:Repeater ID="eventTypeOutputResultsRpt" runat="server">
            <HeaderTemplate>
                <table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#(((RepeaterItem)Container).ItemIndex+1).ToString() %></td>
                    <td><%# Container.DataItem %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <br />
    </div>
    </form>
</body>
</html>
