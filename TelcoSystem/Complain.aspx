
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Complain.aspx.cs" Inherits="TelcoSystem.WebForm3" %>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Sleek Dashboard - Free Bootstrap 4 Admin Dashboard Template and UI Kit. It is very powerful bootstrap admin dashboard, which allows you to build products like admin panels, content management systems and CRMs etc.">
  
    <title>Form Validation - Sleek Admin Dashboard Template</title>
    
    <!-- GOOGLE FONTS -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500|Poppins:400,500,600,700|Roboto:400,500" rel="stylesheet" />

    <link href="https://cdn.materialdesignicons.com/4.4.95/css/materialdesignicons.min.css" rel="stylesheet" />
  
    <!-- PLUGINS CSS STYLE -->
    <link href="assets/plugins/simplebar/simplebar.css" rel="stylesheet" />
    <link href="assets/plugins/nprogress/nprogress.css" rel="stylesheet" />
  
    <!-- No Extra plugin used -->
    

    
    
    <link href='assets/plugins/select2/css/select2.min.css' rel='stylesheet'>
    
    
    
    
    
    
    
    
    

    <!-- SLEEK CSS -->
    <link id="sleek-css" rel="stylesheet" href="assets/css/sleek.css" />
  
    <!-- FAVICON -->
    <link href="assets/img/favicon.png" rel="shortcut icon" />
  
    <!--
      HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries
    -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <script src="assets/plugins/nprogress/nprogress.js"></script>
  </head>

  <body class="header-fixed sidebar-fixed sidebar-dark header-light" id="body">
    <script>
      NProgress.configure({ showSpinner: false });
      NProgress.start();
    </script>

    <!-- ====================================
    ——— WRAPPER
    ===================================== -->
    <div class="wrapper">

      <!-- Github Link -->
     <%-- <a href="https://github.com/tafcoder/sleek-dashboard"  target="_blank" class="github-link">
        <svg width="70" height="70" viewBox="0 0 250 250" aria-hidden="true">
          <defs>
            <linearGradient id="grad1" x1="0%" y1="75%" x2="100%" y2="0%">
              <stop offset="0%" style="stop-color:#896def;stop-opacity:1" />
              <stop offset="100%" style="stop-color:#482271;stop-opacity:1" />
            </linearGradient>
          </defs>
          <path d="M 0,0 L115,115 L115,115 L142,142 L250,250 L250,0 Z" fill="url(#grad1)"></path>
        </svg>
        <i class="mdi mdi-github-circle"></i>
      </a>--%>
        <img src="~/assets/logo/bell.jpeg" runat="server" Width="60" Height="20" />





        <!-- ====================================
          ——— LEFT SIDEBAR WITH OUT FOOTER
        ===================================== -->
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
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#dashboard"
                    aria-expanded="false" aria-controls="dashboard">
                    <i class="mdi mdi-view-dashboard-outline"></i>
                    <span class="nav-text">Dashboard</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="dashboard" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="index.html">
                          <span class="nav-text">Ecommerce</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="analytics.html">
                          <span class="nav-text">Analytics</span>
                          <span class="badge badge-success">new</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                
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

                <!-- <li class="section-title">
                  UI Elements
                </li> -->

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#components"
                    aria-expanded="false" aria-controls="components">
                    <i class="mdi mdi-folder-multiple-outline"></i>
                    <span class="nav-text">Components</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="components" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="alert.html">
                          <span class="nav-text">Alert</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="badge.html">
                          <span class="nav-text">Badge</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="breadcrumb.html">
                          <span class="nav-text">Breadcrumb</span>

                        </a>
                      </li>

                      <li class="has-sub ">
                        <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#buttons"
                          aria-expanded="false" aria-controls="buttons">
                          <span class="nav-text">Buttons</span> <b class="caret"></b>
                        </a>

                        <ul class="collapse " id="buttons">
                          <div class="sub-menu">
                            <li class="">
                              <a href="button-default.html">Button Default</a>
                            </li>

                           <li class="">
                              <a href="button-dropdown.html">Button Dropdown</a>
                            </li>

                           <li class="">
                              <a href="button-group.html">Button Group</a>
                            </li>

                           <li class="">
                              <a href="button-social.html">Button Social</a>
                            </li>

                           <li class="">
                              <a href="button-loading.html">Button Loading</a>
                            </li>
                          </div>
                        </ul>
                      </li>
                      
                      <li class="">
                        <a class="sidenav-item-link" href="card.html">
                          <span class="nav-text">Card</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="carousel.html">
                          <span class="nav-text">Carousel</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="collapse.html">
                          <span class="nav-text">Collapse</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="list-group.html">
                          <span class="nav-text">List Group</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="modal.html">
                          <span class="nav-text">Modal</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="pagination.html">
                          <span class="nav-text">Pagination</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="popover-tooltip.html">
                          <span class="nav-text">Popover & Tooltip</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="progress-bar.html">
                          <span class="nav-text">Progress Bar</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="spinner.html">
                          <span class="nav-text">Spinner</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="switcher.html">
                          <span class="nav-text">Switcher</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="tab.html">
                          <span class="nav-text">Tab</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#icons"
                    aria-expanded="false" aria-controls="icons">
                    <i class="mdi mdi-diamond-stone"></i>
                    <span class="nav-text">Icons</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="icons" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="material-icon.html">
                          <span class="nav-text">Material Icon</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="flag-icon.html">
                          <span class="nav-text">Flag Icon</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                <li class="has-sub active expand">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#forms"
                    aria-expanded="false" aria-controls="forms">
                    <i class="mdi mdi-email-mark-as-unread"></i>
                    <span class="nav-text">Forms</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse show" id="forms" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="basic-input.html">
                          <span class="nav-text">Basic Input</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="input-group.html">
                          <span class="nav-text">Input Group</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="checkbox-radio.html">
                          <span class="nav-text">Checkbox & Radio</span>
                        </a>
                      </li>

                      <li class="active">
                        <a class="sidenav-item-link" href="form-validation.html">
                          <span class="nav-text">Form Validation</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="form-advance.html">
                          <span class="nav-text">Form Advance</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#tables"
                    aria-expanded="false" aria-controls="tables">
                    <i class="mdi mdi-table"></i>
                    <span class="nav-text">Tables</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="tables" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="basic-tables.html">
                          <span class="nav-text">Basic Tables</span>
                        </a>
                      </li>

                      <li class="has-sub ">
                        <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#data-tables"
                          aria-expanded="false" aria-controls="data-tables">
                          <span class="nav-text">Data Tables</span> <b class="caret"></b>
                        </a>

                        <ul class="collapse " id="data-tables">
                          <div class="sub-menu">
                            <li class="">
                              <a href="basic-data-table.html">Basic Data Table</a>
                            </li>

                           <li class="">
                              <a href="responsive-data-table.html">Responsive Data Table</a>
                            </li>

                           <li class="">
                              <a href="hoverable-data-table.html">Hoverable Data Table</a>
                            </li>

                           <li class="">
                              <a href="expendable-data-table.html">Expendable Data Table</a>
                            </li>
                          </div>
                        </ul>
                      </li>
                    </div>
                  </ul>
                </li>

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#maps"
                    aria-expanded="false" aria-controls="maps">
                    <i class="mdi mdi-google-maps"></i>
                    <span class="nav-text">Maps</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="maps" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="google-map.html">
                          <span class="nav-text">Google Map</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="vector-map.html">
                          <span class="nav-text">Vector Map</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#widgets"
                    aria-expanded="false" aria-controls="widgets">
                    <i class="mdi mdi-widgets"></i>
                    <span class="nav-text">Widgets</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="widgets" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="general-widget.html">
                          <span class="nav-text">General Widget</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="chart-widget.html">
                          <span class="nav-text">Chart Widget</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#charts"
                    aria-expanded="false" aria-controls="charts">
                    <i class="mdi mdi-chart-pie"></i>
                    <span class="nav-text">Charts</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="charts" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="">
                        <a class="sidenav-item-link" href="chartjs.html">
                          <span class="nav-text">ChartJS</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                <!-- <li class="section-title">
                  Pages
                </li> -->

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#pages"
                    aria-expanded="false" aria-controls="pages">
                    <i class="mdi mdi-image-filter-none"></i>
                    <span class="nav-text">Pages</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="pages" data-parent="#sidebar-menu">
                    <div class="sub-menu ">
                      <li class="">
                        <a class="sidenav-item-link" href="user-profile.html">
                          <span class="nav-text">User Profile</span>
                        </a>
                      </li>

                      <li class="has-sub ">
                        <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#authentication"
                          aria-expanded="false" aria-controls="authentication">
                          <span class="nav-text">Authentication</span> <b class="caret"></b>
                        </a>

                        <ul class="collapse " id="authentication">
                          <div class="sub-menu">
                            <li class="">
                              <a href="sign-in.html">Sign In</a>
                            </li>

                           <li class="">
                              <a href="sign-up.html">Sign Up</a>
                            </li>
                          </div>
                        </ul>
                      </li>

                      <li class="has-sub ">
                        <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#others"
                          aria-expanded="false" aria-controls="others">
                          <span class="nav-text">Others</span> <b class="caret"></b>
                        </a>

                        <ul class="collapse " id="others">
                          <div class="sub-menu">
                            <li class="">
                              <a href="invoice.html">Invoice</a>
                            </li>

                           <li class="">
                              <a href="404.html">404 Page</a>
                            </li>
                          </div>
                        </ul>
                      </li>
                    </div>
                  </ul>
                </li>

                <li class="has-sub ">
                  <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#documentation"
                    aria-expanded="false" aria-controls="documentation">
                    <i class="mdi mdi-book-open-page-variant"></i>
                    <span class="nav-text">Documentation</span> <b class="caret"></b>
                  </a>

                  <ul class="collapse " id="documentation" data-parent="#sidebar-menu">
                    <div class="sub-menu">
                      <li class="section-title">
                        Getting Started
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="introduction.html">
                          <span class="nav-text">Introduction</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="quick-start.html">
                          <span class="nav-text">Quick Start</span>
                        </a>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="customization.html">
                          <span class="nav-text">Customization</span>
                        </a>
                      </li>

                      <li class="section-title">
                        Layouts
                      </li>

                      <li class="has-sub ">
                        <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#header-variations" aria-expanded="false" aria-controls="header-variations">
                          <span class="nav-text">Header Variations</span> <b class="caret"></b>
                        </a>

                        <ul class="collapse " id="header-variations">
                          <div class="sub-menu">
                            <li class="">
                              <a href="header-fixed.html">Header Fixed</a>
                            </li>

                            <li class="">
                              <a href="header-static.html">Header Static</a>
                            </li>

                            <li class="">
                              <a href="header-light.html">Header Light</a>
                            </li>

                            <li class="">
                              <a href="header-dark.html">Header Dark</a>
                            </li>
                          </div>
                        </ul>
                      </li>

                      <li class="has-sub ">
                        <a class="sidenav-item-link" href="javascript:void(0)" data-toggle="collapse" data-target="#sidebar-variations" aria-expanded="false" aria-controls="sidebar-variations">
                          <span class="nav-text">Sidebar Variations</span> <b class="caret"></b>
                        </a>

                        <ul class="collapse " id="sidebar-variations">
                          <div class="sub-menu">
                            <li class="">
                              <a href="sidebar-fixed-default.html">Sidebar Fixed Default</a>
                            </li>

                            <li class="">
                              <a href="sidebar-fixed-minified.html">Sidebar Fixed Minified</a>
                            </li>

                            <li class="">
                              <a href="sidebar-fixed-offcanvas.html">Sidebar Fixed Offcanvas</a>
                            </li>

                            <li class="">
                              <a href="sidebar-static-default.html">Sidebar Static Default</a>
                            </li>

                            <li class="">
                              <a href="sidebar-static-minified.html">Sidebar Static Minified</a>
                            </li>

                            <li class="">
                              <a href="sidebar-static-offcanvas.html">Sidebar Static Offcanvas</a>
                            </li>

                            <li class="">
                              <a href="sidebar-with-footer.html">Sidebar With Footer</a>
                            </li>

                            <li class="">
                              <a href="sidebar-without-footer.html">Sidebar Without Footer</a>
                            </li>

                            <li class="">
                              <a href="right-sidebar.html">Right Sidebar</a>
                            </li>
                          </div>
                        </ul>
                      </li>

                      <li class="">
                        <a class="sidenav-item-link" href="rtl.html">
                          <span class="nav-text">RTL Direction</span>
                        </a>
                      </li>
                    </div>
                  </ul>
                </li>

                <!-- <li class="section-title">
                  Documentation
                </li> -->
              </ul>
            </div>

            <div class="sidebar-footer">
              <hr class="separator mb-0" />
              <div class="sidebar-footer-content">
                <h6 class="text-uppercase">
                  Cpu Uses <span class="float-right">40%</span>
                </h6>

                <div class="progress progress-xs">
                  <div class="progress-bar active" style="width: 40%;" role="progressbar"></div>
                </div>

                <h6 class="text-uppercase">
                  Memory Uses <span class="float-right">65%</span>
                </h6>

                <div class="progress progress-xs">
                  <div class="progress-bar progress-bar-warning" style="width: 65%;" role="progressbar"></div>
                </div>
              </div>
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
              <!-- search form -->
              <div class="search-form d-none d-lg-inline-block">
                <div class="input-group">
                  <%--<button type="button" name="search" id="search-btn" class="btn btn-flat">
                    <i class="mdi mdi-magnify"></i>
                  </button>
                  <input type="text" name="query" id="search-input" class="form-control" placeholder="'button', 'chart' etc."
                    autofocus autocomplete="off" />--%>
                    <h2>Complain Entry</h2>
                </div>
                <div id="search-results-container">
                 <%-- <ul id="search-results"></ul>--%>
                </div>
              </div>

              <div class="navbar-right ">
                <ul class="nav navbar-nav">
                  <li class="dropdown notifications-menu custom-dropdown">
                    <button class="dropdown-toggle notify-toggler custom-dropdown-toggler">
                      <i class="mdi mdi-bell-outline"></i>
                    </button>

                    <div class="card card-default dropdown-notify dropdown-menu-right mb-0">
                      <div class="card-header card-header-border-bottom px-3">
                        <h2>Notifications</h2>
                      </div>

                      <div class="card-body px-0 py-3">
                        <ul class="nav nav-tabs nav-style-border p-0 justify-content-between" id="myTab" role="tablist">
                          <li class="nav-item mx-3 my-0 py-0">
                            <a class="nav-link active pb-3" id="home2-tab" data-toggle="tab" href="#home2" role="tab" aria-controls="home2" aria-selected="true">All (11)</a>
                          </li>

                          <li class="nav-item mx-3 my-0 py-0">
                            <a class="nav-link pb-3" id="profile2-tab" data-toggle="tab" href="#profile2" role="tab" aria-controls="profile2" aria-selected="false">Msgs (6)</a>
                          </li>

                          <li class="nav-item mx-3 my-0 py-0">
                            <a class="nav-link pb-3" id="contact2-tab" data-toggle="tab" href="#contact2" role="tab" aria-controls="contact2" aria-selected="false">Others (5)</a>
                          </li>
                        </ul>

                        <div class="tab-content" id="myTabContent3">
                          <div class="tab-pane fade show active" id="home2" role="tabpanel" aria-labelledby="home2-tab">
                            <ul class="list-unstyled" data-simplebar style="height: 360px">
                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u2.jpg" alt="Image">
                                    <span class="status away"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Aaren</h4>
                                      <p class="last-msg">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nam itaque doloremque odio, eligendi delectus vitae.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 30 min ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification media-active">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u1.jpg" alt="Image">
                                    <span class="status active"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Abril</h4>
                                      <p class="last-msg">Donec mattis augue a nisl consequat, nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim eu odio vehic.</p>

                                      <span class="font-size-12 font-weight-medium text-white">
                                        <i class="mdi mdi-clock-outline"></i> Just now...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u5.jpg" alt="Image">
                                    <span class="status away"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Emma</h4>
                                      <p class="last-msg">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nam itaque doloremque odio, eligendi delectus vitae.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification event-active">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-info text-white">
                                    <i class="mdi mdi-calendar-check font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">New event added</h4>
                                      <p class="last-msg font-size-14">03/Jan/2020 (1pm - 2pm)</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 10 min ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-warning text-white">
                                    <i class="mdi mdi-chart-areaspline font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Sales report</h4>
                                      <p class="last-msg font-size-14">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nam itaque doloremque odio, eligendi delectus vitae.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-primary text-white">
                                    <i class="mdi mdi-account-multiple-check font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Add request</h4>
                                      <p class="last-msg font-size-14">Add Dany Jones as your contact consequat nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim.</p>

                                      <button type="button" class="my-1 btn btn-sm btn-success">Accept</button>
                                      <button type="button" class="my-1 btn btn-sm btn-secondary">Delete</button>

                                      <span class="font-size-12 font-weight-medium text-secondary d-block">
                                        <i class="mdi mdi-clock-outline"></i> 5 min ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-danger text-white">
                                    <i class="mdi mdi-server-network-off font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Server overloaded</h4>
                                      <p class="last-msg font-size-14">Donec mattis augue a nisl consequat, nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim eu odio vehic.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 30 min ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-purple text-white">
                                    <i class="mdi mdi-playlist-check font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Task complete</h4>
                                      <p class="last-msg font-size-14">Nam ut nisi erat. Ut quis tortor varius, hendrerit arcu quis, congue nisl. In scelerisque, sem ut ve.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 2 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                            </ul>
                          </div>

                          <div class="tab-pane fade" id="profile2" role="tabpanel" aria-labelledby="profile2-tab">
                            <ul class="list-unstyled" data-simplebar style="height: 360px">
                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u6.jpg" alt="Image">
                                    <span class="status away"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">William</h4>
                                      <p class="last-msg">Donec mattis augue a nisl consequat, nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim eu odio vehic.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u7.jpg" alt="Image">
                                    <span class="status away"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Camble</h4>
                                      <p class="last-msg">Nam ut nisi erat. Ut quis tortor varius, hendrerit arcu quis, congue nisl. In scelerisque, sem ut ve.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification media-active">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u1.jpg" alt="Image">
                                    <span class="status active"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Abril</h4>
                                      <p class="last-msg">Donec mattis augue a nisl consequat, nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim eu odio vehic.</p>

                                      <span class="font-size-12 font-weight-medium text-white">
                                        <i class="mdi mdi-clock-outline"></i> Just now...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u2.jpg" alt="Image">
                                    <span class="status away"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Aaren</h4>
                                      <p class="last-msg">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nam itaque doloremque odio, eligendi delectus vitae.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u5.jpg" alt="Image">
                                    <span class="status away"></span>
                                  </div>
                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Emma</h4>
                                      <p class="last-msg">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nam itaque doloremque odio, eligendi delectus vitae.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                            </ul>
                          </div>

                          <div class="tab-pane fade" id="contact2" role="tabpanel" aria-labelledby="contact2-tab">
                            <ul class="list-unstyled" data-simplebar style="height: 360px">
                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification event-active">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-info text-white">
                                    <i class="mdi mdi-calendar-check font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">New event added</h4>
                                      <p class="last-msg font-size-14">03/Jan/2020 (1pm - 2pm)</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 10 min ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-warning text-white">
                                    <i class="mdi mdi-chart-areaspline font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Sales report</h4>
                                      <p class="last-msg font-size-14">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nam itaque doloremque odio, eligendi delectus vitae.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-primary text-white">
                                    <i class="mdi mdi-account-multiple-check font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Add request</h4>
                                      <p class="last-msg font-size-14">Add Dany Jones as your contact consequat nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim.</p>

                                      <button type="button" class="my-1 btn btn-sm btn-success">Accept</button>
                                      <button type="button" class="my-1 btn btn-sm btn-secondary">Delete</button>

                                      <span class="font-size-12 font-weight-medium text-secondary d-block">
                                        <i class="mdi mdi-clock-outline"></i> 5 min ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-danger text-white">
                                    <i class="mdi mdi-server-network-off font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Server overloaded</h4>
                                      <p class="last-msg font-size-14">Donec mattis augue a nisl consequat, nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim eu odio vehic.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 30 min ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-purple text-white">
                                    <i class="mdi mdi-playlist-check font-size-20"></i>
                                  </div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Task complete</h4>
                                      <p class="last-msg font-size-14">Nam ut nisi erat. Ut quis tortor varius, hendrerit arcu quis, congue nisl. In scelerisque, sem ut ve.</p>

                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 2 hrs ago...
                                      </span>
                                    </div>
                                  </div>
                                </a>
                              </li>
                            </ul>
                          </div>
                        </div>
                      </div>
                    </div>

                    <ul class="dropdown-menu dropdown-menu-right d-none">
                      <li class="dropdown-header">You have 5 notifications</li>
                      <li>
                        <a href="#">
                          <i class="mdi mdi-account-plus"></i> New user registered
                          <span class=" font-size-12 d-inline-block float-right"><i class="mdi mdi-clock-outline"></i> 10 AM</span>
                        </a>
                      </li>
                      <li>
                        <a href="#">
                          <i class="mdi mdi-account-remove"></i> User deleted
                          <span class=" font-size-12 d-inline-block float-right"><i class="mdi mdi-clock-outline"></i> 07 AM</span>
                        </a>
                      </li>
                      <li>
                        <a href="#">
                          <i class="mdi mdi-chart-areaspline"></i> Sales report is ready
                          <span class=" font-size-12 d-inline-block float-right"><i class="mdi mdi-clock-outline"></i> 12 PM</span>
                        </a>
                      </li>
                      <li>
                        <a href="#">
                          <i class="mdi mdi-account-supervisor"></i> New client
                          <span class=" font-size-12 d-inline-block float-right"><i class="mdi mdi-clock-outline"></i> 10 AM</span>
                        </a>
                      </li>
                      <li>
                        <a href="#">
                          <i class="mdi mdi-server-network-off"></i> Server overloaded
                          <span class=" font-size-12 d-inline-block float-right"><i class="mdi mdi-clock-outline"></i> 05 AM</span>
                        </a>
                      </li>
                      <li class="dropdown-footer">
                        <a class="text-center" href="#"> View All </a>
                      </li>
                    </ul>
                  </li>
               <%--   <li class="right-sidebar-in right-sidebar-2-menu">
                    <i class="mdi mdi-settings mdi-spin"></i>
                  </li>--%>
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
            <div class="content">





