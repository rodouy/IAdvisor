$(document).ready(function () {




    $('#SaveRain').click(function()
    {

        
        var rainDate = moment($('#rainDate :selected').val());
        addRain($('#rain').val(),
                        $('#IrrigationUnit :selected').val(),
                        rainDate);

        

    });

    $('#SaveIrrigation').click(function () {

        var irrigationDate = moment($('#irrigationDate :selected').val());

        addIrrigation($('#irrigationMilimeters').val(),
                        $('#IrrigationUnitIrrigation :selected').val(),
                        irrigationDate);
    });
   

    var addRain = function (pMilimiters, pIrrigationUnitId, pDate)
    {

        
        var pUrl = './AddRain?pMilimeters=' + pMilimiters +
                '&pIrrigationUnitId=' + pIrrigationUnitId +
                '&pDay=' + pDate.day() +
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
                '&pDay=' + pDate.day() +
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