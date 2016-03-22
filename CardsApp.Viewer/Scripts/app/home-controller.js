(function () {
    'use strict';

    angular
        .module('app')
        .controller('homeController', homeController);

    homeController.$inject = ['$scope', '$http', '$location'];

    function homeController($scope, $http, $location) {
    	$scope.cards = ['a','b','c'];
    }
})();
