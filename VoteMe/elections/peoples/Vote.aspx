<%@ Page Language="C#" Inherits="VoteMe.elections.peoples.Vote" EnableEventValidation="false" %>
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
            <div class="col-md-12 border-info" align="center">

           

            <div class="card border-info bg-dark" style="width: 40rem;align:'center';" >
                     <form id="signupform" runat="server" align="center">

						<img class="card-img-top" src="../../images/signup.jpg" alt="Card image cap" height="320px">

						<div class="card-body">

							<h4 class="card-title border-info">Vote Please </h4>

							<p class="card-text">Please vote with the correct Choice</p><p>

							<asp:label runat="server" id="msg" Text="You will redirect to VoteMe Home Page after successfully vote"  ForeColor="WhiteSmoke" /></p>

						</div>

						<ul class="list-group list-group-flush">
   

							<li class="list-group-item bg-info form-control" BackColor="LightCoral"> 
                                <asp:Label runat="server" id="candidate1" ForeColor="WhiteSmoke" Text="" Enabled="false" Visible="false" />
								<asp:RadioButton  Enabled="false" Visible="false"  Checked="true" runat="server" id="party1" ForeColor="WhiteSmoke" GroupName="gender" Text="" ></asp:RadioButton>
                                <asp:Label runat="server" id="name1" ForeColor="WhiteSmoke" Text="" Enabled="false" Visible="false" />
							</li>
                                <li class="list-group-item bg-info form-control" BackColor="LightCoral"> 
                                <asp:Label runat="server" id="candidate2" ForeColor="WhiteSmoke" Text="" Enabled="false" Visible="false" />
							<asp:RadioButton  Enabled="false" Visible="false" runat="server" id="party2" ForeColor="WhiteSmoke" GroupName="gender" Text="" ></asp:RadioButton>
                            <asp:Label Enabled="false" Visible="false"  runat="server" id="name2" ForeColor="WhiteSmoke" Text=""/>
							</li>
                                <li class="list-group-item bg-info form-control" BackColor="LightCoral"> 
                               <asp:Label runat="server" id="candidate3" ForeColor="WhiteSmoke" Text="" Enabled="false" Visible="false" />
							<asp:RadioButton  Enabled="false" Visible="false"  runat="server" id="party3" ForeColor="WhiteSmoke" GroupName="gender" Text="" ></asp:RadioButton>
							 <asp:Label  Enabled="false" Visible="false" runat="server" id="name3" ForeColor="WhiteSmoke" Text=""/></li> 
                                <li class="list-group-item bg-info form-control" BackColor="LightCoral"> 
                                <asp:Label runat="server" id="candidate4" ForeColor="WhiteSmoke" Text="" Enabled="false" Visible="false" />
								<asp:RadioButton Enabled="false" Visible="false"  runat="server" id="party4" ForeColor="WhiteSmoke" GroupName="gender" Text="" ></asp:RadioButton>
							<asp:Label  Enabled="false" Visible="false" runat="server" id="name4" ForeColor="WhiteSmoke" Text=""/></li>
                                <li class="list-group-item bg-info form-control" BackColor="LightCoral"> 
                                <asp:Label runat="server" id="candidate5" ForeColor="WhiteSmoke" Text="" Enabled="false" Visible="false" />
							<asp:RadioButton Enabled="false" Visible="false"   runat="server" id="party5" ForeColor="WhiteSmoke" GroupName="gender" Text="" ></asp:RadioButton>
							<asp:Label Enabled="false" Visible="false"  runat="server" id="name5" ForeColor="WhiteSmoke" Text=""/></li>                     

							                     
						</ul>

						<div class="card-body">


							<table border="0px" width="100%" >

								<tr><td>

										<asp:Button  Enabled="false" Visible="false"  runat="server" class="btn btn-dark border-info" id="btnSubmit" OnClick="voteMe" Text="Submit Your Vote" Width="50%"/>

									</td>
                                    <td>

										<a class="btn btn-dark border-info" style= "width:50%;" href="home.aspx" Width="100%">Cancel</a>        

							</td></tr></table>
                          
                        

						</div>

					</form>


				</div>  








				


			</div>


		</div>

        <script src="../../resource/jquery/jquery-3.1.1.min.js"></script>
        <script src="../../resource/bootstrap/js/bootstrap.min.js"></script>
        <script src="../../otherResource/validation.js"></script>
	</body>
</html>