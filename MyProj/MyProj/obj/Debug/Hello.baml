   M S B A M L   `   `   `  ����A  =MyProj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyProjMyProj  5   	       MyProj.Hello   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyProj     5   	     � Title$  Login��5   	   $	��500��6   $	��500��6$    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V   .��5
      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��50 �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$" w256h2561339870331Man256_png��5      $��0��5      $	��250��5      $	��250��5      $)��#Images/w256h2561339870331Man256.png��5      $
��Fill=�5      �� 5   
   -   5         ��Name$ textBox��5      $��Login��5      $
��Left=�5      $��1��5      $��35��5      $	��Top=�5      $	��200��5      $��18(�5       $��145,0q�5!      ���	#FF7DA0E1.��5"   *   ��5$      �� 5%       �� Color$ Black��6"    �� Opacity$	 0.5Q�60   .��5&   "   5'      �� 5)   
   -   5        $ Visibilitybox��5)      $
��Left=�5*       �� 	MaxLength$ 18��5+      $��2��5,      $��35��5-      ���#FFe4c4$	��Top=�5/      $	��200��50      $��18(�51      $��145,0q�52      ���	#FF7DA0E153      G� 55   
   -   5        	 G�Name$	 passwordBox��55      
 G� 	MaxLength$
 18��56       G� PasswordChar$ *��57      $
��Left=�58      $��2��59      $��35��5:      ���#FFe4c4$	��Top=�5<      $	��200��5=      $��18(�5>      $��145,0q�5?      ���	#FF7DA0E15@      �� 5A   
   -   5        $ ImageShowHide��5A      $��298,49,152,19q�5B      $��Images/eye.png��5C      $
��Fill=�5D      $��1��5E      $��2��5F      5I      �� 5J   
   $��2��6   .+�5L      �� -   5         ��Name$ button��5L      $��Вход��5M      $
��Left=�5N      $��35��5O      ���#FFe4c4$��180,50,0,-35q�5Q      $��18(�5R      $	��Top=�5S      ���	#FF7DA0E1$	��130��5U      $��Segoe UI Black)�5V      5W      � 5Y      -   5         �Name$ pLink��5Y       � VerticalOffset$
 -300��5Z       � 	StaysOpen .  $��Relative=�5\       � AllowsTransparency . $
��Fade=�5^      .��5`      �� -   5        $��a��5`      ���	#FF4B4B4B
�����_�$	��484��5c      $��50��5d      $��20(�5e      $
��Bold"�5f       �� TextAlignment$ Center=�5g      97Неправильный логин или пароль5h      5i      5j      5l      5m      