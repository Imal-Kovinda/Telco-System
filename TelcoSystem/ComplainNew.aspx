<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComplainNew.aspx.cs" Inherits="TelcoSystem.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

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
    
</asp:Content>
