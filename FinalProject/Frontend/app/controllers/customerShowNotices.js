
  app.controller("customerShowNotices", function ($scope, $http, ajax,$rootScope,$location) {
    $rootScope.PageType = "seller";
    if ($rootScope.UserType != "Customer") {
      $location.path("/");
      return;
    }
    ajax.get(API_PORT + "api/notices/all", success, error);
    function success(response) {
        $scope.notices = response.data;
    }
    function error(error) {
  
    }
  
    $scope.Search = function () {
      ajax.get(API_PORT+"api/notices/search/" + $scope.search,
        function success(response) {
          $scope.orders = response.data;
        },
        function (err) {
          console.log(err);
        }
      );
    }
  
    $scope.ShowAll = function () {
        ajax.get(API_PORT + "api/notices/all", success, error);
        function success(response) {
            $scope.notices = response.data;
        }
        function error(error) {
      
        }
    }
  });