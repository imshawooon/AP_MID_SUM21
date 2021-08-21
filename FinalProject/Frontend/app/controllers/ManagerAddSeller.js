app.controller("ManagerAddSeller", function ($scope, ajax, $rootScope) {
    // alert($rootScope.isUserLoggedIn);
    $rootScope.UserType = "Manager";
    $rootScope.PageType = "seller";
  
    $scope.addseller = function () {
      console.log($scope.Name);
      if($scope.Name!=undefined||$scope.Status!=undefined||$scope.Email!=undefined||$scope.Password!=undefined||$scope.Image!=undefined||$scope.Phone!=undefined){
      var d = {
        name: $scope.Name,
        status: $scope.Status,
        email: $scope.Email,
        password: $scope.Password,
        image: $scope.Image,
        phone: $scope.Phone
      };
      console.log($rootScope.UserId);
      ajax.post("https://localhost:44384/api/Seller/Add/"+$rootScope.UserId, d,
        function (response) {
          alert("Seller added");
        },
        function (err) {
          console.log(err);
        });
      }
      else{
        alert("Fill up all fields");
      }
    };
  });