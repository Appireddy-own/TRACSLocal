<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DCMForm.aspx.cs" Inherits="TRACSLocal.DCMForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
<title></title>  
<style type="text/css">  
.auto-style1 {  
     width: 100%;  
      }  
.auto-style2 {  
     width: 128px;  
       }  
.auto-style3 {  
      width: 128px;  
      height: 23px;  
        }  
.auto-style4 {  
      height: 23px;  
        }  
td{
    width:20px;
    padding:6px;
}
</style>  
</head>  
<body>  
<form id="form1" runat="server">  
<div>           
  <table class="auto-style1">  
    <tr>  
    <td>  
    <asp:Label ID="lblissuerName" runat="server" Text="Issuer Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtissuerName" runat="server" ></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="lblProjectName" runat="server" Text="Project Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtProjectName" runat="server" ></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="lblSizeofDistribution" runat="server" Text="Size of Distribution"></asp:Label></td>  
    <td>  
    <asp:TextBox ID="txtSizeofDistribution" runat="server" ></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="lblDealTeam" runat="server" Text="Deal Team"></asp:Label></td>  
    <td>  
    <asp:TextBox ID="txtDealTeam" runat="server" ></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    </td>  
    <td>  
    <br />  
    <asp:Button ID="btnSubmit" runat="server" Text="Submit Data" CssClass="btn btn-primary" OnClick="FormSubmit_Click"/>  
    </td>  
    </tr>  
      <tr>  
    <td> 
    <asp:Button ID="btnHome" runat="server" CausesValidation="false" Text="TRACS Home" CssClass="btn btn-primary" OnClick="btnHome_Click"/>  
    </td>  
    <td>  
    <br />  
    <asp:Button ID="btnRedirectToList" runat="server" CausesValidation="false" Text="View Data" CssClass="btn btn-primary" OnClick="btnRedirectToList_Click"/>  
    </td>  
    </tr> 
    </table>  
    </div>  
    </form>  
</body>  
</html>  
