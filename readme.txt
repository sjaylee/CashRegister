

项目名称： windows form 版本的 收银机


启动项目： TW.CashRegister.UI

功能描述：

1、 卖家可以设置哪些商品参加哪些活动，点击“设置”按钮立即生效（并且持久化这个设置，下次打开还是这个设置）；

2、 用户可以变更购物车商品（更改条形码的json数组）；

3、 点击“打印”按钮，打印出收银小票；

4、 扩展： 

 
4-a、现有的促销活动可以更新, 折扣95折扣或者买N送m个如果要变更，只需要更新文件\CashRegister\TW.CashRegister.UI\Data\Promation里的活动定义即可；
4-b、可以新添加促销活动， 新活动需要继承促销活动接口"IPromotion", 时间充足的话可以直接使用配置文件来添加新的活动；
4-c、可以新添加新商品， 新活动需要在“\CashRegister\TW.CashRegister.UI\Data” 添加；
4-d、下班时间抽空写的，时间很紧，所以单元测试没有写完。