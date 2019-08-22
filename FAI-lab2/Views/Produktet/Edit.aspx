<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FAI_lab2.Views.Produktet.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <html>
       
      <head>
              <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'>
            <link rel="stylesheet" href="../../Content/StyleSheet1.css" />
             <link rel="stylesheet" href="../../Content/ProduktiStylesheet.css" />
            <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.0.13/css/all.css'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Roboto:300,400,500,700'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Montserrat:400,500,600,700,800,900'>
       
    <header id="header">
    <div class="container d-flex">
      <a class="logo">
           <img   src="../Images/logo1.png" style="width:100%;"">
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
    
           <div class="block-1" style="margin-top: 60px;">
          <div class="control d-flex">
         <div  id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="form-horizontal">
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Ndrysho Produktin" runat="server"  Style="color: #337ab7; font-weight: bold;"></asp:Label>
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
                    <asp:Label ID="EmriLabel" Text="Produkti*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="EmriTextBox" CssClass="form-control" runat="server" Placeholder="Emri i Produktit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NameHelpBlockLabel" Text="Shkruani emrin e Produktit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="ProdhuesiLabel" Text="Prodhuesi*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="ProdhuesiTextBox" CssClass="form-control" runat="server" Placeholder="Prodhuesi"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="ProdhuesiHelpBlockLabel" Text="Shkruani Prodhuesin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="ModeliLabel" Text="Modeli*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="ModeliTextBox" CssClass="form-control" runat="server" Placeholder="Modeli"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="ModeliHelpBlockLabel" Text="Shkruani Modelin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="DataLabel" Text="Data*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="DataTextBox" CssClass="form-control" runat="server" Placeholder="Data" Width="114px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Views/Images/calendar.png" OnClick="ImageButton1_Click" />
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender"></asp:Calendar>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="DataHelpBlockLabel" Text="Caktoni Daten" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="PershkrimiLabel" Text="Pershkrimi*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="PershkrimiTextBox" CssClass="form-control" runat="server" Placeholder="Pershkrimi"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="PershkrimiHelpBlockLabel" Text="Shkruani Modelin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="JetegjatesiaLabel" Text="Jetegjatesia*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="JetegjatesiaTextBox" CssClass="form-control" runat="server" Placeholder="Jetegjatesia"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="JetegjatesiaHelpBlockLabel" Text="Shkruani Jetegjatesine" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="CmimiLabel" Text="Cmimi*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="CmimiTextBox" CssClass="form-control" runat="server" Placeholder="Cmimi"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="CmimiHelpBlockLabel" Text="Shkruani Cmimin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="LlojiLabel" Text="Asset*" runat="server"></asp:Label>
                </label>
                <asp:RadioButtonList ID="llojiProduktit" runat="server">
                <asp:ListItem id="aset" Text="Aset" Value="Aset" />
                <asp:ListItem id="inventor" Text="Inventor" Value="Inventor" />
                </asp:RadioButtonList>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="Label1" Text="Grupi*" runat="server"></asp:Label>
                </label>
                <asp:DropDownList ID="GrupiDropDownList" DataTextField="Grupi" 
                    DataValueField="GrupiID" runat="server">
                </asp:DropDownList> 
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="StatusiLabel" Text="Statusi*" runat="server"></asp:Label>
                </label>
                 <asp:CheckBox ID="StatusiCheckBox" Text="A është duke u përdorur?"  runat="server" />
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="NrSerikLabel" Text="NrSerik*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="NrSerikTextBox" CssClass="form-control" runat="server" Placeholder="NrSerik"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NrSerikHelpBlockLabel" Text="Shkruani salvage value të produktit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="salvageValueLabel" Text="salvageValue*" runat="server"></asp:Label>
                </label>
                <div class="col-md-8 offset-md-1">
                    <asp:TextBox ID="salvageValueTextBox" CssClass="form-control" runat="server" Placeholder="salvageValue"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="SalvageValueHelpBlockLabel" Text="Shkruani salvage value të produktit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-actions">
                <div class="row">
                    <div class="butonat">

                        <asp:Button ID="CancelButton" type="button" runat="server" OnClick="CancelButton_Click" class="btn default" Text="Anulo" />
                        <asp:Button ID="SaveButton" type="button" runat="server" OnClick="SaveButton_Click" class="btn btn-primary" Text="Ruaj" />
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
