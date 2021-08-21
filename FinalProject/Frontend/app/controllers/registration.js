app.controller("registration", function ($scope, $http, ajax, $location, $rootScope) {
  $rootScope.PageType = "admin";
  $scope.usertypes = ["Seller", "Customer"];

  // $rootScope.UserType = "Admin";
  $scope.createUser = function (user) {

      console.log(user);
      if (user.password != user.cpassword) {
          $scope.passError = "Passwords Dont Match";
      }
      else {
          ajax.post(API_PORT + "api/registration", user,
              function (response) {
                  console.log(response);
                  alert("Congratulations!Welcome to ANTS TOURISM!Please login to Explore!")
                  $location.path("/login");
              },
              function (err) {
                  console.log(err);
              });
      }
  };
});