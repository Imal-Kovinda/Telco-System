<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="TelcoSystem.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <style>
        .form-group .form-control{
           
            font-size: 1.4rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  
 


     <div class="content-wrapper">
            <div class="content" style="padding:0rem 0rem;">


    <div class="row justify-content-center">
	<div class="col-12">
                  <div class="card card-default">
                  <div class="card-header justify-content-between" style="padding-top:0rem; ">
                      <h2 style="margin-left:120px; font-size:15px;">Sign Up</h2>
                      
                    </div>

			<div class="card-body" style="padding-top:0rem;">
                <form style="margin-top:20px;">
                                   
                             <div class="col-6">
							     <div class="form-group">
								<asp:Literal ID="Literal1" runat="server" Text="User Nmae"></asp:Literal>
                                <asp:TextBox ID="username" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" CssClass="text-danger"
                                ControlToValidate="username" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator> 
								
							    </div>
						   </div>

                         <div class="col-6">
							<div class="form-group">
								<asp:Literal ID="Literal2" runat="server" Text="Password"></asp:Literal>
							    <asp:TextBox ID="password" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" CssClass="text-danger"
                                ControlToValidate="password" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator> 
							</div>
						</div>

                        <div class="col-6">
							<div class="form-group">
								<asp:Literal ID="Literal3" runat="server" Text="Confirm Password"></asp:Literal>
							    <asp:TextBox ID="conpassword" placeholder="" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" CssClass="text-danger"
                                ControlToValidate="conpassword" ErrorMessage="This field is Required" ValidationGroup="1"></asp:RequiredFieldValidator> 
							</div>
						</div>

                       <asp:Button ID="btnSave" runat="server" Text="Submit" class="btn btn-primary" Style="margin-left:18px; height50px;" OnClick="btnSave_Click" ValidationGroup="1" Width="269px" />


                     </form>
                           

		
			</div>
           
		</div>  

	</div>
</div>



      </div> <!-- End Content -->
    </div>
    

   

</asp:Content>
