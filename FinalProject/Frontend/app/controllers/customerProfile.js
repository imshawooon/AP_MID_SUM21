app.controller("customerProfile", function ($scope, $http, ajax, $rootScope,$location) {

    $rootScope.PageType = "seller";
    if ($rootScope.UserType != "Customer") {
        $location.path("/");
        return;
      }
    $scope.user=$rootScope;
    console.log($scope.user.UserName);
    $scope.edit = function (user) {
      
        console.log(user);
        console.log(user.name);
        var d = {
            name: user.UserName,
            email: user.UserEmail,
            password: user.UserPassword,
            phone: user.UserPhone,
        };
        console.log(d);

        ajax.post(API_PORT+"api/Customer/edit/"+$rootScope.UserId, d,
            function (response) {
                console.log(response);
                alert("edited");
            },
            function (err) {
                console.log(err);
            }
        );
    }
});
