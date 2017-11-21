# VoteMe
The project “VoteMe (Online Voting System)“ aims at making the voting process easy in cooperative societies. 
Presently voting is performed using ballot paper and the counting is done manually, hence it consumes a lot of time. There can be possibility of invalid votes. All these make election a tedious task. 
In our proposed system voting and counting is done with the help of computer. It saves time, avoid error in counting and there will be no invalid votes. It makes the election process easy.
This user the Aadhar Number and registred mobile number with aadhar for user login into the system for the candidates<br/>
Core Languege = C#<br/>
Database = MySql<br/>
CSS = Bootstrap<br/>
Scripting = aps.Net<br/>


Database Description
	Database name : votedb
	Username : voteme
Database Tables :
• Candidates
• Peoples
VoteMe (Online Voting System)
Fields
Datatype
Constraints
Extra
EventID
INT(11)
Reference
-
AadharCandidate
VARCHAR(13)
-
-
Name
VARCHAR(50)
-
-
Party
VARCHAR(13)
-
-
Fields
Datatype
Constraints
Extra
Aadhar
VARCHAR(13)
Primary KEY
-
Mobile
VARCHAR(13)
-
-
FirstName
VARCHAR(50)
-
-
LastName
VARCHAR(50)
-
-
Gender
VARCHAR(50)
-
-
Locality
VARCHAR(50)
-
-
City
VARCHAR(50)
-
-
State
VARCHAR(50)
-
-
Country
VARCHAR(50)
-
-
• Voting
• Voters
Fields
Datatype
Constraints
Extra
EventID
INT(11)
Reference
-
Aadhar
VARCHAR(13)
Reference
-
AadharCandidate
VARCHAR(13)
Reference
-
Fields
Datatype
Constraints
Extra
EventID
INT(11)
Reference
-
Aadhar
VARCHAR(13)
-
-
 17
• Events
VoteMe (Online Voting System)
Fields
Datatype
Constraints
Extra
EventID
INT(11)
Primary KEY
Auto Increment
EventName
VARCHAR(50)
-
-
EventDate
DATE
-
-
Country
VARCHAR(50)
-
-
Location
VARCHAR(50)
-
-
State
VARCHAR(50)
-
-
City
VARCHAR(50)
-
-
Username
VARCHAR(50)
Reference
-
• UserElection
Fields
Datatype
Constraints
Extra
Username
VARCHAR(40)
Primary KEY
-
Password
VARCHAR(50)
-
-
Mobile
VARCHAR(12)
-
-
FirstName
VARCHAR(50)
-
-
LastName
VARCHAR(50)
-
-
Gender
VARCHAR(50)
-
-
Addr
VARCHAR(50)
-
-
