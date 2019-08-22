<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FAI_lab2.Views.Punetoret.Edit" %>
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
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Regjistro Klientin" runat="server" class="col-md-3 control-label" Style="color: #337ab7; font-weight: bold;"></asp:Label>
        </div>
        <div class="form-body">
            <div class="form-group">
                <label class="text-center" style="width: 100%;">
                    <br />
                    <asp:Label ID="lblError" runat="server" Text="Fushat e shenjuara me (*) duhet të plotësohen!" Visible="False" CssClass="col-md-12 alert alert-danger"></asp:Label></label>
                <br />
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="nNameLabel" Text="Emri i Klientit*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="EmriTextBox" CssClass="form-control" runat="server" Placeholder="Emri i Klientit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NameHelpBlockLabel" Text="Shkruani emrin e Klientit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="MbiemriLabel" Text="Mbiemri*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="MbiemriTextBox" CssClass="form-control" runat="server" Placeholder="Mbiemri"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="MbiemriHelpBlockLabel" Text="Shkruani Mbiemrin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
         <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="GjiniaLabel" Text="Gjinia*" runat="server"></asp:Label>
                </label>
                <asp:RadioButtonList ID="Gjinia" runat="server">
                <asp:ListItem id="m" Text="M" Value="M" />
                <asp:ListItem id="f" Text="F" Value="F" />
                </asp:RadioButtonList>
            </div>
             <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="RoliLabel" Text="Roli*" runat="server"></asp:Label>
                </label>
                <asp:DropDownList ID="RoliDropDownList" DataTextField="Roli" 
                    DataValueField="RoliID" runat="server">
                </asp:DropDownList> 
            </div>
                 
            <div class="form-actions">
                <div class="EditButtons">
                   

                   
                        <asp:Button ID="CancelButton" type="button" runat="server" OnClick="CancelButton_Click" class="btn default" Text="Anulo" />
                        <asp:Button ID="SaveButton" type="button" runat="server" OnClick="SaveButton_Click" class="btn btn-primary" Text="Ruaj" />
                   
                    
                </div>
            </div>
        </div>

    </div>
</asp:Content>
