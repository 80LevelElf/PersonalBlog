$(function () {
    $("#add-or-update-button").click(function() {
        var source = window.simpleMde.value();

        //Just check it
        var endIndexOfPreview = source.indexOf("$previewEnd$");
        if (endIndexOfPreview === -1) {
            alert("Не указанно $previewEnd$ !");
            return;
        }

        var postId = $("#md-editor").attr("data-post-id");

        $.ajax({
            type: "POST",
            url: ActionPath("AddOrUpdate", "Admin"),
            data: JSON.stringify(
            {
                PostId: postId,
                Source: source
            }),
            success: function (data) {
                //window.location.href = ActionPathByUrl(data);
            },
            contentType: "application/json"
        });
    });
});