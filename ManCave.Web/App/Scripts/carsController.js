app.controller('carsController', function ($scope, $http, $routeParams) {
    $scope.cars = [];
    $scope.getCars = function () {
        $http({ method: 'GET', url: '/api/v1/Cars/'+ $routeParams.id })
       .success(function (data) {
           $scope.cars = data;
           console.log(data);
       })
    }
    $scope.getCars();
})
