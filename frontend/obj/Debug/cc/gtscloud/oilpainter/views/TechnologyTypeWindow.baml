   M S B A M L   `   `   `  ����C  ?frontend, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:frontend.cc.gtscloud.oilpainter.views%frontend.cc.gtscloud.oilpainter.views  5   	   @    :frontend.cc.gtscloud.oilpainter.views.TechnologyTypeWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:frontend.cc.gtscloud.oilpainter.views     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  工艺类型��5	   	   $	��200��6   $	��400��6#    � WindowStartupLocation$ CenterOwner=�6/    � 
ResizeMode$ NoResize=�6S   .��5
      �  � RowDefinitions 5   
   �� 5      $��56 �6   �� 5      $��1* �6   .+�5   
   � $��0��6   $��
16,16,16,8q�6    � ColumnDefinitions 5      �� 5      $	��120 �6#   �� 5      $��1* �6#   .+�5      �� $��0��6   $��油漆类型：��6(   $��Center=�65   $��Right=�6P   $��0,0,8,0q�6l   �� 5      -   5         ��Name$ cmbOilTypes��5      $��1��6,   $	��240��6<   $��4,0,16,0q�6K    �� 
IsEditable .   �� SelectedIndex$ 0��6�    �� DisplayMemberPath$ OilPaintType��6�   ��6p   �� 6�   5      � 5   
   $��1��6   $��0,8,0,0q�6    5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� $��0��6   $��Center=�6%   $��	12,8,12,0q�6@   $��Right=�6S   $	��100��6o   $	��180��6~   .��5      �� 	 �� Orientation$	 
Horizontal=�6   .+�5      ��    IonIcons#���   6   $	����6D   $��16(�6W   $��Center=�6e   ���#fff6�   �� 5      $��增加��6   $��Center=�6)   ���#fff6K   5       ��5!      �� 5"      
 �� 
TargetType"
 ��6   .�5#      ��  �� Property � �� �� Value
 ���� 68   �� 5$       � ��$ 0q�6<   �� 5%       � �� �#2196F367   5&      5(      �� 5)      $��1��6   $��Center=�6%   $��12,8,0,0q�6@   $
��Left=�6R   $	��100��6m   $	��180��6|   .��5*      �� $	 
Horizontal=�6   .+�5+      �� #���   6   $	����6D   $��16(�6W   $��Center=�6e   ���#fff6�   �� 5,      $��删除��6   $��Center=�6)   ���#fff6K   5-      ��5.      �� 5/      "
 ��6   .�50      ��  � ��
 ���� 68   �� 51       � ��$ 0q�6<   �� 52       � �� �#F4433667   53      55      56      57      58      