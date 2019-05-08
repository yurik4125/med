<%@ Page Title="" Language="C#" MasterPageFile="~/Promedic.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Assignment1.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MedicConnectionString %>" SelectCommand="SELECT * FROM [Users] WHERE ([userName] = @userName)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="userName" Name="userName" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                Login</div>
            <div class="card-body">
                <form>
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox ID="userName" runat="server" CssClass="form-control">Omar.Omar</asp:TextBox>
                          
                            <label for=""userName">User name</label>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox ID="inputPassword" runat="server" TextMode="Password" CssClass="form-control">Omar5556</asp:TextBox>
                        
                            <label for="inputPassword">Password</label>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="checkbox">
                            <label>
                                <input type="checkbox" value="remember-me">
                                Remember Password
                            </label>
                        </div>
                    </div>
                  
                    <asp:Button CssClass="btn btn-primary btn-block" ID="btnLofin" runat="server" Text="Login" OnClick="btnLofin_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="register.html">Register an Account</a>
                    <a class="d-block small" href="forgot-password.html">Forgot Password?</a>
                </div>
            </div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" BackColor="#99FF99" ></asp:TextBox>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>
