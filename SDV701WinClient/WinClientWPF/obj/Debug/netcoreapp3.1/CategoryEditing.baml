   M S B A M L   `   `   `  ����G  CWinClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WinClientWPFWinClientWPF  5   	   "    WinClientWPF.CategoryEditing   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WinClientWPF     5   	      WinClientWPF.Editing    Closing$  Editing_Closing��5   :    � Title$ CategoryEditing��6	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6T   .��5	      � .+�5
   
   �� -   5         ��Name$ tbxCategoryName��5
      $
��Left=�6}   $��
139,14,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   4  .System.Windows.Automation.AutomationProperties   Name$ tbxCategoryName��6�   ��6+   �� *Categoryname+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ tbxCategoryDescription��5      $
��Left=�6�   $��
139,45,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $ tbxCategoryDescription��6�   ��62   �� *Description+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ lbxParts��5      $��0,98,0,0q�6$   $ lbxParts��66   	 � ContextMenu	 5      �� 5      .@�5      m� -   5        $��Edit selected...��5      69   �� 5      m� 5      -   5        $��Delete selected...��5      6;   5      5      �� 5   
   $��Category Name:��6   $
��Left=�6)   $��	38,10,0,0q�6D   $	��Top=�6W   �� 5   
   $��Category Description:��6   $
��Left=�60   $��	10,41,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        
 ��Name$
 
btnRefresh��5      $��Refresh��6%   $��
725,73,7,0q�67   $	��Top=�6K   6c   5      5      