<div class="row">

    <div class="card col-12 card-default">
			 <div class="card-header justify-content-between" style="padding-top:0rem;">
                      <h2>Complain Entry</h2>
                      <div class="date-range-report ">
                          <img src="assets/img/LankaBell.jpg" style="width:200px; height:100px;">
                      </div>
                    </div>

			<div class="card-body">
				<form >
					<div class="row">
						
						<div class="col-sm-6">
							<div class="row">
								<div class="col-6">
									<div class="form-group">
										<h3>STATUS_DESC</h3>
									</div>
								</div>

								<div class="col-6">
									<div class="form-group">
										<label for="State">Referance No</label>
										<input type="text" class="form-control" placeholder="C_COMP_ID">
									</div>
								</div>
							</div>
						</div>

						<div class="col-sm-6">
							<div class="row">
								<div class="col-6">
									<div class="form-group">
										<label for="State">Logged Date</label>
										<input type="text" class="form-control" placeholder="TXN_DATE">
									</div>
								</div>

								<div class="col-6">
									<div class="form-group">
										<label for="Zip">by</label>
										<input type="text" class="form-control" placeholder="LOGGED_BY">
									</div>
								</div>
							</div>
						</div>
					</div>

					
				</form>
			</div>
		</div>

	<div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">

						<div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Service Number</label>
							<input type="text" class="form-control" id="validationServerUsername" placeholder="Service Number" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the service number.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">User Code</label>
							<input type="text" class="form-control" id="validationServerUsername2" placeholder="User Code" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the user code.
							</div>
						</div>

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Code</label>
							<input type="text" class="form-control" id="validationServerUsername3" placeholder="Account Code" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the code.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">Line Type</label>
						    <select class="form-control" id="exampleFormControlSelect3">
							    <option>1</option>
							    <option>2</option>
							    <option>3</option>
							    <option>4</option>
							    <option>5</option>
						    </select>
			            </div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Online</label>
							<input type="text" class="form-control" id="validationServerUsername12" placeholder="Online" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please choose a mode.
							</div>
						</div>


                        <div class="col-md-12 mb-3">
                            <label class="text-dark font-weight-medium" for="validationServerUsername">Online Bill Date</label>
				            <div class="input-group mb-2">
					            <div class="input-group-prepend">
						            <span class="input-group-text">
							            <i class="mdi mdi-calendar-range"></i>
						            </span>
					            </div>

					            <input type="text" class="form-control" data-mask="00/00/0000" placeholder="" aria-label="">
				            </div>
                        </div>

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Address</label>
							<input type="text" class="form-control" id="validationServerUsername4" placeholder="Account Address" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please choose a username.
							</div>
						</div>

					</div>
				</form>
			</div>
		</div>
	</div>



    <div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">
                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">City</label>
						    <select class="form-control" id="exampleFormControlSelect4">
							    <option>Matara</option>
							    <option>Colombo</option>
							    <option>Kandy</option>
							    <option>Galle</option>
						    </select>
			            </div>

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Connection Status</label>
							<input type="text" class="form-control" id="validationServerUsername5" placeholder="Connection Status" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please choose a username.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Custommer Name</label>
							<input type="text" class="form-control" id="validationServerUsername6" placeholder="CUST_NAME" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please choose a username.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Rating</label>
							<input type="text" class="form-control" id="validationServerUsername7" placeholder="ACC_RATING" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please choose a username.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Line Usage</label>
							<input type="text" class="form-control" id="validationServerUsername8" placeholder="LINE_USAGE" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please choose a username.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Total Amt</label>
							<input type="number" class="form-control" id="validationServerUsername9" placeholder="V_TOT" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please choose a username.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">Login Name</label>
						    <select class="form-control" id="exampleFormControlSelect5">
							    <option>Kamal</option>
							    <option>Nimal</option>
							    <option>Bimal</option>
							    <option>Amal</option>
						    </select>
			            </div>

                    </div>
                </form>
			</div>
        </div>
    </div>

     <div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">F/Y Rating</label>
							<input type="text" class="form-control" id="validationServerUsername13" placeholder="IT_BSTR" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">ID Number</label>
							<input type="text" class="form-control" id="validationServerUsername14" placeholder="CP_ID_NUMBER" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Category</label>
							<input type="text" class="form-control" id="validationServerUsername15" placeholder="ACC_CATEGORY" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Last Month BIll</label>
							<input type="text" class="form-control" id="validationServerUsername16" placeholder="LAST_MONTH_BILL" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Bill Run Date</label>
							<input type="text" class="form-control" id="validationServerUsername17" placeholder="BILL_RUN_CODE" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Bill Balance</label>
							<input type="text" class="form-control" id="validationServerUsername19" placeholder="BILL_BALANCE" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Bill Station</label>
							<input type="text" class="form-control" id="validationServerUsername20" placeholder="BILL_NAME" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Credit Limit</label>
							<input type="text" class="form-control" id="validationServerUsername21 placeholder="CR" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                    </div>
                </form>
            </div>
        </div>
    </div>

     <div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">

                       	<div class="form-group col-md-12">
						    <label class="text-dark font-weight-medium" for="exampleFormControlTextarea1">Concern</label>
						    <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
					    </div>

                      
             

                          <div class="col-md-12 mb-3 mt-4">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Contact Person</label>
							<input type="text" class="form-control" id="validationServerUsername22" placeholder="CONTACT_PERSON" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                          <div class="col-md-12 mb-3 mt-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Contact Num</label>
							<input type="text" class="form-control" id="validationServerUsername23" placeholder="CONTACT_NO" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                          <div class="col-md-12 mb-3 mt-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Email</label>
							<input type="text" class="form-control" id="validationServerUsername24" placeholder="EMAIL" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                         <div class="col-md-12 mb-3 mt-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">Nearest BD</label>
						    <select class="form-control" id="exampleFormControlSelect9">
							    <option>Galle</option>
							    <option>Matara</option>
							    <option>Hakmana</option>
							    <option>Kirinda</option>
						    </select>
			            </div>

                         

                        <div class="col-md-12 mb-3 mt-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Informed By</label>
							<input type="text" class="form-control" id="validationServerUsername20" placeholder="INFORMED_BY" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                 
                       

                    </div>
                </form>
            </div>
        </div>
    </div>

 
     <div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">

                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">Category</label>
						    <select class="form-control" id="exampleFormControlSelect9">
							    <option>COMP_CAT_1</option>
							    <option>COMP_CAT_2</option>
							    <option>COMP_CAT_3</option>
							    <option>COMP_CAT_4</option>
						    </select>
			            </div>

                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">Complain</label>
						    <select class="form-control" id="exampleFormControlSelect9">
							    <option>COMP_TYPE_1</option>
							    <option>COMP_TYPE_2</option>
							    <option>COMP_TYPE_3</option>
							    <option>COMP_TYPE_4</option>
						    </select>
			            </div>

                    </div>
                </form>
            </div>
        </div>
    </div>

    <div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">

                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">Complain Sub Category</label>
						    <select class="form-control" id="exampleFormControlSelect9">
							    <option>COMP_SUB_1</option>
							    <option>COMP_SUB_2</option>
							    <option>COMP_SUB_3</option>
							    <option>COMP_SUB_4</option>
						    </select>
			            </div>

                          <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">FID</label>
							<input type="text" class="form-control" id="validationServerUsername20" placeholder="TXT_FID" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>
                      

                    </div>
                </form>
            </div>
        </div>
    </div>

       <div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">
                          <ul class="list-unstyled list-inline mt-2 ml-3 mb-3">
					        <li class="d-inline-block mr-3">
						        <label class="text-dark font-weight-medium" class="control control-radio">Inbound
							        <input type="radio" name="inb" checked="checked" />
							        
						        </label>
					        </li>

					        <li class="d-inline-block mr-3">
						        <label class="text-dark font-weight-medium" class="control control-radio">Outbound
							        <input type="radio" name="inb" />
							        
						        </label>
					        </li>
				        </ul>
                    </div>
                  
                </form>
            </div>
        </div>
    </div>

      <div class="col-lg-6">
		<div class="card card-default">
			<div class="card-body">
				<form >
					 <div class="ml-2">
                        <label class="text-dark font-weight-medium d-inline-block mr-3" for="">Follow Up</label>

				        <ul class="list-unstyled list-inline">
					        <li class="d-inline-block mr-3">
						        <label class="text-gray font-weight-sm" class="control control-radio">Yes
							        <input type="radio" name="option" checked="checked" />
							        
						        </label>
					        </li>

					        <li class="d-inline-block mr-3">
						        <label class="text-gray font-weight-sm" class="control control-radio">No
							        <input type="radio" name="option" />
							        
						        </label>
					        </li>
				        </ul>
                    </div>
                  
                </form>
            </div>
        </div>
    </div>

    <div class="col-12">
		<div class="card card-default">
			<div class="card-body">
				<form >
					<div class="form-row">

                         <div class="col-6">
                            <button type="button" class="mr-2 btn  btn-secondary">GLOBAL INQUIRY</button>
					     </div>

                         <div class="col-6">
						    <button type="button" class="mr-2 btn  btn-success">SAVE</button>
                        </div>

                    </div>
                </form>
            </div>
        </div>
    </div>


   <%-- displane hidden--%>
     <div class="card card-default" style="display:none;">
			<div class="card-header card-header-border-bottom">
				<h2>Other Options</h2>
                
			</div>

			<div class="card-body ml-2">
				<form >
					<div class="row">
						
						<div class="col-sm-6">
							<div class="row">
                              
                                <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-primary">FAULTY</button>
                                </div>
                                
                                 <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-primary">ENABLE</button>
                                </div>
                                <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-secondary">HISTORY</button>
								</div>
								
                              
                                <div class="col-6" style="display:none;">
								    <button type="button" class="mb-1 mr-2 btn  btn-warning">MESSAGE</button>
                                </div>
                                <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-primary">ISP PROXYMITY</button>
								</div>
							</div>
						</div>

						<div class="col-sm-6">
							<div class="row">
                                <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-primary">INQUIRY REPAIRS</button>
                                </div>
                                <div class="col-6" style="display:none;">
									<button type="button" class="mb-1 mr-2 btn  btn-info">REFRESH</button>
                                </div>

								<div class="col-6" style="display:none;">
									<button type="button" class="mb-1 mr-2 btn  btn-success">ISP CDMA</button>
                                </div>
                                <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-warning">CLEAR</button>
                                </div>
                                <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-danger">EXIT</button>
								</div>
							</div>
						</div>
					</div>

					
				</form>
			</div>
		</div>

        <div class="col-lg-6" style="display:none;">
		    <div class="card card-default">
			    <div class="card-body">
				    <form >
					    <div class="form-row">
                            <div>
                                <button type="button" class="mb-1 mb-4 mr-2 btn btn-primary">P</button>
                                <button type="button" class="mb-1 mb-4 mr-2 btn btn-primary">L</button>
                            </div>
                            <div>
                                <button type="button" class="mb-1 mb-4 mr-2 btn btn-primary">B</button>
                                <button type="button" class="mb-1 mb-4 mr-2 btn btn-primary">C</button>
                            </div>
                            <div>
                                <button type="button" class="mb-1 mb-4 mr-2 btn btn-primary">R</button>
                                <button type="button" class="mb-1 mb-4 mr-2 btn btn-primary">T</button>
                            </div>
                            <div>
                                <button type="button" class="mb-1 mb-4 mr-2 btn  btn-secondary">SL</button>
                                <button type="button" class="mb-1 mb-4 mr-2 btn  btn-secondary">U</button>
                            </div>
                      
                        </div>
                    </form>
                </div>
            </div>
        </div>
<%--    display hidden--%>



</div>





      </div> <!-- End Content -->
    </div> <!-- End Content Wrapper -->
    
    
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
  </div> <!-- End Wrapper -->


    <!-- <script type="module">
      import 'https://cdn.jsdelivr.net/npm/@pwabuilder/pwaupdate';

      const el = document.createElement('pwa-update');
      document.body.appendChild(el);
    </script> -->

    <!-- Javascript -->
    <script src="assets/plugins/jquery/jquery.min.js"></script>
    <script src="assets/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/plugins/simplebar/simplebar.min.js"></script>
 
    
    

    
    

    
    
    

    
    
    

    

    
    
    
    

    

    

    
    
    

    
    

    

    <script src="assets/js/sleek.js"></script>
  <link href="assets/options/optionswitch.css" rel="stylesheet">
<script src="assets/options/optionswitcher.js"></script>
</body>
</html>


