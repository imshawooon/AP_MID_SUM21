app.controller("customerAddOrder", function ($scope, ajax, $rootScope, $routeParams,$location) {
  
  $rootScope.PageType = "seller";
  if ($rootScope.UserType != "Customer") {
    $location.path("/");
    return;
  }
    $scope.addOrder = function (order) {
       
      ajax.post(API_PORT+"api/CustomerOrder/Add/"+$rootScope.UserId+"/"+$routeParams.id, order,
        function (response) {
          alert("Order added");
        },
        function (err) {
          console.log(err);
        });
       
     
    };
    var packid = $routeParams.id;
    ajax.get(API_PORT + "api/Package/" + packid, success, error);
    function success(response) {
        $scope.pack = response.data;
        console.log(response.data);
      
      }
      function error(error) {
        console.log(error);
      }
  });