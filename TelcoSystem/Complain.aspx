



<%@ Page Language="C#"  Title="Complain" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Complain.aspx.cs" Inherits="TelcoSystem.Complain" %>

    <title>Form Validation - Sleek Admin Dashboard Template</title>

    <!-- GOOGLE FONTS -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500|Poppins:400,500,600,700|Roboto:400,500" rel="stylesheet" />

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div class="content">

	<div class="row">

    <link href='assets/plugins/select2/css/select2.min.css' rel='stylesheet'>
		
    <!-- SLEEK CSS -->
    <link id="sleek-css" rel="stylesheet" href="assets/css/sleek.css" />

		<div class="card col-12 card-default">
			<div class="card-header card-header-border-bottom">
				<div class="col-6">
                        <h2>Complain Entry</h2>
                        
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
      <a href="https://github.com/tafcoder/sleek-dashboard"  target="_blank" class="github-link">
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
      </a>
        





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
                    <div class="col-6 d-flex flex-row-reverse">
                        <img src="~/assets/logo/bell.jpeg" runat="server" Width="120" Height="60" />
                        
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

			<div class="card-body">
		
					<div class="row">
						
                      <li class="">
                        <a class="sidenav-item-link" href="collapse.html">
                          <span class="nav-text">Collapse</span>
                        </a>
                      </li>
					
						<div class="row">
							<div class="col-6">
								<div class="form-group">
									<h4>STATUS_DESC</h4>
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

							<div class="col-6">
								<div class="form-group">
									<label for="State">Referance No</label>
									<asp:Textbox runat="server" type="text" id="ref_no" class="form-control" placeholder="C_COMP_ID"></asp:Textbox>
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

						<div class="col-sm-6">
							<div class="row">
								<div class="col-6">
									<div class="form-group">
										<label for="State">Logged Date</label>
										<asp:Textbox runat="server" ID="logged_date" type="text" class="form-control" placeholder="TXN_DATE"></asp:Textbox>
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

								<div class="col-6">
									<div class="form-group">
										<label for="Zip">by</label>
										<asp:Textbox runat="server" ID="by" type="text" class="form-control" placeholder="LOGGED_BY"></asp:Textbox>
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

	<div class="col-12">
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
            <ContentTemplate>
		        <div class="card card-default">
			        <div class="card-body">
				        <%--<form runat="server">--%>
					        <div class="form-row">

            <div class="sidebar-footer">
              <hr class="separator mb-0" />
              <div class="sidebar-footer-content">
                <h6 class="text-uppercase">
                  Cpu Uses <span class="float-right">40%</span>
                </h6>
                       
                                <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Service Number</label>
							        <asp:Textbox  type="text" class="form-control" ID="service_number" placeholder="Service Number" Autoposback="true" OnTextChanged="customerDetails_TextChanged" aria-describedby="inputGroupPrepend3" runat="server"></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the service number.
							        </div>
						        </div>

                                <%--<div class="col-6 mb-3">
							        <asp:Button runat="server"  class="mr-2 btn btn-sm btn-success"  Text="CHECK" />
						        </div>--%>

                                <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">User Code</label>
							        <asp:Textbox type="text" ID="user_code" placeholder="User Code" runat="server" class="form-control"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the user code.
							        </div>
						        </div>

                                 <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Account Code</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="acc_code" placeholder="Account Code" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the code.
							        </div>
						        </div>
        </aside>

                          
          <!-- ====================================
        ——— PAGE WRAPPER
        ===================================== -->
        <div class="page-wrapper">

                                 <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Customer Name</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="customer_name" placeholder="CUST_NAME" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please choose a username.
							        </div>
                <div id="search-results-container">
                  <ul id="search-results"></ul>
						        </div>
              </div>

                                 <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">ID Number</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="customer_id" placeholder="CP_ID_NUMBER" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
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
				        <%--</form>--%>
			        </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">
                                  <div class="position-relative mr-3">
                                    <img class="rounded-circle" src="assets/img/user/u5.jpg" alt="Image">
                                    <span class="status away"></span>
		        </div>
            </ContentTemplate>
        </asp:UpdatePanel>
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

    <div class="col-12">
		<div class="card card-default">
			<div class="card-body">
				<%--<form runat="server">--%>
					<div class="form-row">

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Address</label>
							<asp:Textbox runat="server" type="text" class="form-control" ID="account_address" placeholder="Account Address" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-warning text-white">
                                    <i class="mdi mdi-chart-areaspline font-size-20"></i>
						</div>

                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">City</label>
                            <asp:Textbox runat="server" type="text" class="form-control" ID="city" placeholder="City" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
						  
                                      <span class="font-size-12 font-weight-medium text-secondary">
                                        <i class="mdi mdi-clock-outline"></i> 1 hrs ago...
                                      </span>
                                    </div>
			            </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Connection Status</label>
							<asp:Textbox runat="server" type="text" class="form-control" ID="connection_status" placeholder="Connection Status" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							<div class="invalid-feedback">
								Please Fill this Details.
							</div>
						</div>

                                  <div class="media-body d-flex justify-content-between">
                                    <div class="message-contents">
                                      <h4 class="title">Add request</h4>
                                      <p class="last-msg font-size-14">Add Dany Jones as your contact consequat nec imperdiet ex rutrum. Fusce et vehicula enim. Sed in enim.</p>
                       
                                      <button type="button" class="my-1 btn btn-sm btn-success">Accept</button>
                                      <button type="button" class="my-1 btn btn-sm btn-secondary">Delete</button>
                        
                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Rating</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="acc_rating" placeholder="ACC_RATING" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							<div class="invalid-feedback">
								Please Fill this Details.
							</div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-danger text-white">
                                    <i class="mdi mdi-server-network-off font-size-20"></i>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Line Usage</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="line_usage" placeholder="LINE_USAGE" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							<div class="invalid-feedback">
								Please Fill this Details.
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
                <%--</form>--%>
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

     <div class="col-12">
		<div class="card card-default">
			<div class="card-body">
				<%--<form runat="server">--%>
					<div class="form-row">

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

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Category</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="account_category" placeholder="ACC_CATEGORY" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                         <%--<div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Last Month BIll</label>
							<input type="text" class="form-control" id="bill_month" placeholder="LAST_MONTH_BILL" aria-describedby="inputGroupPrepend3" >
							
						</div>--%>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Bill Run Date</label>
							<asp:Textbox runat="server" type="text" Text="28" class="form-control" id="bill_run_date" placeholder="28" ReadOnly="true" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>
                                </a>
                              </li>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Bill Balance</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="bill_balance" placeholder="BILL_BALANCE" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
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

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Credit Limit</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="credit_limit" placeholder="CR" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-warning text-white">
                                    <i class="mdi mdi-chart-areaspline font-size-20"></i>
                    </div>
                <%--</form>--%>
            </div>
        </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-primary text-white">
                                    <i class="mdi mdi-account-multiple-check font-size-20"></i>
    </div>

     <div class="col-12">
        <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>--%>
		        <div class="card card-default">
			        <div class="card-body">
                       
				        <%--<form runat="server">--%>
					        <div class="form-row">

                       	        <div class="form-group col-md-12">
						            <label class="text-dark font-weight-medium" for="exampleFormControlTextarea1">Concern</label>
						            <asp:Textbox runat="server" class="form-control" ID="concern" TextMode="Multiline" rows="3"></asp:Textbox>
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

                                  <div class="col-md-12 mb-3 mt-4">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Contact Person</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="contact_person" placeholder="CONTACT_PERSON" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
							        </div>
                                </a>
                              </li>

                              <li>
                                <a href="javscript:void(0)" class="media media-message media-notification">

                                  <div class="d-flex rounded-circle align-items-center justify-content-center mr-3 media-icon iconbox-45 bg-purple text-white">
                                    <i class="mdi mdi-playlist-check font-size-20"></i>
						        </div>

                                  <div class="col-md-12 mb-3 mt-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Contact Num</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="contact_number" placeholder="CONTACT_NO" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
							        </div>
						        </div>

                                  <div class="col-md-12 mb-3 mt-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Email</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="email" placeholder="EMAIL" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
							        </div>
						        </div>

                                 <div class="col-md-12 mb-3 mt-3">
						            <label class="text-dark font-weight-medium" for="validationServerUsername">Nearest BO</label>
                                   <%-- <asp:DropDownList ID="ddlNearestBd" runat="server"></asp:DropDownList>--%>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlNearestBd" runat="server" class="form-control" ></asp:DropDownList>
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

                                <div class="col-md-12 mb-3 mt-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Informed By</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="informed_by" placeholder="INFORMED_BY" aria-describedby="inputGroupPrepend3" ></asp:Textbox>

						        </div>

                 
                       
