(function () {
    'use strict';

    var app = angular.module('app', [
        'ui.router'
    ]);

    /**
     * #1   Create a LayoutController
     * Syntax:
     * app.controller('ControllerName', fn);
     */
    app.controller('HomeController', HomeController);

    function HomeController() {
        var vm = this;

        vm.title = "Technical Afternoon Angular Demo";

        vm.sessions = [{ title: "Future of asp.net", speaker: "Steve Cleynen", type: "web" },
                       { title: "Clean Architecture", speaker: "Christophe De Baene", type: "architecture" },
                       { title: "Xamarin", speaker: "Nico Vermeir", type: "mobile" }];
    }

}());
