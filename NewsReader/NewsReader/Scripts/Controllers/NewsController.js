newsModule.controller("newsController", ["$scope", "$filter", "newsFactory", function ($scope, $filter, newsFactory) {
    $scope.importantNews = [];
    $scope.filteredNews = [];
    $scope.lastNews = [];
    $scope.showMain = true;

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
    function getFilteredNews() {
        newsFactory.getFiltered(function (error, resp) {
            if (error) {
                alert("Error al recuperar las noticias");
                return;
            }

            if (!resp.data) {
                alert("Error al recuperar las noticias");
                return;
            }

            $scope.filteredNews = resp.data;
        });
    }

    //get 5 recent news
    function getLastNews() {
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

    getNews();
    getLastNews();
}]);