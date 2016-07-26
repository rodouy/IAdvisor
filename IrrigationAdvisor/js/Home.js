$.validator.setDefaults({

    submitHandler: function () {
        alert("Submitted");
    }

});


$(document).ready(function () {


    var MILIMETERS_ERROR = 'La cantidad de milimetros tiene que ser mayor a 0 y menor que 100';
    var MANDATORY_MILMETERS = 'Los milimetros son obligatorios';

    $('#rain').keyup(function (event, b) {

        var saveRainBtn = $('#SaveRain');
        
        var currentValue = event.target.value;

        if (currentValue)
            saveRainBtn.attr('disabled', false);
        else
            saveRainBtn.attr('disabled', true);
        

    });

    $('#irrigationMilimeters').keyup(function (event, b) {

        var saveIrrigationBtn = $('#SaveIrrigation');

        var currentValue = event.target.value;

        if (currentValue)
            saveIrrigationBtn.attr('disabled', false);
        else
            saveIrrigationBtn.attr('disabled', true);
        

    });

    $('#SaveRain').click(function()
    {

        if ($('#rain').val())
        {

            var milimeters = parseFloat($('#irrigationMilimeters').val());

            var maxValue = parseInt($('#rain').attr('max'));
            var minValue = parseInt($('#rain').attr('min'));


            $('#rainMilimetersError').html('');
            if (milimeters > minValue && milimeters <= maxValue) {

                var rainDate = moment($('#rainDate :selected').val(), 'MM/DD/YYYY');

                addRain($('#rain').val(),
                                $('#IrrigationUnit :selected').val(),
                                rainDate);
            } else {

                $('#rain').addClass('input-red-border');
                $('#rainMilimetersError').html(MILIMETERS_ERROR);
            }

            
        } else {

            $('#SaveRain').attr('href', '');
            $('#rainMilimetersError').addClass('input-red-border');
            $('#rainMilimetersError').html(MANDATORY_MILMETERS);

        }

        

    });

    $('#SaveIrrigation').click(function () {

        

        if ($('#irrigationMilimeters').val())
        {
            var milimeters = parseFloat($('#irrigationMilimeters').val());

            var maxValue = parseInt($('#irrigationMilimeters').attr('max'));
            var minValue = parseInt($('#irrigationMilimeters').attr('min'));

            $('#irrigationMilimetersError').html('');
            if (milimeters > minValue && milimeters <= maxValue)
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