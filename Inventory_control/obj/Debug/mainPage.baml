   M S B A M L   `   `   `  ����L  HInventory_control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Inventory_controlInventory_control  5   	        Inventory_control.mainPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1localclr-namespace:Inventory_control     5   	   -   5          � Title$  mainPage��5   	   $��850.249��6   $��1416.446��6+    � 	Resources 5      0   *Inventory_control.inventory_controlDataSet   inventory_controlDataSet  supplierViewSource �� Source �� Source��%Y   &	        &	      7     5   
   6)   �� 5   
    6:   �� *
supplier+8   5	      .��5
      �  � DataContext# [ 6   $��0,0,0,-2q�6=   .+�5   
   �� $
��Left=�6   $	��799��60   $	��Top=�6=   $
��1398��6U   ���	#FFE2E2E2 �� SelectedIndex 6y   �� *
idSupplier+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . .@�5      �� -   5        	 ��Name$	 SalesTab��5      $��Sales��6(   $��36(�67   .��5      � ���	#FFDDF0F3$��	10,4,17,0q�6.   $	��721��6A   $	��Top=�6N   .+�5      �� $
��Left=�6!   $	��701��6<   $��	10,10,0,0q�6I   $	��Top=�6\   $
��1345��6t   .@�5      �� $��TabItem��6"   .��5      � ���	#FFE5E5E56#   5      �� 5      $��TabItem��6"   .��5      � ���	#FFE5E5E56#   5      5      5      5      �� 5      -   5        $	 PurchaseTab��5      $��Purchase��6+   $��36(�6=   .��5      � ���	#FFE5E5E56   5      �� 5      -   5        $	 BillTab��5      $��Bills��6'   $��36(�66   $
��Left=�6D   $��78��6_   .��5      � ���	#FFE5E5E56   5      �� 5      -   5        $	 
payableTab��5      $��payable��6*   $��36(�6;   .��5      � ���	#FFE5E5E56   5       �� 5!      -   5        $	 FinancialTab��5!      $��	Financial��6,   $��36(�6?   .��5"      � ���	#FFE5E5E56   5#      �� 5$      -   5        $	 RegisterTab��5$      $��Register��6+   $��36(�6=   .��5%      � ���	#FFE5E5E5.+�5&      �� -   5        
 ��Name$
 Supp_register��5&      $��Register Supplier��64   $
��Left=�6P   $��179,117,0,0q�6k   $	��Top=�6�   $	��297��6�   $��79��6�   ���	#FFEAFFFF6�   �� 5'      -	   5        $
 RegisterUser��5'      $��RegisterUser��63   $
��Left=�6J   $��536,117,0,0q�6e   $	��Top=�6z   $	��294��6�   $��79��6�   6�   �� 5(      -
   5        $
 
regCompany��5(      $��Register Company��61   $
��Left=�6L   $��179,246,0,0q�6g   $	��Top=�6|   $	��297��6�   $��73��6�   6�   5)      5*      �� 5+      -   5        $	 	ReportTab��5+      $��Report��6)   $��36(�69   .��5,      � ���	#FFE5E5E56   5-      �� 5.      -   5        $	 
SettingTab��5.      $��Setting��6*   $��36(�6;   .��5/      � ���	#FFE5E5E56   50      �� 51      -   5        $	 HelpTab��51      $
��Help��6'   $��36(�65   .��52      � ���	#FFE5E5E5$��	0,0,-2,-2q�6.   $	��737��6A   $��Bottom=�6N   53      56      58      59      