   M S B A M L   `   `   `  ����A  =MyProj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyProjMyProj  5   	       MyProj.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyProj     5   	     � Title$0  *Расписание занятий ФИТ��5   	   $	��650��5	   	   $
��1100��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         StyleButton �� 
TargetType �� Property �� Value �� EndPoint �� 
StartPoint � Color	 � Offset  CheckBoxStyle1
 �� 
TargetType � 	Resources  Key g� 	BeginTime �� 
TargetName �� TargetProperty O� KeyTime O� Value p� KeyTime p� Value ]�Name J� SnapsToDevicePixels �� ContentStringFormat �� ContentStringFormat ��Name �� CornerRadius J� RenderTransformOrigin �� ScaleX �� ScaleY �� AngleX �� AngleY �� Angle T� X  T� Y! �� Triggers" P� Property# P� Value$ N� ExitActions% ��Name  OnUnchecking& N� EnterActions  
OnChecking  	StyleGrid  StyleCalanderDayButton:  4System.Windows.Controls.Primitives.CalendarDayButton  StyleCalanderButton7  1System.Windows.Controls.Primitives.CalendarButton  StyleCalendar&   System.Windows.Controls.Calendar5  /System.Windows.Controls.Primitives.CalendarItem'  Name( �� Triggers��%  &	        &	 �    7  7  &	 �
    &	 �    &	 t    &	     7  7  '�� �    �� 5   
   " ��5      .�5      ��  � ��$ 12(�5      �� 5       � ��$ Global Serif)�5      �� 5       � �� 5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ #089bd6��6'   $		 0.1Q�67   � 5      $ #9ce1fc��6'   $		 0.3Q�67   � 5      $ #9ce1fc��6'   $		 0.4Q�67   � 5      $ #20bcf9��6'   $		 0.8Q�67   5      5      5      �� 5   
   " ��6'   .�5      ��  � ��# � ��6+   �� 5        � ��# � ��6+   �� 5!       � �� 5"      �� 5#      "
 ��6&    5$      ���� 5%      
OnChecking .��5&   "   U� $ 00:00:00X�6@   $ slider��6U   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6t   .\�5'   &   �� $ 00:00:00.3000000��6;   $ 25Q�6V   5(   #   5)      �� 5*      OnUnchecking .��5+   "   U� $ 00:00:00X�6@   $ slider��6U   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6t   .\�5,   &   �� $ 00:00:00.3000000��6;   $ 0Q�6V   5-   #   r� 5.   "   $ 00:00:00X�6C   $ slider��6X   $ (FrameworkElement.Margin)�6w   .	�5/   &   �� $ 00:00:00.3000000��6>   $ 1,1,1,1q�6Y   50   #   51      52      .R�54      ]� $ 	dockPanel��6$   .+�55      �� # z 6/   #��z��6k   # z 6�   #��z��6�   ��. $��Center=�6  � 56      $��5,5,0,5q�6#   $��50��64   ���	#FFC0CCD9.+�57   "   �� $	��OFF��6,   $
��Wrap=�67   $
��Bold"�6K   $��12(�6]   $��Right=�6k   $��0,0,3,0q�6�   �� 58   "   $
��Left=�6,   $��2,0,0,0q�6G   $��12(�6X   $
��Bold"�6f   $��ON��6x   $
��Wrap=�6�   �� 59   "   $ slider��6D   $
��Left=�6)   $��23��6T   $��1,1,1,1q�6_   $ 3,3,3,3��6y   $ 0.5,0.5&�6�   $��1,1,1,1q�6�   z�5:   &   V� 5;   *   .~�5<   .   �� $ 1Q�6=   $ 1Q�6H   �� 5=   .   $ 0Q�6<   $ 0Q�6G   �� 5>   .   $ 0Q�6>   T� 5?   .   $ 0Q�6A   $  0Q�6G   5@   +   ��5B   &   �� 5C   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5D   .   � $ 	#FFFFFFFF��6;   $	 0Q�6M   � 5E   .   $ 	#FF4490FF��6;   $	 1Q�6M   5F   +   ��5H   &   �� 5I   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5J   .   � $ 	#FF8AB4FF��6;   $	 1Q�6M   � 5K   .   $ 	#FFD1E2FF��6;   $	 0Q�6M   5L   +   5N   #   5O      5P      ! 5R      P� 5S      " �@d�	IsChecked$
# TrueY�6;   $ 5T   "   �� 5U   &   $"% OnUnchecking_BeginStoryboard��6a   8��  & 5W   "   �� 5X   &   $ % OnChecking_BeginStoryboard��6_   8�� 5Z      P� 5[      " � {�# .  . �5\   "   �� # � ��6?    � ��5]      5_      5a      5b      �� 5c   
   " �5d      .�5e      ��  � �� 5f      �� 5g      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5h      � $ #089bd6��6'   $		 0.1Q�67   � 5i      $ #9ce1fc��6'   $		 0.3Q�67   � 5j      $ #9ce1fc��6'   $		 0.4Q�67   � 5k      $ #20bcf9��6'   $		 0.8Q�67   5l      5n      5o      �� 5p   
   "  5q      .�5r      ��  � ��$ 20��5s      �� 5t       � ��$ 35��5u      �� 5v       � ��$ 14(�5w      5x      �� 5y   
   "  5z      .�5{      ��  � ��$ 40��5|      �� 5}       � ��$ 60��5~      �� 5       � ��$ Heavy"�5�      5�      �� 5�   
   "  5�      .�5�      ��  � �� 5�      �� 5�      "
  6&   .R�5�      (� .��5�        $' PART_CalendarItem��6+   #��z��5�   !   #��z��5�   !   #��z��5�   !   5�      5�      5�      5�      �� 5�       �@ CalendarDayButtonStyle8   6j   �� 5�       �@ CalendarButtonStyle8  6d   �� 5�       � ��
 �  ��6+   �� 5�       � �� 5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ #089bd6��6'   $		 0.1Q�67   � 5�      $ #9ce1fc��6'   $		 0.3Q�67   � 5�      $ #9ce1fc��6'   $		 0.4Q�67   � 5�      $ #20bcf9��6'   $		 0.8Q�67   5�      5�      �� 5�       � ��$ 0q�60   5�      �� 5�   
   " ��6   ( 5�      P� 5�      " �@��IsMouseOver# . . �5�      ��  � ��
 ��=H�63   5�      .�5�      ��  � ��
 ���F�6+   �� 5�       � �� 6:   Z� 5�      5�      .��5�      � #��[ 6   ) � RowDefinitions) 5�   
   �� 5�      $��50 �6   �� 5�      $
��Auto �6   �� 5�      $��* �6   * � ColumnDefinitions* 5�   
   �� 5�      $	��315 �6   �� 5�      �� 5�      .+�5�   
   �� -   5        + ��Name$+ EditSchedule��5�      $y�Hidden=�5�      $��Stretch=�5�      $��0��5�      $��0��5�      #��[  5�      $+��%ИЗМЕНИТЬ РАСПИСАНИЕ��5�      $��50��5�      $��5,0,0,0q�5�      $
��Left=�6"   $	��150��6=     5�   
   $��Stretch=�6   $��Stretch=�5�      #��[ 5�      $��1��5�      $��0��5�      $��	5,85,10,0q�5�      �� 5�   
   $��2��6   $��0��5�      $	��200��5�      $	��250��5�      $	��250��5�      $	��200��5�      $��10,10,10,10q�5�      �� 5�      -   5        $��http://it.belstu.by/?�5�      .�5�   D   .�5�      �� .F�5�      �� -   5        , ��Name$, fit_logo_png��5�      $��Uniform=�5�      $��Images/fit_logo.png��5�      $��0,0,0,10q�5�      5�      5�      5�       � 5�   
   -  � Source$- 
Times.xaml?�6   $��1��5�      $��0��5�      $��
5,5,30,220q�5�       � 5�   
   $- AddTask.xaml?�6   $��1��5�      $��2��5�      $��1��5�      $��2��5�      $��10,15,15,10q�5�      � 5�   
   -   5        . �Name$. LayoutRoot1��5�      $��2��5�      $��	200,1,1,1q�5�      .+�5�      �� -   5        / ��Name$	/ csc��5�      $��Center=�5�      #���  5�      $��Center=�5�      $��Admin��5�      0 d� 	IsChecked$0 FalseY�5�      $��15(�5�      5�      5�      5�      