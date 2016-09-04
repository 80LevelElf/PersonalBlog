﻿$(function () {
    var simplemde = new SimpleMDE({
        autosave: {
            enabled: true,
            uniqueId: "admin", //I'm the only one user of it
            delay: 10000,
        },
        blockStyles: {
            bold: "__",
            italic: "_"
        },
        element: document.getElementById("#md-editor"),
        indentWithTabs: false,
        insertTexts: {
            horizontalRule: ["", "\n\n-----\n\n"],
            image: ["![](http://", ")"],
            link: ["[", "](http://)"],
            table: ["", "\n\n| Column 1 | Column 2 | Column 3 |\n| -------- | -------- | -------- |\n| Text     | Text      | Text     |\n\n"],
        },
        lineWrapping: false,
        parsingConfig: {
            allowAtxHeaderWithoutSpace: true,
            strikethrough: false,
            underscoresBreakWords: true,
        },
        showIcons: ["code", "table"],
        placeholder: "Type here...",
        previewRender: function (plainText) {
            return markdown.toHTML(plainText, "Maruku");
        },
        /*previewRender: function (plainText, preview) { // Async method
            setTimeout(function () {
                preview.innerHTML = customMarkdownParser(plainText);
            }, 250);

            return "Loading...";
        },*/
        promptURLs: true,
        renderingConfig: {
            singleLineBreaks: false,
            codeSyntaxHighlighting: true
        },
        //styleSelectedText: false,
        tabSize: 4
    });
});