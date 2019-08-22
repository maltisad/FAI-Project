<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="FAI_lab2.Views.Punetoret.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
          <html>
       
      <head>
              <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'>
            <link rel="stylesheet" href="../../Content/StyleSheet1.css" />
          <link rel="stylesheet" href="../../Content/EditDelete.css" />
            <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.0.13/css/all.css'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Roboto:300,400,500,700'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Montserrat:400,500,600,700,800,900'>
       
    <header id="header">
    <div class="container d-flex">
      <a class="logo">
         <img   src="../Images/logo1.png" style="width:100%;margin-top:20px;"">
      </a>
      <ul class="menu d-flex tab-title">
        <li>
          <a href="#dashboard">Dashboard</a>
        </li>
        <li>
       
   <asp:HyperLink ID="ShtoHyperLink" runat="server" Text="Features" NavigateUrl="~/Views/Features/About.aspx" CssClass="btn-link"></asp:HyperLink>
        </li>
        <li>
          <a href="#product">Zhvleresimi</a>
        </li>
        <li>
          <a href="#product">Raportet</a>
        </li>
      </ul>
      <div class="dropdown user">
        <button class="btn dropdown-toggle custom-btn d-flex" type="button" id="userMenu" data-toggle="dropdown" aria-haspopup="true"
          aria-expanded="false">
          <div class="photo d-flex">
            <img src="https://images2.imgbox.com/61/7d/UskGXtvx_o.jpg">
          </div>
          <div class="name d-flex">Admin</div>
        </button>
        <div class="dropdown-menu" aria-labelledby="userMenu">
          <a class="dropdown-item" href="javascript:;">My Profile</a>
          <a class="dropdown-item" href="javascript:;">Log Out</a>
        </div>
      </div>
    </div>
  </header>
           <div class="container">
      <div id="product" class="tab-inner">
     
        <div class="info-wrapper">
         
           <div class="block-1" style="margin-top: 60px;">
          <div class="control d-flex">

          <div  id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">  
    <div class="form-horizontal">
        <div class="form-body1">
            <div class="form-group">
                <label class="text-center" style="width: 100%;">
                    <asp:Label ID="lblError" runat="server" Text="A jeni i sigurt se dëshironi ta fshini këtë entitet?" Visible="False" CssClass="col-md-12 alert alert-danger"></asp:Label></label>
                <br/>
            </div>
        </div>
        <div class="form-actions">
            <div class="DelButtons">
               
                    <asp:Button ID="btnCancel" runat="server" Text="Anulo" OnClick="btnCancel_Click" CssClass="btn default" />&nbsp;
                    <asp:Button ID="btnOK" runat="server" Text="Fshije" OnClick="btnOK_Click" CssClass="btn btn-danger" />
             
            </div>
        </div>
    </div
</asp:Content>
