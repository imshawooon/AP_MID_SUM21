app.controller("ManagerSellerEdit", function ($scope, $http, ajax, $routeParams) {
    $rootScope.UserType = "Manager";
    $rootScope.PageType = "seller";

    ajax.get("https://localhost:44384/api/Seller/edit/" + $routeParams.id, success, error);
    function success(response) {
        $scope.user = response.data[0];
        console.log($scope.user);
        console.log("ashsi");
    }
    function error(error) {

    }

    $scope.edit = function (user) {
        console.log("ashshi");
        console.log(user);
        var d = {
            name: user.name,
            status: user.status,
            email: user.email,
            password: user.password,
            image: user.image,
            phone: user.phone,
        };
        console.log(d);

        ajax.post("https://localhost:44384/api/Seller/edit/" + $routeParams.id, d,
            function (response) {
                console.log(response);
                alert("edited");
            },
            function (err) {
                console.log(err);
            });
    };




});


