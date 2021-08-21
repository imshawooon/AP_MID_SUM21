// app.controller("orderdetails", function ($scope, $http, ajax, $routeParams) {
//     var id = $routeParams.id;
//     ajax
//       .get("https://localhost:44367/api/Order/info/" + id, success, error);
//     function success(response) {
//       $scope.productOrders = response.data;
//       $scope.total = 0;
//       $scope.productOrders.forEach((item) => {
//         $scope.total += item.quantity * item.price;
//       });
//      // $scope.order = response.data;
//     }
//     function error(error) {
//       console.log(error);
//     }
// });
//var app =angular.module('app',['ngRoute'])

app.controller("orderdetails", function ($scope, $http, ajax, $routeParams) {

    ajax.get("https://localhost:44365/api/Order/info/"+ $routeParams.id, success, error);
    function success(response) {
        $scope.productOrders = response.data;

        $scope.total = 0;
        $scope.productOrders.forEach((item) => {
            $scope.total += item.quanitity * item.price;
        });
        ajax.get("https://localhost:44365/api/Order/"+ $routeParams.id, success, error);
        function success(response) {
            $scope.order = response.data;
        }
    
        function error(error) {
            console.log(error);
        }
    }

    function error(error) {
        console.log(error);
    }




  });