<%@ Page Language="C#" Inherits="VoteMe.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
		<link href="resource/bootstrap/css/bootstrap.min.css" rel="stylesheet">
	<title>VoteMe !</title>
		<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="shortcut icon" type="image/x-icon" href="images/signup.jpg" />
</head>
<body style="margin:5px;padding:12px;color:white;height:100%;" class="bg-dark card">
<div class="row" >
  <div class="col-md-8 "  >
  <div class="card border-warning bg-dark mb-3" style="max-width: 100%;padding:0px;">
 
  <div class="card-body">
  <div id="carouselExampleIndicators" class="carousel slide bg-warning" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img height="50%" class="d-block w-100" src="images/a.jpg" alt="First slide">
    </div>
    <div class="carousel-item">
      <img height="50%"  class="d-block w-100" src="images/b.jpg" alt="Second slide">
    </div>
    <div class="carousel-item">
      <img height="50%"  class="d-block w-100" src="images/c.jpg" alt="Third slide">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>


</div></div>
<p> Have a vision? Make the right decision! Vote! </p>
			</div>
  <div class="col-md-4">



				<div class="card text-white bg-danger mb-3" style="max-width: 30rem;">

					<div class="card-header">Register New Voting Event !</div>

					<div class="card-body">

						<h4 class="card-title">Election Officer Login</h4>


                           <form runat="server" id="officerLoginForm">
							
							<table border="0" width="100%">
								<tr>
									<td>
										<div class="input-group">
											<span style="background-color:OrangeRed" class="input-group-addon" id="basic-addon1">@</span>
									<asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightCoral" id="txtUserNameEle" placeholder="Username or Email" Width="100%" MaxLength="20" runat="server"/>
									</div>
									</td>
									</tr>
								<tr>
									<td>&nbsp<asp:Label runat="server" id="msg" ForeColor="WhiteSmoke"/></td>
									</tr>
								<tr>
                                    <td><asp:TextBox  ForeColor="WhiteSmoke" class="form-control" BackColor="LightCoral" id="txtPasswordEle" placeholder="Password" runat="server" MaxLength="20" Width="100%"  TextMode="Password"/></td>
								</tr>
                                 <tr>
									<td>&nbsp</td>
									</tr>
								<tr>
                                    <td ><asp:Button Width="50%" class="btn btn-danger border-success" id="loginEle" OnClick="doLogin" runat="server" Text="Sign In"/></td>
                                </tr>
								<tr>
									<td><p class="card-text"><a class="nav-link" style="color:white;" href="elections/signup.aspx">Register a new account ... </a>
                            </p>
                            </td>
								</tr>
								
							</table>
						   </form>
						
 
  

					</div>

				</div>

                <div class="card text-white bg-success mb-3" style="max-width: 30rem;">

                    <div class="card-header">Use your own Vote !</div>

                    <div class="card-body">

                        <h4 class="card-title">Login For Vote</h4>


                           <form runat="server" id="loginForm">
                            
                            <table border="0" width="100%">
                                <tr>
                                    <td>
                                        <div class="input-group">
											<span class="input-group-addon" style="background-color:SeaGreen" id="basic-addon2">@</span>
                                    <asp:TextBox ForeColor="DarkGreen" class="form-control btn-success border-danger" BackColor="PaleGreen" id="txtAdhar" placeholder="Aadhar Number" Width="100%" MaxLength="12" runat="server"/>
                                </div></td>
									</tr>
								<tr><td>&nbsp<asp:Label runat="server" id="msg1" ForeColor="WhiteSmoke"/></td>
									</tr>
								<tr>
                                    <td><asp:TextBox ForeColor="DarkGreen" class="form-control " BackColor="PaleGreen" id="txtPass" placeholder="Mobile Nubmer"  runat="server" MaxLength="10" Width="100%"  /></td></tr>
                                    <tr><td>&nbsp</td></tr><tr>
                                    <td ><asp:Button Width="50%" class="btn btn-success border-danger" id="login" runat="server" OnClick="doLoginPeople" Text="Sign In"/></td>
                                </tr>

                                
                            </table>
                           </form>
                        
 
  

                    </div>

                </div>



				
		</div>

	</div>








<script src="resource/jquery/jquery-3.1.1.min.js"></script>
        <script src="resource/bootstrap/js/bootstrap.min.js"></script>
        <script src="otherResource/validation.js"></script>
</body>
</html>
