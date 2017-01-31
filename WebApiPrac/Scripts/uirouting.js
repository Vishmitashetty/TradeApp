//angular
//	.module('Viewer', ['ui.router'])

//	.config(function ($stateProvider, $urlRouterProvider) {
//	    $stateProvider
//			.state('Security', {

//			    url: '/Security',
//			    templateUrl: 'Security.html',
//			    controller: 'myapp'
//			})

//			.state('Trade', {

//			    url: '/Trade',
//			    templateUrl: 'Trade.html',
//			    controller: 'tradeCtrl'
//			})

//			.state('position', {
//			    url: '/position',
//			    templateUrl: 'position.html',
//			    controller: 'position'
//			})

//	    .controller('myapp', function ($scope, $http) {


//	        $scope.add = function () {
//	            try {
//	                $scope.Security = {

//	                    Ticker: $scope.ticker,
//	                    CUSIP: $scope.cusip,
//	                    ISIN: $scope.isin,
//	                    SEDOL: $scope.sedol

//	                };
//	                console.log($scope.Security);

//	                $http.post('http://localhost:1818/api/Security/PostProduct', $scope.Security).success(function (data) {
//	                    alert("Added successfully!!");
//	                    ClearFields();
//	                }).error(function (data) {
//	                    $scope.error = "An error has occured while adding! " + data;
//	                });
//	            }
//	            catch (ex) {
//	                console.log(ex);
//	            }
//	        };
//	        $scope.get = function () {

//	            $http.get('http://localhost:1818/api/Security/GetAllProducts').success(function (data) {
//	                alert("Added successfully!!");
//	                $scope.OptionData = data
//	                console.log(data);

//	            }).error(function (data) {
//	                $scope.error = "An error has occured while adding! " + data;
//	            });


//	        };

//	        function ClearFields() {
//	            $scope.ticker = "";
//	            $scope.cusip = "";
//	            $scope.isin = "";
//	            $scope.sedol = "";
//	        }


//	    })
//	   .controller('tradeCtrl', function ($scope, $http) {

//	        $scope.get = function () {

//	            $http.get('http://localhost:1818/api/Security/GetAllProducts').success(function (data) {
//	                alert("Added successfully!!");
//	                $scope.OptionDatas = [];
//	                $scope.OptionDatas = data;
//	                console.log($scope.OptionDatas);
//	                console.log($scope.OptionDatas[1]);

//	            }).error(function (data) {
//	                $scope.error = "An error has occured while adding! " + data;
//	            });


//	        };



//	        $scope.get();

//	        $scope.add = function () {
//	            $scope.Trade = {

//	                SecurityId: $scope.secid,
//	                TransactionType: $scope.tt,
//	                Price: $scope.price,
//	                Quantity: $scope.quantity,
//	                TradeDate: $scope.tradedate

//	            };
//	            console.log($scope.Trade);

//	            $http.post('http://localhost:1818/api/Trade/PostProduct', $scope.Trade).success(function (data) {
//	                alert("Added successfully!!");
//	                ClearFields();
//	            }).error(function (data) {
//	                $scope.error = "An error has occured while adding! " + data;
//	            });
//	        };

//	        $scope.get = function () {

//	            //$http.get('http://localhost:1818/api/Security/GetAllProducts').success(function (data) {
//	            //    alert("Added successfully!!");
//	            //    $scope.OptionDatas = [];
//	            //    $scope.OptionDatas = data;
//	            //    console.log($scope.OptionDatas);
//	            //    console.log($scope.OptionDatas[1]);

//	            //}).error(function (data) {
//	            //    $scope.error = "An error has occured while adding! " + data;
//	            //});


//	        };

//	        function ClearFields() {
//	            $scope.secid = "";
//	            $scope.tt = "";
//	            $scope.price = "";
//	            $scope.quantity = "";
//	            $scope.tradedate = "";
//	        }


//	    })
//	    .controller('position', function ($scope, $http) {

//	        $scope.getdata = function () {

//	            $http.get('http://localhost:1818/api/Position').success(function (data) {
//	                alert("getdata called successfully!!");
//	                console.log("data");
//	                $scope.datas = data


//	            }).error(function (data) {
//	                $scope.error = "An error has occured while adding! " + data;
//	            });

//	        };
//	        $scope.getdata();



//	    });
//	});