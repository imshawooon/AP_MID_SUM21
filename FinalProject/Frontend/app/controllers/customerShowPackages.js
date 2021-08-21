app.controller("customerShowPackages", function ($scope, $http, ajax,$rootScope,$location) {
  $rootScope.PageType = "seller";
  if ($rootScope.UserType != "Customer") {
    $location.path("/");
    return;
  }
    ajax.get(API_PORT+"api/Packages/GetAll", success, error);
    function success(response) {
      $scope.products = response.data;
    }
    function error(error) {
    }
  
    $scope.Search = function () {
      ajax.get(API_PORT+"api/Customer/Package/" + $scope.search,
        function success(response) {
          $scope.products = response.data;
        },
        function (err) {
          console.log(err);
        }
      );
    }
  
    $scope.ShowAll = function () {
      ajax.get(API_PORT+"api/Packages/GetAll", success, error);
      function success(response) {
        $scope.products = response.data;
      }
      function error(error) {
  
      }
    }
  });