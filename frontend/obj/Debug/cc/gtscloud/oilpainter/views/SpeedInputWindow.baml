   M S B A M L   `   `   `  ����C  ?frontend, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:frontend.cc.gtscloud.oilpainter.views%frontend.cc.gtscloud.oilpainter.views  5   	   <    6frontend.cc.gtscloud.oilpainter.views.SpeedInputWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:frontend.cc.gtscloud.oilpainter.views     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  流速输入��5	   	   $	��200��6   $	��300��6#    � WindowStartupLocation$ CenterOwner=�6/    � 
ResizeMode$ NoResize=�6S   .��5
      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $
��1.5* �6   �� 5      $��48 �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��0��6!   $A��;请在充分搅拌后输入搅拌后的油漆黏度(流速)��61   $
��Wrap=�6N   $��Bottom=�6b   $��17(�6}   *  $MahApps.Metro.Controls.NumericUpDown  5   
   -   5          Name$ numSpeed��5   !   $��1��63   $��0��6@   $	��Top=�6P   $��48��6h   $��8,8,8,0q�6w   $��18(�6�      Minimum 6�   �� *
SpeedLow+   Value 6�   �� *
OilSpeed+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�
   Maximum
 6�   �� *	SpeedUp+�� 5   
   $��0��6   $��1��6   $��3��6.   $��90��6?   $��90��6K    �� CornerRadius$ 45��6V   ���#F443366h   �� 5   
   $��0��6   $��1��6"   $��3��62   $��Center=�6C   $��Center=�6`    �� Orientation$ 
Horizontal=�6{   .+�5      �� -   5        $��
lblTimeout��5      ���#fff$��22(�6�   ��6=   �� *	Timeout+$ TwoWay=�$	 PropertyChanged=�6�   �� 5      ���#fff$��s��6+   $��22(�65   $��4,0,0,0q�6C   5      �� 5   
   -   5        $��2��5      $��0��6   $��2��6.   $��Center=�6B   $��Center=�6_   $	��100��6z   $��36��6�   $��18(�6�   $��0,0,16,0q�6�   $��确定��6�   6�   5      5      