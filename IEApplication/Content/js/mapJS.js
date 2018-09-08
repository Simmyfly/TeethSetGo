
    var map;
    function initMap() {
        var addButton = document.getElementById("get_location");
    addButton.onclick = handleSetCenterButtonClicked;
        var location = {lat: -27.469770, lng: 153.025131 };
        map = new google.maps.Map(document.getElementById("map"), {
        zoom: 8,
    center: location,
   });

    var markers = [];
    var contentString = [];
    var infowindow = [];
        $.get("@Url.Action("GetAllLocation","Home")", function (data, status) {
            for (var i = 0; i < data.length; i++) {

        markers[i] = new google.maps.Marker({
            position: { lat: data[i].Lat, lng: data[i].Long },
            map: map
        });
    contentString[i] = '<div id="content">' + '<div id="siteNotice">'
                    + '</div>' + '<h4 id="firstHeading">'+ data[i].clinicName +'</h1>' + '<div id="bodyContent">'
                    + '<p>is a public dental clinic. Please contact <strong>' + data[i].contact + '</strong> for appointments or enquiry.</p></div></div>';
                infowindow[i] = new google.maps.InfoWindow({
        content: contentString[i]
});
var markerValue = markers[i]
                google.maps.event.addListener(markers[i], 'mouseover', (function (markerValue, i) {
                    return function () {
        infowindow[i].open(map, markers[i]);
    }
})(markers[i], i));
                google.maps.event.addListener(markers[i], 'mouseout', (function (markerValue, i) {
                    return function () {
        infowindow[i].close();
    }
})(markers[i], i));

}

})
}

window.onload = initMap;

function getMyLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(displayLocation);
    } else {
        alert("Oops, no geolocation support");
    }
}

function displayLocation(position) {
        showMap(position.coords);
    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;
    var div = document.getElementById("location");
    div.innerHTML = "You are at Latitude: " + latitude + ", Longitude: " + longitude;
}

var yourPos;
function showMap(coords) {
        yourPos = googleLatAndLong;
    var googleLatAndLong = new google.maps.LatLng(coords.latitude, coords.longitude);
    var mapOptions = {
        zoom: 15,
    center: googleLatAndLong,
};
//var mapDiv = document.getElementById("map");
//map = new google.maps.Map(mapDiv, mapOptions);
map.setOptions(mapOptions);
addMarker(googleLatAndLong);
}

var marker;
var markerArray = new Array();

function addMarker(latLong) {
    var markerOptions = {
        position: latLong,
    map: map
};
marker = new google.maps.Marker(markerOptions);

markerArray.push(marker);
}

// this is my setCenter method function
function handleSetCenterButtonClicked(coords) {
        getMyLocation();
    map.setCenter(yourPos);
    map.setZoom(13);
}

