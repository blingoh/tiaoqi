   M S B A M L   `   `   `  ����C  ?frontend, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:frontend.cc.gtscloud.oilpainter.views%frontend.cc.gtscloud.oilpainter.views  5   	   ;    5frontend.cc.gtscloud.oilpainter.views.BomUploadWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:frontend.cc.gtscloud.oilpainter.views     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  	BOM上传��5	   	   $	��500��6   $	��600��6$    � WindowStartupLocation$ CenterOwner=�60    � 	Resources 5
         centerContentCellStyle �� 
TargetType �� Property �� Value��%~   &	        �� 5   
   " ��6/   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   5      5      .��5      � -   5         �Name$ gridBomUploadView��5       � RowDefinitions 5   
   �� 5      $��48 �6   �� 5      $��1* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      $��1* �6#   �� 5      $	��240 �6#   .+�5      �� $��Bom模板：��6   $��0��6&   $��Right=�66   $��Center=�6R   �� 5      	 �� 
IsReadOnly	 . $��1��6(   $��Center=�68   ��6S   �� *BomFilePath+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��2��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� -   5        $��Center=�5      $��	12,0,12,0q�64   $��Right=�6G   $	��100��6c   $	��180��6r   .��5      �� $ 
Horizontal=�6!   .+�5       ��   IonIcons#���  6    $	����6H   $��16(�6[   $��Center=�6i   ���#fff6�   �� 5!      $��浏览��6    $��Center=�6-   ���#fff6O   5"      ��5#      �� 5$      " ��6    .�5%      ��  � ��
 ���� 6<   �� 5&       � ��$ 0q�6@   �� 5'       � �� �#2196F36;   5(      5*      �� 5+      -   5        $��Center=�5+      $��	12,0,12,0q�64   $��Right=�6G   $	��100��6c   $	��180��6r   .��5,      �� $ 
Horizontal=�6!   .+�5-      �� #���  6    $	����6H   $��16(�6[   $��Center=�6i   ���#fff6�   �� 5.      $��确认上传��6    $��Center=�6/   ���#fff6Q   5/      ��50      �� 51      " ��6    .�52      ��  � ��
 ���� 6<   �� 53       � ��$ 0q�6@   �� 54       � �� �#2196F36;   55      57      58      59      � 5:   
   $��1��6   .+�5;      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtBomInfos��5;         AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .  � DataContext 6�   �� *Boms+$
 TwoWay=�$ PropertyChanged=���6�   ��    Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ 客户��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 65      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  6�      Binding 6A   �� *
Customer+$
 TwoWay=�$ PropertyChanged=�6�     5>      $ 品名/机种��6)   $	 120 68    . # [  6�    6D   �� *MachineType+$
 TwoWay=�$ PropertyChanged=�6�     5?      $ 厂商��6)   $	 120 65    . # [  6�    6A   �� *
Supplier+$
 TwoWay=�$ PropertyChanged=�6�     5@      $ 颜色��6)    . # [  6�    65   �� *Color+$
 TwoWay=�$ PropertyChanged=�6�     5A      $ 主剂料号1��6)    . # [  6�    68   �� *MainMeterialOne+$
 TwoWay=�$ PropertyChanged=�6�     5B      $ 主剂料号2��6)    . # [  6�    68   �� *MainMeterialTwo+$
 TwoWay=�$ PropertyChanged=�6�     5C      $ 主剂料号3��6)    . # [  6�    68   �� *MainMeterialThree+$
 TwoWay=�$ PropertyChanged=�6�     5D      $ 
固化剂1��6)    . # [  6�    67   �� *
GuhuaOne+$
 TwoWay=�$ PropertyChanged=�6�     5E      $ 
固化剂2��6)    . # [  6�    67   �� *
GuhuaTwo+$
 TwoWay=�$ PropertyChanged=�6�     5F      $ 
固化剂3��6)    . # [  6�    67   �� *
GuhuaThree+$
 TwoWay=�$ PropertyChanged=�6�     5G      $ 固化剂比例��6)    . # [  6�    68   �� *	GuhuaRate+$
 TwoWay=�$ PropertyChanged=�6�     5H      $ 
稀释剂1��6)    . # [  6�    67   �� *
XishiOne+$
 TwoWay=�$ PropertyChanged=�6�     5I      $ 
稀释剂2��6)    . # [  6�    67   �� *
XishiTwo+$
 TwoWay=�$ PropertyChanged=�6�     5J      $ 
稀释剂3��6)    . # [  6�    67   �� *
XishiThree+$
 TwoWay=�$ PropertyChanged=�6�     5K      $ 稀释剂上限��6)    . # [  6�    68   �� *	XishiUp+$
 TwoWay=�$ PropertyChanged=�6�     5L      $ 稀释剂下限��6)    . # [  6�    68   �� *
XishiLow+$
 TwoWay=�$ PropertyChanged=�6�     5M      $ 油漆黏度上限��6)    . # [  6�    69   �� *
OilSpeedUp+$
 TwoWay=�$ PropertyChanged=�6�     5N      $ 油漆粘度下限��6)    . # [  6�    69   �� *OilSpeedLow+$
 TwoWay=�$ PropertyChanged=�6�     5O      $ 网布目数��6)    . # [  6�    67   �� *WBMS+$
 TwoWay=�$ PropertyChanged=�6�   5Q      5R      5S      5T      