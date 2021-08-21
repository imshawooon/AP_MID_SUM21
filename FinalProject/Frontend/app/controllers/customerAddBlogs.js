app.controller("customerAddBlogs", function ($scope, ajax, $rootScope,$location) {
  
  $rootScope.PageType = "seller";
  if ($rootScope.UserType != "Customer") {
    $location.path("/");
    return;
  }
    $scope.addBlog = function (blog) {
     
      ajax.post(API_PORT+"api/Blogs/add/"+$rootScope.UserId, blog,
        function (response) {
          alert("Blog added");
        },
        function (err) {
          console.log(err);
        });
      
     
    };
  });