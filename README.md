# DDO_QuickLogin
+ Dungeons and Dragons Online Quick Login Client
+ 龙与地下城OL 快速登陆客户端
+ [下载(QuickLogin.exe)](../../raw/master/dist/QuickLogin.exe)
+ 支持Windows XP ，Windows Server 2003 ，Windows Vista，Windows 7，8，10。
+ 本程序运行需要.NET Framework 支持，不限定特定版本, 如不能运行请安装[.NET Framework 3.5 Service Pack 1（完整程序包）](http://download.microsoft.com/download/2/0/e/20e90413-712f-438c-988e-fdaa79a8ac3d/dotnetfx35.exe)
+ 近日有小伙伴反馈使用个别群里别有用心之人编译的快登版本后出现账号丢失,在这里我提醒大家从官网下载, 在这里我承诺代码安全,不存在任何后门, 并且开源所有代码, 接受大家监督,发行版应用程序永不加壳,不含任何木马,不放心的朋友可以使用C#反编译软件检查,或是下载源码自己编译, DDO快登也有将近10年的使用历史了, 口碑还是有保障的.

### 功能
+ 跳过下载壁纸及检查更新,快速进入游戏
+ 保存账号密码服务器信息
+ 多开游戏

### 天赋及天命模拟器
+ GitHub可以存放静态网站, 遂将天赋模拟器汉化版的代码一起上传了, 新版本构思中, 更新随缘.
+ [天赋及天命模拟器(http://dlanny.gitee.io/ddo_quicklogin)](http://dlanny.gitee.io/ddo_quicklogin)
### V2.5.8 更新
+ 修复BUG:选择其他服务器后会自动选择上一次登陆的服务器.

### V2.5.7 更新
+ 同步Vivx97维护版本中的副本包描述信息.
+ 精简代码.
+ 删除supporturl地址 ,和官方客户端同步 .
+ 经过思考,决定将攻略及模拟器等放在网页端,方便更新及后期维护.

### V2.5.6 更新
+ 增加64位客户端启动
+ 更新supporturl地址  

### V2.5.5 更新
+ 性能优化  

### V2.5.4 更新
+ 增加贴吧链接 
+ 增加QQ群链接

### V2.5.3 更新
+ 优化排队策略

### V2.5.2 更新
+ 增加登陆排队验证，防止服务器满了依然登陆导致的报服务器已满错误。

### V2.5.1 更新
+ 压缩程序，减少体积，修复BUG

### V2.5 更新
+ 支持Win7. 支持.net framework 3.5 。
+ 重构代码，移除WebService引用，使用HttpWebRequest直接调用，优化效率。
+ 修复Bug。

### ~~V2.3 -V2.4  废弃 过于臃肿，需要 .net framework 4.6支持~~
+ ~~源码存于GitHub~~
+ ~~账号信息存于Sqlite数据库,避免XML文件损坏造成的无法运行~~
+ ~~旧版本更新的请自行输入账户信息~~

### 使用说明
+ 将QuickLogin.exe文件复制到游戏根目录,如图:![img](https://gitee.com/dlanny/DDO_QuickLogin/raw/master/DOC/1.png)
+ 运行![img](https://images.gitee.com/uploads/images/2019/0628/181152_2385d8a8_1366903.png) 即可
