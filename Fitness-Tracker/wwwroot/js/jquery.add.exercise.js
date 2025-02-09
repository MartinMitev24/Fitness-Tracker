$('#addExerciseForm').submit(function (e) {
    e.preventDefault();

    var exerciseId = $('#exerciseId').val();
    var weight = $('#weight').val();
    var reps = $('#reps').val();
    var sets = $('#sets').val();
    var time = $('#time').val();

    console.log(exerciseId);
    console.log(weight);
    console.log(reps);
    console.log(sets);
    console.log(time);

    $.ajax({
        url: addExerciseUrl,
        type: 'POST',
        data: {
            exerciseId: exerciseId,
            weight: weight,
            reps: reps,
            sets: sets,
            time: time
        },
        success: function (respons) {
            $('#addExerciseToWorkout').modal('hide');
            location.reload();
        },
        error: function (xhr, status, error) {
        }
    });
});