$(function () {
    var sourceElements = $("div.post-wrapper div.source");

    sourceElements.each(function(index, currentSourceElement) {
        var currentSource = $(currentSourceElement);
        currentSource.html(markdown.toHTML(currentSource.html().trim(), "Maruku"));
    });
});