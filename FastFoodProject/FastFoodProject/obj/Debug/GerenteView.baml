   M S B A M L   `   `   `  ����J  FFastFoodProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FastFoodProjectFastFoodProject  5   	   !    FastFoodProject.GerenteView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FastFoodProject     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   6     � Title$  GerenteView��6	   $	��474��6   $	��820��6*      MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      � ���	#FF110E0E � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ btnGestionUsuario��5      $��Gestión de usuarios��6,   $��
0,11,179,0q�6J   $	��Top=�6^   ���	#FFEE3355���	#FFEE3355$��Right=�6�   $	��169��6�   $��32��6�   �� 5   
   -   5        $ btnMantenedorProductos��5      $��Gestión de productos��61   $	��Top=�6P   ���	#FFEE3355$��Right=�6   $	��169��6�   ���	#FFEE3355$��
0,11,349,0q�6�    � 5   
   -   5          �Name$ GerenteFrame��5      $�� ��6&   $��10,79,10,28q�61     � NavigationUIVisibility$ Hidden=�6F   6f   �� 5   
   -   5         ��Name$ txtTitleGerente��5      $��
25,9,618,0q�6-   $
��Wrap=�6A   $	��Top=�6U   $��28��6m   $��Roboto)�6y   $��22(�6�   $��Italic$�6�   ���	#DDB4B4B4�� 6�   $�Fast food Syste��6�   �� 6�   $�m��6�   �� 6�   �� 6�   6  �� 5   
   -   5        $ txtVersionGerente��5      $��499,0,10,-2q�6/   $
��Wrap=�6D   $��Roboto)�6X   $��16(�6l   $��Italic$�6z   ���	#DDB4B4B4$��v0.2.0��6�    �� TextAlignment$ Right=�6�   $��28��6�   $��Bottom=�6�   �� 5   
   -   5        $ btnDesconectar��5      $	��Top=�6)   ���	#FFEE3355$��Right=�6X   $	��169��6t   $��	0,11,10,0q�6�   ���	#FF610C2D.��5      �� 	 �� Orientation$	 
Horizontal=�6   $	��124��62   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Account=�6*   $��22��69   $��21��6E   $��Right=�6P   {�.  6l   �� 5      $��14��6   $	��100��6(   $��Desconectar��64   5      5      5      5       