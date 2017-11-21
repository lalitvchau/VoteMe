<%@ Page Language="C#" Inherits="VoteMe.elections.peoples.home" EnableEventValidation="false" %>
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
            <div class="col-md-4 border-danger" align="center">
                   <div class="card text-white bg-dark border-danger mb-3" style="max-width: 40rem;">
                              <div class="card-header bg-danger">Aadhar user Details</div>
                              <div class="card-body" align="left">
                               
                                <ul class="list-group list-group-flush">
                                     <li class="list-group-item bg-dark border-danger">
                                         <asp:label runat="server" Text="" id="nameUserName"/>
                                     </li>
                                     <li class="list-group-item bg-dark border-danger">
                                         <asp:label runat="server" Text="" id="gender"/>
                                     </li>
                                     <li class="list-group-item bg-dark border-danger">
                                         <asp:label runat="server" Text="" id="addr"/>
                                     </li>
                                     <li class="list-group-item bg-dark border-danger">
                                         <asp:label runat="server" Text="" id="mobile"/>
                                     </li>
                                    
                                     <li class="list-group-item bg-dark border-danger">
                                         <form id="UserForm" runat="server">
                                         <asp:Button  class="btn btn-dark border-danger" OnClick="doSignOut" runat="server" Text="Sign Out" id="sout"/>
                                         </form>
                                    </li>
                                 </ul>
                                 
                               </div>
                         </div>

                <div class="card border-success" style="max-width: 40rem;">
                    <img class="card-img-top" src="../../images/signup.jpg"  style="max-width: 40rem; height:200px;" alt="Card image cap">
                    <div class="card-body bg-success border-success">
                             <p class="card-text" align="justify">The block officials taking good dishes and tiffin packets
And you on the rear side of the truck or availing of somehow
Going to the nondescript village primary school through the muddy way
To take the poll.</p>
                     </div>
               </div>

                
          </div>

            
          <div class="col-md-8 border-warning">


          <div class="card bg-light border-light mb-3" style="max-width: 60rem;">

					<div class="card-header" style="color:black;">Live Voting Events</div>

					<div class="card-body bg-dark">

						<h4 class="card-title">You can vote for these events currently</h4>

						<p class="card-text"><% displayCurrentEvents();%></p>

					</div>

				</div>

				<div class="card bg-warning border-warning mb-3" style="max-width: 60rem;">

                    <div class="card-header" style="color:black;">Events List</div>

                    <div class="card-body bg-dark">

                        <h4 class="card-title">These all are completed and upcoming event</h4>

                        <p class="card-text"><% displayEvents(); %></p>

                    </div>

                </div>
				






			</div>


            </div>





<script src="../../resource/jquery/jquery-3.1.1.min.js"></script>
        <script src="../../resource/bootstrap/js/bootstrap.min.js"></script>
        <script src="../../otherResource/validation.js"></script>
</body>
</html>
