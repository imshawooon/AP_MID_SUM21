app.controller("ManagerHome", function ($scope, ajax, $rootScope) {
    $rootScope.UserType = "Manager";
    $rootScope.PageType = "seller";

    console.log($rootScope.UserName);
    $scope.name = $rootScope.UserName;
    console.log($scope.name);
    $scope.id = $rootScope.UserId;
    $scope.type = $rootScope.UserType;
});