   M S B A M L   `   `   `  ����  HotelManagement"    HotelManagement.SignInWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  SignInWindow��5   	   $	��230��6   $	��320��6+    � 
ResizeMode$ CanMinimize=�67    � WindowStartupLocation$ CenterScreen=�6Q    � 	Resources 5       �� 
TargetType   TooltipInError �� Property �� Value �� CornerRadius � ToolTip	 �� ElementName
 �� Path��%�  &	        �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,2,40,2q�6'   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      ]� ��. .+�5      �� 
���  ��$��right=�66   $��5,0,0,0q�6M   $��18��6^   $��18��6i   $ 9��6u    5      �� $	 customAdorner��$8
 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�5   "   �� $��!��6,   $��center=�65   $��center=�6P   $
��Bold"�6m   
�������5   #   5      �� 5      $��customAdorner��68   $��Center=�6M   .v�5   "   �� 
���  ��$��1q�6;   5      5      5       5"      5#      5&      .��5'      � .+�5(   
   �� $��Email:��6   $
��Left=�6!   $��	39,14,0,0q�6<   $	��Top=�6O   �� 5)   
   -   5         ��Name$ txtUserName��5)      #��[  6'   $
��Left=�6O   $��23��6j   $��
125,18,0,0q�6v    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��144��6�   .��6�   ��5*      �� 5+      $

 Name�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5-       �� NotifyOnValidationError .  �� ValidationRules 5.      5  /System.Windows.Controls.ExceptionValidationRule  5/      51      .��52      54      �� 55   
   $��	Password:��6   $
��Left=�6$   $��	39,69,0,0q�6?   $	��Top=�6R   G� 56   
   -   5         G�Name$ txtPassword��56      #��[  6+   $
��Left=�6S   $��23��6n   $��
125,73,0,0q�6z    G� PasswordChar$ *��6�   $	��Top=�6�   $	��144��6�   6�   �� 57   
   -   5        $��
borPassErr��57   6   
���  ��$y�Hidden=�6"   $��Right=�6H   $	��Top=�6d   $��	0,76,12,0q�6|   $��18��6�   $��18��6�   $ 9��6�   $ Password is Required��58      ._�59      �� $��!��6   $��center=�6!   $��center=�6<   $
��Bold"�6Y   
�������5:      5;      �� 5<   
   -   5         ��Name$ 	btnSignIn��5<      $��Sign In��6$   $
��Left=�66   $��104,126,0,0q�6Q   $	��Top=�6f   $��56��6~   6�   �� 5=   
   -   5        $ 	btnCancel��5=      $��Cancel��6$   $
��Left=�65   $��191,126,0,0q�6P   $	��Top=�6e   $��56��6}   6�   5A      5B      