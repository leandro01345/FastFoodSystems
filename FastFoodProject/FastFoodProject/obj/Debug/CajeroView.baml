   M S B A M L   `   `   `  ����J  FFastFoodProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FastFoodProjectFastFoodProject  5   	        FastFoodProject.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FastFoodProject     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$  
MainWindow��5   	   $	��478��6   $��896.5��6)   ���	#FF3A0E0E   MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      � ���	#FF110E0E � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ button_Copy��5      $	��Top=�6&   ���	#FFEE3355$��Right=�6U   $	��140��6q   $��
0,11,172,0q�6}   ���	#FF610C2D.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]   Kind$
 Food=�6*   $��22��66   $��26��6B   $��Right=�6M   �� 5      $��15��6   $��86��6(   $��Ordenes��63   5      5      �� 5   
   -   5        $ button_Copy1��5      $	��Top=�6'   ���	#FFEE3355$��Right=�6V   $	��140��6r   ���	#FF610C2D$��
0,11,312,0q�6�   .��5      �� $ 
Horizontal=�6   $	��118��62   .+�5        $ Basket=�6*   $��22��68   $��27��6D   $��Right=�6O   �� 5      $��14��6   $��84��6(   $��Caja Virtual��63   5      5       � 5    
   -   5          �Name$ frame��5       $�� ��6   $��25,90,24,28q�6*     � NavigationUIVisibility$ Hidden=�6[   �� 5!   
   -   5        	 ��Name$	 txtUser��5!      $��25,15,484,0q�6%   $
��Wrap=�6:   $	��Top=�6N   $��28��6f   $��Roboto)�6r   $��22(�6�   $��Italic$�6�   ���	#DDB4B4B4$��Bienvenido, usuario��6�   �� 5"   
   -   5        $	 textBlock_Copy��5"      $��499,0,10,-2q�6,   $
��Wrap=�6A   $��Roboto)�6U   $��16(�6i   $��Italic$�6w   ���	#DDB4B4B4$��v0.2.0��6�   
 �� TextAlignment$
 Right=�6�   $��28��6�   $��Bottom=�6�   �� 5#   
   -   5        $ button_Copy2��5#      $	��Top=�6'   ���	#FFEE3355$��Right=�6V   $	��140��6r   $��	0,11,32,0q�6~   ���	#FF610C2D.��5$      �� $ 
Horizontal=�6   $	��124��62   .+�5%        $ Account=�6*   $��22��69   $��21��6E   $��Right=�6P   {�.  6l   �� 5&      $��14��6   $	��100��6(   $��Desconectar��64   5'      5(      �� 5)   
   ���	#FFF52F5C$��2��6%   $��
25,58,32,0q�60   ���	#FFAE3232$	��Top=�6W   5*      5+      