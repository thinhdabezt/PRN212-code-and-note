   M S B A M L   `   `   `  ����U  QPerfumeManagement_SE181531, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PerfumeManagement_SE181531PerfumeManagement_SE181531  5   	   +    %PerfumeManagement_SE181531.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:PerfumeManagement_SE181531     5   	   -   5          �Name$  Main_Window��5   	    � Title$ Main Window��5   	   $	��500��6   $	��800��6*   $��Tahoma)�5	   	   $��13(�5
   	   ���	#FFDDE769 � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ SearchButton��5      $��Search��6'   $
��Left=�68   $��35��6S   $��	40,89,0,0q�6_   $	��Top=�6r   $��91��6�   $��2��6�   �� 5   
   $��Ingredients��6   $
��Left=�6&   $��35��6A   $��
131,89,0,0q�6M   $	��Top=�6a   $	��111��6y   ���	#FF3324A8 J� RenderTransformOrigin$ 0.129,0.301&�6�   $��Tahoma)�6�   $��13(�6�   �� 5   
   -   5         ��Name$ TextBox1��5      $
��Left=�6$   $��35��6?   $��
247,89,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6t   $	��150��6�   $��0��6�    �� TextAlignment$ Right=�6�   ���	#FFF3CFCF6�   �� 5   
   $��Concentration��6   $
��Left=�6(   $��35��6C   $��
402,89,0,0q�6O   $	��Top=�6c   $��61��6{   ���	#FF3324A8$ 0.111,0.428&�6�   $��Tahoma)�6�   $��13(�6�   �� 5   
   -   5        $ TextBox2��5      $
��Left=�6$   $��35��6?   $��
468,89,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��157��6�   $��1��6�   $ Right=�6�   ���	#FFF3CFCF6�   �� 5   
   -   5        $ CreateButton��5      $��Create��6'   $
��Left=�68   $��40��6S   $��665,148,0,0q�6_   $	��Top=�6t   $	��100��6�   $��3��6�   6�   �� 5   
   -   5        $ UpdateButton��5      $��Update��6'   $
��Left=�68   $��40��6S   $��665,202,0,0q�6_   $	��Top=�6t   $	��100��6�   $��4��6�   6�   �� 5   
   -   5        $ DeleteButton��5      $��Delete��6'   $
��Left=�68   $��40��6S   $��665,256,0,0q�6_   $	��Top=�6t   $	��100��6�   $��5��6�   $ 0.518,0.332&�6�   6�   �� 5   
   -   5        $ 
QuitButton��5      $
��Quit��6%   $
��Left=�64   $��40��6O   $��665,365,0,0q�6[   $	��Top=�6p   $	��100��6�   $��6��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ PerfumeDataGrid��5      $
��Left=�6,   $��40,148,0,40q�6G   $	��585��6\   	   AutoGenerateColumns$	 False��6h   $��7��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	PerfumeId+  5      $
 Name��6%   $	 100 63    6?   �� *PerfumeName+  5      $ Ingredients��6%   $	 100 6:    6F   �� *Ingredients+  5      $ ReleaseDate��6%   $	 100 6:    6F   �� *ReleaseDate+  5      $ Concentration��6%   $	 100 6<    6H   �� *Concentration+  5      $ 	Longevity��6%   $	 100 68    6D   �� *	Longevity+  5      $ Production Company Id��6%   $	 100 6D    6P   �� *ProductionCompanyId+  5       $ Production Company��6%   $	 150 6A    6M   �� *)'ProductionCompany.ProductionCompanyName+5"      �� 5#   
   -
   5         ��Name$ 
HelloLabel��5#      $��Hello��6$   $
��Left=�64   $��56��6O   $��	40,20,0,0q�6[   $	��Top=�6n   $	��357��6�   $��Heavy"�6�   $��30(�6�   $��Italic$�6�   ���	#FF3324A86�   5$      5%      