<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DCMFormData.aspx.cs" Inherits="TRACSLocal.DCMFormData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:GridView runat="server" ID="DCMGridData"
                    ItemType="TRACSLocal.DCMFormDataModel" ModelType="TRACSLocal.DCMFormDataModel"
                    AutoGenerateColumns="false">
                    <Columns>
                        <asp:DynamicField DataField="IssuerName" />
                        <asp:DynamicField DataField="ProjectName" />
                        <asp:DynamicField DataField="SizeofDistribution" />
                        <asp:DynamicField DataField="DealTeam" />
                    </Columns>
                </asp:GridView>
        </div>
    <br />  
    <asp:Button ID="btnRedirectFormDataEntry" runat="server" CausesValidation="false" Text="Create Form" CssClass="btn btn-primary" OnClick="btnRedirectFormDataEntry_Click"/>  
    </form>
</body>
</html>
