app.controller("ManagerShowPackages", function ($scope, $http, ajax,$rootScope) {
  $rootScope.UserType = "Manager";
    $rootScope.PageType = "seller";
    
    ajax.get("https://localhost:44384/api/MPackage/GetAll/", success, error);
    function success(response) {
      $scope.products = response.data;
    }
    function error(error) {
  
    }
  
    
  
    $scope.Search = function () {
      console.log("ashsi");
      ajax.get("https://localhost:44384/api/MPackage/Search/" + $scope.search+"/"+$rootScope.UserId,
        function success(response) {
          $scope.products = response.data;
        },
        function (err) {
          console.log(err);
        }
      );
    }
  
    $scope.ShowAll = function () {
      ajax.get("https://localhost:44384/api/MPackage/GetAll/", success, error);
      function success(response) {
        $scope.products = response.data;
      }
      function error(error) {
  
      }
    }
  });