<div class="row">

                            </div>
                       <%-- </form>--%>
                    </div>
                </div>
   <%--         </ContentTemplate>
        </asp:UpdatePanel>--%>
    </div>
========
    <form runat="server">
>>>>>>>> f3d2dc4a0c800aec4df918f719f99a55570a9a49:TelcoSystem/ViewComplains.aspx

 
     <div class="col-12">
     <%--   <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>--%>
		        <div class="card card-default">
			        <div class="card-body">
				        <%--<form runat="server">--%>
					        <div class="form-row">

                       
                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Complain Id</label>
							<asp:Textbox  type="text" class="form-control" ID="comp_id"  aria-describedby="inputGroupPrepend3" runat="server"></asp:Textbox>
							
						</div>

                        

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Transaction Date</label>
							<asp:Textbox type="text" ID="txn_date" runat="server" class="form-control"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
							
						</div>

                                <div class="col-md-12 mb-3">
						            <label class="text-dark font-weight-medium" for="validationServerUsername">Category</label>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlCategory" runat="server" class="form-control"  ></asp:DropDownList>
                                    </div>
						
                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Complain Type</label>
							<asp:Textbox runat="server" type="text" class="form-control" ID="comp_type"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
			                    </div>

                                <div class="col-md-12 mb-3">
						            <label class="text-dark font-weight-medium" for="validationServerUsername">Complain</label>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlComplain" runat="server" class="form-control" ></asp:DropDownList>
                                    </div>

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">DN Service Number</label>
							<asp:Textbox runat="server" type="text" class="form-control" ID="dn_svc_no"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
						
			                    </div>

                            </div>
                        <%--</form>--%>
                    </div>
                </div>
           <%-- </ContentTemplate>
        </asp:UpdatePanel>--%>
    </div>



    <div class="col-12">
  <%--      <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>--%>
		        <div class="card card-default">
			        <div class="card-body">
				        <%--<form runat="server">--%>
					        <div class="form-row">


                                <div class="col-md-12 mb-3">
						            <label class="text-dark font-weight-medium" for="validationServerUsername">Complain Sub Category</label>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlComplainSub" runat="server" class="form-control"></asp:DropDownList>
                                    </div>
					
                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Rating</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="acc_rating"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
						
			                    </div>

                                  <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">FID</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="fid" placeholder="TXT_FID" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
							        </div>

                         <div class="col-md-12 mb-3 mt-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Last Month Bill</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="last_month_bill"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						        </div>

                                <div class="col-md-12 mb-3" id="dvInfo" runat="server">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Inform To</label>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlSectionMaster" runat="server" class="form-control"  ></asp:DropDownList>
                                    </div>
						
                        <div class="form-group col-md-12">
						    <label class="text-dark font-weight-medium" for="exampleFormControlTextarea1">Address</label>
						    <textarea class="form-control" id="address" rows="3"></textarea>
						        </div>
                      

                            </div>
                        <%--</form>--%>
                    </div>
                </div>
