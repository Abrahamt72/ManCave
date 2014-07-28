app.controller('homeController', function ($scope, $http, $q, LoginService, $window, $location) {
  
    $scope.loggedIn = false;
    $scope.token = 'Not logged in';
    $scope.login = function () {
       
        LoginService.processLogin($scope.user.username, $scope.user.password)
            .then(function () {
                $scope.token = "Man Cave";
                $scope.user.username = '';
                $scope.user.password = '';
                $location.path('/test');

            }, function (status) {
                $scope.token = status;
                $scope.user.username = '';
                $scope.user.password = '';
            });
    };
})