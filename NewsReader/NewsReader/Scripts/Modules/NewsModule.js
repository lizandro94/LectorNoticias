var newsModule = angular.module("News", []);

newsModule.filter('trustAsHtml', ['$sce', function ($sce) {
    return function (text) {
        return $sce.trustAsHtml(text);
    };
}]);