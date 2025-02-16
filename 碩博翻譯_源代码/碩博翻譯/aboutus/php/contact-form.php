<?php
if($_POST)
{

    $name = $_POST['tp-username'];
    $to_email       = "aligamaan@gmail.com"; //Recipient email, Replace with own email here
    $subject        = " New Message Received from  ".$name; // the title of message 
    $user_email          = $_POST['tp-email'];  // user email 
    $phone_number   = $_POST['tp-phone']; // user phone number 
    $company   = $_POST['tp-company']; // user phone number 
    $message   = $_POST['tp-message'];  // message 
   
   $message_body;
   
    //additional php validation
    if(!empty($to_email) && !empty($user_email) && !empty($message)){ // check If feild not empty  
        // prepare email body text
$message_body .= "Name: "; // you can chage the text .
$message_body .= $name;
$message_body .= "\n";
$message_body .="Phone Number :"; // you can chage the text .
$message_body .=$phone_number;
$message_body .="\n";
$message_body .="Company :"; // you can chage the text .
$message_body .=$company;
$message_body .="\n";
$message_body .= "Email: "; // you can chage the text .
$message_body .= $user_email;
$message_body .= "\n";
 
$message_body .= "Message: "; // you can chage the text .
$message_body .= $message;
$message_body .= "\n";
      
        
 // Send Mail
   $sendmessage = mail($to_email,$subject, $message_body, "From:".$user_email);
        if(!$sendmessage){
            
            echo 'Could not send mail! Please try agaiin .';
        } 
        else{
              echo "Hi ".$name." Thank you for your email ";
          }
    }
    else{
          echo "You Must fill all required feild .";
    }
}


?>

