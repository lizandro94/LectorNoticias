newsModule.factory("newsFactory", ["$http", function ($http) {
    return {
        get: function (callBack) {
            $http.get("/api/News").then(
                function (resp) {
                    callBack(null, resp);
                },
                function (error) {
                    callBack(error, null);
                });
        }
    };
}]);