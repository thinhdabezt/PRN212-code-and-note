   M S B A M L   `   `   `  ����?  ;MyCV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyCVMyCV  5   	       MyCV.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MyCV     5   	     � Title$
  MyCV��5   	   $	��504��6   $	��800��6#   ���#ff4500 � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � .+�5   
   �� -   5         ��Name$ LoadDataButton��5      $��	Load Data��6)   $��
618,10,0,0q�6=   $��70��6Q   $	��150��6]   $
��Left=�6�   $	��Top=�6�   $��2��6�   �� 5   
   $��Danh sách ứng viên��6   $��30,30,370,363q�6-    
  Header#��[  6D    J� RenderTransformOrigin$ 0.5,0.5&�6d   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 0Q�6$   �� 5      T� 5       T� X$ 0Q�6)   5      5      �� 5   
   $��Create��6   $��
618,90,0,0q�6"   $��70��67   $	��150��6C   $
��Left=�6O   $	��Top=�6j   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CVListDataGrid��5      $��10,133,187,10q�6+      AutoGenerateColumns$ False��6B      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã số��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 60 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $	 Họ và tên��6%   $	
 100 68    6D   �� *Name+  5       $	 	Năm sinh��6%   $
 60 67    6B   �� *Yob+  5!      $	 Vị trí ứng tuyển��6%   $	
 120 6?    6K   �� *
Position+5#      5$      5%      