   M S B A M L   `   `   `  ����C  ?frontend, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:frontend.cc.gtscloud.oilpainter.views%frontend.cc.gtscloud.oilpainter.views  5   	   7    1frontend.cc.gtscloud.oilpainter.views.CustomerAdd   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:frontend.cc.gtscloud.oilpainter.views     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f8metro,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  添加客户��5	   	   $	��200��6   $	��300��6#    � WindowStartupLocation$ CenterOwner=�6/    � 
ResizeMode$ NoResize=�6S   .��5
      � -   5         �Name$ gridRoot��5
       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��1*  �6   �� 5      $��64 �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��0��6!   $��客户代码：��61   $��Right=�6>   $��Center=�6Z   $��15(�6u   �� 5   
   $��1��6   $��0��6!   $��客户名：��61   $��Right=�6=   $��Center=�6Y   $��15(�6t   �� 5   
   $��0��6   $��1��6   $��Center=�6/   $��32��6J   $��4,0,8,0q�6Y   $��16(�6j   ��6x   �� *CustomerCode+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��1��6   $��Center=�6/   $��32��6J   $��4,0,8,0q�6Y   $��16(�6j   ��6x   �� *CustomerName+$ TwoWay=�$ PropertyChanged=��� 5   
   -   5        $��2��5      $��0��6   $��2��6.   $��32��6B   $��96��6Q   $��16(�6_   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��    IonIcons#��[  6   $	����6C   $��16(�6S   $��Center=�6a   ���#fff6|   �� 5      $��确定��6   $��16(�6&   $��8,0,0,0q�64   ���#fff6E   5      ��5      �� 5      	 �� 
TargetType"	 ��6   .�5      �� 
 �� Property
 � �� �� Value
 ���� 64   �� 5       
 � ��$ 0q�68   �� 5!      
 � �� �#2196F363   5"      5$      5%      5&      