<%--            </ContentTemplate>
        </asp:UpdatePanel>--%>
    </div>

       <div class="col-12">
           <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                <ContentTemplate>
		            <div class="card card-default">
			            <div class="card-body">
				        <%--<form runat="server">--%>
					        <div class="form-row">
                                   <asp:RadioButtonList ID="rbBound" runat="server" RepeatDirection="Horizontal" CssClass="margin-left:10px">
                                        <asp:ListItem Value="1" CssClass="form-check-input" Style="margin-right: 50px">&nbsp;Inbound</asp:ListItem>
                                        <asp:ListItem Value="0" CssClass="form-check-input">&nbsp;Outbound</asp:ListItem>
                                    </asp:RadioButtonList>
                     
                        <div class="col-md-12 mb-3">
<<<<<<<< HEAD:TelcoSystem/Complain.aspx
							<label class="text-dark font-weight-medium" for="validationServerUsername">ID Number</label>
							<input type="text" class="form-control" id="validationServerUsername14" placeholder="CP_ID_NUMBER" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
                            </div>
                  
                        <%--</form>--%>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
            
                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Last Month BIll</label>
							<input type="text" class="form-control" id="validationServerUsername16" placeholder="LAST_MONTH_BILL" aria-describedby="inputGroupPrepend3" required>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
    </div>

      <div class="col-12">
           <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                <ContentTemplate>
		            <div class="card card-default">
			            <div class="card-body">
				           
					             <div class="ml-2">
                                    <label class="text-dark font-weight-medium d-inline-block mr-3" for="">Follow Up</label>
                                     <asp:RadioButtonList ID="rbFollow" runat="server" RepeatDirection="Horizontal" CssClass="margin-left:10px">
                                        <asp:ListItem Value="1" CssClass="form-check-input" Style="margin-right: 50px">&nbsp;Yes</asp:ListItem>
                                        <asp:ListItem Value="0" CssClass="form-check-input">&nbsp;No</asp:ListItem>
                                    </asp:RadioButtonList>
				           
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
               </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <div class="col-12">
		<div class="card card-default">
			<div class="card-body">
				<%--<form runat="server">--%>
					<div class="form-row">
                        <div class="d-flex justify-content-around" >
                            <asp:Button runat="server"  class="mr-2 btn btn-danger" OnClick="GoToDashboard" Text="BACK" />

                            <asp:Button runat="server"  class="mr-2 btn btn-secondary"  Text="GLOBAL INQUIRY" />

                            <asp:Button runat="server"  class="mr-2 btn btn-success" OnClick="Save_btn" Text="SAVE" />
					    </div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Contact Number</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="contact_no"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
							
                   </div>
                <%--</form>--%>
            </div>
        </div>
    </div>


   <%-- displane hidden--%>
     <div class="card card-default" style="display:none;">
			<div class="card-header card-header-border-bottom">
				<h2>Other Options</h2>
                
			</div>

			<div class="card-body ml-2">
				<%--<form runat="server">--%>
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
								
                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Inform To</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="info_to" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
                              
                                <div class="col-6" style="display:none;">
								    <button type="button" class="mb-1 mr-2 btn  btn-warning">MESSAGE</button>
                                </div>
                                <div class="col-6" style="display:none;">
                                    <button type="button" class="mb-1 mr-2 btn  btn-primary">ISP PROXYMITY</button>
								</div>
							</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Reference Complain Id</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="ref_comp_id"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
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
                <%--</form>--%>
							</div>
						</div>
					</div>

					
				<%--</form>--%>
			</div>
		</div>

        <div class="col-lg-6" style="display:none;">
		    <div class="card card-default">
			    <div class="card-body">
				    <%--<form runat="server">--%>
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
             
                </div>
            </div>
        </div>


   <%-- displane hidden--%>



    </form>
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


      </div> <!-- End Content -->
    
</asp:Content>
   
    <!-- Javascript -->
    <script src="assets/plugins/jquery/jquery.min.js"></script>
    <script src="assets/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/plugins/simplebar/simplebar.min.js"></script>


    <script src="assets/js/sleek.js"></script>
  <link href="assets/options/optionswitch.css" rel="stylesheet">
<script src="assets/options/optionswitcher.js"></script>
</body>
</html>
