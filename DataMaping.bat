echo CD当前路径：%~dp0
cd /d %~dp0 

echo 创建硬链接
mklink /J "%cd%\DataMaping" D:\Project\Demo\02.ShareLib\DataMaping\DataMaping

pause 