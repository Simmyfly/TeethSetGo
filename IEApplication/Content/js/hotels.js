$(document).ready(function () {
    $('#submit').click(function () {
        $.getJSON("../Content/js/hotels.json", function (data) {
            var table = document.getElementById("hotelTable");

            for (var i = table.rows.length - 1; i > 0; i--) {
                table.deleteRow(i);
            }

            var search = $('#search-bar').val();
            //console.log(search.length);
            //var regex = new RegExp(search, 'i');
            var output;
            var count = 0;
            $.each(data, function (key, val) {
                var postcode = val.Postcode.substr(4, 6);
                //console.log(postcode);
                //!!improve infinite equal
                if ((val.Clinic1 == search.toUpperCase()) || (val.Clinic2 == search.toUpperCase()) || (postcode == search)) {

                    if (val.Address != "") {
                        output += "<tr>";
                        output += "<td id='" + key + "'>" + val.Hotel + "</td>";
                        output += "<td id='" + key + "'>" + val.Address + "<br/>" + val.Postcode + "</td>";
                        output += "<td id='" + key + "'>" + val.Price + "</td>";
                        //output += "<td id='" + key + "'>" + val.Postcode + "</td>";
                        output += "<td id='" + key + "'>" + val.Clinic1 + "<br/>" + val.Clinic2 + "</td>";
                        output += "</tr>";
                    } else {
                        output += "<tr>";
                        output += "<td id='" + key + "'><p style='font-size:21px;color:grey'>" + val.Hotel + " the clinic or postcode that you are searching.</p></td>";
                        //output += "<td id='" + key + "'>" + val.Address + "</td>";
                        //output += "<td id='" + key + "'>" + val.Price + "</td>";
                        //output += "<td id='" + key + "'>" + "</td>";
                        //output += "<td id='" + key + "'>" + "</td>";
                        output += "</tr>";
                    }
                    count += 1;
                } 
                
            });
            //console.log(typeof(count));
            if (parseInt(count) == parseInt(0)) {
                output += "<tr>";
                output += "<td><p style='font-size:21px;color:grey'> No clinics or hotels found matches your search term.</p></td>";
                output += "</tr>";
                //console.log(output);
            }
            $('tbody').html(output);
           
        });
    })

})