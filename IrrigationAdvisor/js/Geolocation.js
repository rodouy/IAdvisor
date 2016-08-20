//debugger;

var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = decodeURIComponent(window.location.search.substring(1)),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return sParameterName[1] === undefined ? true : sParameterName[1];
        }
    }
};

var paramLatitude = getUrlParameter('latitude');


function geoFindMe() {
    var message = $('#geolocation-message');
    var text = $('#geolocation-message-text');
    var output = $('#initial-weather');
    
    if (!navigator.geolocation) {
        output.hide()
        text.html('Geolocalización no es soportado por su navegador. <br/> Esto impide mostrar el clima en donde está ubicado.')
        
        return;
    }
    

    function success(position) {
        message.hide();
        var latitude = position.coords.latitude;
        var longitude = position.coords.longitude;
        location.href = "./?latitude=" + latitude + "&longitude=" + longitude;
    };

    function error(position) {
        output.hide();
        switch (position.code) {
            case position.PERMISSION_DENIED:
                text.html('No se ha permitido el acceso a la posición del usuario. <br/> Debe habilitar la geolocalización para poder mostrar el clima en su región.')
                break;
            case position.POSITION_UNAVAILABLE:
                text.html('No se ha podido acceder a la información de su posición.')
                break;
            case position.TIMEOUT:
                text.html('El servicio ha tardado demasiado tiempo en responder. Pruebe más tarde.')
                break;
            default:
                text.html('Error desconocido. Comunicarse con el administrador del sitio.')
        }
    };

    text.html('Localizando …');

    navigator.geolocation.getCurrentPosition(success, error);
};

if (!paramLatitude)
{
    geoFindMe();
}