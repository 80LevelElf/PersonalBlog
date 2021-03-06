﻿function preparePostsOnPage() {
    var sourceElements = $("div.post-wrapper div.source");

    sourceElements.each(function (index, currentSourceElement) {
        var currentSource = $(currentSourceElement);
        currentSource.html(markdown.toHTML(currentSource.text().trim(), "Maruku"));
    });

    $("div.post-wrapper div.source code").each(function (index, block) {
        hljs.highlightBlock(block);
    });
}