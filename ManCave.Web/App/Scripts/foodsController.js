app.controller('foodsController', function ($scope, $http, $routeParams) {
    $scope.foods = [];
    $scope.getFoods = function () {
        $http({ method: 'GET', url: '/api/v1/Foods/' + $routeParams.id })
       .success(function (data) {
           $scope.foods = data;
           console.log(data);
       })
    }
    $scope.getFoods();
})