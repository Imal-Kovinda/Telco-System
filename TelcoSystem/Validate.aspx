<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validate.aspx.cs" Inherits="TelcoSystem.Validate" %>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Sleek Dashboard - Free Bootstrap 4 Admin Dashboard Template and UI Kit. It is very powerful bootstrap admin dashboard, which allows you to build products like admin panels, content management systems and CRMs etc.">
  
    <title>Table - Sleek Admin Dashboard Template</title>
    
    <!-- GOOGLE FONTS -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500|Poppins:400,500,600,700|Roboto:400,500" rel="stylesheet" />

    <link href="https://cdn.materialdesignicons.com/4.4.95/css/materialdesignicons.min.css" rel="stylesheet" />
  
    <!-- PLUGINS CSS STYLE -->
    <link href="assets/plugins/simplebar/simplebar.css" rel="stylesheet" />
    <link href="assets/plugins/nprogress/nprogress.css" rel="stylesheet" />
  
    <!-- No Extra plugin used -->
    
    <link href='assets/plugins/daterangepicker/daterangepicker.css' rel='stylesheet'>
    
  

    <!-- SLEEK CSS -->
    <link id="sleek-css" rel="stylesheet" href="assets/css/sleek.css" />
  
    <!-- FAVICON -->
    <link href="assets/img/favicon.png" rel="shortcut icon" />
  
  
    <script src="assets/plugins/nprogress/nprogress.js"></script>
  </head>

  <body class="header-fixed sidebar-fixed sidebar-dark header-light" id="body">
       <style>
        .table table-hover tr{
            display:block;
        }
        .table table-hover tbody td, .table table-hover thead>tr>th{
            float:left;
        }
    </style>
    <script>
      NProgress.configure({ showSpinner: false });
      NProgress.start();
    </script>

    <!-- ====================================
    ——— WRAPPER
    ===================================== -->
    <div class="wrapper">

  
        <aside class="left-sidebar bg-sidebar">
          <div id="sidebar" class="sidebar sidebar-with-footer">
            <!-- Aplication Brand -->
            <div class="app-brand">
              <a href="/index.html" title="Sleek Dashboard">
                <svg
                  class="brand-icon"
                  xmlns="http://www.w3.org/2000/svg"
                  preserveAspectRatio="xMidYMid"
                  width="30"
                  height="33"
                  viewBox="0 0 30 33">
                  <g fill="none" fill-rule="evenodd">
                    <path class="logo-fill-blue" fill="#7DBCFF" d="M0 4v25l8 4V0zM22 4v25l8 4V0z" />
                    <path class="logo-fill-white" fill="#FFF" d="M11 4v25l8 4V0z" />
                  </g>
                </svg>

                <span class="brand-name text-truncate">Sleek Dashboard</span>
              </a>
            </div>

            <!-- begin sidebar scrollbar -->
            <div class="" data-simplebar style="height: 100%;">
              <!-- sidebar menu -->
              <ul class="nav sidebar-inner" id="sidebar-menu">
                

                 <li class="has-sub ">
                  <a class="sidenav-item-link" href="BranchReceipt.aspx">
                    <i class="mdi mdi-pencil-box-multiple"></i>
                    <span class="nav-text">Branch Receipt</span>
                  </a>

                </li>
                <li class="has-sub ">
                  <a class="sidenav-item-link" href="BatchReceiptUpload.aspx">
                    <i class="mdi mdi-pencil-box-multiple"></i>
                    <span class="nav-text">Batch Receipt</span>
                  </a>
                </li>
                <li class="has-sub ">
                  <a class="sidenav-item-link" href="Validate.aspx">
                    <i class="mdi mdi-pencil-box-multiple"></i>
                    <span class="nav-text">Validate</span>
                  </a>
                </li>
                   <li class="has-sub ">
                  <a class="sidenav-item-link" href="Complain.aspx">
                    <i class="mdi mdi-pencil-box-multiple"></i>
                    <span class="nav-text">Complain</span>
                  </a>
                </li>

              </ul>
            </div>

          </div>
        </aside>


          <!-- ====================================
        ——— PAGE WRAPPER
        ===================================== -->
        <div class="page-wrapper">
          
          <!-- Header -->
          <header class="main-header " id="header">
            <nav class="navbar navbar-static-top navbar-expand-lg">
              <!-- Sidebar toggle button -->
              <button id="sidebar-toggler" class="sidebar-toggle">
                <span class="sr-only">Toggle navigation</span>
              </button>
             
              <div class="navbar-right ">
                <ul class="nav navbar-nav">          
                  <!-- User Account -->
                  <li class="dropdown user-menu">
                    <button href="#" class="dropdown-toggle nav-link" data-toggle="dropdown">
                      <img src="assets/img/user/user.png" class="user-image" alt="User Image" />
                      <span class="d-none d-lg-inline-block">Abdus Salam</span>
                    </button>
                    <ul class="dropdown-menu dropdown-menu-right">
                      <!-- User image -->
                      <li class="dropdown-header">
                        <img src="assets/img/user/user.png" class="img-circle" alt="User Image" />
                        <div class="d-inline-block">
                          Abdus Salam <small class="pt-1">iamabdus@gmail.com</small>
                        </div>
                      </li>

                      <li>
                        <a href="user-profile.html">
                          <i class="mdi mdi-account"></i> My Profile
                        </a>
                      </li>
                      <li>
                        <a href="#">
                          <i class="mdi mdi-email"></i> Message
                        </a>
                      </li>
                      <li>
                        <a href="#"> <i class="mdi mdi-diamond-stone"></i> Projects </a>
                      </li>
                      <li class="right-sidebar-in">
                        <a href="javascript:0"> <i class="mdi mdi-settings"></i> Setting </a>
                      </li>

                      <li class="dropdown-footer">
                        <a href="index.html"> <i class="mdi mdi-logout"></i> Log Out </a>
                      </li>
                    </ul>
                  </li>
                </ul>
              </div>
            </nav>
          </header>

          
          <!-- ====================================
          ——— CONTENT WRAPPER
          ===================================== -->
          <div class="content-wrapper">
            <div class="content" style="padding:0rem 0rem;">


    <div class="row">
	<div class="col-12">
                  <div class="card card-default">
                  <div class="card-header justify-content-between" style="padding-top:0rem;">
                      <h2>Validate Form</h2>
                      <div class="date-range-report ">
                          <img src="assets/img/LankaBell.jpg" style="width:200px; height:100px;">
                      </div>
                    </div>

			<div class="card-body" style="padding-top:0rem;">
                <div style="height:300px; display:block; overflow-y:auto;">
                    <table class="table table-hover">
					<thead style=" position: sticky;top: 0px; background: gainsboro;">
						<tr>
							<th scope="col">Bank</th>
                            <th scope="col">Batch No</th>
                            <th scope="col">Payment Date</th>
							<th scope="col">Account No</th>
							<th scope="col">Amount(LKR)</th>
							<th scope="col">Flag</th>
                            <th scope="col">Posted</th>
                            <th scope="col">Pre Paid</th>
                            <th scope="col"></th>
						</tr>
					</thead>

					<tbody>

						<tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                            <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

						<tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                             <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

						<tr>
                          <td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                             <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

						<tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                             <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

						<tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                             <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

						<tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                             <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

                        <tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                             <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

                        <tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                             <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>
                          <tr>
						    <td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                               <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>
                          <tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                               <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>
                          <tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                               <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>
                          <tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                               <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>
                          <tr>
							<td scope="row">BANK_OF_CEYLON</td>
							<td>BOC_1587</td>
							<td>2022.11.29</td>
                            <td>33896743</td>
							<td>2000</td>
							<td>0</td>
                            <td>YES</td>
                            <td>YES</td>
                               <td><a href="#" style="text-decoration:underline;">VIEW</a></td>
						</tr>

					</tbody>

				</table>
                </div>
		
			</div>
            <div class="btn" style="display:flex; margin-left:30px; margin-top:-23px;margin-bottom:10px;">
                <button type="button" class="btn btn-primary" style="width:110px; height50px;">Query</button>
                <button type="button" class="btn btn-primary" style="margin-left:20px; width:110px; height50px;">Validate</button>
                <button type="button" class="btn btn-primary" style="margin-left:20px; width:110px; height50px;">Check Error</button>
                <button type="button" class="btn btn-primary" style="margin-left:20px; width:110px; height50px;">Post</button>
                <button type="button" class="btn btn-primary" style="margin-left:20px; width:110px; height50px;">Exit</button>
            </div>
		</div>  

	</div>
</div>



      </div> <!-- End Content -->
    </div> 
            <!-- End Content Wrapper -->
    
    
            <!-- Footer -->
            <footer class="footer mt-auto">
              <div class="copyright bg-white">
                <p>
                  Copyright &copy; <span id="copy-year"></span> a template by <a class="text-primary" href="https://themefisher.com" target="_blank">Themefisher</a>.
                </p>
              </div>
              <script>
                var d = new Date();
                var year = d.getFullYear();
                document.getElementById("copy-year").innerHTML = year;
              </script>
            </footer>

    </div> <!-- End Page Wrapper -->
  </div>
      <!-- End Wrapper -->


   

    <!-- Javascript -->
    <script src="assets/plugins/jquery/jquery.min.js"></script>
    <script src="assets/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/plugins/simplebar/simplebar.min.js"></script>
 
 
    <script src='assets/plugins/daterangepicker/moment.min.js'></script>
    <script src='assets/plugins/daterangepicker/daterangepicker.js'></script>
    <script src='assets/js/date-range.js'></script>

    


    <script src="assets/js/sleek.js"></script>
  <link href="assets/options/optionswitch.css" rel="stylesheet">
<script src="assets/options/optionswitcher.js"></script>
</body>
</html>



