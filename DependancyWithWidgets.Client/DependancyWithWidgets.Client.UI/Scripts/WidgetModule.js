(function (wa) {
  'using strict';

  wa.angular.controller('widgetController', ['$scope', 'widgetService', function ($scope, widgetService) {


    $scope.model = {
      Name: {}
    };


    genreService.get(function (responce) {
      $scope.genres = responce.data;
    }, function (error) {
      console.log(error);
    });

  }]);

})(window.webApp);