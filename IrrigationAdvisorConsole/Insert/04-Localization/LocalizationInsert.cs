using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Weather;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisorConsole.Insert._04_Localization
{
    public static class LocalizationInsert
    {

        #region Localization
#if true

        public static void InsertPositions()
        {

            #region Base
            var lBase = new Position()
            {
                Name = Utils.NameBase,
                Latitude = 0,
                Longitude = 0
            };
            #endregion

            #region Countries
            var lUruguay = new Position()
            {
                Name = Utils.NamePositionUruguay,
                Latitude = -32.523,
                Longitude = -55.766
            };
            #endregion
            #region Regions

            var lRegionSur = new Position()
            {
                Name = Utils.NamePositionRegionSouth,
                Latitude = -33.874333,
                Longitude = -56.009694
            };

            var lRegionNorte = new Position()
            {
                Name = Utils.NamePositionRegionNorth,
                Latitude = -31.381117,
                Longitude = -56.539784
            };

            #endregion
            #region Cities #9
            //1 - Montevideo
            var lMontevideo = new Position()
            {
                Name = Utils.NamePositionCityMontevideo,
                Latitude = -34.9019718,
                Longitude = -56.1640629,
            };

            var lMinas = new Position()
            {
                Name = Utils.NamePositionCityMinas,
                Latitude = -34.366747,
                Longitude = -55.233317,
            };

            var lMercedes = new Position()
            {
                Name = Utils.NamePositionCityMercedes,
                Latitude = -33.255833,
                Longitude = -58.019167,
            };

            var lPalmar = new Position()
            {
                Name = Utils.NamePositionCityPalmar,
                Latitude = -33.062500,
                Longitude = -57.460833,
            };
            //5 - Durazno
            var lDurazno = new Position()
            {
                Name = Utils.NamePositionCityDurazno,
                Latitude = -33.413056,
                Longitude = -56.500556,
            };

            var lYoung = new Position()
            {
                Name = Utils.NamePositionCityYoung,
                Latitude = -32.683333,
                Longitude = -57.633333,
            };

            var lSalto = new Position()
            {
                Name = Utils.NamePositionCitySalto,
                Latitude = -31.3850,
                Longitude = -57.9602,
            };

            var lTacuarembo = new Position()
            {
                Name = Utils.NamePositionCityTacuarembo,
                Latitude = -31.7192,
                Longitude = -55.9742,
            };

            var lRinconDelPino = new Position()
            {
                Name = Utils.NamePositionCityRinconDelPino,
                Latitude = -34.5021	,
                Longitude = -56.8345,
            };
            //10 - 
            #endregion
            #region Farms #14
            #region 1 - Demo1, Demo2, Demo3; Santa Lucia;
            var lDemo1 = new Position()
            {
                Name = Utils.NamePositionFarmDemo1,
                Latitude = -33.023674,
                Longitude = -57.514196,
            };

            var lDemo2 = new Position()
            {
                Name = Utils.NamePositionFarmDemo2,
                Latitude = -34.232518,
                Longitude = -55.541477,
            };

            var lDemo3 = new Position()
            {
                Name = Utils.NamePositionFarmDemo3,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };

            var lSantaLucia = new Position()
            {
                Name = Utils.NamePositionFarmSantaLucia,
                Latitude = -34.232518,
                Longitude = -55.541477,
            };
            #endregion
            #region 2 - DCA: El Paraiso, San Jose, La Perdiz; Del Lago: San Pedro, El Mirador;
            var lDCAElParaiso = new Position()
            {
                Name = Utils.NamePositionFarmDCAElParaiso,
                Latitude = -33.023674,
                Longitude = -57.514196,
            };

            var lDCASanJose = new Position()
            {
                Name = Utils.NamePositionFarmDCASanJose,
                Latitude = -33.023674,
                Longitude = -57.514196,
            };

            var lDCALaPerdiz = new Position()
            {
                Name = Utils.NamePositionFarmDCALaPerdiz,
                Latitude = -33.023674,
                Longitude = -57.514196,
            };

            var lDelLagoSanPedro = new Position()
            {
                Name = Utils.NamePositionFarmDelLagoSanPedro,
                Latitude = -33.343049,
                Longitude = -56.567679,
            };

            var lDelLagoElMirador = new Position()
            {
                Name = Utils.NamePositionFarmDelLagoElMirador,
                Latitude = -33.228183,
                Longitude = -56.652764,
            };
            #endregion
            #region 3 - GMO: La Palma, El Tacuru; Tres Marias; La Rinconada; El Rincon;
            var lGMOLaPalma = new Position()
            {
                Name = Utils.NamePositionFarmGMOLaPalma,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };

            var lGMOElTacuru = new Position()
            {
                Name = Utils.NamePositionFarmGMOElTacuru,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };

            var lTresMarias = new Position()
            {
                Name = Utils.NamePositionFarmTresMarias,
                Latitude = -33.150086,
                Longitude = -55.815822,
            };

            var lLaRinconada = new Position()
            {
                Name = Utils.NamePositionFarmLaRinconada,
                Latitude = -32.806779,
                Longitude = -57.494618,
            };

            var lElRincon = new Position()
            {
                Name = Utils.NamePositionFarmElRincon,
                Latitude = -34.524453,
                Longitude = -56.896186,
            };
            #endregion
            #endregion
            #region WeatherStations #15
            #region INIA #5
            
            var lLasBrujasWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationLasBrujas,
                Latitude = -34.670641,
                Longitude = -56.340871
            };

            var lSantaLuciaWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationSantaLucia,
                Latitude = -34.232518,
                Longitude = -55.541477
            };

            var lLaEstanzuelaWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationLaEstanzuela,
                Latitude = -34.3384179,
                Longitude = -57.6920361,
            };

            var lSaltoGrandeWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationSaltoGrande,
                Latitude = -34.3384179,
                Longitude = -57.6920361,
            };

            var lTacuaremboWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationTacuarembo,
                Latitude = -34.3384179,
                Longitude = -57.6920361,
            };

            #endregion
            #region WetherLink # 10
            
            var lLaTribuWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationLaTribu,
                Latitude = -33.385254,
                Longitude = -55.454741,
            };

            var lElCureWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationElCure,
                Latitude = -34.3,
                Longitude = -54.2,
            };

            var lJCServiciosWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationJCServicios,
                Latitude = -33.6,
                Longitude = -57.6,
            };

            var lMariaElenaWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationMariaElena,
                Latitude = -33.201149,
                Longitude = -57.658801,
            };

            var lElRetiroWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationElRetiro,
                Latitude = -32.141931,
                Longitude = -57.859174,
            };

            var lZanjaHondaWS = new Position()
            {
                Name = Utils.NamePositionWeatherStationZanjaHonda,
                Latitude = -31.091836,
                Longitude = -57.74471,
            };

            var lEstacionVieja = new Position()
            {
                Name = Utils.NamePositionWeatherStationEstacionVieja,
                Latitude = -33.59095,
                Longitude = -58.291256
            };

            var lSanFernando = new Position()
            {
                Name = Utils.NamePositionWeatherStationSanFernando,
                Latitude = -33.436107,
                Longitude = -58.235706
            };

            var lLosOlivos = new Position()
            {
                Name = Utils.NamePositionWeatherStationLosOlivos,
                Latitude = -33.77432,
                Longitude = -57.074937
            };

            var lViveroSanFrancisco = new Position()
            {
                Name = Utils.NamePositionWeatherStationViveroSanFrancisco,
                Latitude = -32.248916,
                Longitude = -58.087099
            };

            #endregion
            #endregion

            #region Pivots Demo1 - La Perdiz #4
            var lDemoPivot11 = new Position()
            {
                Name = Utils.NamePositionPivotDemo11,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };
            var lDemoPivot12 = new Position()
            {
                Name = Utils.NamePositionPivotDemo12,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lDemoPivot13 = new Position()
            {
                Name = Utils.NamePositionPivotDemo13,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lDemoPivot15 = new Position()
            {
                Name = Utils.NamePositionPivotDemo15,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            #endregion
            #region Pivots Demo2 - Santa Lucia #5
            var lDemoPivot21 = new Position()
            {
                Name = Utils.NamePositionPivotDemo21,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot22 = new Position()
            {
                Name = Utils.NamePositionPivotDemo22,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot23 = new Position()
            {
                Name = Utils.NamePositionPivotDemo23,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot24 = new Position()
            {
                Name = Utils.NamePositionPivotDemo24,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lDemoPivot25 = new Position()
            {
                Name = Utils.NamePositionPivotDemo25,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            #endregion
            #region Pivots Demo3 - La Palma #5
            var lDemoPivot31 = new Position()
            {
                Name = Utils.NamePositionPivotDemo31,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot32A = new Position()
            {
                Name = Utils.NamePositionPivotDemo32A,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot33 = new Position()
            {
                Name = Utils.NamePositionPivotDemo33,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot34 = new Position()
            {
                Name = Utils.NamePositionPivotDemo34,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lDemoPivot35 = new Position()
            {
                Name = Utils.NamePositionPivotDemo35,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            #endregion

            #region Pivots Santa Lucia #5
            var lSantaLuciaPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia1,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia2,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia3,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia4,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            var lSantaLuciaPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotSantaLucia5,
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            #endregion
            #region Pivots DCA #27
            #region DCA El Paraiso #7
            var lDCAElParaisoPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotDCAElParaiso1,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };
            var lDCAElParaisoPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotDCAElParaiso2,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lDCAElParaisoPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotDCAElParaiso3,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lDCAElParaisoPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotDCAElParaiso4,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCAElParaisoPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotDCAElParaiso5,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCAElParaisoPivot6 = new Position()
            {
                Name = Utils.NamePositionPivotDCAElParaiso6,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCAElParaisoPivot7 = new Position()
            {
                Name = Utils.NamePositionPivotDCAElParaiso7,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            #endregion
            #region DCA San Jose #4
            var lDCASanJosePivot1 = new Position()
            {
                Name = Utils.NamePositionPivotDCASanJose1,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };
            var lDCASanJosePivot2 = new Position()
            {
                Name = Utils.NamePositionPivotDCASanJose2,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lDCASanJosePivot3 = new Position()
            {
                Name = Utils.NamePositionPivotDCASanJose3,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lDCASanJosePivot4 = new Position()
            {
                Name = Utils.NamePositionPivotDCASanJose4,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            #endregion
            #region DCA La Perdiz #16
            var lDCALaPerdizPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz1,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };
            var lDCALaPerdizPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz2,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lDCALaPerdizPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz3,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lDCALaPerdizPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz4,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz5,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot6 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz6,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot7 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz7,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot8 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz8,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot9 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz9,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot10a = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz10a,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot10b = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz10b,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot11 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz11,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot12 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz12,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot13 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz13,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            var lDCALaPerdizPivot14 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz14,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDCALaPerdizPivot15 = new Position()
            {
                Name = Utils.NamePositionPivotDCALaPerdiz15,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            #endregion
            #endregion
            #region Pivots Del Lago #25
            #region Pivots Del Lago - San Pedro #4
            var lDelLagoSanPedroPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro5,
                Latitude = -33.035406,
                Longitude = -57.551740,
            };

            var lDelLagoSanPedroPivot6 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro6,
                Latitude = -33.024191,
                Longitude = -57.543566,
            };
            var lDelLagoSanPedroPivot7 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro7,
                Latitude = -33.020039,
                Longitude = -57.530693
            };
            var lDelLagoSanPedroPivot8 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoSanPedro8,
                Latitude = -33.031979,
                Longitude = -57.531700
            };
            #endregion
            #region Pivots Del Lago - El Mirador #21
            var lDelLagoElMiradorPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador1,
                Latitude = -33.222236,
                Longitude = -56.628953
            };
            var lDelLagoElMiradorPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador2,
                Latitude = -33.227397,
                Longitude = -56.633578
            };
            var lDelLagoElMiradorPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador3,
                Latitude = -33.227925,
                Longitude = -56.621703
            };
            var lDelLagoElMiradorPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador4,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador5,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot6 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador6,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot7 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador7,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot8 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador8,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot9 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador9,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot10 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador10,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot11 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador11,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot12 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador12,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot13 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador13,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot14 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador14,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot15 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador15,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivotChaja1 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMiradorChaja1,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivotChaja2 = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMiradorChaja2,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            var lDelLagoElMiradorPivot1b = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador1b,
                Latitude = -33.222236,
                Longitude = -56.628953
            };
            var lDelLagoElMiradorPivot2b = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador2b,
                Latitude = -33.227397,
                Longitude = -56.633578
            };
            var lDelLagoElMiradorPivot3b = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador3b,
                Latitude = -33.227925,
                Longitude = -56.621703
            };
            var lDelLagoElMiradorPivot4b = new Position()
            {
                Name = Utils.NamePositionPivotDelLagoElMirador4b,
                Latitude = -33.045291,
                Longitude = -57.531845
            };
            
            #endregion
            #endregion
            #region Pivots GMO #22
            #region LaPalma #9
            var lGMOLaPalmaPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma1,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma2,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma3,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma4,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma5,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot1_1 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma1_1,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot2_1 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma2_1,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot3_1 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma3_1,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOLaPalmaPivot4_1 = new Position()
            {
                Name = Utils.NamePositionPivotGMOLaPalma4_1,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            #endregion
            #region ElTacuru #13
            var lGMOElTacuruPivot1a = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru1a,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot1b = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru1b,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot2a = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru2a,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot2b = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru2b,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot3a = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru3a,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot3b = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru3b,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru4,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot5 = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru5,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot6 = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru6,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot7 = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru7,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot8 = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru8,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot9 = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru9,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            var lGMOElTacuruPivot10 = new Position()
            {
                Name = Utils.NamePositionPivotGMOElTacuru10,
                Latitude = -32.630481,
                Longitude = -57.443751,
            };
            #endregion
            #endregion
            #region Pivots Tres Marias #4
            var lTresMariasPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotTresMarias1,
                Latitude = -33.150086,
                Longitude = -55.815822,
            };
            var lTresMariasPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotTresMarias2,
                Latitude = -33.150086,
                Longitude = -55.815822,
            };
            var lTresMariasPivot3 = new Position()
            {
                Name = Utils.NamePositionPivotTresMarias3,
                Latitude = -33.150086,
                Longitude = -55.815822,
            };
            var lTresMariasPivot4 = new Position()
            {
                Name = Utils.NamePositionPivotTresMarias4,
                Latitude = -33.150086,
                Longitude = -55.815822,
            };
            #endregion
            #region Pivots La Rinconada #4
            var lLaRinconadaPivot1 = new Position()
            {
                Name = Utils.NamePositionPivotLaRinconada1,
                Latitude = -32.806779,
                Longitude = -57.494618,
            };
            var lLaRinconadaPivot2 = new Position()
            {
                Name = Utils.NamePositionPivotLaRinconada2,
                Latitude = -32.806779,
                Longitude = -57.494618,
            };
            var lLaRinconadaPivot3_1 = new Position()
            {
                Name = Utils.NamePositionPivotLaRinconada3_1,
                Latitude = -32.806779,
                Longitude = -57.494618,
            };
            var lLaRinconadaPivot13_1 = new Position()
            {
                Name = Utils.NamePositionPivotLaRinconada13_1,
                Latitude = -32.806779,
                Longitude = -57.494618,
            };
            #endregion
            #region Pivots El Rincon #2
            var lElRinconPivot1a = new Position()
            {
                Name = Utils.NamePositionPivotElRincon1a,
                Latitude = -34.512689,
                Longitude = -56.897440,
            };
            var lElRinconPivot1b = new Position()
            {
                Name = Utils.NamePositionPivotElRincon1b,
                Latitude = -34.512689,
                Longitude = -56.897440,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Positions.Add(lBase);
                context.Positions.Add(lUruguay);
                context.Positions.Add(lRegionSur);
                context.Positions.Add(lRegionNorte);
                #region Cities #9
                context.Positions.Add(lMontevideo);
                context.Positions.Add(lMinas);
                context.Positions.Add(lMercedes);
                context.Positions.Add(lPalmar);
                context.Positions.Add(lDurazno);
                context.Positions.Add(lYoung);
                context.Positions.Add(lSalto);
                context.Positions.Add(lTacuarembo);
                context.Positions.Add(lRinconDelPino);
                #endregion
                #region Farms #14
                context.Positions.Add(lDemo1);
                context.Positions.Add(lDemo2);
                context.Positions.Add(lDemo3);
                context.Positions.Add(lSantaLucia);
                context.Positions.Add(lDCAElParaiso);
                context.Positions.Add(lDCASanJose);
                context.Positions.Add(lDCALaPerdiz);
                context.Positions.Add(lDelLagoSanPedro);
                context.Positions.Add(lDelLagoElMirador);
                context.Positions.Add(lGMOLaPalma);
                context.Positions.Add(lGMOElTacuru);
                context.Positions.Add(lLaRinconada);
                context.Positions.Add(lTresMarias);
                context.Positions.Add(lElRincon);
                #endregion
                #region Weather Stations #15
                context.Positions.Add(lLasBrujasWS);
                context.Positions.Add(lSantaLuciaWS);
                context.Positions.Add(lLaEstanzuelaWS);
                context.Positions.Add(lSaltoGrandeWS);
                context.Positions.Add(lTacuaremboWS);
                context.Positions.Add(lLaTribuWS);
                context.Positions.Add(lElCureWS);
                context.Positions.Add(lJCServiciosWS);
                context.Positions.Add(lMariaElenaWS);
                context.Positions.Add(lElRetiroWS);
                context.Positions.Add(lZanjaHondaWS);
                context.Positions.Add(lEstacionVieja);
                context.Positions.Add(lSanFernando);
                context.Positions.Add(lLosOlivos);
                context.Positions.Add(lViveroSanFrancisco);
                #endregion
                #region Pivots #103
                #region Pivots - Demo #14
                context.Positions.Add(lDemoPivot11);
                context.Positions.Add(lDemoPivot12);
                context.Positions.Add(lDemoPivot13);
                context.Positions.Add(lDemoPivot15);
                context.Positions.Add(lDemoPivot21);
                context.Positions.Add(lDemoPivot22);
                context.Positions.Add(lDemoPivot23);
                context.Positions.Add(lDemoPivot24);
                context.Positions.Add(lDemoPivot25);
                context.Positions.Add(lDemoPivot31);
                context.Positions.Add(lDemoPivot32A);
                context.Positions.Add(lDemoPivot33);
                context.Positions.Add(lDemoPivot34);
                context.Positions.Add(lDemoPivot35);
                #endregion
                #region Pivots - Santa Lucia #5
                context.Positions.Add(lSantaLuciaPivot1);
                context.Positions.Add(lSantaLuciaPivot2);
                context.Positions.Add(lSantaLuciaPivot3);
                context.Positions.Add(lSantaLuciaPivot4);
                context.Positions.Add(lSantaLuciaPivot5);
                #endregion
                #region Pivots - DCA #27
                context.Positions.Add(lDCAElParaisoPivot1);
                context.Positions.Add(lDCAElParaisoPivot2);
                context.Positions.Add(lDCAElParaisoPivot3);
                context.Positions.Add(lDCAElParaisoPivot4);
                context.Positions.Add(lDCAElParaisoPivot5);
                context.Positions.Add(lDCAElParaisoPivot6);
                context.Positions.Add(lDCAElParaisoPivot7);
                context.Positions.Add(lDCASanJosePivot1);
                context.Positions.Add(lDCASanJosePivot2);
                context.Positions.Add(lDCASanJosePivot3);
                context.Positions.Add(lDCASanJosePivot4);
                context.Positions.Add(lDCALaPerdizPivot1);
                context.Positions.Add(lDCALaPerdizPivot2);
                context.Positions.Add(lDCALaPerdizPivot3);
                context.Positions.Add(lDCALaPerdizPivot4);
                context.Positions.Add(lDCALaPerdizPivot5);
                context.Positions.Add(lDCALaPerdizPivot6);
                context.Positions.Add(lDCALaPerdizPivot7);
                context.Positions.Add(lDCALaPerdizPivot8);
                context.Positions.Add(lDCALaPerdizPivot9);
                context.Positions.Add(lDCALaPerdizPivot10a);
                context.Positions.Add(lDCALaPerdizPivot10b);
                context.Positions.Add(lDCALaPerdizPivot11);
                context.Positions.Add(lDCALaPerdizPivot12);
                context.Positions.Add(lDCALaPerdizPivot13);
                context.Positions.Add(lDCALaPerdizPivot14);
                context.Positions.Add(lDCALaPerdizPivot15);
                #endregion
                #region Pivots - Estancias Del Lago #25
                context.Positions.Add(lDelLagoSanPedroPivot5);
                context.Positions.Add(lDelLagoSanPedroPivot6);
                context.Positions.Add(lDelLagoSanPedroPivot7);
                context.Positions.Add(lDelLagoSanPedroPivot8);
                context.Positions.Add(lDelLagoElMiradorPivot1);
                context.Positions.Add(lDelLagoElMiradorPivot2);
                context.Positions.Add(lDelLagoElMiradorPivot3);
                context.Positions.Add(lDelLagoElMiradorPivot4);
                context.Positions.Add(lDelLagoElMiradorPivot5);
                context.Positions.Add(lDelLagoElMiradorPivot6);
                context.Positions.Add(lDelLagoElMiradorPivot7);
                context.Positions.Add(lDelLagoElMiradorPivot8);
                context.Positions.Add(lDelLagoElMiradorPivot9);
                context.Positions.Add(lDelLagoElMiradorPivot10);
                context.Positions.Add(lDelLagoElMiradorPivot11);
                context.Positions.Add(lDelLagoElMiradorPivot12);
                context.Positions.Add(lDelLagoElMiradorPivot13);
                context.Positions.Add(lDelLagoElMiradorPivot14);
                context.Positions.Add(lDelLagoElMiradorPivot15);
                context.Positions.Add(lDelLagoElMiradorPivotChaja1);
                context.Positions.Add(lDelLagoElMiradorPivotChaja2);
                context.Positions.Add(lDelLagoElMiradorPivot1b);
                context.Positions.Add(lDelLagoElMiradorPivot2b);
                context.Positions.Add(lDelLagoElMiradorPivot3b);
                context.Positions.Add(lDelLagoElMiradorPivot4b);
                #endregion
                #region Pivots - GMO #22
                #region LaPalma
                context.Positions.Add(lGMOLaPalmaPivot1);
                context.Positions.Add(lGMOLaPalmaPivot2);
                context.Positions.Add(lGMOLaPalmaPivot3);
                context.Positions.Add(lGMOLaPalmaPivot4);
                context.Positions.Add(lGMOLaPalmaPivot5);
                context.Positions.Add(lGMOLaPalmaPivot1_1);
                context.Positions.Add(lGMOLaPalmaPivot2_1);
                context.Positions.Add(lGMOLaPalmaPivot3_1);
                context.Positions.Add(lGMOLaPalmaPivot4_1);
                #endregion
                #region ElTacuru
                context.Positions.Add(lGMOElTacuruPivot1a);
                context.Positions.Add(lGMOElTacuruPivot1b);
                context.Positions.Add(lGMOElTacuruPivot2a);
                context.Positions.Add(lGMOElTacuruPivot2b);
                context.Positions.Add(lGMOElTacuruPivot3a);
                context.Positions.Add(lGMOElTacuruPivot3b);
                context.Positions.Add(lGMOElTacuruPivot4);
                context.Positions.Add(lGMOElTacuruPivot5);
                context.Positions.Add(lGMOElTacuruPivot6);
                context.Positions.Add(lGMOElTacuruPivot7);
                context.Positions.Add(lGMOElTacuruPivot8);
                context.Positions.Add(lGMOElTacuruPivot9);
                context.Positions.Add(lGMOElTacuruPivot10);
                #endregion
                #endregion
                #region Pivots - Tres Marias #4
                context.Positions.Add(lTresMariasPivot1);
                context.Positions.Add(lTresMariasPivot2);
                context.Positions.Add(lTresMariasPivot3);
                context.Positions.Add(lTresMariasPivot4);
                #endregion
                #region Pivots - La Rinconada #4
                context.Positions.Add(lLaRinconadaPivot1);
                context.Positions.Add(lLaRinconadaPivot2);
                context.Positions.Add(lLaRinconadaPivot3_1);
                context.Positions.Add(lLaRinconadaPivot13_1);
                #endregion
                #region Pivots - El Rincon #2
                context.Positions.Add(lElRinconPivot1a);
                context.Positions.Add(lElRinconPivot1b);
                #endregion
                #endregion
                context.SaveChanges();
            }
        }

        public static void InsertRegions()
        {
            Position lPosition = null;
            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new Region
                {
                    Name = Utils.NameBase,
                    PositionId = 0,
                    Position = new Position(),
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null,
                    TemperatureDataList = null,
                };
                #endregion

                #region Sur
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionRegionSouth
                             select pos).FirstOrDefault();
                var lSur = new Region
                {
                    Name = Utils.NameRegionSouth,
                    PositionId = lPosition.PositionId,
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null,
                    TemperatureDataList = null,
                };
                #endregion

                #region Norte
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionRegionNorth
                             select pos).FirstOrDefault();
                var lNorte = new Region
                {
                    Name = Utils.NameRegionNorth,
                    PositionId = lPosition.PositionId,
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null,
                    TemperatureDataList = null,
                };
                #endregion

                //context.Regions.Add(lBase);
                context.Regions.Add(lSur);
                context.Regions.Add(lNorte);
                context.SaveChanges();
            }
        }

        public static void InsertCapitals()
        {
            using (var context = new IrrigationAdvisorContext())
            {
                Position lPosition = null;

                #region Base
                var lBase = new City
                {
                    Name = Utils.NameBase,
                    PositionId = 0,
                    CountryId = 0,
                };
                #endregion

                #region Montevideo
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityMontevideo
                             select pos).FirstOrDefault();
                var lMontevideo = new City
                {
                    Name = Utils.NameCityMontevideo,
                    PositionId = lPosition.PositionId,
                    CountryId = 1,
                };

                //lMontevideo.Country.LanguageId = 1;
                #endregion

                //context.Cities.Add(lBase);
                context.Cities.Add(lMontevideo);
                context.SaveChanges();
            }
        }

        public static void InsertCountry()
        {
            Position lPosition = null;
            City lCity = null;
            Language lLanguage = null;

            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new Country
                {
                    Name = Utils.NameBase,
                    CapitalId = 0,
                    LanguageId = 0,
                    CityList = null,
                    RegionList = null,
                };
                #endregion

                #region Uruguay
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionUruguay
                             select pos).FirstOrDefault();

                lLanguage = (from language in context.Languages
                             where language.Name == Utils.NameLanguageSpanish
                             select language).FirstOrDefault();

                lCity = (from city in context.Cities
                         where city.Name == Utils.NameCityMontevideo
                         select city).FirstOrDefault();


                var lUruguay = new Country
                {
                    Name = Utils.NameCountryUruguay,
                    LanguageId = lLanguage.LanguageId,
                    CapitalId = lCity.CityId,
                    RegionList = null,
                    CityList = new List<City>(),
                };
                lUruguay.AddCity(lCity);
                #endregion

                //context.Countries.Add(lBase);
                context.Countries.Add(lUruguay);
                context.SaveChanges();
            }
        }

        public static void InsertCities()
        {
            using (var context = new IrrigationAdvisorContext())
            {
                Position lPosition = null;
                Country lCountry = null;

                #region Base
                var lBase = new City
                {
                    Name = Utils.NameBase,
                    PositionId = 0,
                    CountryId = 0,
                };
                #endregion

                #region Minas
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();


                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityMinas
                             select pos).FirstOrDefault();
                var lMinas = new City
                {
                    Name = Utils.NameCityMinas,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion
                #region Mercedes
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();


                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityMercedes
                             select pos).FirstOrDefault();
                var lMercedes = new City
                {
                    Name = Utils.NameCityMercedes,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion
                #region Palmar
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityPalmar
                             select pos).FirstOrDefault();
                var lPalmar = new City
                {
                    Name = Utils.NameCityPalmar,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion
                #region Durazno
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityDurazno
                             select pos).FirstOrDefault();
                var lDurazno = new City
                {
                    Name = Utils.NameCityDurazno,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion
                #region Young
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityYoung
                             select pos).FirstOrDefault();
                var lYoung = new City
                {
                    Name = Utils.NameCityYoung,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion
                #region Salto
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCitySalto
                             select pos).FirstOrDefault();
                var lSalto = new City
                {
                    Name = Utils.NameCitySalto,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion
                #region Tacuarembo
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityTacuarembo
                             select pos).FirstOrDefault();
                var lTacuarembo = new City
                {
                    Name = Utils.NameCityTacuarembo,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion
                #region Rincon del Pino
                lCountry = (from country in context.Countries
                            where country.Name == Utils.NameCountryUruguay
                            select country).FirstOrDefault();
                lPosition = (from pos in context.Positions
                             where pos.Name == Utils.NamePositionCityRinconDelPino
                             select pos).FirstOrDefault();
                var lRinconDelPino = new City
                {
                    Name = Utils.NameCityRinconDelPino,
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };
                #endregion

                //context.Cities.Add(lBase);
                context.Cities.Add(lMinas);
                context.Cities.Add(lMercedes);
                context.Cities.Add(lPalmar);
                context.Cities.Add(lDurazno);
                context.Cities.Add(lYoung);
                context.Cities.Add(lSalto);
                context.Cities.Add(lTacuarembo);
                context.Cities.Add(lRinconDelPino);
                context.SaveChanges();
            }
        }

