   M S B A M L   `   `   `  ����  HotelManagement!    HotelManagement.AddRoomType   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  Add New Room Type��5   	   $	��300��6#   $	��350��60    � 
ResizeMode$ CanMinimize=�6<    � WindowStartupLocation$ CenterScreen=�6U    � 	Resources 5       �� 
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
��Left=�6%   $��	29,41,0,0q�6@   $	��Top=�6S   �� 5'   
   -   5         ��Name$ txtRoomType��5'      #��[  6(   $
��Left=�6P   $��30��6k   $��
111,41,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��188��6�   .��6�   ��5(      �� 5)      $

 Type�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5+       �� NotifyOnValidationError .  �� ValidationRules 5,      5  /System.Windows.Controls.ExceptionValidationRule  5-      5/      .��50      51      �� 52   
   $��	  Guests:��6   $
��Left=�6$   $��	29,95,0,0q�6?   $	��Top=�6R   %  Xceed.Wpf.Toolkit.IntegerUpDown  53   
   -   5        $��NudAllowedGuests��53      #��[  65   $
��Left=�6]   $��30��6x   $��
111,95,0,0q�6�   $	��Top=�6�   $	��188��6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 1X�6�      Maximum$ 15X�6�   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$ 1��6�      Value 55      �� 56      $
 Capacity�6    . $ PropertyChanged=�58       .  59        5:      5<      5>      �� 5?   
   -   5        $	��Add��5?      $
��Left=�6   $��139,200,0,0q�6:   $	��Top=�6O   $��80��6g   $��27��6r   6~   �� 5@   
   $��
  Charges:��6   $
��Left=�6%   $��
29,145,0,0q�6@   $	��Top=�6T   �� 5A   
   -   5        $ 
txtCharges��5A      #��[  6&   $
��Left=�6N   $��30��6i   $��111,145,0,0q�6u   $
 Wrap=�6�   $	��Top=�6�   $	��188��6�   .��6�   ��5B      �� 5C      $
 Charges�6    . $ PropertyChanged=�5E       .  5F        5G      5I      .��5J      5K      5M      5N      