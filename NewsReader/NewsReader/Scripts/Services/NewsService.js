newsModule.factory("newsFactory", ["$http", function ($http) {
    return {
        get: function (callBack) {
            $http.get("/api/News/GetAllNews").then(
                function (resp) {
                    callBack(null, resp);
                },
                function (error) {
                    callBack(error, null);
                });
        },
        getFiltered: function (data, callBack) {
            $http.post("/api/News", data).then(
                function (resp) {
                    callBack(null, resp);
                },
                function (error) {
                    callBack(error, null);
                });
        },
        getLastNews: function (callBack) {
            $http.get("/api/News/GetLastNews").then(
                function (resp) {
                    callBack(null, resp);
                },
                function (error) {
                    callBack(error, null);
                });
        }
    };
}]);