   M S B A M L   `   `   `  ����J  FFastFoodProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FastFoodProjectFastFoodProject  5      %    FastFoodProject.Sistema_Ordenes   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:FastFoodProject     5        N� Title$  Sistema_Ordenes��5   0    � 	Resources 5	      (   "FastFoodProject.FastFoodPedidosSet   fastFoodPedidosSet  pedidoViewSource �� Source �� Source%   FastFoodProject.FastFoodDataSet  fastFoodDataSet  productoViewSource��%�   &	        &	      7   &	 ?     &	 R     7    5
   
   6#   �� 5   
    68   �� *Pedido+8     5   
   6    �� 5   
    6:   �� *
Producto+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ groupBox_Copy��5      $��Ordenes��6*   $��320,26,10,11q�6;   ��6Q   Z� &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ pedidoDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��320,59,10,11q�6~   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   
   CanUserAddRows
 .     CanUserResizeRows .     CanUserDeleteRows .     
IsReadOnly .    CanUserReorderColumns .     CanUserSortColumns .  ���	#DD000000��6f   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        id_pedidoColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 	id pedido��5   \      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	id_pedido+6�     5      -   5        descripcionColumn��$ descripcion��5   `   $	 300 6u    6@   �� *descripcion+6u     5      -   5        valorColumn��$ valor��5   T   $	 100 6c    6:   �� *valor+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        fechaColumn��$ fecha��5   >   $	 110 6M      CellTemplate 5      �� 5      .R�5      (	  "System.Windows.Controls.DatePicker	   	  SelectedDate 6)   �� *fecha+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        estadoColumn��$ estado��5   V   $ SizeToHeader 6f    6;   �� *estado+6f   5       �� 5!   
   -   5        $ groupBox_Copy1��5!      $��Productos del pedido��6+   $��
10,26,0,10q�6I   $
��Left=�6s   $	��285��6�   ��6]   Z� 6�     5"   
   -	   5        $ productoDataGrid��5"       .   . $��
10,59,0,10q�6�   $	 VisibleWhenSelected=�6�   $
��Left=�6�   $	��285��6	   . 
 .   .   .  ��6h   �� # [  5#        5$      -
   5        nombreColumn��$ nombre��5$   V   $	 150 6f    6;   �� *nombre+6f     5%      -   5        cantidadColumn1��$ cantidad��5%   [   $ 80 6m    6>   �� *
cantidad+6m     5&      -   5        valorColumn1��$ valor��5&   U   $	 100 6d    6;   �� *valor+6d   5(      5*      5+      