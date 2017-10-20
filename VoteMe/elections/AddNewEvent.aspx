<%@ Page Language="C#" Inherits="VoteMe.elections.AddNewEvent" EnableEventValidation="false"%>

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
  <div class="col-md-12 border-success" align="center">

  <!-- sign up form -->
 
        <div class="card border-success bg-dark" style="width: 40rem;" >
                     <form id="signupform" runat="server" align="center">
  <img class="card-img-top" src="../../images/signup.jpg" alt="Card image cap" height="320px">
  <div class="card-body">
    <h4 class="card-title">New Event Registration </h4>
    <p class="card-text">Please register with the correct informations
                            </p><p><asp:label runat="server" id="msg"  ForeColor="WhiteSmoke" /></p>
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke"  class="form-control" BackColor="LightGreen" id="txtEventName" placeholder="Event Name" Width="100%" MaxLength="20" runat="server"/>
                                  </li>
							
    <li class="list-group-item bg-success"><asp:Calendar  ForeColor="DarkGreen" class="form-control" BackColor="LightGreen" id="txtEventDate" ShowDayHeader="true" runat="server" MaxLength="20" Width="100%" ToolTip="Select The Vooting Event Date"/></li>
     <li class="list-group-item bg-dark">Select Country</li>
    <li class="list-group-item bg-success"><asp:DropDownList  ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtCountry"  runat="server"  Width="100%" >
					</asp:DropDownList></li>
							
    <li class="list-group-item bg-dark">Select State</li>
    <li class="list-group-item bg-success"><asp:DropDownList  class="form-control"  ForeColor="WhiteSmoke" BackColor="LightGreen" id="txtState"  runat="server"  Width="100%"  /></li>
    <li class="list-group-item bg-dark">Select City</li>
	<li class="list-group-item bg-success"><asp:DropDownList   class="form-control"   ForeColor="WhiteSmoke" BackColor="LightGreen" id="txtCity" runat="server" Width="100%"  /></li>
    <li class="list-group-item bg-dark">Select Locality</li>
	<li class="list-group-item bg-success"><asp:DropDownList class="form-control"  BackColor="LightGreen" ForeColor="WhiteSmoke" id="txtLocation" runat="server"  Width="100%"  /></li>  
    <li class="list-group-item bg-dark">First Candidate Details</li>
	<li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcName1" placeholder="Candidate Name" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcAadhar1" placeholder="Candidate Aadhar" Width="100%" MaxLength="12" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcParty1" placeholder="Candidate Party" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-dark">Second Candidate Details</li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcName2" placeholder="Candidate Name" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcAadhar2" placeholder="Candidate Aadhar" Width="100%" MaxLength="12" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcParty2" placeholder="Candidate Party" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-dark">Third Candidate Details</li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcName3" placeholder="Candidate Name" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcAadhar3" placeholder="Candidate Aadhar" Width="100%" MaxLength="12" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcParty3" placeholder="Candidate Party" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-dark">Fourth Candidate Details</li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcName4" placeholder="Candidate Name" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcAadhar4" placeholder="Candidate Aadhar" Width="100%" MaxLength="12" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcParty4" placeholder="Candidate Party" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-dark">Fifth Candidate Details</li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcName5" placeholder="Candidate Name" Width="100%" MaxLength="20" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcAadhar5" placeholder="Candidate Aadhar" Width="100%" MaxLength="12" runat="server"/></li>
    <li class="list-group-item bg-success"><asp:TextBox ForeColor="WhiteSmoke" class="form-control" BackColor="LightGreen" id="txtcParty5" placeholder="Candidate Party" Width="100%" MaxLength="20" runat="server"/></li>
    
						</ul>
  <div class="card-body">

    <table border="0px" width="100%" >
                <tr><td>
                <asp:Button runat="server" class="btn btn-dark border-success" id="btnSubmit" OnClick="addEvent" Text="Register" Width="50%"/>
                                        </td>
                                    <td>
               <a class="btn btn-dark border-success" style= "width:50%;" href="eleHome.aspx" Width="100%">Cancel</a>        
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
