<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="linqtosql.aspx.cs" Inherits="strona.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <asp:Button ID="btnGetData" runat="server" OnClick="btnGetData_Click" Text="Get Data" />
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="height: 26px" Text="Delete" />
        <br />
        <asp:Label ID="lblDept" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnGetEmployeesByDepartment" runat="server" OnClick="btnGetEmployeesByDepartment_Click" Text="Get Employees By Department" />
    </form>
</body>
</html>
