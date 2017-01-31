(function () {

    angular.module("Viewer",[])
    .controller("tradeCtrl", function ($scope, $http) {

        $scope.get = function () {

            $http.get('http://localhost:1818/api/Security/GetAllProducts').success(function (data) {
                alert("Added successfully!!");
                $scope.OptionDatas = [];
                $scope.OptionDatas = data;
                console.log($scope.OptionDatas);
                console.log($scope.OptionDatas[1]);

            }).error(function (data) {
                $scope.error = "An error has occured while adding! " + data;
            });

       
    };



        $scope.get();

        $scope.add = function () {
            $scope.Trade = {

                SecurityId: $scope.secid,
                TransactionType: $scope.tt,
                Price: $scope.price,
                Quantity: $scope.quantity,
                TradeDate: $scope.tradedate

            };
            console.log($scope.Trade);

            $http.post('http://localhost:1818/api/Trade/PostProduct', $scope.Trade).success(function (data) {
                alert("Added successfully!!");
                ClearFields();
            }).error(function (data) {
                $scope.error = "An error has occured while adding! " + data;
            });
        };

        $scope.get = function () {

            //$http.get('http://localhost:1818/api/Security/GetAllProducts').success(function (data) {
            //    alert("Added successfully!!");
            //    $scope.OptionDatas = [];
            //    $scope.OptionDatas = data;
            //    console.log($scope.OptionDatas);
            //    console.log($scope.OptionDatas[1]);

            //}).error(function (data) {
            //    $scope.error = "An error has occured while adding! " + data;
            //});


        };

        function ClearFields() {
            $scope.secid = "";
            $scope.tt = "";
            $scope.price = "";
            $scope.quantity = "";
            $scope.tradedate = "";
        }


    });


}());