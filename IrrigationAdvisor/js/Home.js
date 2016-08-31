﻿
$(document).ready(function () {

    var MILIMETERS_ERROR = 'La cantidad de milimetros tiene que ser mayor a 0 y menor que 100';
    var MANDATORY_MILMETERS = 'Los milimetros son obligatorios';

    var saveRainBtn = $('#SaveRain');
    var saveIrrigationBtn = $('#SaveIrrigation');
    var savePhenoBtn = $('#savePhenoBtn');
    var irrigationMilimeters = $('#irrigationMilimeters');
    var rainMilimeters = $('#rain');
    var dateOfReferenceBtn = $('#dateOfReferenceBtn');
    var cropIrriWeatherPheno = $('#CropIrriWeatherPheno');
    var specieIdInput = $('#specieId');
    var phenoDate = $('#phenoDate');
    var stagePheno = $('#StagePheno'); 
    var dateOfReferenceBtn2 = $('#dateOfReferenceBtn2');
    var txtDateOfReference = $('#txtDateOfReference');
    var maxDateOfReference = $('#maxDateOfReference');
    var minDateOfReference = $('#minDateOfReference');
    var addIrrigationModal = $('#addIrrigationModal');
    var addPhenoModal = $('#addPhenoModal');
    var addRainModal = $('#addRainModal');
    var modalIrrigation = $('#modal');
    var modalRain = $('#modal-lluvia');
    var modalPheno = $('#modal-fenologia');
    var cancelIrrigation = $('#CancelIrrigation');
    var cancelRain = $('#CancelRain');
    var cancelPheno = $('#CancelPheno');
    var lstFarms = $('#lstFarms');

    

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

    $('#loading').modal({
        keyboard: false,
        backdrop: 'static'
    })



    var showLoading = function () {
        $('#loading').modal('show');

    }

    var hideLoading = function () {
        $('#loading').modal('hide');
    }

    var init = function () {

        var farmParam = getUrlParameter('farm');

        if (farmParam) {
            lstFarms.val(farmParam);
        }

        addIrrigationModal.hide();
        addRainModal.hide();
        addPhenoModal.hide();

        var initModal = { backdrop: false, show: false };

        modalIrrigation.modal(initModal);
        modalRain.modal(initModal);
        modalPheno.modal(initModal);

        hideLoading();
    };

    init();


    $.getScript("https://code.jquery.com/ui/1.12.0/jquery-ui.js", function () {
        var addIrrigationModal = $('#addIrrigationModal');
        var addRainModal = $('#addRainModal');
        var addPhenoModal = $('#addPhenoModal');
        addIrrigationModal.show();
        addRainModal.show();
        addPhenoModal.show();
    });

    
    addIrrigationModal.click(function () {
        modalIrrigation.modal('show');
        $('.modal-content').draggable();
    });

    addRainModal.click(function () {
        modalRain.modal('show');
        $('.modal-content').draggable();
    });

    addPhenoModal.click(function () {
        modalPheno.modal('show');
        $('.modal-content').draggable();
    });

    cancelIrrigation.click(function () {
        modalIrrigation.modal('hide');
    });

    cancelRain.click(function () {
        modalRain.modal('hide');
    });

    cancelPheno.click(function () {
        modalPheno.modal('hide');
    });

    

    dateOfReferenceBtn2.click(function () {

        txtDateOfReference.removeClass('input-red-border');

        var formattedDateOfReference = moment(txtDateOfReference.val());

        var minDate = moment(minDateOfReference.val());
        var maxDate = moment(maxDateOfReference.val());

        if (formattedDateOfReference.isValid() && formattedDateOfReference >= minDate && formattedDateOfReference <= maxDate)
        {

            showLoading();
            $.ajax({
                type: 'GET',
                url: './ChangeDateOfReference?pDay=' + formattedDateOfReference.date() + '&pMonth=' + (formattedDateOfReference.month() + 1) + '&pYear=' + formattedDateOfReference.year(),
                success: function () {
                    location.href = "./home";
                   

                },
                error: function (data) {

                    console.log(data);
                
                }
            });

        }
        else if (formattedDateOfReference < minDate || formattedDateOfReference > maxDate)
        {
            
            txtDateOfReference.addClass('input-red-border');

            alert('Fecha de referencia fuera del intervalo');

            /*txtDateOfReference.popover({
                trigger: 'manual',
                placement: 'top',
                content: 'Fecha de referencia fuera del intervalo'
            });*/

            //txtDateOfReference.popover("show");

        }
        else
        {
            txtDateOfReference.addClass('input-red-border');

            alert('Fecha de referencia fuera del intervalo');

            //txtDateOfReference.data('bs.popover').options.content = 'Formato de fecha inválida';

            //txtDateOfReference.popover("show");
        }


    });

    rainMilimeters.change(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveRainBtn.attr('disabled', false);
        else
            saveRainBtn.attr('disabled', true);


    });

    irrigationMilimeters.change(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveIrrigationBtn.attr('disabled', false);
        else
            saveIrrigationBtn.attr('disabled', true);


    });

    rainMilimeters.keyup(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveRainBtn.attr('disabled', false);
        else
            saveRainBtn.attr('disabled', true);
        

    });

    irrigationMilimeters.keyup(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveIrrigationBtn.attr('disabled', false);
        else
            saveIrrigationBtn.attr('disabled', true);
        

    });

    var loadStageForCropIrrigationWeather = function () {

        var selectedCropIrriWeatherPheno = cropIrriWeatherPheno.val();
        var specieId = specieIdInput.val();

        var comboStages = $('#StagePheno');

        $.ajax({
            type: 'GET',
            url: './GetStagesBy?pSpecieId=' + specieId + '&pCropIrrigationWeatherId=' + selectedCropIrriWeatherPheno,
            success: function (data) {

                var values = JSON.stringify(data);

                comboStages.empty();
                $.each($.parseJSON(values), function (key, value) {
                   comboStages.append('<option value="' + value.StageId + '">' + value.ShortName + '</option>');
                });

            },
            error: function (data) {

                console.log("Error on irrigationUnitPheno.change");

            }
        });

    };

    loadStageForCropIrrigationWeather();

    cropIrriWeatherPheno.change(function () {

        loadStageForCropIrrigationWeather();

    });

    dateOfReferenceBtn.click(function () {

        showLoading();

    });


    savePhenoBtn.click(function () {

        var selectedCropIrriWeatherPheno = cropIrriWeatherPheno.val();
        var specieId = specieIdInput.val();
        var phenoDateVal = phenoDate.val();
        var stagePhenoVal = stagePheno.val();

        showLoading();

        $.ajax({
            type: 'GET',
            url: './AddPhenology?pDate=' + phenoDateVal + '&pCropIrrigationWeatherId=' + selectedCropIrriWeatherPheno + '&pStageId=' + stagePhenoVal,
            success: function (data) {

                if(data == "Ok")
                {
                    location.href = "./home";
                }
                else {
                    hideLoading();
                    console.log(data);
                }

            },
            error: function (data) {
                hideLoading();
                console.log(data);
            }
        });

        

    });

    saveRainBtn.click(function ()
    {

        if ($('#rain').val())
        {

            var milimeters = parseFloat(rainMilimeters.val());

            var maxValue = parseInt(rainMilimeters.attr('max'));
            var minValue = parseInt(rainMilimeters.attr('min'));


            $('#rainMilimetersError').html('');
            if (milimeters >= minValue && milimeters <= maxValue) {
                modalRain.modal('hide');
                var rainDate = moment($('#rainDate :selected').val(), 'MM/DD/YYYY');
                saveRainBtn.attr('disabled', true);
                rainMilimeters.attr('disabled', true);
                showLoading();
                addRain($('#rain').val(),
                                $('#IrrigationUnit :selected').val(),
                                rainDate);
            } else {

                rainMilimeters.addClass('input-red-border');
                $('#rainMilimetersError').html(MILIMETERS_ERROR);
            }

            
        } else {

            saveRainBtn.attr('href', '');
            rainMilimeters.addClass('input-red-border');
            $('#rainMilimetersError').html(MANDATORY_MILMETERS);

        }

        

    });

    saveIrrigationBtn.click(function () {

        

        if ($('#irrigationMilimeters').val())
        {
            var milimeters = parseFloat(irrigationMilimeters.val());

            var maxValue = parseInt(irrigationMilimeters.attr('max'));
            var minValue = parseInt(irrigationMilimeters.attr('min'));

            $('#irrigationMilimetersError').html('');
            if (milimeters >= minValue && milimeters <= maxValue)
            {

                var irrigationDate = moment($('#irrigationDate :selected').val(), 'MM/DD/YYYY');
                $('#irrigationDate').removeClass('.input-red-border');
                saveIrrigationBtn.attr('disabled', true);
                irrigationMilimeters.attr('disabled', true);
                showLoading();
                modalIrrigation.modal('hide');
                addIrrigation(irrigationMilimeters.val(),
                                $('#IrrigationUnitIrrigation :selected').val(),
                                irrigationDate);


            }else
            {
                irrigationMilimeters.addClass('input-red-border');
                $('#irrigationMilimetersError').html(MILIMETERS_ERROR);
            }

            
        }
        else
        {
            //saveIrrigationBtn.attr('href', '');
            irrigationMilimeters.addClass('input-red-border');
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

        $('#floatingCirclesG').show();
        $.ajax({
            type: 'GET',
            url: pUrl,
            success:function(data)
            {
                if (data == "Ok") {

                    location.href = "./home";
                }
                else
                {
                    console.log(data);
                    hideLoading();
                }
                
                
            },
            error: function(data)
            {
                hideLoading();
                console.log(data);
                //$('#myModal').modal('hide');
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
            success: function (data) {
                if (data == "Ok") {

                    location.href = "./home";
                }
                else
                {
                    console.log(data);
                    hideLoading();
                }
                

            },
            error: function (data) {
                hideLoading();
                console.log(data);
                //$('#myModal').modal('hide');
            }
        });

    }

    lstFarms.change(function () {
        showLoading();
        location.href = './home?farm=' + lstFarms.val();

    });


});