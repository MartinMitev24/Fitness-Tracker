$('#addExerciseForm', function () {
    var muscleGroup = $('#muscleGroup');
    var exercises = $('#exerciseId').children();

    muscleGroup.on('change', function () {

        exercises.each(function (index, element) {
            var firstElement = exercises.first();
            console.log(firstElement);

            if (muscleGroup.val() === 'none') {
                $(element).show();
            } else {
                if ($(element).attr('data-muscleGroup') != muscleGroup.val()) {
                    $(element).hide();
                } else {
                    $(element).show();
                }
            }

            firstElement.show();
            $('#exerciseId').val('none');
        });
    });
});