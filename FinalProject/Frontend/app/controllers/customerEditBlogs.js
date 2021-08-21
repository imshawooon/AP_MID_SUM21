app.controller("customerEditBlogs", function ($scope, $http, ajax, $routeParams, $rootScope,$location) {
    $rootScope.PageType = "seller";
    if ($rootScope.UserType != "Customer") {
        $location.path("/");
        return;
      }
    ajax.get(API_PORT+"api/Blog/edit/" + $routeParams.id, success, error);
    function success(response) {
        $scope.blogs = response.data;
        console.log($scope.blogs);
    }
    function error(error) {

    }

    $scope.edit = function (blog) {
      
        console.log(blog);
        var d = {
            blog1: blog.blog1,
        };
        console.log(d);

        ajax.post(API_PORT+"api/Blog/edit/" + $routeParams.id, d,
            function (response) {
                console.log(response);
                alert("edited");
            },
            function (err) {
                console.log(err);
            });
    };
});


