   M S B A M L   `   `   `  ����G  CKassensystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Kassensystem.ViewModelKassensystem.ViewModel  5   	   ?$clr-namespace:Kassensystem.ViewModelKassensystem.ViewModel  5   	   5clr-namespace:Kassensystem.ViewKassensystem.View  5   	       Kassensystem.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Kassensystem.ViewModel     5   	   3vm$clr-namespace:Kassensystem.ViewModel     5   	   0viewclr-namespace:Kassensystem.View     5   	     � Title$  
MainWindow��5
   	   $	��900��6   $
��1600��6)   ���#D2E2FC � DataContext 5      2   ,Kassensystem.ViewModel.KassensystemViewModel  5   
    � 	Resources 5       �� DataType&    Kassensystem.ViewModel.WaageView!   Kassensystem.View.WaageView&    Kassensystem.ViewModel.HauptView!   Kassensystem.View.HauptView$   Kassensystem.ViewModel.EndView   Kassensystem.View.EndView(   "Kassensystem.ViewModel.GegebenView#	   Kassensystem.View.GegebenView��%�  (��       5   *   *, +)(�� N     5   *   *, +)(�� �     5   (   *, +)(�� �     5   ,   *, +)�� 5   
   	WaageView��"  6*   .R�5         6   �� 5      �� 5   
   	HauptView��"  6*   .R�5         6   �� 5      �� 5   
   EndView��"  6(   .R�5         6   �� 5      �� 5   
   GegebenView��"  6,   .R�5      	   6   �� 5      5      .��5      �  � ColumnDefinitions 5   
   �� 5       $	��450 �6   �� 5!      $	��450 �6   �� 5"      $	��300 �6   �� 5#      $	��300 �6    � RowDefinitions 5%   
   �� 5&      $	��200 �6   �� 5'      $	��500 �6   �� 5(      $	��350 �6   .+�5*   
   �� -   5        $��0��5*      $��0��6!   $��4��6.   $��0q�6\   .��5+      �� $3��-C:/Users/Daniel/Desktop/Kassensystem/Logo.png��6   $
��Fill=�6K   5,      �� 5.   
   $��1��6   $��3��6"   $��2��62   .+�5/      �� -   5         ��Name$ Storno��5/   k   $��	41,0,60,0q�6   $��5q�6(   
���   �.��50      �� $5��/C:/Users/Daniel/Desktop/Kassensystem/Storno.png��6   51      �� 53      -   5        $ Bezahlen��53   n   $��
41,68,60,0q�6   $��5q�6)   
���   �.��54      �� $7��1C:/Users/Daniel/Desktop/Kassensystem/Bezahlen.png��6   55      �� 57      -   5        $ Waage��57   k   $��
41,68,60,0q�6   $��5q�6)   
���   �.��58      �� $4��.C:/Users/Daniel/Desktop/Kassensystem/WAAGE.png��6   59      �� 5;      -   5        $ Zurück��5;   k   $��
41,68,60,0q�6   $��5q�6)   
���   �.��5<      �� $6��0C:/Users/Daniel/Desktop/Kassensystem/ZURUECK.png��6   5=      �� 5?      -   5        $ Bestätigen��5?   p   $��
41,68,60,0q�6   $��5q�6)   
���   �.��5@      �� $:��4C:/Users/Daniel/Desktop/Kassensystem/BESTAETIGEN.png��6   5A      5B      �� 5D   
   $	��820��6   $��0��6&   $	��Top=�66   $��3��6N   $��1��6b   $��2��6o   $��0q�6�   ��6�   �� 6�   5E      5F      