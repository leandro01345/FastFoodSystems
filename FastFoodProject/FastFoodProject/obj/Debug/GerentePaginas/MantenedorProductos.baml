   M S B A M L   `   `   `  ����J  FFastFoodProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:FastFoodProject.GerentePaginasFastFoodProject.GerentePaginas  5      1clr-namespace:FastFoodProjectFastFoodProject  5      8    2FastFoodProject.GerentePaginas.MantenedorProductos   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:FastFoodProject.GerentePaginas     5      9FastFoodProjectclr-namespace:FastFoodProject     5        N� Title$  Mantenedor_Productos��5
       � 	Resources 5      %   FastFoodProject.FastFoodDataSet   fastFoodDataSet  productoViewSource �� Source �� Source��%Y   &	        &	      7     5   
   6*   �� 5   
    6:   �� *
Producto+8   5      .��5      � .+�5   
   �� -   5         ��Name$ groupBox��5      $W��QMantenedor de productos: Edita y modifica la información de tus productos aquí.��6%   $��0,-6,0,6q�6~   �� 5   
   -   5         ��Name$ 
tabControl��5      $��0,31,0,0q�6)   .@�5      �� $��Agregar nuevo producto��6   
�������
�������.��5      � ���	#E5000000$��-13,-3,-5,-14q�6.    � ColumnDefinitions 5      �� 5      .+�5      �� -   5         ��Name$ lblProducto��5      $��Agregue un nuevo producto��61   $
��Left=�6U   $��	55,22,0,0q�6p   $	��Top=�6�   $	��274��6�   
���   ����	#DDF5F1F1$��20(�6�   �� 5      -   5        $ 	lblNombre��5      $��Nombre:��6/   $
��Left=�6A   $��	60,60,0,0q�6\   $	��Top=�6o   $��75��6�   ���	#DDF1E3E3$��14(�6�   �� 5      -   5        $ lblValor��5      $��Valor:��6.   $
��Left=�6?   $��
60,107,0,0q�6Z   $	��Top=�6n   $��75��6�   ���	#DDF7F1F1$��14(�6�   �� 5      -   5         ��Name$ 	txtNombre��5      $
��Left=�61   $��28��6L   $��
135,60,0,0q�6X   	 �� TextWrapping$
	 Wrap=�6l   $	��Top=�6�   $	��149��6�   ���	#FFECE6E66�   �� 5      -   5        $ txtValor��5      $
��Left=�60   $��28��6K   $��135,107,0,0q�6W   $
	 Wrap=�6l   $	��Top=�6�   $	��149��6�   ���	#FFEEE9E9$��0��6�   6�   �� 5      -   5        
 ��Name$
 
btnAgregar��5      $��Agregar��61   $��
60,165,0,0q�6C   $	��Top=�6W    J� RenderTransformOrigin$ 0.275,-0.545&�6o   $��16(�6�   $
��Left=�6�   $	��101��6�   5      5       �� 5!      $��Editar producto��6   .��5"      � ���	#E5000000$��-12,-3,-8,-12q�6.    5#      �� 5$      .+�5&      �� -	   5        $ lblActualizar��5&      $��Actualizar producto��63   $
��Left=�6Q   $��	41,17,0,0q�6l   $	��Top=�6   $	��202��6�   
���   ����	#DDF5F1F1$��20(�6�   �� 5'      -
   5        $ lblNombreUpdate��5'      $��Nombre:��65   $
��Left=�6G   $��	41,93,0,0q�6b   $	��Top=�6u   $��87��6�   ���	#DDF1E3E3$��14(�6�   �� 5(      -   5        $ lblCantidadUpdate��5(      $��	Cantidad:��67   $
��Left=�6K   $��
41,127,0,0q�6f   $	��Top=�6z   $��87��6�   ���	#DDF0E1E1$��14(�6�   �� 5)      -   5        $ lblValorUpdate��5)      $��Valor:��64   $
��Left=�6E   $��
41,164,0,0q�6`   $	��Top=�6t   $��87��6�   ���	#DDF7F1F1$��14(�6�   �� 5*      -   5        $ txtNombreUpdate��5*      $
��Left=�67   $��26��6R   $��
146,94,0,0q�6^   $
	 Wrap=�6r   $	��Top=�6�   $	��149��6�   ���	#FFECE6E66�   �� 5+      -   5        $ txtCantidadUpdate��5+      $
��Left=�69   $��26��6T   $��146,130,0,0q�6`   $
	 Wrap=�6u   $	��Top=�6�   $	��149��6�   ���	#FFE8E6E6$��0��6�   6�   �� 5,      -   5        $ txtValorUpdate��5,      $
��Left=�66   $��26��6Q   $��146,167,0,0q�6]   $
	 Wrap=�6r   $	��Top=�6�   $	��149��6�   ���	#FFEEE9E9$��0��6�   6�   �� 5-      -   5        $
 	btnBuscar��5-      $��Buscar��60   $
��Left=�6A   $��
345,55,0,0q�6\   $	��Top=�6p   $	��115��6�   $��16(�6�   6�   �� 5.      -   5        $
 	btnUpdate��5.      $��
Actualizar��60   $
��Left=�6E   $��345,161,0,0q�6`   $	��Top=�6u   $	��115��6�   $��16(�6�   6�   �� 5/      -   5        $ lblId��5/      $��Id Producto:��6+   $
��Left=�6B   $��	41,58,0,0q�6]   $	��Top=�6p   $��87��6�   $��14(�6�   ���	#DDFBEEEE6�   �� 50      -   5        $ txtId��50      $
��Left=�6-   $��26��6H   $��
146,58,0,0q�6T   $
	 Wrap=�6h   $	��Top=�6|   $	��149��6�   ���	#FFF7F1F16�   �� 51      -   5        $
 btnEliminar��51      $��Eliminar��62   $
��Left=�6E   $��345,109,0,0q�6`   $	��Top=�6u   $	��115��6�   6�   52      53      �� 54      $��Lista de productos��6   $��
-2,-2,-2,0q�62   .��55      � ���	#E5190E18 � DataContext# [ 6.   .+�56      &   System.Windows.Controls.DataGrid  -   5          Name$ productoDataGrid��56         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6t   ��    Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID��58   c      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *id_producto+6o     59      -   5        nombreColumn��$ Nombre��59   b   $	 150 6r    6G   �� *nombre+6r     5:      -   5        valorColumn��$ Precio��5:   `   $	 100 6p    6F   �� *valor+6p     5;      -   5        idPedidoColumn��$ 
Pedido N°��5;   n   $	 150 6�    6I   �� *pedido_id_pedido+6�   5>      5?      5@      5A      5C      5D      