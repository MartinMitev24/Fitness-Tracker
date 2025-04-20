$('#deleteExercise').on('show.bs.modal', function (e) {
    var exerciseId = $(e.relatedTarget).data('id');
    $('#exerciseId').val(exerciseId);
})