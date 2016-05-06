'use strict';
app.factory('routeService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var ordersServiceFactory = {};

    ordersServiceFactory.delete = function (id) {
        return $http({
            url: serviceBase + "api/purchase/delete",
            method: "GET",
            params: {
                id: id
            }
        }).then(function (results) {
            return results;
        });
    };
    
    ordersServiceFactory.getRoutes = function () {  
        return $http({
            url: serviceBase + "api/route/getall",
            method: "GET"
        }).then(function (results) {
            return results;
        });
    };
    ordersServiceFactory.purchase = function (id) {
        return $http({
            url: serviceBase + "api/purchase/add",
            method: "GET",
            params: {
                id:id
            }
        }).then(function (results) {
            return results;
        });
    };;

    return ordersServiceFactory;

}]);