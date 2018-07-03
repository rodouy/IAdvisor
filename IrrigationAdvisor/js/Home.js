
$(document).ready(function () {

    var MILIMETERS_ERROR = 'La cantidad de milimetros tiene que ser mayor o igual a 0 y menor que 100.';
    var MANDATORY_MILMETERS = 'Los milimetros son obligatorios.';

    var saveRainBtn = $('#SaveRain');
    var saveIrrigationBtn = $('#SaveIrrigation');
    var savePhenoBtn = $('#savePhenoBtn');
    var saveNoIrrigation = $('#SaveNoIrrigation');
    var irrigationMilimeters = $('#irrigationMilimeters');
    var rainMilimeters = $('#rain');
    var dateOfReferenceBtn = $('#dateOfReferenceBtn');
    var cropIrriWeatherPheno = $('#CropIrriWeatherPheno');
    var phenoDate = $('#phenoDate');
    var stagePheno = $('#StagePheno'); 
    var dateOfReferenceBtn2 = $('#dateOfReferenceBtn2');
    var txtDateOfReference = $('#txtDateOfReference');
    var maxDateOfReference = $('#maxDateOfReference');
    var minDateOfReference = $('#minDateOfReference');
    var addIrrigationModal = $('#addIrrigationModal');
    var addIrrigationModalMobile = $('#addIrrigationModalMobile');
    var addNoIrrigationMobile = $('#addNoIrrigationMobile');
    var addPhenoModal = $('#addPhenoModal');
    var addRainModal = $('#addRainModal');
    var addNoIrrigationModal = $('#addNoIrrigationModal');
    var addRainModalMobile = $('#addRainModalMobile');
    var modalIrrigation = $('#modal');
    var modalRain = $('#modal-lluvia');
    var modalPheno = $('#modal-fenologia');
    var modalMoveIrrigation = $('#modal-move-irrigation')
    var modalNoIrrigation = $('#modal-no-irrigation');
    var cancelIrrigation = $('#CancelIrrigation');
    var cancelRain = $('#CancelRain');
    var cancelPheno = $('#CancelPheno');
    var cancelNoIrrigation = $('#CancelNoIrrigation');
    var lstFarms = $('#lstFarms');
    var modalLoadStatus = $('.disable-save-button').length == 0;
    var farmInfo = $('#farm-info');
    var irrigationUnitIrrigation = $('#IrrigationUnitIrrigation');
    var irrigationUnit = $('#IrrigationUnit');
    var irrigationUnitRainMail = $('#irrigationUnitRainMail');
    var irrigationUnitIrrigationMail = $('#irrigationUnitIrrigationMail');
    var userName = $('#userName').val();
    var dvtxtDateOfReferencedateOfReferenceBtn2 = $('#dv-for-txtDateOfReference-dateOfReferenceBtn2');
    var barResp = $('.bar-resp');
    var dateFromNoIrrigation = $('#dateFromNoIrrigation');
    var dateToNoIrrigation = $('#dateToNoIrrigation');
    var cropIrriWeatherNoIrrigation = $('#CropIrriWeatherNoIrrigation');
    var noIrrigationReason = $('#noIrrigationReason');
    var noIrrigationObs = $('#noIrrigationObs');
    var noIrrigationChecks = $('.no-irrigation-check');
    var selectedAllCiwNoIrrigation = $('#selectedAllCiwNoIrrigation');
    var moveIrrigation = $('.move-irrigation');
    var saveMoveIrrigation = $('#SaveMoveIrrigation');
    var dateToMove = $('#dateToMove');
    var selectedWaterInput = $('#selectedWaterInput');
    var cancelMoveIrrigation = $('#CancelMoveIrrigation');
    var isFertigation = $('#isFertigation');

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

    var getDateToday = function () {

        var monthValue;

        if ((moment().month() + 1) < 10) {
            monthValue = '0' + (moment().month() + 1);
        }
        else {
            monthValue = (moment().month() + 1);
        }

        var today = moment().year() + '-' + monthValue + '-' + moment().date();

        return today;
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

    var loadUserFarms = function () {

        $.ajax({
            type: 'GET',
            url: './GetFarmsByUser',
            success: function (data) {
                
                if (jQuery.type(data) == "array" && data.length > 0)
                {
                    var values = JSON.stringify(data);
                    var farmParam = getUrlParameter('farm');

                    lstFarms.empty();
                    var i = 0;
                    $.each($.parseJSON(values), function (key, value) {
                       
                        if (farmParam == value.FarmId) {
                            farmInfo.val(value.FarmId + " - " + value.FarmDescription);
                        }
                        else
                        {
                            // If not take the first.
                            if (i == 0)
                            {
                                farmInfo.val(value.FarmId + " - " + value.FarmDescription);
                            }
                        }

                        lstFarms.append('<option value="' + value.FarmId + '">' + value.FarmDescription + '.</option>');
                        i++;
                    });

                    $('#IrrigationUnit > option').each(function (index) {

                        var formattedString = $(this).val() + " - " + $(this).text() + "[br]";

                        if ($(this).val() == "-1")
                        {
                            irrigationUnitRainMail.val($(this).text() + "[br]");
                        }

                        if (irrigationUnitRainMail.val() == "")
                        {
                            irrigationUnitRainMail.val(formattedString);
                        }
                        else
                        {
                            irrigationUnitRainMail.val(irrigationUnitRainMail.val() + formattedString);
                        }                       
                    });

                    $('#IrrigationUnitIrrigation > option').each(function (index) {

                        var formattedString = $(this).val() + " - " + $(this).text() + "[br]";

                        if ($(this).val() == "-1") {
                            irrigationUnitIrrigationMail.val($(this).text() + "[br]");
                        }

                        if (irrigationUnitIrrigationMail.val() == "") {
                            irrigationUnitIrrigationMail.val(formattedString);
                        }
                        else {
                            irrigationUnitIrrigationMail.val(irrigationUnitIrrigationMail.val() + formattedString);
                        }
                    });
                    
                    if (lstFarms.children().length > 0 && farmParam) {
                        lstFarms.val(farmParam);
                    }

                    lstFarms.show();
                }
                else
                {
                    console.log("Error on loadUserFarms. - " + data);
                }
                
            },
            error: function (data) {

                console.log("Error on loadUserFarms");

            }
        });
    };

    var loadStageForCropIrrigationWeather = function () {
        var selectedCropIrriWeatherPheno = cropIrriWeatherPheno.val();
        
        var comboStages = $('#StagePheno');

        $.ajax({
            type: 'GET',
            url: './GetStagesBy?pCropIrrigationWeatherId=' + selectedCropIrriWeatherPheno,
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

    var loadDates = function () {

        var date = getDateToday();

        dateFromNoIrrigation.val(date);
        dateToNoIrrigation.val(date);

    };

    var init = function () {

        addIrrigationModal.hide();
        addRainModal.hide();
        addIrrigationModalMobile.hide();
        addRainModalMobile.hide();
        addPhenoModal.hide();
        addNoIrrigationModal.hide();
        addNoIrrigationMobile.hide();
        lstFarms.hide();
        
        var initModal = { backdrop: false, show: false };

        modalIrrigation.modal(initModal);
        modalRain.modal(initModal);
        modalPheno.modal(initModal);
        modalNoIrrigation.modal(initModal);
        modalMoveIrrigation.modal(initModal);
        loadUserFarms();
        loadDates();
        if (modalLoadStatus) {
            loadStageForCropIrrigationWeather();
        }

        hideLoading();
    };

    init();

    var removeClasses = function()
    {
        dvtxtDateOfReferencedateOfReferenceBtn2.removeClass('col-xs-8');
        dvtxtDateOfReferencedateOfReferenceBtn2.removeClass('col-md-5');
        dvtxtDateOfReferencedateOfReferenceBtn2.removeClass('col-lg-5');
        //lstFarms
        lstFarms.css("width", "100%");
        txtDateOfReference.css("bottom", "0");
        txtDateOfReference.css("width", "100%");
        addIrrigationModalMobile.css("background-color", "#4aca83");
        addPhenoModal.css("background-color", "#4169E1");
        dateOfReferenceBtn2.css("background-color", "#5A91FA");
        barResp.css('width', 'inherit');
    }

    var addClasses = function()
    {
        dvtxtDateOfReferencedateOfReferenceBtn2.addClass('col-xs-8');
        dvtxtDateOfReferencedateOfReferenceBtn2.addClass('col-md-5');
        dvtxtDateOfReferencedateOfReferenceBtn2.addClass('col-lg-5');
        lstFarms.css("width", "50%");
        txtDateOfReference.css("bottom", "8px");
        txtDateOfReference.css("width", "50%");
        addIrrigationModalMobile.css("background-color", "#00a1d3");
        addPhenoModal.css("background-color", "#00a1d3");
        dateOfReferenceBtn2.css("background-color", "#00a1d3");
        barResp.css('width', '842px');
    }

    $(window).resize(function () {

        var width = $(window).width();
        var height = $(window).height();

        if (width <= 760) {
            addIrrigationModalMobile.show();
            addRainModalMobile.show();
            addNoIrrigationMobile.show();

            addIrrigationModal.hide();
            addRainModal.hide();
            addNoIrrigationModal.hide();
            removeClasses();
        }
        else {
            addIrrigationModalMobile.hide();
            addRainModalMobile.hide();
            addNoIrrigationMobile.hide();

            addIrrigationModal.show();
            addRainModal.show();
            addNoIrrigationModal.show()
            addClasses();
        }

    });


    $.getScript("https://code.jquery.com/ui/1.12.0/jquery-ui.js", function () {
        var addIrrigationModal = $('#addIrrigationModal');
        var addRainModal = $('#addRainModal');
        var addPhenoModal = $('#addPhenoModal');

        var addIrrigationModalMobile = $('#addIrrigationModalMobile');
        var addRainModalMobile = $('#addRainModalMobile');
        var addPhenoModalMobile = $('#addPhenoModalMobile');
        var addNoIrrigationMobile = $('#addNoIrrigationMobile');
        var addNoIrrigationModal = $('#addNoIrrigationModal');

        var width = $(window).width();
        var height = $(window).height();

        addPhenoModal.show();

        if (width <= 760) {
            addIrrigationModalMobile.show();
            addRainModalMobile.show();

            addIrrigationModal.hide();
            addRainModal.hide();
            addNoIrrigationModal.hide();

            removeClasses();
        }
        else
        {
            addIrrigationModalMobile.hide();
            addRainModalMobile.hide();

            addIrrigationModal.show();
            addRainModal.show();
            addNoIrrigationModal.show();
            addClasses();
        }
        
    });

    
    addIrrigationModal.click(function () {
        modalIrrigation.modal('show');
        $('.modal-content').draggable();
    });

    addIrrigationModalMobile.click(function () {
        modalIrrigation.modal('show');
        $('.modal-content').draggable();
    });

    addRainModal.click(function () {
        modalRain.modal('show');
        $('.modal-content').draggable();
    });

    addRainModalMobile.click(function () {
        modalRain.modal('show');
        $('.modal-content').draggable();
    });

    addNoIrrigationModal.click(function () {
        modalNoIrrigation.modal('show');
        $('.modal-content').draggable();
    });

    addNoIrrigationMobile.click(function () {
        modalNoIrrigation.modal('show');
        $('.modal-content').draggable();
    });

    addPhenoModal.click(function () {
        modalPheno.modal('show');
        $('.modal-content').draggable();
    });

    moveIrrigation.click(function (e, v) {

        var inputElement = $(this).find('.waterInputValue').val();
        selectedWaterInput.val(inputElement);

        modalMoveIrrigation.modal('show');
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

    cancelNoIrrigation.click(function () {
        modalNoIrrigation.modal('hide');
    });

    cancelMoveIrrigation.click(function () {
        modalMoveIrrigation.modal('hide');
    });

    dateOfReferenceBtn2.click(function () {

        txtDateOfReference.removeClass('input-red-border');

        var formattedDateOfReference = moment(txtDateOfReference.val());

        var minDate = moment(minDateOfReference.val());
        var maxDate = moment(maxDateOfReference.val());

        if (formattedDateOfReference.isValid() && formattedDateOfReference >= minDate && formattedDateOfReference <= maxDate)
        {
            showLoading();

            var farmId = -1;
            
            if (getUrlParameter('farm'))
            {
                farmId = getUrlParameter('farm');
            }

            $.ajax({
                type: 'GET',
                url: './ChangeDateOfReference?pDay=' + formattedDateOfReference.date() + '&pMonth=' + (formattedDateOfReference.month() + 1) + '&pYear=' + formattedDateOfReference.year() + '&pFarmId=' + farmId,
                success: function (data) {
                    location.href = data;

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

        if (currentValue && modalLoadStatus)
            saveRainBtn.attr('disabled', false);
        else
            saveRainBtn.attr('disabled', true);


    });

    irrigationMilimeters.change(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue && modalLoadStatus)
            saveIrrigationBtn.attr('disabled', false);
        else
            saveIrrigationBtn.attr('disabled', true);


    });

    rainMilimeters.keyup(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue && modalLoadStatus)
            saveRainBtn.attr('disabled', false);
        else
            saveRainBtn.attr('disabled', true);
        

    });

    irrigationMilimeters.keyup(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue && modalLoadStatus)
            saveIrrigationBtn.attr('disabled', false);
        else
            saveIrrigationBtn.attr('disabled', true);
        

    });

    var sendMail = function(subject, body)
    {
        $.ajax({
            url: '/Home/SendEmails?subject=' + subject + '&body=' + body,
            type: "GET",
            dataType: "text",
            traditional: true,
            contentType: "application/json; charset=utf-8",
            success: function (data) {

                if (data == "Ok") {
                    
                }
                else {

                    console.log(data);
                }


            },
            error: function (data) {

                console.log(data);

            }
        });
    }

    cropIrriWeatherPheno.change(function () {

        loadStageForCropIrrigationWeather();

    });

    dateOfReferenceBtn.click(function () {

        var formattedDateOfReference = moment(txtDateOfReference.val());

        showLoading();

        var farmId = -1;

        if (getUrlParameter('farm')) {
            farmId = getUrlParameter('farm');
        }

        $.ajax({
            type: 'GET',
            url: './ChangeDateOfReference?pDay=' + formattedDateOfReference.date() + '&pMonth=' + (formattedDateOfReference.month() + 1) + '&pYear=' + formattedDateOfReference.year() + '&pFarmId=' + farmId,
            success: function (data) {
                location.href = data;

            },
            error: function (data) {

                console.log(data);

            }
        });

    });


    savePhenoBtn.click(function () {

        var selectedCropIrriWeatherPheno = cropIrriWeatherPheno.val();
        var phenoDateVal = phenoDate.val();
        var stagePhenoVal = stagePheno.val();

        showLoading();

        $.ajax({
            type: 'GET',
            url: './AddPhenology?pDate=' + phenoDateVal + '&pCropIrrigationWeatherId=' + selectedCropIrriWeatherPheno + '&pStageId=' + stagePhenoVal,
            success: function (data) {

                if(data == "Ok")
                {
                    $.when(sendMail("Se ha modificado Fenología para el establecimiento " + lstFarms.val() + ".", "CropIrrigationWeatherId: " + selectedCropIrriWeatherPheno + ", StageId: " + stagePhenoVal + ", Fecha: " + phenoDateVal)).done(function () {
                        location.href = "./home?farm=" + lstFarms.val();
                    });
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
            if (milimeters > minValue && milimeters < maxValue) {
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
            if (milimeters >= minValue && milimeters < maxValue)
            {

                var irrigationDate = moment($('#irrigationDate :selected').val(), 'MM/DD/YYYY');
                $('#irrigationDate').removeClass('.input-red-border');
                saveIrrigationBtn.attr('disabled', true);
                irrigationMilimeters.attr('disabled', true);
                showLoading();
                modalIrrigation.modal('hide');
                addIrrigation(irrigationMilimeters.val(),
                                $('#IrrigationUnitIrrigation :selected').val(),
                                irrigationDate,
                                isFertigation.val());

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

    noIrrigationChecks.change(function()
    {
        selectedAllCiwNoIrrigation.prop("checked", false);
    });

    selectedAllCiwNoIrrigation.change(function () {
        noIrrigationChecks.prop("checked", this.checked);
    });
   
    saveNoIrrigation.click(function () {
        
        if (moment(dateToNoIrrigation.val()).isBefore(dateFromNoIrrigation.val()))
        {
            alert("La fecha hasta no puede ser mayor que la fecha desde");
        }
        else
        {
            showLoading();
            modalNoIrrigation.modal('hide');

            var selectedCiws = "";

            $.each(noIrrigationChecks, function (key, value) {
                if (value.checked)
                {
                    selectedCiws = value.value + "," + selectedCiws;
                }       
            });

            if (selectedCiws == "")
            {
                alert("Debe seleccionar por lo menos un cultivo");
            }
            else
            {
                selectedCiws = selectedCiws.substring(0, selectedCiws.length - 1);

                addNoIrrigation(dateFromNoIrrigation.val(),
                                dateToNoIrrigation.val(),
                                selectedCiws,
                                noIrrigationReason.val(),
                                noIrrigationObs.val());
            }
            
        }


    });

    saveMoveIrrigation.click(function () {
        debugger;
        var dateMove = moment(dateToMove.val());
        
        if (!dateMove.isValid())
        {
            alert("La fecha ingresada no es válida");
        }
        else
        {
            showLoading();
            modalMoveIrrigation.modal('hide');
            
            var arrayElements = selectedWaterInput.val().split(',');

            moveIrrigation(dateMove._i, arrayElements[0], arrayElements[1], arrayElements[2], arrayElements[3], arrayElements[4]);
        }
    });

    var moveIrrigation = function (pDateToMove, pWaterInputId, pWaterInputOldDate, pCIWId, pCIWName, pMilimiters) {

        var pUrl = './MoveIrrigation?pDateToMove=' + pDateToMove +
                    '&pWaterInputId=' + pWaterInputId +
                     '&farm=' + lstFarms.val();

        $('#floatingCirclesG').show();

        $.ajax({
            type: 'GET',
            url: pUrl,
            success: function (data) {
                if (data == "Ok") {

                    var formatedDate = moment(pDateToMove).format('DD/MM/YYYY');

                    $.when(sendMail("Usuario: " + userName + " ha movido riego " + farmInfo.val() + ".", "Establecimiento:" + farmInfo.val() + "[br] Fecha anterior: " + pWaterInputOldDate + "[br] Fecha actualizada: " + formatedDate + "[br] Water Input Id: " + pWaterInputId + "[br] Cultivo: " + pCIWId + " - " + pCIWName + "[br] Milímetros: " + pMilimiters)).done(function () {
                        location.href = "./home?farm=" + lstFarms.val();
                    });

                }
                else {
                    sendMail("Error al mover riego", data);
                    console.log(data);
                    hideLoading();
                }


            },
            error: function (data) {
                hideLoading();
                sendMail("Error al mover riego", data);
                console.log(data);
                //$('#myModal').modal('hide');
            }
        });

    };

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
                    
                    //TO-DO: Buscar las descripciones de los establecimientos. En caso de todos todas las descripciones de todos.
                    if (pIrrigationUnitId == "-1") {
                        pIrrigationUnitId = "Todos";
                    }

                    var selected = $('#IrrigationUnit option:selected').text();
                    var irrigationMailText = "";

                    if (selected == "Todos") {
                        irrigationMailText = irrigationUnitRainMail.val().replace("Todos", "");         
                    }
                    else {
                        irrigationMailText = selected;
                    }
                    
                    $.when(sendMail("Usuario: " + userName + " ha agregado Lluvia para el establecimiento " + farmInfo.val() + ".", "Establecimiento:" + farmInfo.val() + "[br] Milimetros: " + pMilimiters + "[br] Fecha: " + pDate.date() + "/" + (pDate.month() + 1) + "/" + pDate.year() + "[br] IrrigationUnitId: " + pIrrigationUnitId + " - " + irrigationMailText)).done(function () {
                        location.href = "./home?farm=" + lstFarms.val();
                    });
                   
                }
                else
                {
                    sendMail("Error al cargar Lluvia", data);
                    console.log(data);
                    hideLoading();
                }
                
                
            },
            error: function(data)
            {
                hideLoading();
                sendMail("Error al cargar Lluvia", data);
                console.log(data);
                //$('#myModal').modal('hide');
            }
        });

    }


    var addIrrigation = function (pMilimiters, pIrrigationUnitId, pDate, pIsFertigation) {

        var fertigationBool = false;

        if (pIsFertigation == "on")
        {
            fertigationBool = true;
        }

        var pUrl = './AddIrrigation?pMilimeters=' + pMilimiters +
                '&pIrrigationUnitId=' + pIrrigationUnitId +
                '&pDay=' + pDate.date() +
                '&pMonth=' + (pDate.month() + 1) +
                '&pYear=' + pDate.year() + 
                '&pIsFertigation=' + fertigationBool;

        
        $.ajax({
            type: 'GET',
            url: pUrl,
            success: function (data) {
                if (data == "Ok") {

                    if (pIrrigationUnitId == "-1")
                    {
                        pIrrigationUnitId = "Todos";
                    }
                    
                    var selected = $('#IrrigationUnitIrrigation option:selected').text();
                    var irrigationMailText = "";

                    if (selected == "Todos")
                    {
                        irrigationMailText = irrigationUnitIrrigationMail.val().replace("Todos", "");
                    }
                    else
                    {
                        irrigationMailText = selected;
                    }

                    $.when(sendMail("Usuario: " + userName + " ha agregado Riego para el establecimiento " + farmInfo.val() + ".", "Establecimiento:" + farmInfo.val() + "[br] Milimetros: " + pMilimiters +  "[br] Fecha: " + pDate.date() + "/" + (pDate.month() + 1) + "/" + pDate.year() + "[br] IrrigationUnitId: " + pIrrigationUnitId + " - " + irrigationMailText)).done(function () {
                        location.href = "./home?farm=" + lstFarms.val();
                    });
                    
                }
                else
                {
                    sendMail("Error al cargar Riego", data);
                    console.log(data);
                    hideLoading();
                }
                

            },
            error: function (data) {
                hideLoading();
                sendMail("Error al cargar Riego", data);
                console.log(data);
                //$('#myModal').modal('hide');
            }
        });

    }

    var addNoIrrigation = function (pDateFrom, pDateTo, pCropIrrigationWeatherList, pReasonId, pObservations) {


        var pUrl = './AddNoIrrigation?pDateFrom=' + pDateFrom +
                '&pDateTo=' + pDateTo +
                '&pCropIrrigationWeatherList=' + pCropIrrigationWeatherList +
                '&pReasonId=' + pReasonId +
                '&pObservations=' + pObservations +
                '&farm=' + lstFarms.val();

        $.ajax({
            type: 'GET',
            url: pUrl,
            success: function (data) {
                if (data == "Ok") {

                    var ciwSelectedNoIrrigation = "";

                    $('.dropdown :checkbox:checked').each(function (index, value) {                     
                            ciwSelectedNoIrrigation = value.value + "- " + $(this).next('span').next('span').text() + "[br]" + ciwSelectedNoIrrigation;                                                             
                    });
                               
                    ciwSelectedNoIrrigation = ciwSelectedNoIrrigation.replace("-1- Todos", "");

                    var reasonString = $('#noIrrigationReason :selected').text();
                    
                    $.when(sendMail("Usuario: " + userName + " ha agregado intervalo de No Riego para el establecimiento " + farmInfo.val() + ".", "Establecimiento:" + farmInfo.val() + "[br] Fecha Desde: " + pDateFrom + "[br] Fecha Hasta: " + pDateTo + '[br] Razón: ' + pReason + '- ' + reasonString + "[br] Cultivo: " + ciwSelectedNoIrrigation + '[br] Observaciones: ' + pObservations)).done(function () {
                        location.href = "./home?farm=" + lstFarms.val();
                    });

                }
                else {
                    sendMail("Error al cargar No Riego", data);
                    console.log(data);
                    hideLoading();
                }
            },
            error: function (data) {
                hideLoading();
                sendMail("Error al cargar No Riego", data);
                console.log(data);
            }
        });

    }

    lstFarms.change(function () {
        showLoading();
        location.href = './home?farm=' + lstFarms.val();

    });

    $('.td-pheno').dblclick(function (e, f) {

        var ciw = e.currentTarget.children[0].value;

        var pUrl = './GetStagesBy?pCropIrrigationWeatherId=' + ciw;

        var comboStages = $('#select-pheno-stage-' + ciw);
        var ok = $('#pheno-ok-' + ciw);
        var cancel = $('#pheno-cancel-' + ciw);
        var phenoClock = $('#pheno-clock-' + ciw);
        var selectedPheno = $('#selected-pheno-name-' + ciw);
        selectedPheno.hide();
        phenoClock.show();

        $.ajax({
            type: 'GET',
            url: pUrl,
            success: function (data) {

                var values = JSON.stringify(data);

                comboStages.empty();
                $.each($.parseJSON(values), function (key, value) {
                    if (selectedPheno.text() == value.ShortName)
                    {
                        comboStages.append('<option value="' + value.StageId + '" selected>' + value.ShortName + '</option>');
                    }
                    else
                    {
                        comboStages.append('<option value="' + value.StageId + '">' + value.ShortName + '</option>');
                    }
                   
                });
                
                comboStages.show();
                ok.show();
                cancel.show();
                phenoClock.hide();

            },
            error: function (data) {
                hideLoading();
                //sendMail("Error al cargar No Riego", data);
                console.log(data);
            }
        });
    });

    $('.pheno-ok').click(function (e, f) {
        var ciw = e.currentTarget.parentElement.children[0].value;

    });

    $('.pheno-cancel').click(function (e, f) {
        var ciw = e.currentTarget.parentElement.children[0].value;
        
        var comboStages = $('#select-pheno-stage-' + ciw);
        var ok = $('#pheno-ok-' + ciw);
        var cancel = $('#pheno-cancel-' + ciw);
        var selectedPheno = $('#selected-pheno-name-' + ciw);

        comboStages.hide();
        ok.hide();
        cancel.hide();
     
        selectedPheno.show();
    });
});