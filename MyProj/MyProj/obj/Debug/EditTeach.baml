   M S B A M L   `   `   `  ����A  =MyProj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyProjMyProj  5   	       MyProj.EditTeach   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyProj     5   	   -   5          � Title$  	EditTeach��5   	   $	��350��6   $	��500��6(    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	teachGrid��5   /      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$ 	 Преподаватель��6C   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	TEACHERid+6Z     5      $	 ФИО��6F   $	
 200 6S    6%   �� *TEACHER_NAME+6S     5      $	 Кафедра��6@   $	
 100 6Q    6%   �� *PULPIT+6Q     5      $	 Предмет��6A   $	
 220 6R    6%   �� *	SUBJECT+6R   5      �� 5   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�5      �� -   5         ��Name$ updateButton��5      $��Обновить��6+   6>   �� 5       -   5        $ deleteButton��5       $��Удалить��6+   6=   5!      5"      5#      