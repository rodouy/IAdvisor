$(document).ready(function () {



    

    $('#SaveRain').click(function()
    {
        var rainDate = moment($('#rainDate :selected').val(),'dd/mm/yyyy');

        addIrrigation(  $('#rain').val(),
                        $('#IrrigationUnit :selected').val(),
                        rainDate);

    });
   

    var addIrrigation = function (pMilimiters, pIrrigationUnitId, pDate)
    {

        
        var pUrl = './AddRain?pMilimeters=' + pMilimiters +
                '&pIrrigationUnitId=' + pIrrigationUnitId +
                '&pDay=' + pDate.date() +
                '&pMonth=' + pDate.month() +
                '&pYear=' + pDate.year();

        $.ajax({
            type: 'GET',
            url: pUrl,
            success:function()
            {
                $('#myModal').modal('hide');
            },
            error: function(data)
            {
                
                console.log("Error on AddRain");
                $('#myModal').modal('hide');
            }
        });

    }


});