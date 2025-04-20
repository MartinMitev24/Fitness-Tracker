$('#deleteExerciseForm').submit(function (e) {
    e.preventDefault();

    var exerciseId = $('#exerciseId').val();

    $.ajax({
        url: getExerciseIdURL,
        type: 'POST',
        data: {
            Id: exerciseId,
        },
        success: function (respons) {
            $('#deleteExercise').modal('hide');
            location.href = "/Exercise/All";
        },
        error: function (xhr, status, error) {
        }
    });
});