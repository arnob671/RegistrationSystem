<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="project.log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Human Resource Management<br />
         <br />
         Login Here...<br />
        <br />
    
    </div>
      
       
        <div>
            <asp:Label ID="Label5" runat="server" BackColor="White" Text="User Name:"></asp:Label>
&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server"
                 ErrorMessage="Required User Name" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
           
        </p>
        &nbsp;<br />
        <br />
            <asp:Label ID="Label6" runat="server" BackColor="White" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server"
                 ErrorMessage="Required User password" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
            
        </p>
            <asp:CheckBox ID="CheckBox1" runat="server" CausesValidation="false" Text="Remember me" />
        <br />
        <br />
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" />
        &nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false"  OnClick="LinkButton1_Click1">Sign up</asp:LinkButton>
        <br />
&nbsp;
        <asp:Label ID="Label7" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            </div>
    
    </div>
    </form>
</body>
</html>
