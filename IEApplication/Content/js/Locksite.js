  
        var password = "team104";
        var x = prompt("Please Enter the password to visit the website:", "");
        if (x.toLowerCase() == password) {
            alert("Come right in \n \n You've entered in the right password");
            //window.location.href='@Url.Action("Index", "Home")';
            
        }
        else {
            alert("You have entered wrong password. Please refresh to try again.");
            window.location = "bad.html";
        }
