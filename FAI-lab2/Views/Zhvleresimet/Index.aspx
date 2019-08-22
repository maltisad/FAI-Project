<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FAI_lab2.Views.Zhvleresimet.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                  <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'>
            <link rel="stylesheet" href="../../Content/StyleSheet1.css" />
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
          <div id="product" class="tab-inner">
     
        <div class="info-wrapper">
       
          <div class="block-1" style="margin-top: 60px;">
         
    <div class="form-horizontal">
       
    
        <div class="table table-striped custom-table">
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
                    <asp:TemplateField HeaderText="Pershkrimi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="PershkrimiLabel" runat="server" Text='<%# Bind("Pershkrimi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Prodhuesi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="ProdhuesiLabel" runat="server" Text='<%# Bind("Prodhuesi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Modeli" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="ModeliLabel" runat="server" Text='<%# Bind("Modeli") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Jetegjatesia" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="JetegjatesiaLabel" runat="server" Text='<%# Bind("Jetegjatesia") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Asset" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="AssetLabel" runat="server" Text='<%# Bind("Lloji") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Grupi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="GrupiLabel" runat="server" Text='<%# Bind("GrupiID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Statusi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="StatusiLabel" runat="server" Text='<%# Bind("Statusi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NrSerik" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="NrSerikLabel" runat="server" Text='<%# Bind("NrSerik") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="salvageValue" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="salvageValueLabel" runat="server" Text='<%# Bind("salvageValue") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cmimi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="CmimiLabel" runat="server" Text='<%# Bind("Cmimi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="DataLabel" runat="server" Text='<%# Bind("Data1") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="" InsertVisible="False">
                    <ItemTemplate>
                             <asp:LinkButton ID="EditButton"
                                runat="server"
                                CommandName="EditCommandName"
                                CommandArgument='<%# Bind("ProduktiID") %>'
                                class="btn btn-primary btn-xs">
                                  Shiko Zhvlersimin
                            </asp:LinkButton>
                        </ItemTemplate>
                 
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </div>
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


