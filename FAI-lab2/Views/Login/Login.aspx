<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FAI_lab2.Views.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="../../Content/main.css">
 
      <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.0.13/css/all.css'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Roboto:300,400,500,700'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Montserrat:400,500,600,700,800,900'>
  
</head>
<body>
    <div class="container-login" style="background-image: url('/Views/Images/bg-02.jpg');">
			<div class="wrap-login">
				<form class="login-form" runat="server">
					
					

					<span class="form-title">
						Log in
					</span>

					<div class="form-input">
                         <asp:TextBox ID="txtUserName" runat="server" placeholder="Username"/>  
                        <asp:RequiredFieldValidator ID="rfvUser" ErrorMessage="Please enter Username" ControlToValidate="txtUserName" runat="server" />   
						
						<span class="focus-inputs"></span>
					</div>

					<div class="form-input">
						 <asp:TextBox ID="txtPWD" runat="server" placeholder="Password" TextMode="Password"/>  
                        <asp:RequiredFieldValidator ID="rfvPWD" runat="server" ControlToValidate="txtPWD" ErrorMessage="Please enter Password" /> </td> 
						<span class="focus-inputs"></span>
					</div>

			

					<div class="log-in">
						<asp:Button ID="btnSubmit" runat="server" Text="Log in" OnClick="btnSubmit_Click" />   
					</div>

					
				</form>
			</div>
		</div>
	

</body>
</html>
