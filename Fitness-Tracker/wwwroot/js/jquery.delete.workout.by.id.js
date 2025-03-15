$('#deleteWorkoutForm').submit(function (e) {
    e.preventDefault();

    var workoutId = $('#workoutId').val();

    $.ajax({
        url: getWorkoutIdURL,
        type: 'POST',
        data: {
            Id: workoutId,
        },
        success: function (respons) {
            $('#deleteWorkout').modal('hide');
            location.href = "/Workout/All";
        },
        error: function (xhr, status, error) {
        }
    });
});