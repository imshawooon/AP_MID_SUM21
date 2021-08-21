app.controller("customerShowOrderDetails", function ($scope, $http, ajax, $routeParams, $rootScope,$location) {
  $rootScope.PageType = "seller";
  if ($rootScope.UserType != "Customer") {
    $location.path("/");
    return;
  }
    var id = $routeParams.id;
    ajax.get(API_PORT + "api/CustomerOrder/" + id, success, error);
    function success(response) {
      $scope.order = response.data;
      console.log(response.data);
    
    }
    function error(error) {
      console.log(error);
    }
   
  });
  