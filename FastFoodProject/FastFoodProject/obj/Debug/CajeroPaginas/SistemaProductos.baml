   M S B A M L   `   `   `  ����J  FFastFoodProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FastFoodProjectFastFoodProject  5      '    !FastFoodProject.Sistema_Productos   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:FastFoodProject     5      U QGongSolutions.WPF.DragDrop, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullddurn:gong-wpf-dragdrop  5
      -   5          N� Title$  Sistema_Productos��5	       � 	Resources 5         ItemCollectionViewSource �� CollectionViewType%   FastFoodProject.FastFoodDataSet  fastFoodDataSet  productoViewSource �� Source �� Source��%{   &	        &	      &	 +     7  �� 5   
   " ��6@     5   
   6    �� 5   
    6:   �� *
Producto+8   5      .��5      �  � DataContext# [ 6    � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ groupBox��5      $��Resumen de orden��6%   $��	0,26,0,74q�6?   $
��Left=�6R   $	��275��6m   �� 5   
   -   5        $ groupBox_Copy��5      $��Productos online��6*   $��315,26,42,74q�6D   ��6Z   Z� ��6p   Z� ��6�   Z� �� 5   
   -   5        $ groupBox_Copy1��5      $��Total ��6+   $
��Left=�6;   $	��275��6V   $��69��6b   $��Bottom=�6n   ���	#FF3A13136�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dg_carrito��5      	   AutoGenerateColumns	 .  
   EnableRowVirtualization
 . $��	0,60,0,74q�5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6       
IsReadOnly . )  #GongSolutions.Wpf.DragDrop.DragDrop   IsDragSource .     IsDropTarget . $
��Left=�5   N   $	��275��6i   ��5   b   �� *
Producto+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        nombreColumn1��,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��5   W      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *nombre+6g     5      -   5        valorColumn1��$ Precio��5   U   $ SizeToHeader 6e    6;   �� *valor+6e     5       -   5        cantidadColumn1��$ Cantidad��5    [   $ SizeToHeader 6m    6>   �� *
cantidad+6m   5"      �� 5#   
   -	   5         ��Name$ lblPrecioTotal��5#      $��$0��6(   $��38,0,372,37q�65   $��28��6J   $��Bottom=�6V   ���	#DDFFFFFF$��16(�6�   �� 5$   
   -
   5         ��Name$ btnConfirmarCompra��5$      $��Generar Orden��6-   $
��Left=�6E   $��
128,0,0,10q�6`   $��Bottom=�6t   $	��135��6�   ���	#FD1B1B1B$��34��6�   ���	#FF0D8EAA J� RenderTransformOrigin$ 0.267,0.426&�6�   ��5%      �� 5&       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5'      �  � Color$ 	#FFBEF7A9��6#    � Offset$ 0Q�65   � 5(      $ 	#FF13C6CF��6#   $ 1Q�65   5)      5+      �� 5,   
   -   5        $ 
btnLimpiar��5,      $��Limpiar Orden��6%   $��	134,5,0,0q�6=   $	��Top=�6P   ���	#FDFFFFFF$��31��6   ���	#FF721ED6$ 0.267,0.426&�6�   $
��Left=�6�   $	��141��6�   ��5-      �� 5.      $ 0.5,1&�6&   $ 0.5,0&�67   .��5/      � $ 	#FF7F817F��6#   $ 0Q�65   � 50      $ 	#FFE419AD��6#   $ 1Q�65   51      53      �� 54   
   -   5         ��Name$ textBox��54      $��315,240,42,10q�6#    �� TextWrapping$
 Wrap=�6:    �� AcceptsReturn . 
�������$9��3Ingresa los detalles adicionales del cliente aquí.��6�   $��18(�6�   �� 55   
   -   5         ��Name$ productoListBox��55   D   # [ 6   $��315,60,42,74q�6v    .  .  
����������	#FF131313���	#FFFF9595$��Stretch=�56   �   }�. $��14(�6�   ��55   ^   ��  J� OpacityMask 57      �� 58      $ 0.5,1&�6&   $ 0.5,0&�67   .��59      � $ Black��6#   $ 0Q�61   � 5:      $ 	#FF2E00FF��6#   $ 1Q�65   5;      ��5=      �� 5>      .R�5?      �  � Orientation$ 
Horizontal=�6    5@      ��5D      �� 5E      .R�5F      �   � ColumnDefinitions  5G      �� 5H      $��50 �6/   ! z� SharedSizeGroup$! Column1��6:   �� 5I      $��8 �6/   $! Column4��69   �� 5J      $	��210 �6/   $! Column2��6;    5M      �� 5N      $��40 �6,   $
! Row1��68   �� 5O      $��80 �6,   $
! Row2��68   .+�5R      �� $��0��6$   $��0��64   $�� ��6A   �� 5S      $��2��6$   $��0��64   ��6A   �� *nombre+�� 5T      $��2��6$   $��1��64   ��6A   �� *valor+�� 5U      $��1��6$   $��1��64   $��$��6A   5V      5W      5Y      5Z      5[      