   M S B A M L   `   `   `  ����?  ;MyCV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyCVMyCV  5   	       MyCV.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MyCV     5   	     � Title$  Connect to the system��5   	   $	��538��6'   $	��855��64   ���#ff2800 � WindowStartupLocation$ CenterScreen=�6U    � 
ResizeMode$ NoResize=�6z   .��5	      � $��
-17,0,17,0q�6    � ColumnDefinitions 5
   
   �� 5      $	��63* �6   �� 5      $	��65* �6   �� 5      $
��722* �6   .+�5   
   �� $
��Left=�6   $	��301��6/   
���   �$	��Top=�6K   $	��574��6c   ���#ffff00 �� RadiusX$ 20��6~    �� RadiusY$ 20��6�   $��
23,123,0,0q�6�   $��2��6�   �� 5   
   $��Log in��6   $
��Left=�6!   $��67��6<   $��
195,24,0,0q�6H   $	��Top=�6\   $	��230��6t   $��Center=�6�   $��2��6�    
  Header#��[  6�   �� 5   
   $��Username��6   $
��Left=�6#   $��45��6>   $��
68,182,0,0q�6J   $	��Top=�6^   $	��107��6v   ���#ff4500$��2��6�   �� 5   
   -   5         ��Name$ UsernameTextBox��5      $
��Left=�6+   $��45��6F   $��180,179,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6|   $	��374��6�   $��0��6�   $��2��6�   �� 5   
   $��Password��6   $
��Left=�6#   $��45��6>   $��
68,251,0,0q�6J   $	��Top=�6^   $	��107��6v   ���#ff4500$��2��6�   �� 5   
   -   5        $ PasswordTextBox��5      $
��Left=�6+   $��45��6F   $
 Wrap=�6R   $	��Top=�6g   $	��374��6   $��1��6�   $��2��6�   $��180,249,0,0q�6�   �� 5   
   -   5         ��Name$ LoginButton��5      $��Login��6&   $
��Left=�66   $��55��6Q   $��
68,339,0,0q�6]   $	��Top=�6q   $	��230��6�   $��2��6�   $��2��6�     SecondaryStyle#��[ 6�   �� 5   
   -   5        $ 
QuitButton��5      $
��Quit��6%   $
��Left=�64   $��55��6O   $��324,339,0,0q�6[   $	��Top=�6p   $	��230��6�   $��3��6�   $��2��6�   #��[ 6�   6�   5      5      