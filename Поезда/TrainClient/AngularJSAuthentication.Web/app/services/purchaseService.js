'use strict';
app.factory('purchaseService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var ordersServiceFactory = {};

    var _getOrders = function () {
        return $http({
            url: serviceBase + "api/purchase/getall",
            method: "GET"
        }).then(function (results) {
            return results;
        });
    };

    ordersServiceFactory.delete = function(id) {
        return $http({
            url: serviceBase + "api/purchase/delete",
            method: "GET",
            params: {
                id:id
            }
        }).then(function (results) {
            return results;
        });
    };
    ordersServiceFactory.getOrders = _getOrders;

    return ordersServiceFactory;

}]);