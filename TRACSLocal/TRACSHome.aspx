<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TRACSHome.aspx.cs" Inherits="TRACSLocal.TRACSHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="btnMVCPage" runat="server" CausesValidation="false" Text="Create ABS (MVC Form)" CssClass="btn btn-primary" OnClick="btnMVCPage_Click"/>  
        <asp:Button ID="btnASPXPage" runat="server" CausesValidation="false" Text="Create DCM (ASPX Form)" CssClass="btn btn-primary" OnClick="btnASPXPage_Click"/>  
        </div>
    </form>
</body>
</html>
