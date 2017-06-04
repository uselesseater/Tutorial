angular
    .module("Questionnaire.ctrl.QandA", [])
    .controller("QandAController",
    [
        "$http", "$scope", "$location", "$routeParams", "$log", "$window",
        function ($http,
            $scope,
            $location,
            $routeParams,
            $log,
            $window) {

            $scope.questTitle = "";
            $scope.questions = [];
            
            $scope.loadQuestions = function () {
                $http.get($("#wsbasehref").val())
                    .then(function (data) {
                        $scope.questTitle = data.data.QuestionnaireTitle;
                        $scope.questions = [];
                        for (var i = 0; i < data.data.QuestionsText.length; i++) {
                            $scope.questions.push(data.data.QuestionsText[i]);
                        }
                    });
            }

            $scope.loadQuestions();

        }
    ]);
    

