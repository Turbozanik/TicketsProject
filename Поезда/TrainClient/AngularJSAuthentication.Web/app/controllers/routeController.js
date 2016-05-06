'use strict';
app.controller('routeController', ['$scope','$http', 'routeService', function ($scope,$http, routeService) {

    $scope.routes = [];

    routeService.getRoutes().then(function (results) {
        $scope.routes = results.data;
    }, function (error) {
        //alert(error.data.message);
    });

    $scope.find = function (from, to) {
        $http({
            url: serviceBase + "api/route/getbydate",
            method: "GET",
            params: {
                from: from,
                to: to
            }
        }).then(function (results) {
            $scope.routes = results.data;
        });
    }

    $scope.purchase = function (route) {
        routeService.purchase(route.id).then(function (results) {
            route.freePlaces--;
            $("#add").show();
            window.setTimeout(function () {
                $("#add").fadeTo(500, 0).slideUp(500, function () {
                    $(this).remove();
                });
            }, 3000);
            //$scope.routes = results.data;
        }, function (error) {
            //alert(error.data.message);
        });
    }

}]);