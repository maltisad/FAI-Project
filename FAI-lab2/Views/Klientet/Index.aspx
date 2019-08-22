<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FAI_lab2.Views.Klientet.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <html>
       
      <head>
              <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'>
            <link rel="stylesheet" href="../../Content/StyleSheet1.css" />
            <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.0.13/css/all.css'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Roboto:300,400,500,700'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Montserrat:400,500,600,700,800,900'>
       
          </head>
        <body>
   <header id="header">
    <div class="container d-flex">
      <a class="logo">
        <img   src="../Images/logo1.png" style="width:100%;margin-top:20px;"">
      </a>
      <ul class="menu d-flex tab-title">
        <li>
          <a href="../Features/About.aspx">Dashboard</a>
        </li>
        <li>
          <a href="../Features/About.aspx">Features</a>
        </li>
        <li>
          <a href="../Zhvleresimet/Index.aspx">Zhvleresimi</a>
        </li>
        <li>
          <a href="../Amortizimet/Index.aspx">Amortizimi</a>
        </li>
      </ul>
    
    </div>
  </header>
     <div id="main">
    <div class="container">
      <div id="product" class="tab-inner">
     
        <div class="info-wrapper">
          <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
              <li class="breadcrumb-item">
                <a href="javascript:;">
                  <i class="fas fa-home"></i>Home</a>
              </li>
              <li class="breadcrumb-item active" aria-current="page">Groups</li>
            </ol>
          </nav>
          <div class="info-panel d-flex">
            <h4 class="title">Regjistrimi i Klientit</h4>
          </div>
        </div>
        <div class="block-1">
          <div class="control d-flex">
            <!-- Button trigger modal -->
            <button type="button" class="btn custom-modal" data-toggle="modal" data-target="#exampleModalCenter">
              Shto Klient
              <i class="fas fa-plus-circle"></i>
            </button>
            <!-- Modal -->
              <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
              <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLongTitle">Regjistrimi i  Klientit</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;
                      </span>
                    </button>
                  </div>
                  <div class="modal-body d-flex">
                    <div class="left-panel">
                     
                    </div>
                    <div class="right-panel">
                      <div class="product-info">
                           <asp:Label ID="lblError" runat="server" Text="Fushat e shenuara me (*) duhet të plotësohen!" Visible="False" CssClass="col-md-12 alert alert-danger"></asp:Label></label>
                        <div class="form-group">
                            
                          <label class="item-name">Informacionet e Klientit</label><br />
                             <asp:Label ID="nNameLabel"  runat="server" ></asp:Label>
                            <asp:TextBox ID="EmriTextBox" runat="server" placeholder="Shkruani Emrin* " CssClass="form-control form-title"></asp:TextBox>
                        
                        </div>
                        
                       <div class="form-group">
                         
                             <asp:Label ID="MbiemriLabel"  runat="server" ></asp:Label>
                            <asp:TextBox ID="MbiemriTextBox" runat="server" placeholder="Shkruani Mbiemrin " CssClass="form-control form-title"></asp:TextBox>
                        
                        </div>
                  <div class="form-group">
                        
                             <asp:Label ID="NumriTelefonitLabel"  runat="server" ></asp:Label>
                            <asp:TextBox ID="NumriTelefonitTextBox" runat="server" placeholder="Numri Kontaktues" CssClass="form-control form-title"></asp:TextBox>
                        
                        </div>
                          <div class="form-group">
                         
                             <asp:Label ID="Label1"  runat="server" ></asp:Label>
                            <asp:TextBox ID="EmailTextBox" runat="server" placeholder="Shkruani Email Adresen" CssClass="form-control form-title"></asp:TextBox>
                        
                        </div>
                          
                           <div class="bottom-btns d-flex">
                        
                        <asp:Button ID="CancelButton" type="button" runat="server" OnClick="CancelButton_Click"  class="btn btn-Draft" Text="Anulo" />
                        <asp:Button ID="SaveButton" type="button" runat="server" OnClick="SaveButton_Click" class="btn btn-publish" Text="Ruaj" />
                      </div>

                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
    <div class="portlet box green">
        <div class="portlet-title">
            <div class="caption">
             Lista e Klienteve te Regjistruar
            </div>
           
        </div>
        <div class="portlet-body flip-scroll">
            <asp:GridView
                ID="ListGridView"
                runat="server"
                CssClass="table table-bordered table-striped table-condensed flip-content"
                AllowPaging="True"
                PageSize="51"
                AllowSorting="True"
                AutoGenerateColumns="False"
                Width="100%"
                EditIndex="1"
                EnableViewState="False"
                OnPageIndexChanging="ListGridView_PageIndexChanging"
                OnRowCommand="ListGridView_RowCommand"
                OnRowDataBound="ListGridView_RowDataBound">

                <PagerSettings PageButtonCount="20" FirstPageText="Fillimi" LastPageText="Fundi" />
                <Columns>
                    <asp:TemplateField HeaderText="Emri" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="EmriLabel" runat="server" Text='<%# Bind("Emri") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Mbiemri" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="MbiemriLabel" runat="server" Text='<%# Bind("Mbiemri") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NumriTelefonit" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="NumriTelefonitLabel" runat="server" Text='<%# Bind("NumriTelefonit") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="" InsertVisible="False">
                    <ItemTemplate>
                             <asp:LinkButton ID="EditButton"
                                runat="server"
                                CommandName="EditCommandName"
                                CommandArgument='<%# Bind("KlientiID") %>'
                                class="btn btn-info btn-xs">
                                  Ndrysho
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField InsertVisible="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="DeleteButton"
                                runat="server"
                                CommandName="DeleteCommandName"
                                CommandArgument='<%# Bind("KlientiID") %>'
                                class="btn btn-danger red-mint btn-xs">
                                  Fshije
                    </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
            </div></div>

                            <script src='https://code.jquery.com/jquery-3.2.1.slim.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js'></script>
<script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.4.0/Chart.min.js'></script>

  

    <script  src="js/index.js"></script>

            </body>
        </html>
 </asp:Content>

