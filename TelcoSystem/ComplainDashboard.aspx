<%@ Page Title="ComplainDashboard" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComplainDashboard.aspx.cs" Inherits="TelcoSystem.ComplainDashboard" %>

 
     




<asp:Content ID="ComplainDashboard" ContentPlaceHolderID="MainContent" runat="server">
            <div class="content">
          
               <%--    style="position: relative; z-index: -1;"--%>
                 <%--  style="position: absolute; z-index: 1;"--%>

                     <!-- Recent Order Table -->
                    <div class="row container mb-4" >
			            <div class="col-12">
                          <div class="card" id="recent-orders">
                           <div class="row p-3">
                                <div class="col-6">
						            <h2><span style="color:red">Co</span><span style="color:blue">mplains</span></h2>
					            </div>
                                 <div class="col-6 d-flex  flex-row-reverse">
						              <asp:Button runat="server" type="button" class="mb-1 mb-4 mr-2 btn btn-primary" onclick="makeComplain" Text="Make Complain" />
			                     </div>
                           </div>
                            
                      
                            <div class="card-body" style="overflow-y:scroll; height:280px;" >
                              <asp:GridView  ID="GridView" runat="server" AllowSorting="True" OnSorting="gridView_Sorting" AutoGenerateColumns="False" CssClass="table table-hover"  ForeColor="#333333" GridLines="None" AllowPaging="True">
                                  <HeaderStyle CssClass="left-align" />
                                  <Columns>
                                    <%--<asp:BoundField DataField="CompId" HeaderText="Complain Id" SortExpression="CompId" />--%>
                                    <asp:TemplateField  HeaderText="Complain ID">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnRemarks" CssClass="btn-sm btn-secondary btn-user btn-block" runat="server" OnClick="btnRemarks_Click" CommandArgument='<%# Eval("CompId") %>'><%# Eval("CompId") %></asp:LinkButton> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="CompType" HeaderText="Complain Type" SortExpression="CompType"/>
                                    
                                    <asp:BoundField DataField="CompSubType" HeaderText="Complain Sub Type" SortExpression="CompSubType"/>
                                    <asp:BoundField DataField="AccCode" HeaderText="Account" SortExpression="AccCode"/>
                                    <asp:BoundField DataField="TxnDate" HeaderText="Txn Date" SortExpression="TxnDate"/>
                                    <asp:BoundField DataField="CustRemarks" HeaderText="Remarks" />
                            
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnView" CssClass="btn-sm btn-primary btn-user btn-block" runat="server" OnClick="btnView_Click" CommandArgument='<%# Eval("CompId") %>'>More</asp:LinkButton> 
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                       <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnDone" CssClass="btn-sm btn-danger btn-user btn-block" runat="server" OnClick="btnDone_Click" CommandArgument='<%# Eval("CompId") %>'>Done</asp:LinkButton> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                 
                                </Columns>
                              </asp:GridView>
                            </div>


                          </div>

			            </div>
		            </div>

                  <%-- <div class="col-6"  ID="confirmBox" runat="server">
                       <h2>ConfirmMe</h2>
                   </div>--%>

              <%--   hidden div--%>
                  

                <div id="dvView_More" runat="server"  class="rowcol-12 mt-1 mb-10" style="overflow-y:scroll; height:380px;">
                       <div class="row">
                        <div runat="server"  class="col-6"  >
		                     <div class="card card-table-border-none recent-orders">
                                
			                    <div class="card-body"  >
				                <%--<formview></formview>--%>
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
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Customer Name</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="cust_name"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Complain Category Code</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="comp_cat_code"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
						
						                    </div>

                                             <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Complain Type</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" ID="comp_type"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                             <div class="col-md-12 mb-3">
						                        <label class="text-dark font-weight-medium" for="validationServerUsername">Complain Sub Type</label>
                                                <asp:Textbox runat="server" type="text" class="form-control" ID="comp_sub_type"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
						 
			                                </div>
                                             <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">My Remarks</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="my_remarks" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                              <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Inform To</label>
							                    <asp:DropDownList ID="ddlSectionMaster" runat="server" class="form-control"  ></asp:DropDownList>
							
						                    </div>
                                            

                                            

					                    </div>
				                    <%--</form>--%>
			                    </div>
		                    </div>
	                    </div>



                        <div class="col-6">
		                    <div class="card card-default">
			                    <div class="card-body">
				                    <%--<form runat="server">--%>
					                    <div class="form-row">
                       
                                           
                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Account Code</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="acc_code"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Account Rating</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="acc_rating"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
						
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Connection Status</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="conn_status"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3" style="display:none;">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Account Category</label>
							                    <asp:Textbox runat="server" type="number" class="form-control" id="acc_category"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
							
						                    </div>

                                             <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Line Type</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="line_type"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Line Usage</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="line_usage"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                             <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Last Month Bill</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="last_month_bill"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">User Code</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="user_code"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="form-group col-md-12">
						                        <label class="text-dark font-weight-medium" for="exampleFormControlTextarea1">Address</label>
						                        <asp:Textbox class="form-control" ID="comp_address" runat="server"></asp:Textbox>
					                        </div>


                                        </div>
                                    <%--</form>--%>
			                    </div>
                            </div>
                        </div>

                         <div class="col-6">
		                    <div class="card card-default">
			                    <div class="card-body">
				                    <%--<form runat="server">--%>
					                    <div class="form-row">

                                           

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Contact Person</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="contact_person"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
						
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Contact Number</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="contact_no"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
							
						                    </div>

                                             <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Informed By</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="informed_by"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Logged BY</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="logged_by" aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Attended On</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="attended_on"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							                  
						                    </div>

                                    
                                             <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">DN Service Number</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" ID="dn_svc_no"  aria-describedby="inputGroupPrepend3"></asp:Textbox>
						
						                    </div>

                                        </div>
                                    <%--</form>--%>
                                </div>
                            </div>
                        </div>

                           <div class="col-6">
		                    <div class="card card-default">
			                    <div class="card-body">
				                    <%--<form runat="server">--%>
					                    <div class="form-row">

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Reference Complain Id</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="ref_comp_id"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Urgent Complain</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="urgent_comp"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Hold To</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="hold_to"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Fault Id</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="fault_id"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Rejected</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="rejected"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
						                    </div>

                                            <div class="col-md-12 mb-3">
							                    <label class="text-dark font-weight-medium" for="validationServerUsername">Customer Remark</label>
							                    <asp:Textbox runat="server" type="text" class="form-control" id="cust_remarks"  aria-describedby="inputGroupPrepend3" ></asp:Textbox>
							
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
                                             <div class="col-md-6 mb-3">
                                                     <asp:Button runat="server"  class="mr-2 btn btn-secondary" onclick="backToDashboard" Text="Back" />
                                                </div>

                                                 <div class="col-md-6 mb-3  d-flex  flex-row-reverse">
                                                     <asp:Button runat="server"  class="mr-2 btn btn-primary" onclick="btn_ReSave" Text="Save" />
                                                </div>
                                          </div>
                                    <%--</form>--%>
                                </div>
                            </div>
                        </div>

                        </div>
                    </div>

                 <%--  hidden div--%>

                  <div ID="dvCompRemarks_grid" runat="server" class="col-12">
		                    <div class="card card-default">
			                    <div class="card-body">
				                    <%--<form runat="server">--%>
					                 <div class="card-body" style="overflow-y:scroll; height:240px;" >
                                          <asp:GridView  ID="GridViewRemarks" runat="server" AllowSorting="True" OnSorting="gridView_Sorting" AutoGenerateColumns="False" CssClass="table table-hover"  ForeColor="#333333" GridLines="None" AllowPaging="True">
                                              <HeaderStyle CssClass="left-align" />
                                              <Columns>
                                                <asp:BoundField DataField="RemarkId" HeaderText="Remark Id"/>
                                                <asp:BoundField DataField="CompId" HeaderText="Complain Id"/>
                                                <asp:BoundField DataField="SectionId" HeaderText="Section Id"/>
                                                <asp:BoundField DataField="ReInfoDate" HeaderText="Re-inform Date"/>
                                                <asp:BoundField DataField="MyRemarks" HeaderText="My Remarks"/>
                                            </Columns>
                                          </asp:GridView>
                                          <div class="col-md-12 d-flex  flex-row-reverse mb-3">
                                                <asp:Button runat="server"  class="mr-2 btn btn-primary" onclick="backToGridView" Text="OK" />
                                          </div>
                                        </div>
                                    <%--</form>--%>
			                    </div>
                            </div>
                        </div>

                  <%-- POPUP DIV--%>
                   <div id="popup" runat="server" style="border-radius:8px; position: fixed; top: 50%; left: 50%; transform: translate(-50%, -50%); background-color: white; padding: 20px; border: 1px solid black; width: 400px; height: 260px; z-index: 1;">
                        <div class="p-4 mb-4 ">
                            <h4 class="ml-6" ><span style="color:red">Confirm</span> <span style="color:blue">that complain</span></h4>
                        </div>
                       <div class="row">
                            <div class="col-md-6 ">
                                <asp:Button runat="server"  class="mr-2 btn btn-secondary" onclick="cancelPopup" Text="Cancel" />
                            </div>
                           <div class="col-md-6 d-flex  flex-row-reverse">
                                <asp:Button runat="server"  class="mr-2 btn btn-primary" onclick="donePopup" Text="Confirm" />
                            </div>
                       </div>
                   </div>



      </div> <!-- End Content -->



</asp:Content>


