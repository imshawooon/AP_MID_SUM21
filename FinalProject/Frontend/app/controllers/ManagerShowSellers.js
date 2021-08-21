app.controller("ManagerShowSellers", function ($scope, $http, ajax,$rootScope) {

  $rootScope.UserType = "Manager";
    $rootScope.PageType = "seller";
    
    ajax.get("https://localhost:44384/api/Seller/GetAll/", success, error);
    function success(response) {
      $scope.users = response.data;
    }
    function error(error) {
  
    }
  
    $scope.delete = function (id) {
      if (confirm('Are you sure your want to delete?')) {
        //do stuff
  
        console.log("ashsi");
        ajax.post("https://localhost:44384/api/Seller/delete/" + id,
          function (response) {
            console.log(response);
            // alert("deleted");
          },
          function (err) {
            console.log(err);
            alert("deleted");
            ajax.get("https://localhost:44384/api/Seller/GetAll/"+$rootScope.UserId, success, error);
            function success(response) {
              $scope.users = response.data;
            }
            function error(error) {
          
            }
  
          }
        );
      }
    }
  
    $scope.Search = function () {
      console.log("ashsi");
      ajax.get("https://localhost:44384/api/Seller/Search/" + $scope.search+"/"+$rootScope.UserId,
        function success(response) {
          $scope.users = response.data;
        },
        function (err) {
          console.log(err);
        }
      );
    }
  
    $scope.ShowAll = function () {
      ajax.get("https://localhost:44384/api/Seller/GetAll/", success, error);
      function success(response) {
        $scope.users = response.data;
      }
      function error(error) {
  
      }
    }
  });