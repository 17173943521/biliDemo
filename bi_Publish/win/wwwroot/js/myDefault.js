


//Ajax
var myAjax = function (url, data, dataType, type) {
    var retInfo;
    $.ajax({
        url,
        data,
        dataType,
        type,

    }).done(function (info) {
        retInfo = info;
    })
    return retInfo;
}

//首页
//获取所有基础类型 并拼接部分影片
function GetTypeAll() {

    //清空
    $("#homeTypeList").empty();

    //请求数据
    $.ajax({
        url: '/AllFunction/GetTypeAll',
        data: '',
        dataType: 'json',
        type: 'get',

    }).done(function (info) {


        $("#homeTypeDetail").empty();
        $('[name="myListExample"]').empty();

        //拼接数据
        var navInfo = '<nav class="nav">';
        $(info).each(function (i, n) {
            if (n.parent == 0) {
                navInfo += '<a class="nav-link" href="javascript:ToDetail(' + n.id + ')">' + n.name + '</a>';
                $("#homeTypeDetail").append(
                    $(
                        '<div class="col-9" id="list-item-' + n.id + '">' +
                        '<div class="card" style="margin-top:20px;background-color:bisque;height:300px;">' +
                        '<a href="javascript:ToDetail(' + n.id + ')" style="font-size:30px;margin-left:20px;margin-top:20px;">' + n.name + '</a>' +
                        '<div class="row">' +
                        GetListFilm(n.id) +
                        '</div>' +
                        '</div>' +
                        '</div>' +
                        '<div class="col-3">' +
                        '<div class="card" style="margin-top:20px;background-color:bisque;height:300px;">' +
                        '<a href="javascript:ToDetail(' + n.id + ')" style="font-size:30px;margin-left:20px;margin-top:20px;">' + n.name + '</a>' +
                        '</div>' +
                        '</div>'
                    )
                );
                $('[name="myListExample"]').append(
                    $(
                        '<a  class="myfloat-text" href="#list-item-' + n.id + '">' + n.name + '</a>'
                    )
                );
            }
        })
        navInfo += '</nav>';
        $('[name="myListExample"]').append('<a id="TopShow" class="TopShow" href="javascript:ToTop()">TOP</a>')

        //添加数据
        $("#homeTypeList").append(navInfo);
    })

}

//首页
//回到顶部
function ToTop() {
    $('html,body').animate({ scrollTop: '0px' });
}

//首页
//跳转至详情页（播放页）
function ToDetail(id) {
    _setCookie('filmId', id, 1);
    location.href = '/Home/Detail';
}

//获取影片信息 - 用于拼接
var GetListFilm = function (id) {
    var divInfo = '';
    $.ajax({
        url: '/AllFunction/GetFilm?id=' + id,
        async: false,
        data: '',
        dataType: 'json',
        type: 'get',

    }).done(function (info) {
        $(info).each(function (i, n) {
            divInfo +=
                '<div class="col-2" style="max-height:70vh;">' +
                '<div class="card" >' +
                '<img src="http://localhost:54038/image/854937068.jpeg"  onclick="ToDetail(' + n.id + ')" style="width:100%;height:60%" />' +
                '<p>' + n.name + '</p>' +
                '<p><i class="iconfont icon-UPzhu"></i>' + n.uName + '</p>' +
                '</div>' +
                '</div>'
        })
    })
    return divInfo;
}

//影片详情页（播放）
//获取影片
function GetFilm(id) {
    $.ajax({
        url: '/AllFunction/GetFilmOne?id=' + id,
        data: '',
        dataType: 'json',
        type: 'get',

    }).done(function (info) {
        $('#videoShow').append('<source src="' + info.filmPath + '" type="video/mp4" />');
        $('#detailTitle').append(
            '<h4 class="bi-text-headline">' + info.name + '</h4>' +
            '<a class="bi-text-small">' + info.addTime + '</a><br/>' +
            '<a class="bi-text-small"><i class="iconfont icon-xiazaishibai"></i>未经作者授权，禁止转载</a>'
        )
    })
    //var info = myAjax('/AllFunction/GetFilmOne?id=' + id, '', 'json', 'get');
}








