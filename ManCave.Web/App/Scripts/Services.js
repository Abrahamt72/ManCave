app.factory('SessionHandler', function ($window) {
    var setLoggedInToken = function (token) {
        $window.sessionStorage.setItem('token', token);
    };
    var removeLoggedInToken = function () {
        $window.sessionStorage.removeItem('token');
    };
 
    return {
        setLoggedInToken: setLoggedInToken,
        removeLoggedInToken: removeLoggedInToken,
       
    };
});

app.factory('LoginService', function ($q, $http, SessionHandler) {
    var isLoggedIn = false;
    var processLogin = function (username, password) {
        var deferred = $q.defer();
        $http({
            method: 'POST',
            data: 'username=' + username + '&password=' + password + '&grant_type=password',
            async: false,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            url: '/Token',
            isArray: false
        }).success(function (data) {
            SessionHandler.setLoggedInToken(data.access_token);
            isLoggedIn = true;
            deferred.resolve();
        }).error(function (data, status) {
            SessionHandler.removeLoggedInToken();
            deferred.reject(status);
        });
        return deferred.promise;
    };
    var checkLoggedIn = function () {
        return isLoggedIn;
    };
    var processLogout = function () {
        var deferred = $q.defer();
        $http({
            method: 'POST',
            url: '/api/Account/Logout' 
        }).success(function () {
            SessionHandler.logout();
            isLoggedIn = false;
            deferred.resolve();
        }).error(function (data, status) {
            return deferred.reject(status);
        });
        return deferred.promise;
    };
    return {
        checkLoggedIn: checkLoggedIn,
        processLogin: processLogin,
        processLogout: processLogout
    };
});

app.factory('AuthInterceptor', function ($window) {
    return {
        request: function (config) {
            config.headers = config.headers || {};
             if ($window.sessionStorage.getItem('token')) {
                config.headers.Authorization = 'Bearer ' + $window.sessionStorage.getItem('token'); 
            }
            return config;
        }
    };
});


