<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FAI_lab2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<!DOCTYPE html>
<html lang="en" >

<head>
  <meta charset="UTF-8">
  <title>Fixed Asset and Inventory</title>
   
      <link rel="stylesheet" runat="server" media="screen" href="../../Content/StyleSheet1.css" />
     <link rel="stylesheet" runat="server" media="screen" href="../../Content/StyleSheet2.css" />
    <link rel="stylesheet" runat="server" media="screen" href="../../Content/StyleSheet3.css" />
          <link rel="stylesheet" runat="server" media="screen" href="../../Content/FeaturesStyle.css" />
  <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'>
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
          <a href="#dashboard">Dashboard</a>
        </li>
        <li>
          <a href="#orders">Features</a>
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
      <div id="dashboard" class="tab-inner">
        <div class="info-wrapper">
          <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
              <li class="breadcrumb-item">
                <a href="javascript:;">
                  <i class="fas fa-home"></i>Home</a>
              </li>
              <li class="breadcrumb-item active" aria-current="page">Dashboard</li>
            </ol>
          </nav>
          <div class="info-panel d-flex">
            <h4 class="title">Overview</h4>
          </div>
        </div>
        <div class="block-3 d-flex">
          <div class="panel d-flex">
            <div class="icon">
              <i class="fas fa-hand-holding-usd"></i>
            </div>
            <div class="content">
              <p>Caktimi i Produkteve</p>
              <asp:Button ID="Button2" type="button" runat="server"  OnClick="PunetoriProduktiButton_Click" Text="Regjistro" />
                
            </div>
          </div>
          <div class="panel d-flex">
            <div class="icon">
              <i class="fas fa-boxes"></i>
            </div>
            <div class="content">
              <p>Caktimi i Hapsirave</p>
             
                 <asp:Button ID="Button3" type="button" runat="server"  OnClick="HapsiraProduktiButton_Click" Text=" Regjistro" />
            </div>
          </div>
          <div class="panel d-flex">
            <div class="icon">
              <i class="fas fa-money-bill"></i>
            </div>
            <div class="content">
              <p>Kerkesa per mirembajtje teknike</p>
              <asp:Button ID="Button4" type="button" runat="server"  OnClick="MirembajtjaButton_Click" Text="Regjistro" /></span>
            </div>
          </div>
        </div>
        <div class="block-1">
          <div class="panel">
            <h4 class="title">Activity</h4>
            <canvas id="myChart"></canvas>
          </div>
        </div>
        <div class="block-2 d-flex">
          
          <div class="panel right">
            <h4 class="title">produktet e regjistruara se fundmi</h4>
            <ul class="list d-flex">
              <li class="item d-flex">
                
                <div class="detail d-flex">
                  <p>Laptop HP</p>
                  <span class="date">
                    <i class="fas fa-clock"></i>2018/06/13 13:42
                  </span>
                  <span class="people">
                    <i class="fas fa-male"></i>Sasia: 20
                  </span>
                </div>
                <div class="total">
                  <div class="num">
                    <span>$</span>3,200</div>
                </div>
              </li>
              <li class="item d-flex">
                
                <div class="detail d-flex">
                  <p>Tavolina Salle</p>
                  <span class="date">
                    <i class="fas fa-clock"></i>2018/06/13 10:45
                  </span>
                  <span class="people">
                    <i class="fas fa-male"></i>Sasia: 54
                  </span>
                </div>
                <div class="total">
                  <div class="num">
                    <span>$</span>2,800</div>
                </div>
              </li>
              <li class="item d-flex">
                
                <div class="detail d-flex">
                  <p>Laptop</p>
                  <span class="date">
                    <i class="fas fa-clock"></i>2018/06/13 08:26
                  </span>
                  <span class="people">
                    <i class="fas fa-male"></i>Sasia: 10
                  </span>
                </div>
                <div class="total">
                  <div class="num">
                    <span>$</span>1,600</div>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
      <!-- orders -->
      <div id="orders" class="tab-inner">
        <div class="info-wrapper">
          <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
              <li class="breadcrumb-item">
                <a href="javascript:;">
                  <i class="fas fa-home"></i>Home</a>
              </li>
              <li class="breadcrumb-item active" aria-current="page">Features</li>
            </ol>
          </nav>
          <div class="info-panel d-flex">
            <h4 class="title">Funksionet</h4>
          </div>
        </div>
       
       
  <aside id="right-panel" class="right-panel" style="margin: 0 15%;">
      <div class="row" style="margin-bottom: 50px;">
            <!-- Produkti -->
                      <div class="module">
                          
                        <asp:Button ID="GrupiButton" type="button" runat="server" class="butoni1" OnClick="GrupiButton_Click"  Text="Grupi" />
                       
                      </div>

                      <!-- Punetori -->
                      <div class="module">
                        <asp:Button ID="ProduktiButton" type="button" runat="server"  OnClick="ProduktiButton_Click" Text="Produkti" />
            
                      </div>

                      <!-- Objekti -->
                      <div class="module">
                        <asp:Button ID="VendoriButton" type="button" runat="server"  OnClick="VendoriButton_Click" Text="Vendori" />
                      </div>
      </div>

      <div class="row" style="margin-bottom: 50px;">
            <!-- ProduktiPunetori -->
                      <div class="module">
                          <asp:Button ID="Button1" type="button" runat="server" OnClick="KlientiButton_Click" Text="Klienti" />
                      
                      </div>

                      <!-- Vendori -->
                      <div class="module">
                     <asp:Button ID="ObjektiButton" type="button" runat="server"  OnClick="ObjektiButton_Click" Text="Objekti" />
                      </div>

                       <div class="module">
                     <asp:Button ID="PunetoriButton" type="button" runat="server"  OnClick="PunetoriButton_Click" Text="Punetori" />
                      </div>
      </div>

    
  </aside>


  <script src='https://code.jquery.com/jquery-3.2.1.slim.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js'></script>
<script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.4.0/Chart.min.js'></script>

  

    <script  src=" ../../Content/JavaScript.js"></script>



</body>

</html>

    </div>

</asp:Content>
