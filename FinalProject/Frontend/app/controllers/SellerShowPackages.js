app.controller("SellerShowPackages", function ($scope, $http, ajax,$rootScope) {
  ajax.get("https://localhost:44384/api/Package/GetAll/"+$rootScope.UserId, success, error);
  function success(response) {
    $scope.products = response.data;
  }
  function error(error) {

  }

  $scope.delete = function (id) {
    if (confirm('Are you sure your want to delete?')) {
      //do stuff

      console.log("ashsi");
      ajax.post("https://localhost:44384/api/Package/delete/" + id,
        function (response) {
          console.log(response);
          // alert("deleted");
        },
        function (err) {
          console.log(err);
          alert("deleted");
          ajax.get("https://localhost:44384/api/Package/GetAll/"+$rootScope.UserId, success, error);
          function success(response) {
            $scope.products = response.data;
          }
          function error(error) {
        
          }

        }
      );
    }
  }

  $scope.Search = function () {
    console.log("ashsi");
    ajax.get("https://localhost:44384/api/Package/Search/" + $scope.search+"/"+$rootScope.UserId,
      function success(response) {
        $scope.products = response.data;
      },
      function (err) {
        console.log(err);
      }
    );
  }

  $scope.ShowAll = function () {
    ajax.get("https://localhost:44384/api/Package/GetAll/"+$rootScope.UserId, success, error);
    function success(response) {
      $scope.products = response.data;
    }
    function error(error) {

    }
  }
});