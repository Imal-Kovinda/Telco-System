<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BatchReceiptUpload.aspx.cs" Inherits="TelcoSystem.WebForm2" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="content-wrapper">
        <div class="content" style="padding: 0rem 0rem;">


            <div class="row">
                <div class="col-lg-6" style="padding-right: 0px;">
                    <div class="card card-default">
                        <div class="card-header justify-content-between" style="padding-top: 2rem; display: flex;">
                            <div class="form-group" style="display: flex; gap: 20px;">
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <%-- <asp:TextBox ID="txtFilePath" runat="server"></asp:TextBox>--%>
                            </div>
                            <asp:Button ID="btnBrowse" runat="server" Text="Browse" OnClick="BrowseButton_Click" />
                        </div>

                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="card-body" style="padding: 0.50rem; margin-top: 10px;">

                                    <div class="col-6" style="margin-top: -30px;">
                                        <div class="form-group row">
                                            <div class="col-12 col-md-3 text-right" style="color: #1b223c; font-size: 15px;">
                                                <asp:Literal ID="Literal5" runat="server" Text="Type"></asp:Literal>
                                            </div>

                                            <div class="col-12 col-md-9">
                                                <asp:DropDownList class="form-control" ID="ddltype" runat="server">
                                                    <asp:ListItem>ACCOUNT</asp:ListItem>
                                                    <asp:ListItem>DN</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>


                                    <div style="height: 300px; display: block; overflow-y: auto;">

                                        <div class="col3">
                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover">
                                                <Columns>
                                                    <asp:BoundField DataField="accountId" HeaderText="Account Num" />
                                                    <asp:BoundField DataField="amount" HeaderText="Amount" />
                                                    <asp:BoundField DataField="code" HeaderText="Code" />
                                                    <asp:BoundField DataField="batchNo" HeaderText="Batch No" />
                                                </Columns>
                                            </asp:GridView>
                                        </div>
                                        <asp:Label ID="Label1" Style="color: red;" runat="server"></asp:Label>
                                    </div>

                                    <div class="form-group" style="display: flex; gap: 30px; margin-top: 20px;">
                                        <label for="total" style="font: x-large; margin-top: 10px;">Total Amount</label>
                                        <input type="text" class="form-control" style="width: 20%;" placeholder="Total">
                                    </div>
                                </div>




                                <div class="btn" style="display: flex; margin-left: 30px; margin-top: -41px;">
                                    <asp:Button ID="btnSave" runat="server" Text="Save" Style="width: 100px; height: 50px;" class="btn btn-primary" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnUpload" runat="server" Text="Upload" Style="margin-left: 20px; width: 100px; height: 50px;" class="btn btn-primary" OnClick="btnUpload_Click" />

                                    <button type="button" class="btn btn-primary" style="margin-left: 20px; width: 100px; height50px;">Exit</button>
                                </div>

                            </ContentTemplate>
                        </asp:UpdatePanel>


                    </div>

                </div>

                <div class="col-lg-6" style="padding-right: 0px;">
                    <div class="card card-default">

                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>

                                <div class="card-body" style="padding: 0.50rem; margin-top: 10px;">
                                    <div class="col3">
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover">
                                            <Columns>
                                                <asp:BoundField DataField="accountId" HeaderText="Account Num" />
                                                <asp:BoundField DataField="amount" HeaderText="Amount" />
                                                <asp:BoundField DataField="code" HeaderText="Code" />
                                                <asp:BoundField DataField="batchNo" HeaderText="Batch No" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>

                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>



                    </div>

                </div>



            </div>



        </div>
        <!-- End Content -->
    </div>
</asp:Content>
