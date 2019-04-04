<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GerenCenter.aspx.cs" Inherits="GerenCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="https://cdn.bootcss.com/normalize/8.0.1/normalize.min.css"/>
     <link rel="stylesheet" href="css/gerencenter.css"/>
    <title>个人中心</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="top clearf">
        
       <span class="item">HR-X</span>
        <span class="item2">退出</span>
        <span class="item2"><iframe width="420" scrolling="no" height="60" frameborder="0" allowtransparency="true" src="//i.tianqi.com/index.php?c=code&id=12&icon=1&num=5&site=12"></iframe></span>
    </div>
    <div class="content clearf ">
        <div class="wenzi1">
            <span>您好！</span>
            <span class="wenzi2">admin(站长)</span>
            <span>您目前有15条待办，2条异常考勤，2条通知！</span>
            <span class="fr" id="localtime" style="padding-right:20px;">
                <script type="text/javascript">             //动态时钟
           function clock()
           {
             var str = "";
             var date = new Date();//获取日期
             nowYear = date.getFullYear();//年份
             nowMonth = date.getMonth() + 1;//getMonth返回值为0-11，所以要加1
               if (nowMonth < 10) nowMonth = '0' + nowMonth;
             nowDate = date.getDate();//日子
               if (nowDate < 10) nowDate = '0' + nowDate;
             nowHour = date.getHours();
               if (nowHour < 10) nowHour = '0' + nowHour;
             nowMinute = date.getMinutes();
               if (nowMinute < 10) nowMinute = '0' + nowMinute;//不够10分钟前面加个0
             nowSecond = date.getSeconds();
               if (nowSecond < 10) nowSecond = '0' + nowSecond;
             nowWeek = date.getDay();//获取周几

             var week;
             switch (nowWeek)
             {
                 case 1:
                     week = "星期一";
                     break;
                 case 2:
                     week = "星期二";
                     break;
                 case 3:
                     week = "星期三";
                     break;
                 case 4:
                     week = "星期四";
                     break;
                 case 5:
                     week = "星期五";
                     break;
                 case 6:
                     week = "星期六";
                     break;
                 case 0:
                     week = "星期日";
                     break;
                 default:
                     break;
             }
             str = +nowYear + "年" + nowMonth + "月" + nowDate + "日 " + nowHour + ":" + nowMinute + ":" + nowSecond + "  " + week
             return (str);
            
         }
           function tick() {              
               document.getElementById("localtime").innerHTML = clock();
               window.setTimeout("tick()", 1000);
           }
           tick();
         </script>
            </span>
        </div>

      <div class="kuai">
          <div class="col-1">我要请假</div>
          <div class="col-1">我要加班</div>
          <div class="col-1">我的工资</div>

      </div>
       <input type="text" id="test1">
<script src="JavaScript/layDate-v5.0.9/laydate/laydate.js"  charset="utf-8"></script> <!-- 改成你的路径 -->
<script>
//执行一个laydate实例
laydate.render({
  elem: '#test1' //指定元素
});
</script>
       


  
    </div>
 <div class="footer clearf ">
    <span>声明：版权所有 侵权必究 未经作者允许，不得随意转载 懒得团队-郑晓荣</span>
     <span>E-mail:1778595505@qq.com  |  Tel:17854172240</span>
 </div>
    </form>
</body>
</html>
