$(document).ready(function () {
    $('#submit').click(function () {
        $.getJSON("../Content/js/hotels.json", function (data) {
            var table = document.getElementById("hotelTable");
            //var old_tbody = table.getElementsByTagName("tbody");
            //console.log(old_tbody);

            //var new_tbody = document.createElement('tbody');
            ////populate_with_new_rows(new_tbody);
            //console.log(old_tbody.parentNode);
            //table.replaceChild(new_tbody, old_tbody);

            for (var i = table.rows.length - 1; i > 0; i--) {
                table.deleteRow(i);
            }

            var search = $('#search-bar').val();
            //console.log(search.length);
            //var regex = new RegExp(search, 'i');
            var output;
            $.each(data, function (key, val) {
                var postcode = val.Postcode.substr(4, 6);
                //console.log(postcode);
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
            }
            });
            $('tbody').html(output);
           
        });
    })

})