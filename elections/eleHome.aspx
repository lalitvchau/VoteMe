<%@ Page Language="C#" Inherits="VoteMe.elections.eleHome" EnableEventValidation="false" %>
<!DOCTYPE html>
<html>
<head runat="server">
        <link href="../../resource/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <title>VoteMe !</title>
        <meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">

</head>
<body style="margin:5px;padding:12px;color:white;"  align="center"  class="bg-dark card">



       
   <div class="row" >
			<div class="col-md-4 border-warning" align="center">
                   <div class="card text-white bg-dark border-info mb-3" style="max-width: 40rem;">
                              <div class="card-header bg-info">Election Officer Details</div>
                              <div class="card-body" align="left">
                               
                                <ul class="list-group list-group-flush">
                                     <li class="list-group-item bg-dark border-info">
                                         <asp:label runat="server" Text="" id="nameUserName"/>
                                     </li>
                                     <li class="list-group-item bg-dark border-info">
                                         <asp:label runat="server" Text="" id="gender"/>
                                     </li>
                                     <li class="list-group-item bg-dark border-info">
                                         <asp:label runat="server" Text="" id="addr"/>
                                     </li>
                                     <li class="list-group-item bg-dark border-info">
                                         <asp:label runat="server" Text="" id="mobile"/>
                                     </li>
                                    
                                     <li class="list-group-item bg-dark border-info">
                                         <form id="ElectionUserForm" runat="server">
                                         <asp:Button  class="btn btn-dark border-info" OnClick="doSignOut" runat="server" Text="Sign Out" id="sout"/>
                                         </form>
                                    </li>
                                 </ul>
                                 
                               </div>
                         </div>

                <div class="card border-danger" style="max-width: 40rem;">
                    <img class="card-img-top" src="../../images/signup.jpg"  style="max-width: 40rem; height:200px;" alt="Card image cap">
                    <div class="card-body bg-danger border-danger">
                             <p class="card-text" align="justify">The block officials taking good dishes and tiffin packets
And you on the rear side of the truck or availing of somehow
Going to the nondescript village primary school through the muddy way
To take the poll.</p>
                     </div>
               </div>

                
          </div>

			
          <div class="col-md-8 border-warning">

				<div class="card text-white bg-warning mb-3" style="max-width: 60rem;">
                    <div class="card-header">Register A new Voting Event ..</div>
                    <div class="card-body bg-dark">
                         <form id="EventFrom" runat="server">
							   <asp:Button id="newEvent" class="btn btn-dark border-warning" OnClick="AddNewEvent" Text="Register New Voting Event" runat="server" />
							  <!-- <asp:Button id="editEvent" class="btn btn-dark border-warning" OnClick="EditNewEvent" Text="Delete Voting Event" runat="server" />
                              -->
							</form>
                    </div>
                </div>
				<!-- Ongoing Events-->
                <div class="card text-white bg-secondary border-secondary mb-3" style="max-width: 60rem; align:'center';">
                    <div class="card-header ">Events History</div>
                    <div class="card-body bg-dark border-light">
                         <h4 class="card-title">These all are  events with live result</h4>
                         <p class="card-text " align="center">
                            <% displayCurrentEvents(); %>
                        </p>
                    </div>
                </div>
               	

          </div>

   </div>








<script src="../../resource/jquery/jquery-3.1.1.min.js"></script>
        <script src="../../resource/bootstrap/js/bootstrap.min.js"></script>
        <script src="../../otherResource/validation.js"></script>
</body>
</html>