#endif
        #endregion

        #region Localization.Farm
#if true

        public static void InsertFarms()
        {
            Position lPosition = null;
            WeatherStation lWeatherStation = null;
            City lCity = null;

            #region Base
            var lBase = new Farm
            {
                Name = Utils.NameBase,
                Company = "",
                Address = "",
                Phone = "",
                PositionId = 0,
                Has = 0,
                WeatherStationId = 0,
                WeatherStation = null,
                SoilList = null,
                BombList = null,
                IrrigationUnitList = null,
                CityId = 0,
                UserFarmList = null,
            };
            #endregion

            #region Demo1 - LaPerdiz - Del Carmen ACISA SA
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo1
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMercedes
                             select city).FirstOrDefault();

                    var lDemo = new Farm
                    {
                        Name = Utils.NameFarmDemo1,
                        Company = "Del Carmen ACISA SA - Demo",
                        Address = "",
                        Phone = "",
                        PositionId = lPosition.PositionId,
                        Has = 411,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDemo);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Demo2 - SantaLucia - Campo de Sol SA
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo2
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMinas
                             select city).FirstOrDefault();

                    var lDemo = new Farm
                    {
                        Name = Utils.NameFarmDemo2,
                        Company = "Campo de Sol SA - Demo",
                        Address = "",
                        Phone = "",
                        PositionId = lPosition.PositionId,
                        Has = 470,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDemo);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Demo3 - LaPalma - GMO - Menafra
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == Utils.NameWeatherStationLasBrujas
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDemo3
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityYoung
                             select city).FirstOrDefault();

                    var lDemo = new Farm
                    {
                        Name = Utils.NameFarmDemo3,
                        Company = "GMO - Demo",
                        Address = "Menafra",
                        Phone = "094 688 833",
                        PositionId = lPosition.PositionId,
                        Has = 140,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDemo);
                    context.SaveChanges();
                }
            }
            #endregion
            #region SantaLucia - Campo de Sol SA
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_SantaLucia_2016
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmSantaLucia
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMinas
                             select city).FirstOrDefault();

                    var lSantaLucia = new Farm
                    {
                        Name = Utils.NameFarmSantaLucia,
                        Company = "Campo de Sol SA",
                        Address = "",
                        Phone = "",
                        PositionId = lPosition.PositionId,
                        Has = 470,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lSantaLucia);
                    context.SaveChanges();
                }
            }
            #endregion

            #region DCA - El Paraiso - Del Carmen ACISA SA
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_DCAElParaiso_2016
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDCAElParaiso
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMercedes
                             select city).FirstOrDefault();

                    var lDCAElParaiso = new Farm
                    {
                        Name = Utils.NameFarmDCAElParaiso,
                        Company = "Del Carmen ACISA SA",
                        Address = "Ruta 2 km 270",
                        Phone = "099 830 058",
                        PositionId = lPosition.PositionId,
                        Has = 298,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDCAElParaiso);
                    context.SaveChanges();
                }
            }
            #endregion
            #region DCA - LaPerdiz - Del Carmen ACISA SA
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_DCALaPerdiz_2016
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDCALaPerdiz
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMercedes
                             select city).FirstOrDefault();

                    var lDCALaPerdiz = new Farm
                    {
                        Name = Utils.NameFarmDCALaPerdiz,
                        Company = "Del Carmen ACISA SA",
                        Address = "Ruta 55 km 60",
                        Phone = "099 830 058",
                        PositionId = lPosition.PositionId,
                        Has = 1156,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDCALaPerdiz);
                    context.SaveChanges();
                }
            }
            #endregion
            #region DCA - SanJose - Del Carmen ACISA SA
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_DCASanJose_2016
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDCASanJose
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityMercedes
                             select city).FirstOrDefault();

                    var lDCASanJose = new Farm
                    {
                        Name = Utils.NameFarmDCASanJose,
                        Company = "Del Carmen ACISA SA",
                        Address = "Ruta 21 km 70",
                        Phone = "099 830 058",
                        PositionId = lPosition.PositionId,
                        Has = 330,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDCASanJose);
                    context.SaveChanges();
                }
            }
            #endregion

            #region DelLago - San Pedro - Estancias del Lago S.R.L.
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_DelLagoSanPedro_2016
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoSanPedro
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityDurazno
                             select city).FirstOrDefault();

                    var lDelLagoSanPedro = new Farm
                    {
                        Name = Utils.NameFarmDelLagoSanPedro,
                        Company = "Estancias del Lago S.R.L.",
                        Address = "Miguel Cabrera Km 5. Durazno, Uruguay.",
                        Phone = "+598 91 359 000",
                        PositionId = lPosition.PositionId,
                        Has = 560,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDelLagoSanPedro);
                    context.SaveChanges();
                }
            }
            #endregion
            #region DelLago - El Mirador - Estancias del Lago S.R.L.
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_DelLagoElMirador_2016
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmDelLagoElMirador
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityDurazno
                             select city).FirstOrDefault();

                    var lDelLagoElMirador = new Farm
                    {
                        Name = Utils.NameFarmDelLagoElMirador,
                        Company = "Estancias del Lago S.R.L.",
                        Address = "Miguel Cabrera Km 5. Durazno, Uruguay.",
                        Phone = "+598 91 359 000; +598 92 124 119",
                        PositionId = lPosition.PositionId,
                        Has = 1129,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lDelLagoElMirador);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Menafra - GMO - LaPalma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_GMOLaPalma_2017
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmGMOLaPalma
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityYoung
                             select city).FirstOrDefault();

                    var lGMOLaPalma = new Farm
                    {
                        Name = Utils.NameFarmGMOLaPalma,
                        Company = "GMO",
                        Address = "Menafra",
                        Phone = "099 830 058",
                        PositionId = lPosition.PositionId,
                        Has = 186,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lGMOLaPalma);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Menafra - GMO - ElTacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_GMOElTacuru_2017
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmGMOElTacuru
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityYoung
                             select city).FirstOrDefault();

                    var lGMOElTacuru = new Farm
                    {
                        Name = Utils.NameFarmGMOElTacuru,
                        Company = "GMO",
                        Address = "Menafra",
                        Phone = "099 830 058",
                        PositionId = lPosition.PositionId,
                        Has = 721,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lGMOElTacuru);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Albanell - Tres Marias
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.TresMarias)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_TresMarias_2017
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmTresMarias
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityDurazno
                             select city).FirstOrDefault();

                    var lTresMarias = new Farm
                    {
                        Name = Utils.NameFarmTresMarias,
                        Company = "ADOLFO ALBANELL E IRENE ARRARTE",
                        Address = "Ruta 3 km 287.3",
                        Phone = "099 603 349",
                        PositionId = lPosition.PositionId,
                        Has = 82,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lTresMarias);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Maria Elena SRL - LaRinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_LaRinconada_2017
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmLaRinconada
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityYoung
                             select city).FirstOrDefault();

                    var lLaRinconada = new Farm
                    {
                        Name = Utils.NameFarmLaRinconada,
                        Company = "Maria Elena SRL",
                        Address = "Ruta 3 km 287.3",
                        Phone = "099 492 897",
                        PositionId = lPosition.PositionId,
                        Has = 158,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lLaRinconada);
                    context.SaveChanges();
                }
            }
            #endregion
            #region Nilve S.A. - El Rincon
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.ElRincon)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    lWeatherStation = (from ws in context.WeatherStations
                                       where ws.Name == DataEntry.WeatherStationMainName_ElRincon_2017
                                       select ws).FirstOrDefault();
                    lPosition = (from pos in context.Positions
                                 where pos.Name == Utils.NamePositionFarmElRincon
                                 select pos).FirstOrDefault();
                    lCity = (from city in context.Cities
                             where city.Name == Utils.NameCityRinconDelPino
                             select city).FirstOrDefault();

                    var lElRincon = new Farm
                    {
                        Name = Utils.NameFarmElRincon,
                        Company = "Maria Elena SRL",
                        Address = "Ruta 1 km 77",
                        Phone = "099 204 293",
                        PositionId = lPosition.PositionId,
                        Has = 93,
                        WeatherStationId = lWeatherStation.WeatherStationId,
                        SoilList = null,
                        BombList = null,
                        IrrigationUnitList = null,
                        CityId = lCity.CityId,
                        UserFarmList = null,
                    };
                    context.Farms.Add(lElRincon);
                    context.SaveChanges();
                }
            }
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Farms.Add(lBase);
                context.SaveChanges();
            }
        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDemo1()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = {   Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm};
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDemo1
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDemo1)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDemo1)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDemo1)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDemo1));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDemo1));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDemo1));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDemo2()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = {   Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDemo2
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDemo2)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDemo2)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDemo2)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDemo2));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDemo2));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDemo2));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDemo3()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = {   Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDemo3
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDemo3)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDemo3)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDemo3)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDemo3));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDemo3));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDemo3));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmSantaLucia()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserSantaLucia, 
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmSantaLucia
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmSantaLucia)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmSantaLucia)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmSantaLucia)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmSantaLucia));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmSantaLucia));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmSantaLucia));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, and Irrigation Units
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDCAElParaiso()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDCA1, Utils.NameUserDCA2, 
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDCAElParaiso
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDCAElParaiso)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDCAElParaiso)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDCAElParaiso)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDCAElParaiso));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDCAElParaiso));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDCAElParaiso));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDCALaPerdiz()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDCA1, Utils.NameUserDCA2, 
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDCALaPerdiz
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDCALaPerdiz)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDCALaPerdiz)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDCALaPerdiz)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDCALaPerdiz));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDCALaPerdiz));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDCALaPerdiz));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDCASanJose()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lIrrigationUnitList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQIrrigationUnit = null;
            String[] lUserNames = { Utils.NameUserDCA1, Utils.NameUserDCA2,
                                      Utils.NameUserSeba, Utils.NameUserGonza,
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDCASanJose
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDCASanJose)
                             select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDCASanJose)
                             select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDCASanJose)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQIrrigationUnit = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDCASanJose));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDCASanJose));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQIrrigationUnit = lIQIrrigationUnit.Where(b => b.Name.Contains(Utils.NameFarmDCASanJose));
                foreach (Pivot item in lIQIrrigationUnit) lIrrigationUnitList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lIrrigationUnitList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoSanPedro()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDelLago1, Utils.NameUserDelLago2, 
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDelLagoSanPedro
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDelLagoSanPedro)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDelLagoSanPedro)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDelLagoSanPedro)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDelLagoSanPedro));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDelLagoSanPedro));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDelLagoSanPedro));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmDelLagoElMirador()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserDelLago1, Utils.NameUserDelLago2, 
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmDelLagoElMirador
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmDelLagoElMirador)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmDelLagoElMirador)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmDelLagoElMirador)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmDelLagoElMirador));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmDelLagoElMirador));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmDelLagoElMirador));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmGMOLaPalma()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lIrrigationUnitList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQIrrigationUnit = null;
            String[] lUserNames = { Utils.NameUserGMO1, Utils.NameUserGMO2, Utils.NameUserGMO3, 
                                      Utils.NameUserGMO4, Utils.NameUserGMO5, Utils.NameUserGMO6, 
                                      Utils.NameUserGMO7, Utils.NameUserGMO8,
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmGMOLaPalma
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmGMOLaPalma)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmGMOLaPalma)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmGMOLaPalma)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQIrrigationUnit = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmGMOLaPalma));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmGMOLaPalma));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQIrrigationUnit = lIQIrrigationUnit.Where(b => b.Name.Contains(Utils.NameFarmGMOLaPalma));
                foreach (Pivot item in lIQIrrigationUnit) lIrrigationUnitList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lIrrigationUnitList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmGMOElTacuru()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserGMO1, Utils.NameUserGMO2, Utils.NameUserGMO3, 
                                      Utils.NameUserGMO4, Utils.NameUserGMO5, Utils.NameUserGMO6, 
                                      Utils.NameUserGMO7, Utils.NameUserGMO8,
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmGMOElTacuru
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmGMOElTacuru)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmGMOElTacuru)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmGMOElTacuru)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmGMOElTacuru));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmGMOElTacuru));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmGMOElTacuru));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmTresMarias()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserTM1,
                                      Utils.NameUserSeba, Utils.NameUserGonza,
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmTresMarias
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmTresMarias)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmTresMarias)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmTresMarias)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmTresMarias));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmTresMarias));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmTresMarias));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmLaRinconada()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserLR1, Utils.NameUserLR2, 
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmLaRinconada
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmLaRinconada)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmLaRinconada)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmLaRinconada)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmLaRinconada));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmLaRinconada));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmLaRinconada));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

        public static void UpdateSoilsBombsIrrigationUnitsUsersFarmElRincon()
        {
            Farm lFarm = null;
            List<Bomb> lBombList = new List<Bomb>();
            IQueryable<Bomb> lIQBombs = null;
            List<Soil> lSoilList = new List<Soil>();
            IQueryable<Soil> lIQSoils = null;
            List<IrrigationUnit> lPivotList = new List<IrrigationUnit>();
            IQueryable<IrrigationUnit> lIQPivots = null;
            String[] lUserNames = { Utils.NameUserER1,  
                                      Utils.NameUserSeba, Utils.NameUserGonza, 
                                      Utils.NameUserAdmin, Utils.NameUserCristian,
                                      Utils.NameUserCPalo, Utils.NameUserMCarle,
                                      Utils.NameUserROlivera, Utils.NameUserDemo,
                                      Utils.NameUserTesting, Utils.NameUserTestAdm };
            List<User> lUserList = new List<User>();
            IQueryable<User> lIQUsers = null;
            List<UserFarm> lUserFarmList = new List<UserFarm>();
            IQueryable<UserFarm> lIQUserFarms = null;

            Bomb lBomb = null;
            Soil lSoil = null;
            Pivot lPivot = null;

            using (var context = new IrrigationAdvisorContext())
            {
                //Set context information
                lFarm = (from farm in context.Farms
                         where farm.Name == Utils.NameFarmElRincon
                         select farm).FirstOrDefault();
                lBomb = (from bomb in context.Bombs
                         where bomb.Name.Contains(Utils.NameFarmElRincon)
                         select bomb).FirstOrDefault();
                lSoil = (from soil in context.Soils
                         where soil.Name.Contains(Utils.NameFarmElRincon)
                         select soil).FirstOrDefault();
                lPivot = (from pivot in context.Pivots
                          where pivot.Name.Contains(Utils.NameFarmElRincon)
                          select pivot).FirstOrDefault();
                lUserList = (from user in context.Users
                             select user).ToList();
                lUserFarmList = (from userFarm in context.UserFarms
                                 where userFarm.FarmId == lFarm.FarmId
                                 select userFarm).ToList();

                lIQBombs = context.Bombs;
                lIQSoils = context.Soils;
                lIQPivots = context.Pivots;
                lIQUsers = context.Users;
                lIQUserFarms = context.UserFarms;

                lIQBombs = lIQBombs.Where(b => b.Name.Contains(Utils.NameFarmElRincon));
                foreach (Bomb item in lIQBombs) lBombList.Add(item);

                lIQSoils = lIQSoils.Where(b => b.Name.Contains(Utils.NameFarmElRincon));
                foreach (Soil item in lIQSoils) lSoilList.Add(item);

                lIQPivots = lIQPivots.Where(b => b.Name.Contains(Utils.NameFarmElRincon));
                foreach (Pivot item in lIQPivots) lPivotList.Add(item);

                lIQUsers = lIQUsers.Where(u => lUserNames.Contains(u.UserName));
                lIQUserFarms = lIQUserFarms.Where(uf => uf.FarmId == lFarm.FarmId);
                lUserFarmList = new List<UserFarm>();
                foreach (User lUser in lIQUsers)
                {
                    foreach (UserFarm lUserFarm in lIQUserFarms)
                    {
                        if (lUserFarm.UserId == lUser.UserId)
                        {
                            lUserFarmList.Add(lUserFarm);
                        }
                    }
                }

                // Update list of Bombs, Soils, Irrigation Units, and Users
                lFarm.BombList = lBombList;
                lFarm.SoilList = lSoilList;
                lFarm.IrrigationUnitList = lPivotList;
                lFarm.UserFarmList = lUserFarmList;

                context.SaveChanges();
            }

        }

#endif
        #endregion

    }
}