//初始化
//判断登录状态
$(function () {
    var uName = _getCookie('uName');
    if (uName == null) {
        $("#uLogin").empty();
        $("#uLogin").append(
            '<a class="nav-link" href="/User/Login">登录</a>' +
            '<a class="nav-link" href="/User/Register">注册</a>'
        )
    } else {
        $("#uLogin").empty();
        $("#uLogin").append(

            '<div class="dropdown">' +
            '<a href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
            '<img class="rounded-circle" src="http://localhost:54038//image/user_header.png" style="width:40px;height:40px;" />' +
            '</a>' +
            '<div class="dropdown-menu" aria-labelledby="dropdownMenuLink">' +
            ' <a>等级 进度条</a>' +
            ' <a>硬币数量 B币数量</a>' +
            '<a class="dropdown-item" href="#">关注 粉丝 动态</a>' +
            '<hr />' +
            '<div class="nav text-dark">' +
            '<a class="dropdown-item" href="/User/Index">个人中心</a>' +
            '<a class="dropdown-item" href="/User/Upload">投稿管理</a>' +
            '<a class="dropdown-item" href="#">B币钱包</a>' +
            '<a class="dropdown-item" href="#">订单中心</a>' +
            '</div>' +
            '<hr />' +
            '<a class="dropdown-item" href="javascript:UserExit()">退出</a>' +
            '</div>' +
            '</div>' +





            '<a class="nav-link" href="#">大会员</a>' +
            '<a class="nav-link" href="#">消息</a>' +
            '<a class="nav-link" href="/User/Publish">动态</a>' +
            '<a class="nav-link" href="/User/Collect">收藏</a>' +
            '<a class="nav-link" href="/User/WatchRecord">历史</a>' +
            '<a class="nav-link" href="#">创作中心</a>' +
            '<a class="btn btn-tougao" href="/User/Upload">投稿</a>'
        );

    }


    $("#img_userList").on({
        mouseover: function () {
            $("#btn_userList").click();
        },
        mouseout: function () {
            //$("#btn_userList").click();
        }
    })
})

//导航条
//退出登录
function UserExit() {
    _removeCookie('uName');
    _removeCookie('uImage');
    _removeCookie('uMotto');
    _removeCookie('uId');
    location.href = '/Home/Index';
}

//用户登录页
//用户登录 拼接导航条
function UserLogin() {
    var account = $("#account").val();
    var password = $("#password").val();
    $.ajax({
        url: '/AllFunction/Login',
        data: {
            account, password
        },
        dataType: "text",
        type: "get"
    }).done(function (result) {
        if (result == undefined) {
            alert('用户名错误');
        } else if (result.account = undefined) {
            alert('密码错误');
        } else {
            _setCookie('uName', result.name, 7);
            _setCookie('uImage', result.image, 7);
            _setCookie('uMotto', result.motto, 7);
            _setCookie('uId', result.id, 7);
            location.href = '/Home/Index';
        }
    });

    //$.ajax({
    //    url: '/AllFunction/Login',
    //    data: {
    //        account: $("#account").val(),
    //        password: $("#password").val()
    //    },
    //    dataType: 'json',
    //    type:'get'
    //}).done(function (ret) {
    //    alert(ret);
    //    //if (ret == null) {

    //    //} else if (ret.account == null) {

    //    //} else {
    //    //    _setCookie('userId', ret.ID, 7);
    //    //    _setCookie('userName', ret.name, 7);
    //    //    _setCookie('userImage', ret.image, 7);
    //    //    _setCookie('userMotto', ret.motto, 7);
    //    //}
    //})
}



//用户历史记录
function UserHistory() {
    $('#userHistory').empty()
    var data = myAjax('/All/', '', 'json', 'get');
    $(data).each(function (i, n) {
        $('#userHistory').append(
            //开始
            '<div class="row" style="height:150px;">' +
            //左 竖线
            '<div class="col-1" style="border-right:1px solid  #e5e9ef;height:200px;"></div>' +
            //中 时间
            '<div class="col-2">' +
            '<div class="bi-mt-50">' +
            '<span class="bi-text-small">' + n.createTime + '</span>' +
            '</div>' +
            '</div>' +
            //右 详情
            '<div class="col-9">' +
            //右 详情 开始
            '<div class="row">' +
            //右 详情 图
            '<div class="col-3" style="height:150px;">' +
            '<a class=" bi-mt-10" href="#"><img src="' + n.FilmImage + '" class="border border-secondary rounded" style="width:100%;height:90%;" /></a>' +
            '</div>' +
            //右 详情 标题 & UP & 分类
            '<div class="col-8">' +
            '<a href="#" class="bi-mt-10 bili-text-20">' + n.FilmName + '</a>' +
            '<p class="bi-mt-60">' +
            '<a href="#" class="bi-text-small">使用什么看的</a>' +
            '<a href="#" class="bi-text-small" style="margin-left:40%;">up主</a><i class="bi-ml-10">|</i><a class="bi-text-small" href="#">分类</a>' +
            '</p>' +
            '<hr />' +
            '</div>' +
            //右 详情 删除按钮
            '<div class="col-1">' +
            '<div class="bi-mt-50">' +
            '<a href="#"><i class="iconfont icon-shanchu bili-text-26"></i></a>' +
            '</div>' +
            '</div>' +
            //右 详情 删除按钮
            '</div>' +
            //右 详情 结束
            '</div>' +
            //结束
            '</div>'
        )

    })
}