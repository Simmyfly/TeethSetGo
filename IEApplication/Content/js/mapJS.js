function initMap() {
    var location = { lat: -27.998940, lng: 153.33886 };
    map = new google.maps.Map(document.getElementById("map"), {
        zoom: 12,
        center: location,

    });
    var addButton = document.getElementById("get_location");
    addButton.onclick = handleSetCenterButtonClicked;

    $.get("@Url.Action("GetAlllocation","Home")", function (data, status) {

    })
}

var map;
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
