$(function () {
    $("#add-or-update-button").click(function() {
        var source = window.simpleMde.value();

        //Checking
        var endIndexOfPreview = source.indexOf("$previewEnd$");
        if (endIndexOfPreview === -1) {
            alert("Не указанно $previewEnd$ !");
            return;
        }

        var title = $("#title").val();
        if (!title) {
            alert("Не введен заголовок!");
            return;
        }

        var postId = $("#md-editor").attr("data-post-id");
        var updateCreationDate = $("#update-creation-date").is(':checked');

        $.ajax({
            type: "POST",
            url: ActionPath("AddOrUpdate", "Admin"),
            data: JSON.stringify(
            {
                PostId: postId,
                Source: source,
                Title: title,
                UpdateCreationDate: updateCreationDate
            }),
            success: function (data) {
                window.location.href = ActionPathByUrl(data);
            },
            error: function(xhr, status, error) {
                alert(xhr.responseText);
            },
            contentType: "application/json"
        });
    });
});