
<%@ Page Language="C#"  Title="Complain" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Complain.aspx.cs" Inherits="TelcoSystem.Complain" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div class="content">

	<div class="row">

		

		<div class="card col-12 card-default">
			<div class="card-header card-header-border-bottom">
				<div class="col-6">
                        <h2>Complain Entry</h2>
                        

                    </div>
                    <div class="col-6 d-flex flex-row-reverse">
                        <img src="~/assets/logo/bell.jpeg" runat="server" Width="120" Height="60" />
                        

                    </div>
			</div>

			<div class="card-body">
		
					<div class="row">
						
					
						<div class="row">
							<div class="col-6">
								<div class="form-group">
									<h4>STATUS_DESC</h4>
								</div>
							</div>

							<div class="col-6">
								<div class="form-group">
									<label for="State">Referance No</label>
									<asp:Textbox runat="server" type="text" id="ref_no" class="form-control" placeholder="C_COMP_ID"></asp:Textbox>
								</div>
							</div>
						</div>
				

						<div class="col-sm-6">
							<div class="row">
								<div class="col-6">
									<div class="form-group">
										<label for="State">Logged Date</label>
										<asp:Textbox runat="server" ID="logged_date" type="text" class="form-control" placeholder="TXN_DATE"></asp:Textbox>
									</div>
								</div>

								<div class="col-6">
									<div class="form-group">
										<label for="Zip">by</label>
										<asp:Textbox runat="server" ID="by" type="text" class="form-control" placeholder="LOGGED_BY"></asp:Textbox>
									</div>
								</div>
							</div>
						</div>
					</div>

			</div>
		</div>

	<div class="col-12">
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
            <ContentTemplate>
		        <div class="card card-default">
			        <div class="card-body">
				        <%--<form runat="server">--%>
					        <div class="form-row">

                       
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

                          

                                 <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Customer Name</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="customer_name" placeholder="CUST_NAME" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please choose a username.
							        </div>
						        </div>

                                 <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">ID Number</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="customer_id" placeholder="CP_ID_NUMBER" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
							        </div>
						        </div>

                         

					        </div>
				        <%--</form>--%>
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

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Address</label>
							<asp:Textbox runat="server" type="text" class="form-control" ID="account_address" placeholder="Account Address" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						</div>

                        <div class="col-md-12 mb-3">
						    <label class="text-dark font-weight-medium" for="validationServerUsername">City</label>
                            <asp:Textbox runat="server" type="text" class="form-control" ID="city" placeholder="City" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
						  
			            </div>

                         <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Connection Status</label>
							<asp:Textbox runat="server" type="text" class="form-control" ID="connection_status" placeholder="Connection Status" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							<div class="invalid-feedback">
								Please Fill this Details.
							</div>
						</div>

                       
                        
                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Account Rating</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="acc_rating" placeholder="ACC_RATING" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							<div class="invalid-feedback">
								Please Fill this Details.
							</div>
						</div>

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Line Usage</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="line_usage" placeholder="LINE_USAGE" aria-describedby="inputGroupPrepend3"></asp:Textbox>
							<div class="invalid-feedback">
								Please Fill this Details.
							</div>
						</div>


                      

                    </div>
                <%--</form>--%>
			</div>
        </div>
    </div>

     <div class="col-12">
		<div class="card card-default">
			<div class="card-body">
				<%--<form runat="server">--%>
					<div class="form-row">

                         

                       

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

                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Bill Balance</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="bill_balance" placeholder="BILL_BALANCE" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>



                        <div class="col-md-12 mb-3">
							<label class="text-dark font-weight-medium" for="validationServerUsername">Credit Limit</label>
							<asp:Textbox runat="server" type="text" class="form-control" id="credit_limit" placeholder="CR" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							<div class="invalid-feedback">
								Please enter the connection status.
							</div>
						</div>

                    </div>
                <%--</form>--%>
            </div>
        </div>
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

          
             

                                  <div class="col-md-12 mb-3 mt-4">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Contact Person</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="contact_person" placeholder="CONTACT_PERSON" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
							        </div>
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
				
			                    </div>

                         

                                <div class="col-md-12 mb-3 mt-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Informed By</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="informed_by" placeholder="INFORMED_BY" aria-describedby="inputGroupPrepend3" ></asp:Textbox>

						        </div>

                 
                       

                            </div>
                       <%-- </form>--%>
                    </div>
                </div>
   <%--         </ContentTemplate>
        </asp:UpdatePanel>--%>
    </div>

 
     <div class="col-12">
     <%--   <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>--%>
		        <div class="card card-default">
			        <div class="card-body">
				        <%--<form runat="server">--%>
					        <div class="form-row">

                                <div class="col-md-12 mb-3">
						            <label class="text-dark font-weight-medium" for="validationServerUsername">Category</label>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlCategory" runat="server" class="form-control"  ></asp:DropDownList>
                                    </div>
						
			                    </div>

                                <div class="col-md-12 mb-3">
						            <label class="text-dark font-weight-medium" for="validationServerUsername">Complain</label>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlComplain" runat="server" class="form-control" ></asp:DropDownList>
                                    </div>

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
					
			                    </div>

                                  <div class="col-md-12 mb-3">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">FID</label>
							        <asp:Textbox runat="server" type="text" class="form-control" id="fid" placeholder="TXT_FID" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							        <div class="invalid-feedback">
								        Please enter the connection status.
							        </div>
						        </div>

                                <div class="col-md-12 mb-3" id="dvInfo" runat="server">
							        <label class="text-dark font-weight-medium" for="validationServerUsername">Inform To</label>
                                    <div class="col-sm-12" style="display: flex; flex-direction: row">
                                        <asp:DropDownList ID="ddlSectionMaster" runat="server" class="form-control"  ></asp:DropDownList>
                                    </div>
						
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
                     
                            </div>
                  
                        <%--</form>--%>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
            
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
				           
                                </div>
                  
                      
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





</div>





      </div> <!-- End Content -->
    
</asp:Content>
   


