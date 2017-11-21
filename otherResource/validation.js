function validate() {

	if (document.signUp.name.value.trim() == "") {
		document.signUp.name.value="";
		document.signUp.name.placeholder = "Please Enter your name  !";
		document.signUp.name.focus();
		return false;
	}

	if (document.signUp.email.value.trim() == "") {
		document.signUp.email.value="";
		document.signUp.email.placeholder = "Please enter your email or username !";
		document.signUp.email.focus();
		return false;
	}

	if (document.signUp.password.value.trim() == "") {
		document.signUp.password.value="";
		document.signUp.password.placeholder = "Please enter a new password !";
		document.signUp.password.focus();
		return false;
	}

	if (document.signUp.password1.value.trim() == "") {
		document.signUp.password1.value="";
		document.signUp.password1.placeholder = "Please conform password !";
		document.signUp.password1.focus();
		return false;
	}
	if (document.signUp.password1.value.trim() != document.signUp.password.value.trim()) {
		document.signUp.password1.value = "";
		document.signUp.password.value = "";
		document.signUp.password1.placeholder = "Conform Password and Password doesn't Match !";
		document.signUp.password.placeholder = "Conform Password and Password doesn't Match !";
		document.signUp.password.focus();
		return false;
	}

	return (true);
}

function validateSign() {

	if (document.signIn.username.value.trim() == "") {
		document.signIn.username.value="";
		document.signIn.username.placeholder = "Email or Username ! ";
		document.signIn.username.focus();
		return false;
	}

	if (document.signIn.pass.value.trim() == "") {
		document.signIn.pass.value="";
		document.signIn.pass.placeholder = "Password ! ";
		document.signIn.pass.focus();
		return false;
	}
	

	return (true);
}

function validateEditPass() {
	if (document.editPass.password2.value.trim() == "") {
		document.editPass.password2.value="";
		document.editPass.password2.placeholder = "Current Password ! ";
		document.editPass.password2.focus();
		return false;
	}

	if (document.editPass.password.value.trim() == "") {
		document.editPass.password.value="";
		document.editPass.password.placeholder = "Password ! ";
		document.editPass.password.focus();
		return false;
	}
	if (document.editPass.password1.value.trim() == "") {
		document.editPass.password1.value="";
		document.editPass.password1.placeholder = "Conform Password ! ";
		document.editPass.password1.focus();
		return false;
	}
	if (document.editPass.password2.value.trim() == document.editPass.password.value.trim()) {
		document.editPass.password2.value = "";
		document.editPass.password.value = "";
		document.editPass.password1.value = "";
		document.editPass.password1.placeholder = "Conform Password";
		document.editPass.password2.placeholder = "Old and New Password Same, Try Diffrent !";
		document.editPass.password.placeholder = "Old and New Password Same, Try Diffrent !";
		document.editPass.password2.focus();
		return false;
	}
	if (document.editPass.password1.value.trim() != document.editPass.password.value.trim()) {
		document.editPass.password1.value = "";
		document.editPass.password.value = "";
		document.editPass.password1.placeholder = "Conform Password and Password doesn't Match !";
		document.editPass.password.placeholder = "Conform Password and Password doesn't Match !";
		document.editPass.password.focus();
		return false;
	}

	return (true);
}

function validateEdit() {

	if (document.edit.name.value.trim() == "") {
		document.edit.name.value="";
		document.edit.name.placeholder = "Username or email ! ";
		document.edit.name.focus();
		return false;
	}
	if (document.edit.city.value.trim() == "") {
		document.edit.city.value="";
		document.edit.city.placeholder = "City ! ";
		document.edit.city.focus();
		return false;
	}
	if (document.edit.password.value.trim() == "") {
		document.edit.password.value="";
		document.edit.password.placeholder = "Password ! ";
		document.edit.password.focus();
		return false;
	}


	return (true);
}
function validateQry() {

	if (document.qry.qryArea.value.trim() == "") {
		document.qry.qryArea.value="";
		document.qry.qryArea.placeholder = "Please write your querry !";
		document.qry.qryArea.focus();
		return false;
	}

	return (true);
}
function validateCode() {

	if (document.cd.cdArea.value.trim() == "") {
		alert("Please write your Code ! and don't delete default class");
		document.cd.cdArea.value = "public class Main{\n\tpublic static void main(String[] args){\n\t\t//call your class or Code here\n\n\t}\n}\nwrite your class or Code here ";
		document.cd.cdArea.focus();
		return false;
	}

	return (true);
}
function validateStatus() {

	if (document.statusForm.status.value.trim() == "") {
		document.statusForm.status.value="";
		document.statusForm.status.placeholder = "Share your knowledge !";
		document.statusForm.status.focus();
		return false;
	}

	return (true);
}
