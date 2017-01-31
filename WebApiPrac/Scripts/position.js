(function () {
    angular.module("result",[])
    .controller("position", function ($scope, $http) {

        $scope.getdata = function () {

            $http.get('http://localhost:1818/api/Position').success(function (data) {
                alert("getdata called successfully!!");
                console.log("data");
                $scope.datas = data
                

            }).error(function (data) {
                $scope.error = "An error has occured while adding! " + data;
            });

        };
        $scope.getdata();



    });

  


}());