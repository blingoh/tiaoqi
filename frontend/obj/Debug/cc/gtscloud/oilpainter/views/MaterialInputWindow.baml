   M S B A M L   `   `   `  ����C  ?frontend, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:frontend.cc.gtscloud.oilpainter.views%frontend.cc.gtscloud.oilpainter.views  5   	   ?    9frontend.cc.gtscloud.oilpainter.views.MaterialInputWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:frontend.cc.gtscloud.oilpainter.views     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  输入剂料信息��5	   	   $	��300��6   $	��500��6'    � WindowStartupLocation$ CenterOwner=�63    � 
ResizeMode$ NoResize=�6W   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $
��4.5* �6   �� 5      $��84 �6   .+�5   
   �� $��0��6   $��0��6!   $��Right=�61   $��Center=�6M   $��	扫码：��6h   $��16(�6s   �� 5   
   $��1��6   $��0��6!   $��Right=�61   $��Center=�6M   $��剂料号：��6h   $��16(�6t   �� 5   
   $��2��6   $��0��6!   $��Right=�61   $��Center=�6M   $��批次号：��6h   $��16(�6t   �� 5   
   -   5         ��Name$ 
txtBarCode��5      $��0��6&   $��1��63   $��2��6C   $��Center=�6W   $	��8,0q�6r   $��48��6   $��16(�6�   $��Center=�6�   �� 5   
   $��1��6   $��1��6   $��Center=�6/   $	��8,0q�6J   $��48��6W   $��16(�6f   $��Center=�6�   ��6t   �� * MaterialNumInfo.MaterialNumber+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��2��6   $��1��6   $��Center=�6/   $	��8,0q�6J   $��48��6W   $��16(�6f   $��Center=�6�   ��6t   �� *MaterialNumInfo.BatchNumber+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $��	btnSubmit��5      $��1��6"   $��2��6/   $	��8,0q�6?   ��6L   ��  �� ElementName$ 
txtBarCode��	 �� Path$	 ActualHeight�.��5      �� 
 �� Orientation$
 
Horizontal=�6   .+�5      ��    IonIcons#��[  6   $	����6C   $��16(�6S   $��Center=�6a   ���#fff6|   �� 5      $��编码��6   $��16(�6&   $��2,0,0,0q�64   ���#fff6E   5       ��5!      �� 5"       �� 
TargetType" ��6   .�5#      ��  �� Property � �� �� Value
 ���� 64   �� 5$       � ��$ 0q�68   �� 5%       � �� �#2196F363   5&      5(      �� 5)   
   $��2��6   $��2��6   $	��8,0q�6.   ��6;   �� $ 
txtBarCode��$	 ActualHeight�.��5*      �� $
 
Horizontal=�6   .+�5+      �� #��[  6   $	����6C   $��16(�6S   $��Center=�6a   ���#fff6|   �� 5,      $��编码��6   $��16(�6&   $��2,0,0,0q�64   ���#fff6E   5-      ��5.      �� 5/      " ��6   .�50      ��  � ��
 ���� 64   �� 51       � ��$ 0q�68   �� 52       � �� �#2196F363   53      55      �� 56   
   -   5        $��3��56      $��0��6   $��3��6.   $	��140��6B   $��48��6Q   .��57      �� $
 
Horizontal=�6   .+�58      �� #��[  6   $	����6C   $��16(�6S   $��Center=�6a   ���#fff6|   �� 59      $��提交��6   $��16(�6&   $��8,0,0,0q�64   ���#fff6E   5:      ��5;      �� 5<      " ��6   .�5=      ��  � ��
 ���� 64   �� 5>       � ��$ 0q�68   �� 5?       � �� �#2196F363   5@      5B      5C      5D      