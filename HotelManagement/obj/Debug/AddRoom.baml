   M S B A M L   `   `   `  ����  HotelManagement    HotelManagement.AddRoom   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   
   -   5          � Title$  Add New Room��5   	   $	��400��6   $	��400��6+    � 
ResizeMode$ CanMinimize=�67    � WindowStartupLocation$ CenterScreen=�6P    � 	Resources 5       �� 
TargetType   TooltipInError �� Property �� Value �� CornerRadius � ToolTip	 �� ElementName
 �� Path��%�  &	        �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,2,40,2q�6'   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      ]� ��. .+�5      �� 
���  ��$��right=�66   $��5,0,0,0q�6M   $��18��6^   $��18��6i   $ 9��6u    5      �� $	 customAdorner��$8
 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�5   "   �� $��!��6,   $��center=�65   $��center=�6P   $
��Bold"�6m   
�������5   #   5      �� 5      $��customAdorner��68   $��Center=�6M   .v�5   "   �� 
���  ��$��1q�6;   5      5      5       5"      5#      5$      .��5%      � .+�5&   
   �� $��
Room Type:��6   $
��Left=�6%   $��	29,94,0,0q�6@   $	��Top=�6S   �� 5'   
   -   5         ��Name$ 
cbRoomType��5'      #��[  6'   $��30��6O   $
��Left=�6[   $��
125,98,0,0q�6v   $	��Top=�6�   $	��203��6�    �� SelectedValue 5(      �� 5)      $
 RoomType�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5+       �� NotifyOnValidationError .  �� ValidationRules 5,      5  /System.Windows.Controls.ExceptionValidationRule  5-      5/      51      �� 52   
   $��Room No:��6   $
��Left=�6#   $��	29,36,0,0q�6>   $	��Top=�6Q   %  Xceed.Wpf.Toolkit.IntegerUpDown  53   
   -   5        $��NudRoomNumber��53      #��[  62   $
��Left=�6Z   $��30��6u   $��
125,40,0,0q�6�   $	��Top=�6�   $	��203��6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$	 200X�6�      Maximum$	 250X�6�   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$ 1��6�      Value 54      �� 55      $
 
RoomNumber�6    . $ PropertyChanged=�57       .  58        59      5;      5=      �� 5>   
   $��
Manage By:��6   $
��Left=�6%   $��
29,153,0,0q�6@   $	��Top=�6T   �� 5?   
   -   5        $ 	cbManager��5?      #��[  6&   $
��Left=�6N   $��30��6i   $��125,157,0,0q�6u   $	��Top=�6�   $	��203��6�    5@      �� 5A      $
 	ManagerId�6    . $ PropertyChanged=�5C       .  5D        5E      5G      5I      �� 5J   
   $��Maintain By:��6   $
��Left=�6'   $��
29,211,0,0q�6B   $	��Top=�6V   �� 5K   
   -   5        $ cbMaintainer��5K      #��[  6)   $
��Left=�6Q   $��30��6l   $��125,215,0,0q�6x   $	��Top=�6�   $	��203��6�    5L      �� 5M      $
 MaintainerId�6    . $ PropertyChanged=�5O       .  5P        5Q      5S      5U      �� 5V   
   -   5        $	��Add��5V      $
��Left=�6   $��170,292,0,0q�6:   $	��Top=�6O   $��80��6g   $��27��6r   6~   5W      5X      