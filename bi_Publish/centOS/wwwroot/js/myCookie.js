
//设置cookie

var _setCookie = function (name, value, days) { // days为保存时间长度

    var date = new Date()
    //$.cookie()
    date.setDate(date.getDate() + days)

    document.cookie = name + '=' + value + ';expires=' + date + ';path=/';

};

//获取cookie

var _getCookie = function (name) {

    var arr = document.cookie.split(';');

    for (var i = 0; i < arr.length; i++) {

        arr[i] = arr[i].replace(/^\s*/, '');

        var arr2 = arr[i].split('=');

        if (arr2[0] == name) {

            return arr2[1]

        }

    }

    return null

};



//删除cookie

var _removeCookie = function (name) {

    _setCookie(name, 1, -1) // -1代表昨天过期，系统自动删除

};


/**
     * 删除cookie
     * @param name cookie的名称
     */
var delCookie = function (name) {
    setCookie(name, ' ', -1);
};




/**
     * 获取对应名称的cookie
     * @param name cookie的名称
     * @returns {null} 不存在时，返回null
     */
var getCookie = function (name) {
    var arr;
    var reg = new RegExp("(^| )" + name + "=([^;]*)(;|$)");
    if (arr = document.cookie.match(reg))
        return unescape(arr[2]);
    else
        return null;
};


/**
     * 设置cookie
     * @param name cookie的名称
     * @param value cookie的值
     * @param day cookie的过期时间
     */
var setCookie = function (name, value, day) {
    if (day !== 0) {     //当设置的时间等于0时，不设置expires属性，cookie在浏览器关闭后删除
        var expires = day * 24 * 60 * 60 * 1000;
        var date = new Date(+new Date() + expires);
        document.cookie = name + "=" + escape(value) + ";expires=" + date.toUTCString();
    } else {
        document.cookie = name + "=" + escape(value);
    }
};