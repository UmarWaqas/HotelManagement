   M S B A M L   `   `   `  ����  HotelManagement    HotelManagement.AddJob   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  addJob��5   	    � Title$ Add New Catagory��5   	   $	��300��6"   $	��350��6/    � 
ResizeMode$ CanMinimize=�6;    � WindowStartupLocation$ CenterScreen=�6T    � 	Resources 5       �� 
TargetType   TooltipInError �� Property �� Value �� CornerRadius	 � ToolTip
 �� ElementName �� Path��%�  &	        �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,2,40,2q�6'   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      ]� ��. .+�5      �� 
���  ��$��right=�66   $��5,0,0,0q�6M   $��18��6^   $��18��6i   $ 9��6u   	 5      �� $
 customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�5   "   �� $��!��6,   $��center=�65   $��center=�6P   $
��Bold"�6m   
�������5   #   5      �� 5      $��customAdorner��68   $��Center=�6M   .v�5   "   �� 
���  ��$��1q�6;   5      5      5      5!      5"      5#      .��5$      � .+�5%   
   �� $��Name:��6   $
��Left=�6    $��	29,41,0,0q�6;   $	��Top=�6N   �� 5&   
   -   5         ��Name$ 
txtJobType��5&      #��[  6&   $
��Left=�6N   $��30��6i   $��
116,41,0,0q�6u    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��188��6�   .��6�   ��5'      �� 5(      $
 Type�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5*       �� NotifyOnValidationError .  �� ValidationRules 5+      5  /System.Windows.Controls.ExceptionValidationRule  5,      5.      .��5/      51      �� 52   
   $��Salary:��6   $
��Left=�6"   $��
29,101,0,0q�6=   $	��Top=�6Q   �� 53   
   -   5        $ 	txtSalary��53      #��[  6%   $
��Left=�6M   $��30��6h   $��116,101,0,0q�6t   $
 Wrap=�6�   $	��Top=�6�   $	��188��6�   .��6�   ��54      �� 55      $ Salary�6    . $ PropertyChanged=�57       .  58        59      5;      .��5<      5>      �� 5?   
   -   5         ��Name$ btnAdd��5?      $	��Add��6!   $
��Left=�6/   $��139,176,0,0q�6J   $	��Top=�6_   $��80��6w   $��27��6�   6�   5A      5B      