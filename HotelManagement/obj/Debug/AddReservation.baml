   M S B A M L   `   `   `  ����  HotelManagement$    HotelManagement.AddReservation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  Add New Reservation��5      $	��650��6$   $	��600��61    � 
ResizeMode$ CanMinimize=�6=    � WindowStartupLocation$ CenterScreen=�6V    � 	Resources 5       �� 
TargetType   TooltipInError �� Property �� Value �� CornerRadius � ToolTip	 �� ElementName
 �� Path��%�  &	        �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,2,40,2q�6'   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      ]� ��. .+�5      �� 
���  ��$��right=�66   $��5,0,0,0q�6M   $��18��6^   $��18��6i   $ 9��6u    5      �� $	 customAdorner��$8
 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�5   "   �� $��!��6,   $��center=�65   $��center=�6P   $
��Bold"�6m   
�������5   #   5      �� 5      $��customAdorner��68   $��Center=�6M   .v�5   "   �� 
���  ��$��1q�6;   5      5      5       5"      5#      5$      .��5%      � .+�5&   
   �� $��Name:��6   $
��Left=�6    $��
80,240,0,0q�6;   $	��Top=�6O   �� 5'   
   -   5         ��Name$ txtName��5'      #��[  6#   $
��Left=�6K   $��23��6f   $��211,244,0,0q�6r    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��203��6�   .��6�   ��5(      �� 5)      $

 Name�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5+       �� NotifyOnValidationError .  �� ValidationRules 5,      5  /System.Windows.Controls.ExceptionValidationRule  5-      5/      .��50      51      �� 52   
   -   5         ��Name$ 
cbRoomType��52      #��[  6'   $
��Left=�6O   $��
211,19,0,0q�6j   $	��Top=�6~   $	��203��6�    �� SelectedValue 53      �� 54      $
 RoomType�6    . $ PropertyChanged=�56       .  57        58      5:      5<      �� 5=   
   $��Email:��6   $
��Left=�6!   $��
80,285,0,0q�6<   $	��Top=�6P   �� 5>   
   -   5        $ txtEmail��5>      #��[  6$   $
��Left=�6L   $��23��6g   $��211,289,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   .��6�   ��5?      �� 5@      $
 Email�6    . $ PropertyChanged=�5B       .  5C        5D      5F      .��5G      5H      �� 5I   
   $��CNIC:��6   $
��Left=�6    $��
80,330,0,0q�6;   $	��Top=�6O   �� 5J   
   -   5        $ txtCnic��5J      #��[  6#   $
��Left=�6K   $��23��6f   $��211,334,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   .��6�   ��5K      �� 5L      $

 CNIC�6    . $ PropertyChanged=�5N       .  5O        5P      5R      .��5S      5T      �� 5U   
   $��Phone:��6   $
��Left=�6!   $��
80,374,0,0q�6<   $	��Top=�6P   �� 5V   
   -   5        $ txtPhone��5V      #��[  6$   $
��Left=�6L   $��23��6g   $��211,378,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   .��6�   ��5W      �� 5X      $
 PhoneNumber�6    . $ PropertyChanged=�5Z       .  5[        5\      5^      .��5_      5`      �� 5a   
   $��
Room Type:��6   $
��Left=�6%   $��	80,15,0,0q�6@   $	��Top=�6S   �� 5b   
   $��Address:��6   $
��Left=�6#   $��
80,422,0,0q�6>   $	��Top=�6R   �� 5c   
   -   5        $ 
txtAddress��5c      #��[  6&   $
��Left=�6N   $��73��6i   $��211,422,0,0q�6u   $	��Top=�6�   $	��203��6�   .��6�   ��5d      �� 5e      $
 Address�6    . $ PropertyChanged=�5g       .  5h        5i      5k      .��5l      5m      �� 5n   
   -   5        $��Reserve��5n      $
��Left=�6#   $��256,576,0,0q�6>   $	��Top=�6S   $��82��6k   6v   �� 5o   
   -	   5        $ cbRoomNumber��5o      #��[  6)   $
��Left=�6Q   $��
211,63,0,0q�6l   $	��Top=�6�   $	��203��6�    5p      �� 5q      $
 
RoomNumber�6    . $ PropertyChanged=�5s       .  5t        5u      5w      5y      �� 5z   
   $��Room No:��6   $
��Left=�6#   $��	80,59,0,0q�6>   $	��Top=�6Q   �� 5{   
   $��	Check-In:��6   $
��Left=�6$   $��
80,105,0,0q�6?   $	��Top=�6S   &   Xceed.Wpf.Toolkit.DateTimePicker  5|   
   -
   5          Name$ 	dpCheckIn��5|      #��[  61   $	��203��6Y   $��30��6e   $
��Left=�6q   $	��Top=�6�   $��211,105,0,0q�6�   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ LongDate=�6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5}      �� 5~      $
 CheckInDate�6    . $ 	LostFocus=�5�       .  5�        5�      5�      5�      �� 5�   
   $��
Check-Out:��6   $
��Left=�6%   $��
80,153,0,0q�6@   $	��Top=�6T     5�   
   -   5        $ 
dpCheckOut��5�      $	��203��62   #��[  6>   $��30��6f   $
��Left=�6r   $	��Top=�6�   $��211,153,0,0q�6�   $ LongDate=�6�    5�      �� 5�      $
 CheckOutDate�6    . $ 	LostFocus=�5�       .  5�        5�      5�      5�      �� 5�   
   $��Nights:��6   $
��Left=�6"   $��
80,202,0,0q�6=   $	��Top=�6Q   %  Xceed.Wpf.Toolkit.IntegerUpDown  5�   
   -   5        $��	NudNights��5�      $	��203��6.   #��[  6:   $��30��6b   $
��Left=�6n   $	��Top=�6�   $��211,199,0,0q�6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 1X�6�      Maximum$ 30X�6�   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$ 1��6�      Value 5�      �� 5�      $
 Nights�6    . $ PropertyChanged=�5�       .  5�        5�      5�      5�      �� 5�   
   $��Date of Birth:��6   $
��Left=�6)   $��
80,523,0,0q�6D   $	��Top=�6X     5�   
   -   5        $ dpDateOfBirth��5�      $	��203��65   #��[  6A   $��30��6i   $
��Left=�6u   $	��Top=�6�   $��211,523,0,0q�6�   $ LongDate=�6�    5�      �� 5�      $
 DateOfBirth�6    . $ 	LostFocus=�5�       .  5�        5�      5�      5�      5�      5�      