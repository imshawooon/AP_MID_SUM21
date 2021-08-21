app.controller("login", function ($scope, ajax, $rootScope, $location) {
  if ($rootScope.isUserLoggedIn) {
    $location.path("/");
    return;
  }
  $rootScope.PageType = "login";
  console.log($rootScope.PageType);
  $scope.login = function (user) {
    // console.log("ashsi");
    // console.log($scope.Email);
    // console.log($rootScope.UserType);

    ajax.post(
      "https://localhost:44384/api/Login",
      user,
      function (response) {
        // console.log(response);
        $scope.user = response.data;
        if ($scope.user == null) {
          alert("Invalid Email and Password");
        } else {
          //set id value and type value
          $rootScope.UserId = $scope.user.userid;
          $rootScope.UserType = $scope.user.usertype;
          $rootScope.UserName = $scope.user.name;
          $rootScope.UserPassword = $scope.user.password;
          $rootScope.UserPhone = $scope.user.phone;
          $rootScope.UserEmail = $scope.user.email;
          localStorage.setItem("user", JSON.stringify($scope.user));
          // console.log($rootScope.UserName);
          //set login status
          if ($scope.user.usertype == "Seller") {
            $rootScope.isUserLoggedIn = true;
            $location.path("/SellerHome");
          }
          else if ($scope.user.usertype == "Manager") {
            $rootScope.isUserLoggedIn = true;
            $location.path("/ManagerHome");
          } else if ($scope.user.usertype == "Admin") {
            $rootScope.isUserLoggedIn = true;
            $location.path("/admin");
          } else if ($scope.user.usertype == "Customer") {
            $rootScope.isUserLoggedIn = true;
            $location.path("/customer/dashboard");
          }
        }
      },
      function (err) {
        alert(err);
      }
    );
  };
});
