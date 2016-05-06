'use strict';
app.controller('purchaseController', ['$scope', 'purchaseService', function ($scope, purchaseService) {

    $scope.purchases = [];

    purchaseService.getOrders().then(function (results) {
        $scope.purchases = results.data;
    }, function (error) {
        //alert(error.data.message);
    });

    $scope.delete = function (purchase) {
        purchaseService.delete(purchase.id).then(function (results) {
            $scope.purchases.splice($scope.purchases.indexOf(purchase, 1),1);
        }, function (error) {
            //alert(error.data.message);
        });
    }

}]);