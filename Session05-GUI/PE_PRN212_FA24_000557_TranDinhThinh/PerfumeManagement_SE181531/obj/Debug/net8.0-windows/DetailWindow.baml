   M S B A M L   `   `   `  ����U  QPerfumeManagement_SE181531, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PerfumeManagement_SE181531PerfumeManagement_SE181531  5   	   -    'PerfumeManagement_SE181531.DetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:PerfumeManagement_SE181531     5   	   -   5          � Title$  Detail Window��5   	   $	��500��6   $	��800��6,   $��Tahoma)�5	   	   $��13(�5
   	   ���	#FFDDE769 � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ 
SaveButton��5      $
��Save��6%   $
��Left=�64   $��40��6O   $��
660,87,0,0q�6[   $	��Top=�6o   $	��100��6�   $��3��6�   6�   �� 5   
   -   5        $ CancelButton��5      $��Close��6'   $
��Left=�67   $��40��6R   $��660,141,0,0q�6^   $	��Top=�6s   $	��100��6�   $��4��6�   6�   �� 5   
   -   5         ��Name$ DetailWindowModeLabel��5      $��Detail Window��6/   $
��Left=�6G   $��56��6b   $��	40,20,0,0q�6n   $	��Top=�6�   $	��357��6�   $��Heavy"�6�   $��30(�6�   $��Italic$�6�   ���	#FF3324A86�   �� 5   
   $��ID��6   $
��Left=�6   $��30��68   $��	40,84,0,0q�6D   $	��Top=�6W   $	��130��6o   ���	#FF3324A8$��Arial Narrow)�6�   $��12(�6�   �� 5   
   -   5         ��Name$ 	IdTextBox��5      $
��Left=�6%   $��30��6@   $��
170,84,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6u   $	��409��6�   $��0��6�   ���	#FFF3CFCF6�   �� 5   
   $
��Name��6   $
��Left=�6   $��30��6:   $��
40,131,0,0q�6F   $	��Top=�6Z   $	��130��6r   ���	#FF3324A8$��Arial Narrow)�6�   $��12(�6�   �� 5   
   -   5        $ NameTextBox��5      $
��Left=�6'   $��30��6B   $��170,131,0,0q�6N   $
 Wrap=�6c   $	��Top=�6x   $	��409��6�   $��0��6�   ���	#FFF3CFCF6�   �� 5   
   $��Ingredients��6   $
��Left=�6&   $��30��6A   $��
40,181,0,0q�6M   $	��Top=�6a   $	��130��6y   ���	#FF3324A8$��Arial Narrow)�6�   $��12(�6�   �� 5   
   -   5        $ IngredientsTextBox��5      $
��Left=�6.   $��30��6I   $��170,181,0,0q�6U   $
 Wrap=�6j   $	��Top=�6   $	��409��6�   $��0��6�   ���	#FFF3CFCF6�   �� 5   
   $��Release Date��6   $
��Left=�6'   $��30��6B   $��
40,242,0,0q�6N   $	��Top=�6b   $	��130��6z   ���	#FF3324A8$��Arial Narrow)�6�   $��12(�6�   �� 5   
   $��Concentration��6   $
��Left=�6(   $��30��6C   $��
40,307,0,0q�6O   $	��Top=�6c   $	��130��6{   ���	#FF3324A8$��Arial Narrow)�6�   $��12(�6�   �� 5   
   -   5        $ ConcentrationTextBox��5      $
��Left=�60   $��30��6K   $��170,307,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��409��6�   $��0��6�   ���	#FFF3CFCF6�   �� 5   
   $��	Longevity��6   $
��Left=�6$   $��30��6?   $��
40,366,0,0q�6K   $	��Top=�6_   $	��130��6w   ���	#FF3324A8$��Arial Narrow)�6�   $��12(�6�   �� 5   
   -	   5        $ LongevityTextBox��5      $
��Left=�6,   $��30��6G   $��170,366,0,0q�6S   $
 Wrap=�6h   $	��Top=�6}   $	��409��6�   $��0��6�   ���	#FFF3CFCF6�   �� 5   
   $��Production Company��6   $
��Left=�6-   $��30��6H   $��
40,420,0,0q�6T   $	��Top=�6h   $	��130��6�   ���	#FF3324A8$��Arial Narrow)�6�   $��12(�6�   �� 5   
   -
   5         ��Name$! ProductionCompanyIDComboBox��5      $��170,412,414,26q�68   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ ReleaseDate��5      $
��Left=�6*   $��170,245,0,0q�6E   $	��Top=�6Z   $��27��6r   $	��139��6~   5       5!      