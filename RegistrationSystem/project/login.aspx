<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="project.login" %>
<script src="Scripts/jquery-1.9.1.js"></script>
<script src="Scripts/jquery-migrate-1.2.1.min.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 229px">

        <asp:Panel ID="Panel2" runat="server" Height="250px">
             Create an Account...<br />
        <p>
            <asp:Label ID="Label1" runat="server" BackColor="White" Text="User Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ErrorMessage="Name is Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "TextBox1" ID="RegularExpressionValidator3" ValidationExpression = "^[\s\S]{5,20}$" runat="server"
                ErrorMessage="Minimum 5 and Maximum 20 character required."></asp:RegularExpressionValidator>
           
            
    
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" BackColor="White" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Enter password" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "TextBox2" ID="RegularExpressionValidator1" ValidationExpression = "^[\s\S]{4,20}$" runat="server"
                ErrorMessage="Minimum 4 and Maximum 20 character required."></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" BackColor="White" Text="Confirm Password:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" textMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" ErrorMessage="Enter password for confirm" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "TextBox3" ID="RegularExpressionValidator2" ValidationExpression = "^[\s\S]{4,20}$" runat="server"
                ErrorMessage="Minimum 4 and Maximum 20 character required."></asp:RegularExpressionValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox3" ControlToCompare="TextBox2" ErrorMessage="Password Mismatch" ></asp:CompareValidator>
        </p>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
        &nbsp;&nbsp;&nbsp;
             <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CausesValidation="false">Go for sign in..</asp:LinkButton>
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        <br />
           
       
        </div>

        </asp:Panel>
        
        <div>
            <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        </div>
        
           
       
    </form>
</body>
</html>
