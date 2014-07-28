var app = angular.module('app', ['ngRoute']);
app.config(function ($routeProvider, $httpProvider) {
    //routes
    $routeProvider.when('/', {
        templateUrl: '/app/views/home.html',
        controller: 'homeController'
    //})
    //    .when('/test', {
    //        templateUrl: '/app/views/test.html',
    //        controller: 'teamsController'
        //})
        //     .when('/test', {
        //         templateUrl: '/app/views/test.html',
        //         controller: 'carsController'
             })
             .when('/test', {
                 templateUrl: '/app/views/test.html',
                 controller: 'foodsController'

    })

    $httpProvider.interceptors.push('AuthInterceptor');
})