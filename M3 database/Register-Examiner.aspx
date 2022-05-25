<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register-Examiner.aspx.cs" Inherits="M3_database.Register_Examiner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link href="register-student.css" rel="stylesheet" />

</head>
<body>
    <div class ="loginbox"> 
       <img src="img/user.png" alt =" Alternative Text" class ="user"/> 
        <h2>Register Here</h2>

        <form id="form2" runat="server">
            <asp:Label Text="name" CssClass="lblname" runat ="server" />
            <asp:TextBox ID="name" runat="server" CssClass="txttype" placeholder="ENTER NAME" required="true"/>
       
            <br />
       
            <asp:Label Text="Email" CssClass="lblemail" runat ="server" />
            <asp:TextBox ID="email" runat="server" CssClass="txtemail" placeholder="Enter Email" required="true" />
            <asp:Label Text="Password" CssClass="lblpass"  runat="server" />
            <asp:TextBox ID="password"  runat ="server" CssClass="txtpass" placeholder="********" required="true" />

            <asp:Label Text="fieldOfWork" CssClass="lblname"  runat="server" />
            <asp:TextBox ID="fieldOfWork"  runat ="server" CssClass="txttype" placeholder="field of work" required="true" />
            <br />
            <br />
            <asp:RadioButton ID="national" text="national" groupname="nationality" runat="server" CssClass="Gucian" OnCheckedChanged="national_CheckedChanged" required="false"/>
            <asp:RadioButton ID="international" text="international" groupname="nationality" runat="server" CssClass="Gucian" OnCheckedChanged="international_CheckedChanged" required="false" />
            <br />
            <br />
                        <asp:Button Text="Sign Up" CssClass="Signup"  runat="server" OnClick="signupclick"  />
            <br />
             
             <br />
            <br />
                   <asp:Label ID="national2" Text="Kindly choose national/international" CssClass="lblnamee"  runat="server" ForeColor="Red"  Visible="false" />
                 </form>
    </div>


</body>
</html>
