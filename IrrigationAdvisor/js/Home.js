$.validator.setDefaults({

    submitHandler: function () {
        alert("Submitted");
    }

});


$(document).ready(function () {


    var MILIMETERS_ERROR = 'La cantidad de milimetros tiene que ser mayor a 0 y menor que 100';
    var MANDATORY_MILMETERS = 'Los milimetros son obligatorios';

    $('#SaveRain').click(function()
    {

        var rainDate = moment($('#rainDate :selected').val(), 'MM/DD/YYYY');
        addRain($('#rain').val(),
                        $('#IrrigationUnit :selected').val(),
                        rainDate);

    });

    $('#SaveIrrigation').click(function () {

        debugger;

        if ($('#irrigationMilimeters').val())
        {
            var milimeters = parseFloat($('#irrigationMilimeters').val());

            if (milimeters > 0 && milimeters <= 100)
            {
                var irrigationDate = moment($('#irrigationDate :selected').val(), 'MM/DD/YYYY');
                $('#irrigationDate').removeClass('.input-red-border');
                location.href = ".#";
                addIrrigation($('#irrigationMilimeters').val(),
                                $('#IrrigationUnitIrrigation :selected').val(),
                                irrigationDate);

                

            }else
            {
                $('#irrigationMilimeters').addClass('input-red-border');
                $('#irrigationMilimetersError').html(MILIMETERS_ERROR);
            }

            
        }
        else
        {
            $('#SaveIrrigation').attr('href', '');
            $('#irrigationMilimeters').addClass('input-red-border');
            $('#irrigationMilimetersError').html(MANDATORY_MILMETERS);
        }

       
    });
   

    var addRain = function (pMilimiters, pIrrigationUnitId, pDate)
    {

        
        var pUrl = './AddRain?pMilimeters=' + pMilimiters +
                '&pIrrigationUnitId=' + pIrrigationUnitId +
                '&pDay=' + pDate.date() +
                '&pMonth=' + (pDate.month() + 1) + 
                '&pYear=' + pDate.year();

        $.ajax({
            type: 'GET',
            url: pUrl,
            success:function()
            {

                location.reload();
                
            },
            error: function(data)
            {
                
                console.log("Error on AddRain");
                $('#myModal').modal('hide');
            }
        });

    }


    var addIrrigation = function (pMilimiters, pIrrigationUnitId, pDate) {


        var pUrl = './AddIrrigation?pMilimeters=' + pMilimiters +
                '&pIrrigationUnitId=' + pIrrigationUnitId +
                '&pDay=' + pDate.date() +
                '&pMonth=' + (pDate.month() + 1) +
                '&pYear=' + pDate.year();

        $.ajax({
            type: 'GET',
            url: pUrl,
            success: function () {

                location.reload();

            },
            error: function (data) {

                console.log("Error on AddIrrigation");
                $('#myModal').modal('hide');
            }
        });

    }

    


});