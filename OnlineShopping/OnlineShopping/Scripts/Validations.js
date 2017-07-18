$(document).ready(function () {
    $("#Submit").click(function () {
        var firstname = $("#firstname").val();
        var lastname = $("#lastname").val();
        var middlename = $("#middlename").val();
        var emailid = $("#emailid").val();
        var password = $("#password").val();
        var gender = $("#gender").val();
        var mobilenumber = $("#mobilenumber").val();
        var country = $("#country").val();
        var state = $("#state").val();
        var city = $("#city").val();
        var address1 = $("#address1").val();
        var address2 = $("#address2").val();
        if(firstname=="")
        {
            $("#firstname").focus();
            $("#txterror1").text("enter the firstname");
            return false;
        }
      else if(lastname=="")
        {
            $("#lastname").focus();
            $("#txterror1").empty();
            $("#txterror2").text("enter the lastname");
            return false;
      }
      else if(middlename=="")
      {
          $("#middlename").focus();
          $("#txterror2").empty();
          $("#txterror3").text("Enter the middlename");
          return false;
      }
      else if(emailid=="")
      {
          $("#emailid").focus();
          $("#txterror3").empty();
          $("#txterror4").text("Enter the Emailid ");
          return false;
      }
      else if(password=="")
      {
          $("#password").focus();
          $("#txterror4").empty();
          $("#txterror5").text("enter the password");
          return false;
      }
      else if (gender=="")
      {
          $("#gender").focus();
          $("#txterror5").empty();
          $("#txterror6").text("Enter the gender");
          return false;
      }
      else if(mobilenumber=="")
      {
          $("#mobilenumber").focus();
          $("#txterror6").empty();
          $("#txterror7").text("enter mobilenumber");
          return false;
      }
      else if (country=="")
      {
          $("#country").focus();
          $("#txterror7").empty();
          $("#txterror8").text("select country");
          return false;
      }
      else if(state=="")
      {
          $("#state").focus();
          $("#txterror8").empty();
          $("#txterror9").text("select state");

         return false;
      }
      else if(city=="")
      {
          $("#city").focus();
          $("#txterror9").empty();
          $("#txterror10").text("select city");
          return false;
      }
      else if(address1=="")
      {
          $("#address1").focus();
          $("#txterror10").empty();
          $("#txterror11").text("enter address1");
          return false;
      }
      else if (address2=="")
      {
          $("#address2").focus();
          $("#txterror11").empty();
          $("#txterror12").text("enter address2");
          return false;
      }
    })
})