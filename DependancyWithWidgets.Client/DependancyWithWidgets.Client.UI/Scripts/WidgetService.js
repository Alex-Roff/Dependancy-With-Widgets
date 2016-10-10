(function (wa) {
  'using strict';

  wa.angular.factory('widgetService', ['$http', function ($http) {
    return {
      get: function (pass, fail) {
        $http({
          method: 'get',
          url: 'http://localhost/GreenTomatoRest/api/genre'
        }).then(pass, fail);
      },
      post: function (data, pass, fail) {
        $http({
          method: 'post',
          data: data,
          url: 'http://localhost/GreenTomatoRest/api/genre'
        }).then(pass, fail);
      }
    }
  }]);

})(window.webApp);