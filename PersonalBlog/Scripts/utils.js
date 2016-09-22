function MoveTo(action, controller, paramObject) {
    window.location.href = ActionPath(action, controller, paramObject);
}

function ActionPath(action, controller, paramObject) {
    var host = window.location.host;

    var result = "http://" + host + "/" + controller + "/" + action + "/";

    if (paramObject != null && paramObject.length !== 0) {
        //Get all keys
        var array = new Array();
        for (var key in p) {
            if (p.hasOwnProperty(key)) {
                array.push(key + "=" + p[key]);
            }
        }

        //Write it
        result += "?" + array.join("&");
    }

    return result;
}

function ActionPathByUrl(url) {
    var host = window.location.host;

    if (url.charAt(0) !== '/')
        url = '/' + url;

    return "http://" + host + url;
}