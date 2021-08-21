app.controller("customerShowBlogs", function ($scope, $http, ajax,$rootScope,$location) {
  $rootScope.PageType = "seller";
  if ($rootScope.UserType != "Customer") {
    $location.path("/");
    return;
  }
    ajax.get(API_PORT+"api/Blogs/" + $rootScope.UserId+"/GetAll", success, error);
    function success(response) {
      $scope.blogs = response.data;
    }
    function error(error) {
  
    }

    $scope.delete = function (id) {
        if (confirm('Are you sure your want to delete?')) {
          ajax.post(API_PORT+"api/Blogs/delete/" + id,
            function (response) {
              console.log(response);
            },
            function (err) {
              console.log(err);
              alert("deleted");
              ajax.get(API_PORT+"api/Blogs/" + $rootScope.UserId+"/GetAll", success, error);
              function success(response) {
                $scope.blogs = response.data;
              }
              function error(error) {
            
              }
            }
          );
        }
      }
  });