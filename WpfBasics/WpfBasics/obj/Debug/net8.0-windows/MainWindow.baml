   M S B A M L   `   `   `  ����D  @WpfBasics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfBasics	WpfBasics  5   	       WpfBasics.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfBasics     5   	     � Title$  
Wpf Basics��5   	   $	��800��6   $	��400��6)   .��5
      ��  �� Padding$ 10q�6   ._�5      �� .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ ApplyButton��5      $��0 0 10 0q�6D   $��0��6W   $��Apply��6g   �� 5      -   5        $ ResetButton��5      $��1��6D   $��Reset��6T   �� 5      $��10 0 0 0q�6   $��2��6(   $��Refresh��68   5      �� 5      $��Pulse Properities��6   $
��Bold"�61   $
��0 10q�6C   �� 5      $��Description��6   �� 5      -   5         ��Name$ DescriptionText��5      $��2q�6/   � 5"       5#      �� 5$      $��2* �6'   �� 5%      $��* �6'   .+�5,      �� $��0��6   $��0 0 10 0q�6-   .+�5-      �� $��Status��6    �� 5.       �� 
IsReadOnly$
 True��6   ���#eee$��2q�6B   5/      �� 52      $��1��6   .+�53      �� $��Revision��6    �� 54      $��2q�6   $
 True��6*   ���#eee6<   55      59      �� 5<      $��Part Number��6   �� 5=      $��2q�6   $
 True��6#   ���#eee65   �� 5@      $��Raw Material��6   $
��Bold"�6,   $
��0 10q�6>   �� 5C      $��Material��6   �� 5D      $��2q�6   �� 5G      $��Manufacturing Info��6   $
��Bold"�62   $
��0 10q�6D   �� 5J      $��Work Centres��6   $��0 0 0 10q�6,   � 5N       5O      �� 5P      $��* �6'   �� 5Q      $��* �6'   .+�5V      �� $��0��6   $��0 0 10 0q�6-   .+�5W      �� -   5         ��Name$ WeldCheckBox��5W   :   $
��Weld��6P   �� 5X      -   5        $ AssemblyCheckBox��5X   :   $��Assembly��6T   �� 5Y      -   5        $ PlasmaCheckBox��5Y   :   $��Plasma��6R   �� 5Z      -   5        $ LaserCheckBox��5Z   :   $��Laser��6Q   �� 5[      -   5        $ PurchaseCheckBox��5[   :   $��Purchase��6T   5]      �� 5_      $��1��6   .+�5`      �� -	   5        $ LatheCheckBox��5`   :   $��Lathe��6Q   �� 5a      -
   5        $ DrillCheckBox��5a   :   $��Drill��6Q   �� 5b      -   5        $ FoldCheckBox��5b   :   $
��Fold��6P   �� 5c      -   5        $ RollCheckBox��5c   :   $
��Roll��6P   �� 5d      -   5        $ SawCheckBox��5d   :   $	��Saw��6O   5e      5j      �� 5m      $��Length��6   �� 5n      -   5        $ 
LengthText��5n      $��2q�6*   �� 5q      $
��Mass��6   �� 5r      $��2q�6   ���#eee$
 True��64   �� 5v      $��Finish��6   �� 5w       �� SelectedIndex$ 0��6   $��2q�6)   .@�5x      �� .��6   	Painted6(   �� 5y      .��6   Not Painted6,   5z      �� 5}      $��Purchase Info��6   �� 5~      $ 0��6   $��2q�6)   .@�5      �� .��6   Rubber6'   �� 5�      .��6   
Not Rubber6+   5�      �� 5�      $��Supplier Name��6   �� 5�      $��2q�6   �� 5�      $��Supplier Code��6   �� 5�      $��2q�6   �� 5�      $��Additional Info��6   $
��Bold"�6/   $
��0 10q�6A   �� 5�      $
��Note��6   �� 5�      $��2q�6   5�      5�      5�      