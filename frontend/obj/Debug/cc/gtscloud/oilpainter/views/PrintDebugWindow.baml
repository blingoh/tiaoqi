   M S B A M L   `   `   `  ����C  ?frontend, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:frontend.cc.gtscloud.oilpainter.views%frontend.cc.gtscloud.oilpainter.views  5   	   <    6frontend.cc.gtscloud.oilpainter.views.PrintDebugWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:frontend.cc.gtscloud.oilpainter.views     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  打印测试��5	   	   $	��500��6   $	��400��6#    � WindowStartupLocation$ CenterOwner=�6/    � 
ResizeMode$ CanMinimize=�6S   .��5
      � -   5         �Name$ gridRoot��5
       � RowDefinitions 5   
   �� 5      $��48 �6   �� 5      $��48 �6   �� 5      $��48 �6   �� 5      $��48 �6   �� 5      $��48 �6   �� 5      $��48 �6   �� 5      $��48 �6   �� 5      $��64 �6   �� 5      $��64 �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��0��6!   $��Right=�61   $��Center=�6M   $��线别��6h   $��0,0,16,0q�6r   �� 5   
   $��1��6   $��0��6!   $��Right=�61   $��Center=�6M   $��机种��6h   $��0,0,16,0q�6r   �� 5   
   $��2��6   $��0��6!   $��Right=�61   $��Center=�6M   $��原油料号��6h   $��0,0,16,0q�6t   �� 5   
   $��3��6   $��0��6!   $��Right=�61   $��Center=�6M   $��固化剂料号��6h   $��0,0,16,0q�6u   �� 5   
   $��4��6   $��0��6!   $��Right=�61   $��Center=�6M   $��稀释剂料号��6h   $��0,0,16,0q�6u   �� 5   
   $��5��6   $��0��6!   $��Right=�61   $��Center=�6M   $��油漆秒数��6h   $��0,0,16,0q�6t   �� 5    
   $��6��6   $��0��6!   $��Right=�61   $��Center=�6M   $��有效时间��6h   $��0,0,16,0q�6t   �� 5!   
   $��0��6   $��1��6   $��Center=�6/   $��4,0,32,0q�6J   $	��300��6\   ��6k   �� *
LineType+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5"   
   $��1��6   $��1��6   $��Center=�6/   $��4,0,32,0q�6J   $	��300��6\   ��6k   �� *MachineType+$ TwoWay=�$ PropertyChanged=��� 5#   
   $��2��6   $��1��6   $��Center=�6/   $��4,0,32,0q�6J   $	��300��6\   ��6k   �� *OilMaterialNum+$ TwoWay=�$ PropertyChanged=��� 5$   
   $��3��6   $��1��6   $��Center=�6/   $��4,0,32,0q�6J   $	��300��6\   ��6k   �� *GuhuaMaterialNu+$ TwoWay=�$ PropertyChanged=��� 5%   
   $��4��6   $��1��6   $��Center=�6/   $��4,0,32,0q�6J   $	��300��6\   ��6k   �� *XishiMaterialNum+$ TwoWay=�$ PropertyChanged=�*  $MahApps.Metro.Controls.NumericUpDown  5&   
   $��5��6!   $��1��6.   $��Center=�6>   $��4,0,32,0q�6Y   $	��300��6k      Value 6z   �� *
OilSeconds+$ TwoWay=�$ PropertyChanged=�  5'   
   $��6��6!   $��1��6.   $��Center=�6>   $��4,0,32,0q�6Y   $	��300��6k    6z   �� *ValidateTime+$ TwoWay=�$ PropertyChanged=��� 5(   
   -   5        $��7��5(      $��2��6   $��测试��62   $��	32,8,32,8q�6?   6R   �� 5)   
   -   5        $��8��5)      $��2��6   $$��打印最后一次调漆记录��62   $��	32,8,32,8q�6G   6Z   5*      5+      