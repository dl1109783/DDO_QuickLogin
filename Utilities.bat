echo 请以管理员身份运行本脚本
echo CD当前路径：%~dp0
cd /d %~dp0 

echo 创建硬链接
mklink /J "%cd%\Utilities" D:\Project\Demo\02.ShareLib\DataMaping\Utilities

pause 