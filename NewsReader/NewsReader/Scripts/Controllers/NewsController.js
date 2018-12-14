newsModule.controller("newsController", ["$scope", "$filter", "newsFactory", function ($scope, $filter, newsFactory) {
    $scope.importantNews = [];
    $scope.filteredNews = [];
    $scope.lastNews = [];
    $scope.showMain = true;
    $scope.create = {};

    //Get 3 random news
    function getNews() {
        newsFactory.get(function (error, resp) {
            if (error) {
                alert("Error al recuperar las noticias");
                return;
            }

            if (!resp.data) {
                alert("Error al recuperar las noticias");
                return;
            }

            $scope.importantNews = resp.data;
        });
    }

    //get filtered news
    $scope.getFilteredNews = function () {
        var data = getFilterData();
        newsFactory.getFiltered(data, function (error, resp) {
            if (error) {
                alert("Error al recuperar las noticias");
                return;
            }

            if (!resp.data) {
                alert("Error al recuperar las noticias");
                return;
            }

            $scope.lastNews = resp.data;
        });
    }

    //get 5 recent news
    $scope.getLastNews = function () {
        newsFactory.getLastNews(function (error, resp) {
            if (error) {
                alert("Error al recuperar las noticias");
                return;
            }

            if (!resp.data) {
                alert("Error al recuperar las noticias");
                return;
            }

            $scope.lastNews = resp.data;
        });
    }

    //get data to filter
    function getFilterData() {
        return {
            Title: $scope.create.title,
            StartDate: $scope.create.startDate,
            EndDate: $scope.create.endDate
        };
    }


    getNews();
    $scope.getLastNews();
}]);