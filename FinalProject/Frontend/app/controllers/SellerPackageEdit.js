app.controller("SellerPackageEdit", function ($scope, $http, ajax, $routeParams) {
    ajax.get("https://localhost:44384/api/Package/edit/" + $routeParams.id, success, error);
    function success(response) {
        $scope.packages = response.data;
        console.log($scope.packages);
        console.log("ashsi");
    }
    function error(error) {

    }

    $scope.edit = function (package) {
        console.log("ashshi");
        console.log(package);
        var d = {
            packagename: package.packagename,
            price: package.price,
            category: package.category,
            details: package.details,
            discount: package.discount,
            advertisement: package.advertisement,
            location: package.location,
        };
        console.log(d);

        ajax.post("https://localhost:44384/api/Package/edit/" + $routeParams.id, d,
            function (response) {
                console.log(response);
                alert("edited");
            },
            function (err) {
                console.log(err);
            });
    };




});


