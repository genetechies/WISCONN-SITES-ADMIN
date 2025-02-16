var CheResult = true;

function doSubmit(){
	
	CheResult = true;
	firstErrorControl = "";
	
	if(subjectCheck() == false)
		CheResult = false;

	if(contentCheck() == false)
		CheResult = false;
		
	if(companyCheck() == false)
		CheResult = false;
		
	if( nameCheck() == false)
		CheResult = false;
		
	if( emailCheck() == false)
		CheResult = false;	
		
	if( countryCheck() == false)
		CheResult = false;	
		
	if( captchaCheck() == false)
		CheResult = false;		
	SetMsgFocus();
	
	if(CheResult){
		GE('btSubmit').disabled = true;
		document.theForm.submit();
	}
	return CheResult;
}

function subjectCheck(){
	CtoH('subject');
	if( isEmpty(GE('subject').value) == true ){
		SetMsg("error","subject","block","Please enter your subject");
		return false;
	}else{
		SetMsg("success","subject","none","");
	}
}

function contentCheck(){
	CtoH('content');
	if( isEmpty( GE('content').value) == true ){
		SetMsg("error","content","block","Please enter your message");
		return false;
	}else{
		SetMsg("success","content","none","");
	}
}

function companyCheck(){
	CtoH('company');
	if(isEmpty(GE('company').value) == true ){
		SetMsg("error","company","block","Please enter company name");
		return false;
	}else{
		SetMsg("success","company","none","");
	}
}

function nameCheck(){
	CtoH('name');
	if( isEmpty( GE('name').value) == true ){
		SetMsg("error","name","block","Please enter name");
		return false;
	}else{
		SetMsg("success","name","none","");
	}
}

function emailCheck(){
	CtoH('email');
	if(isEmpty(GE('email').value) == true ){
		SetMsg("error","email","block","The Email is required");
		return false;
	}else if(isEmail(GE('email').value) == false ){
		SetMsg("error","email","block","Please enter a correct Email");
		return false;
	}else{
		SetMsg("success","email","none","");
	}
}

function countryCheck(){
	CtoH('country');
	if(isEmpty(GE('country').value) == true ){
		SetMsg("error","country","block","The country is required.");
		return false;
	}else{
		SetMsg("success","country","none","");
	}
}

function captchaCheck(){
	CtoH('captcha');
	if( isEmpty( GE('captcha').value) == true ){
		SetMsg("error","captcha","block","Verfication Code must be provided");
		return false;
	}else{
		SetMsg("success","captcha","none","");
	}
}
