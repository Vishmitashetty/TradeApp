(function () {

    angular.module("security",[])
    .controller("myapp", function ($scope, $http) {


        $scope.add = function () {
            try{
                $scope.Security = {

                    Ticker: $scope.ticker,
                    CUSIP: $scope.cusip,
                    ISIN: $scope.isin,
                    SEDOL: $scope.sedol

                };
                console.log($scope.Security);

                $http.post('http://localhost:1818/api/Security/PostProduct', $scope.Security).success(function (data) {
                    alert("Added successfully!!");
                    ClearFields();
                }).error(function (data) {
                    $scope.error = "An error has occured while adding! " + data;
                });
            }
            catch (ex) {
                console.log(ex);
            }
        };
        $scope.get = function () {

            $http.get('http://localhost:1818/api/Security/GetAllProducts').success(function (data) {
                alert("Added successfully!!");
                $scope.OptionData = data
                console.log(data);

            }).error(function (data) {
                $scope.error = "An error has occured while adding! " + data;
            });


        };

        function ClearFields() {
            $scope.ticker = "";
            $scope.cusip = "";
            $scope.isin = "";
            $scope.sedol = "";
        }


    });


}());