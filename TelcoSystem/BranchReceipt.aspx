<%@ Page Title="BranchReciept" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BranchReceipt.aspx.cs" Inherits="TelcoSystem.WebForm1" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .form-group .form-control, .input-group .form-control {
            height: 30px;
        }

        .form-row {
            height: 55px;
        }

        .col-sm-6 {
            height: 63px;
            max-width: 100%;
            top: 0px;
            left: 0px;
        }
    </style>


    <div class="content" style="padding: 0rem 0rem;">

        <div class="card card-default">
            <div class="row" style="color: black; margin-right: -165px;">
                <div class="col-md-8" style="margin-left: 10px; max-width: 80%;">

                    <div class="row1" style="padding: 0.5rem; border: 1px solid black; border-color: #cfd2d5;">
                        <div class="col1 ml-2" style="display: flex; gap: 50px; margin-top: 10px; background-color: #e5e5e5;">
                            <h4 style="margin-left: 10px; margin-top: 5px;">Payment Mode</h4>

                            <ul class="list-unstyled list-inline" style="margin-top: 5px; margin-bottom: -7px;">
                                <li class="d-inline-block mr-3">
                                    <label class="control control-radio">
                                        Cash
							                <input type="radio" name="option" checked="checked">
                                        <div class="control-indicator"></div>
                                    </label>
                                </li>

                                <li class="d-inline-block mr-3">
                                    <label class="control control-radio">
                                        Cheque
							                <input type="radio" name="option">
                                        <div class="control-indicator"></div>
                                    </label>
                                </li>

                                <li class="d-inline-block">
                                    <label class="control control-radio">
                                        Credit Card
							                <input type="radio" name="option">
                                        <div class="control-indicator"></div>
                                    </label>
                                </li>
                            </ul>

                        </div>


                        <!-- Extended default form grid -->
                        <form style="margin-top: 20px;">

                            <div class="form-row" style="margin-top: 20px;">

                                <div class="form-group col-md-6">
                                    <asp:Literal ID="Literal11" runat="server" Text="Category"></asp:Literal>
                                    <asp:TextBox ID="txtCategory" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>

                                </div>

                                <div class="form-group col-md-6">
                                    <asp:Literal ID="Literal10" runat="server" Text="Receipt Date"></asp:Literal>
                                    <asp:TextBox ID="txtDate" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>


                                </div>
                            </div>

                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <asp:Literal ID="Literal9" runat="server" Text="Receipt No"></asp:Literal>
                                    <asp:TextBox ID="txtReceiptNo" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>


                                </div>
                                <div class="form-group col-md-6">
                                    <asp:Literal ID="Literal8" runat="server" Text="Provisionary Receipt No"></asp:Literal>
                                    <asp:TextBox ID="txtProRecNo" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>

                                </div>
                            </div>

                            <div class="form-row">

                                <div class="form-group col-md-6">
                                    <asp:Literal ID="Literal6" runat="server" Text="Receipt Total"></asp:Literal>
                                    <asp:TextBox ID="txtTotal" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>

                                </div>
                            </div>



                        </form>
                        <!-- Extended default form grid -->

                    </div>

                    <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">--%>
                    <contenttemplate>
                        <div class="row2" style="padding: 0.5rem; border: 1px solid black; border-color: #cfd2d5;">

                            <div class="col2" style="margin-top: 10px;">


                                <div class="row">

                                    <div class="col-sm-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <div class="form-group">
                                                    <asp:Literal ID="Literal4" runat="server" Text="Account Code"></asp:Literal>
                                                    <asp:TextBox ID="txtAccCode" placeholder="" CssClass="form-control" runat="server" AutoPostBack="true" OnTextChanged="txtAccCode_TextChanged"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" CssClass="text-danger"
                                                        ControlToValidate="txtAccCode" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>
                                                    <%--AutoPostBack="true" OnTextChanged="txtAccCode_TextChanged" --%>
                                                </div>
                                            </div>

                                            <div class="col-6">
                                                <div class="form-group">
                                                    <asp:Literal ID="Literal3" runat="server" Text="DN"></asp:Literal>
                                                    <asp:TextBox ID="txtDN" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" CssClass="text-danger"
                                                        ControlToValidate="txtDN" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>

                                                </div>
                                            </div>
                                        </div>

                                    </div>

                                    <div class="col-sm-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <div class="form-group">
                                                    <asp:Literal ID="Literal2" runat="server" Text="NIC No"></asp:Literal>
                                                    <asp:TextBox ID="txtNIC" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" CssClass="text-danger"
                                                        ControlToValidate="txtNIC" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>

                                                </div>
                                            </div>


                                            <div class="form-group">
                                                <asp:Literal ID="Literal5" runat="server" Text="Payment Type"></asp:Literal>
                                                <asp:DropDownList class="form-control" ID="ddlpaytypeid" runat="server" OnSelectedIndexChanged="ddllpaymentTypeId_SelectedValueChanged">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" CssClass="text-danger"
                                                    ControlToValidate="ddlpaytypeid" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>
                                            </div>


                                        </div>
                                    </div>




                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <%--<asp:Label ID="lblSubName" runat="server" CssClass="form-control" ></asp:Label>--%>
                                            <asp:TextBox ID="txtSubName" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-danger"
                                                ControlToValidate="txtSubName" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>

                                        </div>
                                    </div>


                                </div>




                                <div class="row" style="margin-top: -30px;">

                                    <div class="col-sm-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <div class="form-group">
                                                    <asp:Literal ID="Literal1" runat="server" Text="Account Name"></asp:Literal>
                                                    <asp:TextBox ID="txtAccName" Style="width: 218%;" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" CssClass="text-danger"
                                                        ControlToValidate="txtAccName" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>

                                                </div>
                                            </div>

                                        </div>

                                    </div>

                                    <div class="col-sm-6">
                                        <div class="row">

                                            <div class="col-6">
                                                <div class="form-group">
                                                    <asp:Literal ID="ltAmount" runat="server" Text="Amount"></asp:Literal>
                                                    <asp:TextBox ID="txtAmount" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" CssClass="text-danger"
                                                        ControlToValidate="txtAmount" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>

                                                </div>
                                            </div>
                                            <div class="col-6" style="margin-top: 21px;">
                                                <asp:Button ID="btnNext" runat="server" Text="Next" class="btn btn-block btn-outline-primary btn-sm" OnClick="btnNext_Click" ValidationGroup="1" />
                                            </div>
                                        </div>
                                    </div>


                                </div>
                            </div>

                        </div>
                    </contenttemplate>

                    <%--  </asp:UpdatePanel>--%>


                    <div class="row-3">
                        <div class="col3">
                            <asp:GridView ID="gvReceiptDetails" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover"
                                CellPadding="4" ForeColor="#333333" GridLines="None">
                                <Columns>
                                    <asp:BoundField DataField="accountId" HeaderText="Account Code" />
                                    <asp:BoundField DataField="payTypeId" HeaderText="Type" />
                                    <asp:BoundField DataField="accountName" HeaderText="Account Name" />
                                    <asp:BoundField DataField="amount" HeaderText="Amount" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                    <div class="row4" style="border: 1px solid black; border-color: #cfd2d5;">
                        <div class="col4" style="margin-bottom: 20px;">

                            <div class="btn" style="display: flex; height: 58px;">
                                <button type="button" class="btn btn-primary" style="width: 100px; height50px;">Query</button>
                                <button type="button" class="btn btn-primary" style="margin-left: 5px; width: 100px;">Exit</button>
                                <button type="button" class="btn btn-primary" style="margin-left: 5px; width: 100px;">Clear</button>

                                <nav style="margin-left: 5px;" aria-label="Page navigation example">
                                    <ul class="pagination pagination-seperated">
                                        <li class="page-item">
                                            <a class="page-link" href="#" aria-label="Previous"><<
				
                                            </a>
                                        </li>

                                        <li class="page-item">
                                            <a class="page-link" href="#"><</a>
                                        </li>

                                        <li class="page-item">
                                            <a class="page-link" href="#">></a>
                                        </li>

                                        <li class="page-item">
                                            <a class="page-link" href="#" aria-label="Next">>>
								
                                            </a>
                                        </li>
                                    </ul>
                                </nav>

                                <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" Style="margin-left: 95px; width: 100px;" OnClick="btnSave_Click" />


                            </div>

                        </div>
                    </div>


                </div>
                <div style="border: 1px solid black; border-color: #cfd2d5; padding: 1rem; max-width: 18%" class="col-md-4">
                    <div class="col-sm-6">
                        <div class="form-group">
                            <asp:Literal ID="Literal12" runat="server" Text="Rating"></asp:Literal>
                            <asp:TextBox ID="txtRating" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" CssClass="text-danger"
                                ControlToValidate="txtRating" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator> --%>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="form-group">
                            <asp:Literal ID="Literal13" runat="server" Text="Type"></asp:Literal>
                            <asp:TextBox ID="txtType" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" CssClass="text-danger"
                                ControlToValidate="txtType" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator> --%>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="form-group">
                            <asp:Literal ID="Literal14" runat="server" Text="Status"></asp:Literal>
                            <asp:TextBox ID="txtStatus" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" CssClass="text-danger"
                                ControlToValidate="txtStatus" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="form-group">
                            <asp:Literal ID="Literal15" runat="server" Text="Outstanding"></asp:Literal>
                            <asp:TextBox ID="txtOutstanding" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" CssClass="text-danger"
                                ControlToValidate="txtOutstanding" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator> --%>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="form-group">
                            <asp:Literal ID="Literal16" runat="server" Text="Credit Limit"></asp:Literal>
                            <asp:TextBox ID="txtcreditLimit" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" CssClass="text-danger"
                                ControlToValidate="txtcreditLimit" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator> --%>
                        </div>
                    </div>

                </div>
            </div>
        </div>




    </div>
    <!-- End Content -->


</asp:Content>
