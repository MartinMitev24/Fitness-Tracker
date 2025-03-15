$('#deleteWorkout').on('show.bs.modal', function (e) {
    var workoutId = $(e.relatedTarget).data('id');
    $('#workoutId').val(workoutId);
})