<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="FAI_lab2.Views.Amortizimet.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <head>
              <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'>
            <link rel="stylesheet" href="../../Content/StyleSheet1.css" />
           <link rel="stylesheet" href="../../Content/StyleSheet2.css" />
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
          <a href="../Features/About.aspx">Dashboard</a>
        </li>
        <li>
          <a href="../Features/About.aspx">Features</a>
        </li>
        <li>
          <a href="../Zhvlersimet/Index.aspx">Zhvleresimi</a>
        </li>
        <li>
          <a href="../Amortizimet/Index.aspx">Amortizimi</a>
        </li>
      </ul>
    
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
            <asp:Label ID="TitlePageLabel" Text="Emri i Produktit" runat="server" class="col-md-5 control-label" Style="color: #337ab7; font-weight: bold;margin-left:332px;"></asp:Label>
        </div>
        <div class="form-body">
            <div class="form-group">
                <label class="text-center" style="width: 100%;">
                    <br />
                    <asp:Label ID="lblError" runat="server" Text="Fushat e shenjuara me (*) duhet të plotësohen!" Visible="False" CssClass="col-md-12 alert alert-danger"></asp:Label></label>
                    <br />
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-5 control-label" for="form_control">
                    <asp:Label ID="DataSotLabel" Text="Data Sot: " runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="DataSotTextBox" CssClass="form-control" runat="server" Placeholder="DataSot"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-5 control-label" for="form_control">
                    <asp:Label ID="VitiLabel" Text="Viti: " runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="VitiTextBox" CssClass="form-control" runat="server" Placeholder="Viti"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-7 control-label" for="form_control">
                    <asp:Label ID="DataRegjistrimitLabel" Text="Data Regjistrimit: " runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="DataRegjistrimitTextBox" CssClass="form-control" runat="server" Placeholder="DataRegjistrimit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-7 control-label" for="form_control">
                    <asp:Label ID="AmortizimiAkumuluarLabel" Text="Amortizimi i Akumuluar: " runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="AmortizimiAkumuluarTextBox" CssClass="form-control" runat="server" Placeholder="Cmimi"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-7 control-label" for="form_control">
                    <asp:Label ID="AmortizimiVjetorLabel" Text="Amortizimi Vjetor: " runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="AmortizimiVjetorTextBox" CssClass="form-control" runat="server" Placeholder="AmortizimiVjetor"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-7 control-label" for="form_control">
                    <asp:Label ID="DataAmortizimitLabel" Text="Data e Amortizimit: " runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="DataAmortizimitTextBox" CssClass="form-control" runat="server" Placeholder="DataAmortizimit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
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
                OnRowDataBound="ListGridView_RowDataBound">

                  <PagerSettings PageButtonCount="20" FirstPageText="Fillimi" LastPageText="Fundi" />
                <Columns>
                    <asp:TemplateField HeaderText="ProduktiID" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="ProduktiIDLabel" runat="server" Text='<%# Bind("ProduktiID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="AmortizimiAkumuluar" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("AmortizimiAkumuluar") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Amortizimi Vjetor" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("AmortizimiVjetor") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Viti" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Viti") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data e Amortizimit" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("DataAmortizimit") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Download" 
            onclick="Button1_Click" />
        </div>
</asp:Content>