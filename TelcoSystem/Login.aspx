<%@ Page Title="Login" Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TelcoSystem.Login" %>


<asp:Content ID="Login" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container d-flex align-items-center justify-content-center vh-100">
      <div class="row justify-content-center">
        <div class="col-lg-6 col-md-10">
          <div class="card">
            <div class="card-header bg-white">
              <div class="d-flex align-items-center justify-content-center " >
             
                <img src="~/assets/logo/bell.jpeg" runat="server" Width="160" Height="85" />
              </div>
            </div>

            <div class="card-body">
              <h3 class="text-dark mb-4"><span style="color:red">Si</span><span style="color:blue">gn In</span></h3>
              
       
                <div class="row">
              
                   <div class="form-group col-md-12 mb-2">
                        <label class="form-label" for="inputUserName">User Name</label>
                        <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control input-lg" placeholder="Username"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server"
                            ControlToValidate="txtUserName" ErrorMessage="Username is Required">*</asp:RequiredFieldValidator>
                   </div>

                   <div class="form-group col-md-12 ">
                        <label for="inputPassword" class="form-label">Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control " TextMode="Password" placeholder="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="txtPassword" ErrorMessage="Password Required">*</asp:RequiredFieldValidator>

                  </div>

                  <div class="col-md-12">
                    <div class="d-flex my-2 justify-content-between">
                      <div class="d-inline-block mr-3">
                        <label class="control control-checkbox">Remember me
                          <input type="checkbox" />
                          <%--<div class="control-indicator"></div>--%>
                        </label>
                      </div>

                      <p><a class="text-blue" href="#">Forgot Your Password?</a></p>
                    </div>
                    <asp:Label ID="lblErrorMsg" runat="server" Text="" ForeColor="#800040" BackColor="#ffc6c6"></asp:Label>
                    <div class="form-outline mb-3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />
                    </div>
                  <%--  <asp:Button runat="server" type="submit" class="btn btn-lg btn-primary btn-block mb-4" onclick="login" Text="Sign In" />--%>

                    <div class="form-group d-flex justify-content-center">
                        <a class="small" href="#"></a>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary btn-block" Width="400px" Font-Bold="true" OnClick="btnLogin_Click" />
                    </div>

                  </div>
                </div>
     
            </div>
          </div>
        </div>
      </div>
    </div>


</asp:Content>


