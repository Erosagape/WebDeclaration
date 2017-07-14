
function JSDate(jsonDateString) {
    try {
        var jsDate = new Date(parseInt(jsonDateString.replace('/Date(', '')));
        var month = jsDate.getMonth() + 1;
        var day = jsDate.getDate();
        var year = jsDate.getFullYear();
        if (month <= 9) month = '0' + month;
        if (day <= 9) day = '0' + day;
        var date = year + "-" + month + "-" + day;
        return date;
    }
    catch (e) {
        return '';
    }
}
function JSTime(jsonDateString) {
    try {
        var jsDate = new Date(parseInt(jsonDateString.replace('/Date(', '')));
        var hour = jsDate.getHours();
        var min = jsDate.getMinutes();
        var sec = jsDate.getSeconds();
        if (hour <= 9) hour = '0' + hour;
        if (min <= 9) min = '0' + min;
        if (sec <= 9) sec = '0' + sec;
        var date = hour + ":" + min + ":" + sec;
        return date;
    }
    catch (e) {
        return '';
    }
}