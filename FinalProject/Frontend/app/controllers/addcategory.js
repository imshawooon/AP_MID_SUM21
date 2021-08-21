app.controller("addcategory",function($scope,ajax){

    $scope.addcategory = function(){
        //$scope.Name
        var d = {
          id:$scope.Id,
          name:$scope.Name
        };
        ajax.post("https://localhost:44365/api/Category/Add",d,
        function(response){

        },
        function(err){

        });
    };
});