$(document).ready(function () {

    $('#SaveRain').click(function()
    {

        debugger;
        var rainDate = moment($('#rainDate :selected').val());

        addIrrigation(  $('#rain').val(),
                        $('#IrrigationUnit :selected').val(),
                        rainDate);

        

    });
   

    var addIrrigation = function (pMilimiters, pIrrigationUnitId, pDate)
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


});