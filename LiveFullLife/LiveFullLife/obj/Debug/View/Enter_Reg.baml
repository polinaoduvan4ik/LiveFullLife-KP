   M S B A M L   `   `   `  ����G  CLiveFullLife, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LiveFullLife.ViewLiveFullLife.View  5      !    LiveFullLife.View.Enter_Reg   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:LiveFullLife.View  5        N� Title$  	Enter_Reg��5
      .��5      � ���#7AB4B4 � ColumnDefinitions 5   
   �� 5      $
��1024 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��204.8 �6   �� 5      .+�5   
   �� $��/Icons/cloud.png��6   $��3��6+   $��-46,30,-72,-1q�6<   � 5   
   -   5         �Name$ 	GridPanel��5      ���	#FF136365$��	0,0,0,0.4q�6:   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5      �� -   5         ��Name$ 	ButtonOff��5       0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6,   $��25��6r   $��25��6}   
�������$��0,3,0,0q�6�   $	��Top=�6�   ��6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Power=�6.   5      5      5      �� 5    
   $��/Icons/summer.png��6   $��92��6+   $��88��67   $��Center=�6C   $��Center=�6^   $��1��6|    J� RenderTransformOrigin$ 0.468,0.181&�6�   $��459,60.6,477,52.2q�6�   �� 5"   
   $��LiveForLife��6   $��	helvetica)�5#      $��24(�5$      $��1��6&   $��Center=�5%      $��460,146.6,452,23.2q�62   $	��112��6N   �� 5)   
   $��2��6   $��
0,0.8,0,-9q�6"   .+�5*      �� $��	helvetica)�6   $%��Имя пользователя��5+      $��18(�5,      $��Center=�5-      
������ $��0q�5/        50      $ Account=�6&   $��410,-26,0,0q�65   $��21��6J   $��21��6V   �� 52      -   5         ��Name$ Input_Login��52      $��	helvetica)�6+   $��18(�53      $��Center=�54      
������ $��427,0q�56      $	��170��57      �� 5:      $��	helvetica)�6   $��Пароль��5;      $��18(�5<      $��Center=�5=      
������ $��0q�5?      $
��0,10q�5@      G� 5B      -   5        	 G�Name$	 Input_Password��5B      $��	helvetica)�62   
 G� Password$
  ��5C      $��18(�5D      $��Center=�5E      
������ $��0,-10q�5G      $	��170��5H      �� 5I      $
��0,25q�6   $ 
Horizontal=�6'   .+�5K      �� -   5        $ Button_Enter��5K      $	��100��60   $��25��6<   $��	400,0,0,0q�6H   $��
Войти��6\   6l   �� 5M      -   5        $ Button_Registration��5M      $	��100��66   $��25��6B   $��20,0,0,0q�6N   $��Регистрация��6`   6v   5O      5R      5U      5V      