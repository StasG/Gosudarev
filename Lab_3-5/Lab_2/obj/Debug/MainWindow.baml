   M S B A M L   `   `   `  ����@  <Lab_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab_2Lab_2  5   	       Lab_2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab_2     5   	     � Title$  TheMainestWindow!!!��5   	   $��363.92��6%   $��459.788��65    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Dictionary1.xaml?�6%   %    5      ��5      �� 5   
    �� ImageSource$ Pictures/1.png��6    � DataContext 5        Lab_2.VM  5   
   6   .��5      ��  �� Orientation$ Vertical=�6   $��Center=�6(   .+�5   
   �� $��18.667(�6   $��Comic Sans MS)�6"   $��45��6=   .��6I   FDКонфигурация транспортного средства6n   �� 5   
   $ 
Horizontal=�6   $	��240��6.   .+�5      �� $ Vertical=�6   $	��200��60   $	��Top=�6<   .+�5      �� $��Comic Sans MS)�6   $
��Left=�63   $��16(�6N   $��0,0,0,20q�6\   .��6w   %#Основные параметры6�   �� 5      $ 
Horizontal=�6   $��0,0,0,8q�66   .+�5      �� $��0,0,67,0q�6   .��67   Модель6?   �� 5         Box1#��[  6   ��6=   �� *Model+ �� SelectedItem 6[   �� *SModel+ �� Mode$ TwoWay=�5      5      �� 5       $ 
Horizontal=�6   $��0,0,0,8q�66   .+�5!      �� $��0,0,15,0q�6   .��67   Объём двигателя6H   �� 5"      #��[  6   ��6=   �� *Volume+ 6\   �� *	SVolume+$ TwoWay=�5#      5$      �� 5%      $ 
Horizontal=�6   $��0,0,0,8q�66   .+�5&      �� $	��120��6   .��6(   КПП6-   �� 5'      #��[  6   ��6=   �� *Box+ 6Y   �� *SBox+$ TwoWay=�5(      5)      �� 5*      $ 
Horizontal=�6   $��0,0,0,8q�66   .+�5+      �� $	��120��6   .��6(   Привод60   �� 5,      #��[  6   ��6=   �� *Tran+ 6Z   �� *STran+$ TwoWay=�5-      5.      �� 5/      $ 
Horizontal=�6   .+�50      �� $	��120��6   .��6(   
Цвет6.   �� 51      #��[  6   	 �� SelectedIndex$	 0��6=   
 �� SelectedValuePath$	
 Key��6�    �� DisplayMemberPath$	 Key��6�   ��6O   �� *Col+ 6k   �� *SCol+��6�   �� *CarCol+52      53      54      �� 55      $��50��6   $��2��6   	 �� X1$ 25��62   	 �� X2$ 25��6:   	 �� Y2$	 240��6B   $��Center=�6K   	 �� Y1$ 7��6h   
���   �6o   �� 56      $ Vertical=�6   $	��200��60   $	��210��6<   $	��Top=�6I   .+�57      �� $��Comic Sans MS)�6   $
��Left=�63   $��16(�6N   $��0,0,0,20q�6\   .��6w   )'Дополнительные опции6�   �� 58      $ 
Horizontal=�6   $��0,0,0,8q�66   .+�59      ��   mah#��[ 6   {�6<   �� *EnableCliCon+ d� 	IsChecked 6_   �� *CliCon+$ TwoWay=�6�   �� 5:      .��6   Климат-контроль6-   5;      �� 5<      $ 
Horizontal=�6   $��0,0,0,8q�66   .+�5=      �� #��[ 6   {�6<   �� *
EnableHeat+ 6]   �� *Heat+$ TwoWay=�6�   �� 5>      .��6   Подогрев руля6+   5?      �� 5@      $ 
Horizontal=�6   $��0,0,0,8q�66   .+�5A      �� #��[ 6   {�6<   �� *
EnableRain+ 6]   �� *Rain+$ TwoWay=�6�   �� 5B      .��6   Датчик дождя6*   5C      �� 5D      $ 
Horizontal=�6   $��0,0,0,8q�66   .+�5E      �� #��[ 6   {�6<   �� *
EnablePark+ 6]   �� *EPark+$ TwoWay=�6�   �� 5F      .��6   !Датчики парковки6.   5G      �� 5H      $	 0��6e   ��6   �� *Park+ 69   �� *SPark+$ TwoWay=�{�6w   �� *EPark+5I      5J      5K      �� 5L   
   $ 
Horizontal=�6   $	��400��6.   $
��Left=�6:   .+�5M      �� $
��Left=�6   $��0,0,60,0q�60   $��60��6B   ��6M   �� *Cancel+.��6h   Отмена6p   �� 5N      -   5        $��0,0,42,0q�5N      $��60��6'   ��62   �� *Count+.��6a   Расчёт6i   �� 5O      $��Comic Sans MS)�6   $��13.333(�6/   $
��Bold"�6A   .��6S   06V   �� 5P      $��Comic Sans MS)�6   $��13.333(�6/   $
��Bold"�6A   .��6S   Флобсов6\   5Q      5R      5S      