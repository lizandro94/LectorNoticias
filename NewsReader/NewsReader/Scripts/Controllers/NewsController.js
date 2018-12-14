newsModule.controller("newsController", ["$scope", "$filter", "newsFactory", function ($scope, $filter, newsFactory) {
    $scope.importantNews = [];

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

    getNews();
}]);