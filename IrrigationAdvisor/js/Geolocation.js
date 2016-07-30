
function geoFindMe() {
    var output = document.getElementById("out");

    if (!navigator.geolocation) {
        output.innerHTML = "<p>Geolocation no es soportado por su browser</p>";
        return;
    }

    function success(position) {
        var latitude = position.coords.latitude;
        var longitude = position.coords.longitude;

        output.innerHTML = '<p>Latitud es ' + latitude + '° <br>Longitud es ' + longitude + '°</p>';

        var img = new Image();
        img.src = "http://maps.googleapis.com/maps/api/staticmap?center=" + latitude + "," + longitude + "&zoom=13&size=300x300&sensor=false";

        output.appendChild(img);
    };

    function error() {
        output.innerHTML = "No se puede obtener su localizacion.";
    };

    output.innerHTML = "<p>Localizando…</p>";

    navigator.geolocation.getCurrentPosition(success, error);
}
