app.controller("showcategories", function ($scope, $http, ajax) {
    ajax.get("https://localhost:44365/api/Category/GetAll", success, error);
    function success(response) {
      $scope.categories = response.data;
    }
    function error(error) {}
  });