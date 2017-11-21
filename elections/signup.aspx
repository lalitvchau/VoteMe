<%@ Page Language="C#" Inherits="VoteMe.elections.signup" EnableEventValidation="false"%>
<!DOCTYPE html>
<html>
<head runat="server">
        <link href="../../resource/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <title>VoteMe !</title>
        <meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">

</head>
<body style="margin:5px;padding:12px;color:white;height:100%;"  align="center"  class="bg-dark card">
<div class="row" >
  <div class="col-md-12 border-warning" align="center">

  <!-- sign up form -->
 
		<div class="card border-danger bg-dark" style="width: 40rem;" >
					 <form id="signupform" runat="server" align="center">
  <img class="card-img-top" src="../../images/signup.jpg" alt="Card image cap" height="320px">
  <div class="card-body">
    <h4 class="card-title">Election Officer Registration </h4>
    <p class="card-text">Please register with the correct informations</p><p>
							<asp:label runat="server" id="msg"  ForeColor="WhiteSmoke" /></p>
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item bg-danger"><div class="input-group">
                                            <span style="background-color:OrangeRed" class="input-group-addon" id="basic-addon1">@</span>
                                    <asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightCoral" id="txtUsername" placeholder="Username or Email" Width="100%" MaxLength="20" runat="server"/>
                                    </div></li>
    <li class="list-group-item bg-danger"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightCoral" id="txtPasswordEle" placeholder="Password" runat="server" MaxLength="20" Width="100%"  TextMode="Password"/></li>
    <li class="list-group-item bg-danger"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightCoral" id="txtConform" placeholder="Conform Password" runat="server" MaxLength="20" Width="100%"  TextMode="Password"/></li>
    <li class="list-group-item bg-danger"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightCoral" id="txtfName" placeholder="First Name" runat="server" MaxLength="40" Width="100%"  /></li>
	<li class="list-group-item bg-danger"><asp:TextBox class="form-control" ForeColor="WhiteSmoke" BackColor="LightCoral" id="txtlName" placeholder="Last Name" runat="server" MaxLength="40" Width="100%"  /></li>
	<li class="list-group-item bg-danger"><asp:TextBox class="form-control" BackColor="LightCoral" ForeColor="WhiteSmoke" id="txtMobile" placeholder="Mobile Number" runat="server" MaxLength="10" Width="100%"  /></li>	
	<li class="list-group-item bg-danger form-control" BackColor="LightCoral"> 
							<asp:RadioButton Checked="true" runat="server" id="male" ForeColor="WhiteSmoke" GroupName="gender" Text="Male" ></asp:RadioButton>
							<asp:RadioButton runat="server" id="female" ForeColor="WhiteSmoke" GroupName="gender" Text="Female" ></asp:RadioButton>
							<asp:RadioButton  runat="server" id="other" ForeColor="WhiteSmoke" GroupName="gender" Text="Other" ></asp:RadioButton></li>						
	<li class="list-group-item bg-danger"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightCoral" id="txtAddr" placeholder="Address" runat="server" MaxLength="40" Width="100%"  TextMode="MultiLine" Rows="5"/></li>						
						</ul>
  <div class="card-body">

	<table border="0px" width="100%" >
				<tr><td>
                <asp:Button runat="server" class="btn btn-dark border-danger" id="btnSubmit" OnClick="doSignup" Text="Register" Width="50%"/>
										</td>
									<td>
               <a class="btn btn-dark border-danger" style= "width:50%;" href="../../Default.aspx" Width="100%">Cancel</a>        
							</td></tr></table>
                          
						
  </div>
						  </form>
</div>	
					
 <!-- sign up form -->
        </div>

    </div>








<script src="../../resource/jquery/jquery-3.1.1.min.js"></script>
        <script src="../../resource/bootstrap/js/bootstrap.min.js"></script>
        <script src="../../otherResource/validation.js"></script>
</body>
</html>
