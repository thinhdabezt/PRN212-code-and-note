   M S B A M L   `   `   `  ����W  SBookManagement_TranDinhThinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:BookManagement_TranDinhThinhBookManagement_TranDinhThinh  5   	   -    'BookManagement_TranDinhThinh.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:BookManagement_TranDinhThinh     5   	   -   5          � Title$  Main Window��5      $	��500��6%   $	��800��62   $��Arial)�5	   	   $��14(�5
   	   ���	#FFD4F7D4 � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ SearchButton��5      $��Search��6'   $
��Left=�68   $��35��6S   $��	40,89,0,0q�6_   $	��Top=�6r   $��91��6�   $��2��6�   �� 5   
   $��Function��6   $
��Left=�6#   $��35��6>   $��
131,89,0,0q�6J   $	��Top=�6^   $	��111��6v   
��� � � J� RenderTransformOrigin$ 0.129,0.301&�6�   �� 5   
   -   5         ��Name$ TextBox1��5      $
��Left=�6$   $��35��6?   $��
247,89,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6t   $	��150��6�   $��0��6�    �� TextAlignment$
 Left=�6�   �� 5   
   $��Quantity��6   $
��Left=�6#   $��35��6>   $��
402,89,0,0q�6J   $	��Top=�6^   $��61��6v   
��� � �$ 0.111,0.428&�6�   �� 5   
   -   5        $ TextBox2��5      $
��Left=�6$   $��35��6?   $��
468,89,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��157��6�   $��1��6�   �� 5   
   -   5        $ CreateButton��5      $��Create��6'   $
��Left=�68   $��40��6S   $��665,148,0,0q�6_   $	��Top=�6t   $	��100��6�   $��3��6�   6�   �� 5   
   -   5        $ UpdateButton��5      $��Update��6'   $
��Left=�68   $��40��6S   $��665,202,0,0q�6_   $	��Top=�6t   $	��100��6�   $��4��6�   6�   �� 5   
   -   5        $ DeleteButton��5      $��Delete��6'   $
��Left=�68   $��40��6S   $��665,256,0,0q�6_   $	��Top=�6t   $	��100��6�   $��5��6�   $ 0.518,0.332&�6�   6�   �� 5   
   -   5        $ 
QuitButton��5      $
��Quit��6%   $
��Left=�64   $��40��6O   $��665,365,0,0q�6[   $	��Top=�6p   $	��100��6�   $��6��6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ BookDataGrid��5      $
��Left=�6)   $��40,148,0,40q�6D   $	��585��6Y      AutoGenerateColumns$ False��6e   $��7��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *BookId+  5      $

 Name��6%   $ 80 63    6>   �� *
BookName+  5      $
 Description��6%   $	 120 6:    6F   �� *Description+  5      $
 Public Date��6%   $	 100 6:    6F   �� *PublicationDate+  5      $
 Quantity��6%   $ 70 67    6B   �� *
Quantity+  5      $
 Price��6%   $ 60 64    6?   �� *Price+  5      $
 Author��6%   $ 90 65    6@   �� *Author+  5       $
 Category��6%   $ 80 67    6B   �� *BookCategory.BookGenreType+5"      �� 5#   
   -
   5         ��Name$ 
HelloLabel��5#      $��Hello��6$   $
��Left=�64   $��56��6O   $��	40,20,0,0q�6[   $	��Top=�6n   $	��357��6�   $��Heavy"�6�   $��30(�6�   $��Italic$�6�   
��� � �6�   5$      5%      