$(function () {
    var editor = $("#md-editor");

    var canTurnOnAutosave = false;
    if (!editor || editor.val())
        canTurnOnAutosave = true;

    var initialValue = "\n\n$previewEnd$";
    if (editor && editor.val())
        initialValue = editor.val();

    window.simpleMde = new SimpleMDE({
        initialValue: initialValue,
        autosave: {
            enabled: canTurnOnAutosave,
            uniqueId: "admin", //I'm the only one user of it
            delay: 5000
        },
        blockStyles: {
            bold: "__",
            italic: "_"
        },
        element: document.getElementById("md-editor"),
        indentWithTabs: false,
        insertTexts: {
            horizontalRule: ["", "\n\n-----\n\n"],
            image: ["![](http://", ")"],
            link: ["[", "](http://)"],
            table: ["", "\n\n| Column 1 | Column 2 | Column 3 |\n| -------- | -------- | -------- |\n| Text     | Text      | Text     |\n\n"]
        },
        lineWrapping: false,
        parsingConfig: {
            allowAtxHeaderWithoutSpace: true,
            strikethrough: false,
            underscoresBreakWords: true,
        },
        showIcons: ["table"],
        placeholder: "Type here...",
        previewRender: function (plainText) {
            return markdown.toHTML(plainText, "Maruku");
        },
        promptURLs: true,
        renderingConfig: {
        singleLineBreaks: false,
        codeSyntaxHighlighting: true
        },
        //styleSelectedText: false,
        tabSize: 4
    });
});