   M S B A M L   `   `   `  ����C  ?frontend, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:frontend.cc.gtscloud.oilpainter.views%frontend.cc.gtscloud.oilpainter.views  5   	   B    <frontend.cc.gtscloud.oilpainter.views.CustomerMaintainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:frontend.cc.gtscloud.oilpainter.views     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  客户维护��5	   	   $	��240��6   $	��400��6#    � WindowStartupLocation$ CenterOwner=�6/    � 
ResizeMode$ NoResize=�6S   .��5
      �  � RowDefinitions 5   
   �� 5      $��64 �6   �� 5      $��56 �6   �� 5      $��1* �6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� $��80��6   $��客户代码��6*   $��Center=�66   �� 5      -   5         ��Name$ cmbCustomers��5      $	��160��61   $��Center=�6@    �� DisplayMemberPath$ CustomerCode��6s    �� SelectedIndex$ 0��6�   ��6[   �� 6�   5      5      � 5   
   $��1��6   .+�5      �� $ 
Horizontal=�6   $��Center=�62   .+�5      �� $��80��6   $��客户名称��6*   $��Center=�66   �� 5      $	��160��6   $��Center=�6)   ��6D   ��  �� ElementName$ cmbCustomers��	 �� Path$	 SelectedItem.CustomerName�5      5      � 5   
   $��2��6   .+�5      �� $ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��Center=�5      $��	12,8,12,0q�64   $��Right=�6G   $	��100��6c   $	��180��6r   .��5      �� $ 
Horizontal=�6!   .+�5       ��    IonIcons#���   6    $	����6H   $��16(�6[   $��Center=�6i   ���#fff6�   �� 5!      $��增加��6    $��Center=�6-   ���#fff6O   5"      ��5#      �� 5$      
 �� 
TargetType"
 ��6    .�5%      ��  �� Property � �� �� Value
 ���� 6<   �� 5&       � ��$ 0q�6@   �� 5'       � �� �#2196F36;   5(      5*      �� 5+      -   5        $��1��5+      $��Center=�6)   $��12,8,0,0q�6D   $
��Left=�6V   $	��100��6q   $	��180��6�   .��5,      �� $ 
Horizontal=�6!   .+�5-      �� #���   6    $	����6H   $��16(�6[   $��Center=�6i   ���#fff6�   �� 5.      $��删除��6    $��Center=�6-   ���#fff6O   5/      ��50      �� 51      "
 ��6    .�52      ��  � ��
 ���� 6<   �� 53       � ��$ 0q�6@   �� 54       � �� �#F443366;   55      57      58      59      5:      5;      