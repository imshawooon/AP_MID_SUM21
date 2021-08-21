app.controller("customerShowOrder", function ($scope, $http, ajax,$rootScope,$location) {
    $rootScope.PageType = "seller";
    if ($rootScope.UserType != "Customer") {
      $location.path("/");
      return;
    }
    ajax.get(API_PORT+"api/CustomerOrder/" + $rootScope.UserId+"/GetAll", success, error);
    function success(response) {
      $scope.orders = response.data;
    }
    function error(error) {
  
    }
  
    $scope.Search = function () {
      ajax.get(API_PORT+"api/CustomerOrder/Search/" + $scope.search+"/"+$rootScope.UserId,
        function success(response) {
          $scope.orders = response.data;
        },
        function (err) {
          console.log(err);
        }
      );
    }
  
    $scope.ShowAll = function () {
        ajax.get(API_PORT+"api/CustomerOrder/" + $rootScope.UserId+"/GetAll", success, error);
      function success(response) {
        $scope.orders = response.data;
      }
      function error(error) {
    
      }
    }

    $scope.cancel = function (id) {
        if (confirm('Are you sure your want to cancel the order?')) {
          ajax.post(API_PORT+"api/CustomerOrder/cancel/" + id,
            function (response) {
              console.log(response);
            },
            function (err) {
              console.log(err);
              alert("cancelled");
              ajax.get(API_PORT+"api/CustomerOrder/" + $rootScope.UserId+"/GetAll", success, error);
             function success(response) {
                $scope.orders = response.data;
             }
             function error(error) {
    
            }
            }
          );
        }
      }
   
  });